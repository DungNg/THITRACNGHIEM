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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);

            Program.servername = cbxCoso.SelectedValue.ToString();
            txtTendangnhap.Text = "th101";
            txtMatkhau.Text = "1";
        }

        private void cbxChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCoso.SelectedValue != null)
                Program.servername = cbxCoso.SelectedValue.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtMatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatkhau.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTendangnhap.Focus();
                return;
            }
            Program.mlogin = txtTendangnhap.Text; 
            Program.password = txtMatkhau.Text; 
            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cbxCoso.SelectedIndex;           
            Program.bds_dspm = bdsPM; //luu lai bds
            Program.mloginDN = Program.mlogin; //luu lai login luc dang nhap
            Program.passwordDN = Program.password;

            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);            

            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.mHoten))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                Program.mHoten = Program.myReader.GetString(1); //lay ho ten
                Program.mGroup = Program.myReader.GetString(2); //lay nhom
            }
            catch (Exception)
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            

            Program.myReader.Close();
            Program.conn.Close();

            string lenh = "EXEC SP_Laymacoso '" + Program.username + "','"+Program.mGroup+"'";
            SqlDataReader rd = Program.ExecSqlDataReader(lenh);
            if (rd == null) return;
            rd.Read();
            Program.Macs = rd.GetString(0);
            rd.Close();
            if(Program.mGroup=="SINHVIEN")
            {
                FrmChuanbithi cbthi = new FrmChuanbithi();
                this.Hide();
                cbthi.ShowDialog();
                this.Show();
            }
            else
            {
                FrmMain main = new FrmMain();
                main.stManv.Text = "Mã nhân viên : " + Program.username; //hien manv
                main.stHoten.Text = "Họ tên : " + Program.mHoten; //hien hoten
                main.stNhom.Text = "Nhóm : " + Program.mGroup; //hien nhom

                this.Hide();
                main.ShowDialog();
                this.Show();
            }
        }
       
      
    }
}