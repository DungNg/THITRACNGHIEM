using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ThiTracNghiem
{
    public partial class FrmChuanbithi : DevExpress.XtraEditors.XtraForm
    {
        private CauHoi[] dscauhoi = new CauHoi[99];
        public FrmChuanbithi()
        {
            InitializeComponent();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if(Program.mGroup=="SINHVIEN")
            {
                Laythongtinthi();
                if (Kiemtra() == 0)
                {
                    Thi();
                }
                else
                {
                    MessageBox.Show("Sinh viên không đủ điều kiện thi!");
                }
            }
            else
            {
                Laythongtinthi();
                Thi();
            }
        }

        int Kiemtra() //0: cho phep thi - 1: ko cho phep thi
        {
            try
            {
                string lenh = "EXEC SP_KTDKT '" + Program.username + "','" + cbxMamh.Text + "','" + cbxLanthi.Text+"'";
                SqlDataReader rd = Program.ExecSqlDataReader(lenh);
                rd.Read();
                int kq = rd.GetInt32(0);
                rd.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra điều kiện thi! "+ex.Message);
                return 1;
            }
        }

        void Laythongtinthi()
        {
            // 0MAGV 1MAMH 2MALOP 3TRINHDO 4NGAYTHI 5LAN 6SOCAUTHI 7THOIGIAN
            DateTime ngaythi = DateTime.Today;
            SqlDataReader rd;
            try
            {
                int socauhoi = 0;
                int thoigianthi=0;
                string lenh = "EXEC SP_Kiemtramonhocthi '" + Program.username + "','" + cbxMamh.Text + "','" + cbxLanthi.Text + "','"+Program.mGroup+"'";
                rd = Program.ExecSqlDataReader(lenh);
                if (rd.HasRows)
                {
                    rd.Read();
                    ngaythi = rd.GetDateTime(4);
                    socauhoi = rd.GetInt16(6);
                    thoigianthi = rd.GetInt16(7);
                }
                rd.Close();
                Program.Lopthi = cbxMalop.Text;
                Program.Monthi = cbxMamh.Text;
                Program.Ngaythi = ngaythi;
                Program.Socauhoithi = socauhoi;
                Program.Thoigianthi = thoigianthi;
                Program.Lanthi =Convert.ToInt32(cbxLanthi.Text);
                Program.DiemChoMoiCauHoi = (float)10 / Program.Socauhoithi;
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Lỗi thực hiện truy vấn! " + ex.Message);
                return;
            }
        }        

        void Thi()
        {
            FrmThi thi = new FrmThi();
            this.Close();
            thi.ShowDialog();
        }

        private void FrmChuanbithi_Load(object sender, EventArgs e)
        {
            if(Program.mGroup=="SINHVIEN")
            {
                cbxMalop.Enabled = false;
            }
            else
            {
                cbxMalop.Enabled = true;
                button1.Enabled = false;
            }
            btnThi.Enabled = false;
            dtpkNgaythi.Value = DateTime.Today;
            try
            {
                txtMasv.Text = Program.username;
                string lenh = "EXEC SP_DSLOP '" + Program.username + "','" + Program.mGroup + "'";
                DataTable ds = Program.ExecSqlDataTable(lenh);
                if (ds.Rows.Count > 0)
                {
                    cbxMalop.DataSource = ds;
                    cbxMalop.DisplayMember = "malop";
                    dtpkNgaythi.Enabled = true;
                }
                else
                {
                    cbxMalop.DataSource = null;
                    cbxMalop.Enabled = false;
                    btnThi.Enabled = false;
                    MessageBox.Show("Lỗi lấy lớp để chuẩn bị thi,chưa đăng ký thi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!" + ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpkNgaythi_ValueChanged(object sender, EventArgs e)
        {
            string lenh = "EXEC SP_DSMH '"+cbxMalop.Text+"','" + dtpkNgaythi.Value.ToString("yyyy/MM/dd") + "'";
            DataTable ds = Program.ExecSqlDataTable(lenh);
            if (ds.Rows.Count > 0)
            {
                cbxMamh.DataSource = ds;
                cbxMamh.DisplayMember = "mamh";
                cbxMamh.SelectedIndex = 0;
                cbxMamh.Enabled = true;
            }
            else
            {
                cbxMamh.DataSource = null;
                cbxMamh.Enabled = false;
                btnThi.Enabled = false;
                //MessageBox.Show("Lớp của sinh viên chưa được đăng ký thi ngày này!");
                //this.Close();
            }
        }

        private void cbxMamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lenh = "EXEC SP_Laylanthi '" + cbxMalop.Text + "','" +cbxMamh.Text+"','"+ dtpkNgaythi.Value.ToString("yyyy/MM/dd") + "'";
            DataTable ds = Program.ExecSqlDataTable(lenh);
            if (ds.Rows.Count > 0)
            {
                cbxLanthi.DataSource = ds;
                cbxLanthi.DisplayMember = "lan";
                cbxLanthi.Enabled = true;
                btnThi.Enabled = true;
            }
            else
            {
                cbxLanthi.DataSource = null;    
                cbxLanthi.Enabled = false;
                btnThi.Enabled = false;
            }
        }

        private void cbxMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMamh.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInBaiThi frm = new FrmInBaiThi();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}