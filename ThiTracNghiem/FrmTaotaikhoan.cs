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
    public partial class FrmTaotaikhoan : DevExpress.XtraEditors.XtraForm
    {
        public FrmTaotaikhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if(txtTendangnhap.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                return;
            }
            if(txtMatkhau.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                return;
            }
            string lenh = "EXEC SP_Kiemtraid_taotk '" + txtTendangnhap.Text + "'";
            string lenh1 = "EXEC SP_Kiemtralogintontai '" + txtTendangnhap.Text + "'";
            string lenh2 = "EXEC SP_TAOLOGIN '" + txtTendangnhap.Text
                                               + "','" + txtMatkhau.Text
                                               + "','" + txtTendangnhap.Text
                                               + "','" + comboBox1.Text + "'";           
            DataTable tb, tb1;
            tb= Program.ExecSqlDataTable(lenh);
            tb1 = Program.ExecSqlDataTable(lenh1);
            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Mã giáo viên hoặc sinh viên ko tồn tại!");
            }
            else
            {
                if(tb1.Rows.Count==1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
                else
                {
                    try
                    {
                        Program.ExecSqlNonQuery(lenh2);
                        MessageBox.Show("Tạo tài khoản thành công!");
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }
        }


        private void FrmTaotaikhoan_Load(object sender, EventArgs e)
        {
            if(Program.mGroup=="TRUONG")
            {
                comboBox1.Items.Add("TRUONG");
            }
            else
            {
                if(Program.mGroup=="COSO")
                {
                    comboBox1.Items.Add("COSO");
                    comboBox1.Items.Add("GIANGVIEN");
                    comboBox1.Items.Add("SINHVIEN");
                }               
                
            }
            
        }
    }
}