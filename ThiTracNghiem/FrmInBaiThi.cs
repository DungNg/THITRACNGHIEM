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
    public partial class FrmInBaiThi : DevExpress.XtraEditors.XtraForm
    {
        public FrmInBaiThi()
        {
            InitializeComponent();
        }

        private void FrmInBaiThi_Load(object sender, EventArgs e)
        {
            txtMasv.Text = Program.username;
            Laylop();
        }

        void Laylop()
        {
            try
            {              
                string lenh = "EXEC SP_DSLOP '" + txtMasv.Text + "','" + Program.mGroup + "'";
                DataTable ds = Program.ExecSqlDataTable(lenh);
                if (ds.Rows.Count > 0)
                {
                    cbxMalop.DataSource = ds;
                    cbxMalop.DisplayMember = "malop";
                }
                else
                {
                    cbxMalop.DataSource = null;
                    cbxMalop.Enabled = false;
                    //MessageBox.Show("Lỗi lấy lớp để in bài thi,chưa đăng ký thi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!" + ex.Message);
            }
        }
        void Laylanthi()
        {
            string lenh = "EXEC SP_Laylanthi '" + cbxMalop.Text + "','" + cbxMamh.Text + "',' '";
            DataTable ds = Program.ExecSqlDataTable(lenh);
            if (ds.Rows.Count > 0)
            {
                cbxLanthi.DataSource = ds;
                cbxLanthi.DisplayMember = "lan";
                cbxLanthi.Enabled = true;
            }
            else
            {
                cbxLanthi.DataSource = null;
                cbxLanthi.Enabled = false;
            }
        }
        void Laymonthi()
        {
            string lenh = "EXEC SP_DSMH '" + cbxMalop.Text + "',' '";
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
            }
        }

        private void cbxMamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laylanthi();
        }

        private void cbxMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laymonthi();
        }

        void Layngaythi()
        {
            // 0MAGV 1MAMH 2MALOP 3TRINHDO 4NGAYTHI 5LAN 6SOCAUTHI 7THOIGIAN
            SqlDataReader rd;
            try
            {               
                string lenh = "EXEC SP_Kiemtramonhocthi '" + Program.username + "','" + cbxMamh.Text + "','" + cbxLanthi.Text + "','" + Program.mGroup + "'";
                rd = Program.ExecSqlDataReader(lenh);
                if (rd.HasRows)
                {
                    rd.Read();
                    Program.Ngaythi = rd.GetDateTime(4);                    
                }
                rd.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện truy vấn! " + ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Layngaythi();
            Baocao.rptInBaiThi obj = new Baocao.rptInBaiThi();
            string lenh = "EXEC SP_INBAITHI '" + txtMasv.Text + "','" + cbxMamh.Text + "','" + cbxLanthi.Text + "'";
            try
            {
                DataTable tb = Program.ExecSqlDataTable(lenh);
                obj.SetDataSource(tb);
                obj.SetParameterValue("LOP", cbxMalop.Text);
                obj.SetParameterValue("HOTEN", Program.mHoten);
                obj.SetParameterValue("MONTHI", cbxMamh.Text);
                obj.SetParameterValue("LANTHI", cbxLanthi.Text);
                obj.SetParameterValue("NGAYTHI", Program.Ngaythi);
                crystalReportViewer1.ReportSource = obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMasv_TextChanged(object sender, EventArgs e)
        {
            Laylop();
        }
    }
}