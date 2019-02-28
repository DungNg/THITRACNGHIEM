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

namespace ThiTracNghiem
{
    public partial class FrmInBangDiem : DevExpress.XtraEditors.XtraForm
    {
        public FrmInBangDiem()
        {
            InitializeComponent();
        }


        private void FrmInBangDiem_Load(object sender, EventArgs e)
        {
            cbxLanthi.SelectedIndex = 1;
            cbxLanthi.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMalop.Text==string.Empty)
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }
            if (txtMamh.Text == string.Empty)
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }
            Baocao.rptInBangDiem obj = new Baocao.rptInBangDiem();
            string lenh = "EXEC SP_INBANGDIEM '" + txtMalop.Text + "','" + txtMamh.Text + "','" + cbxLanthi.Text + "'";
            try
            {
                DataTable tb = Program.ExecSqlDataTable(lenh);
                obj.SetDataSource(tb);
                obj.SetParameterValue("LOP", txtMalop.Text);
                obj.SetParameterValue("MONHOC", txtMamh.Text);
                obj.SetParameterValue("LANTHI", cbxLanthi.Text);
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
            this.Close();
        }
    }
}