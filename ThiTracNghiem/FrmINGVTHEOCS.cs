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
    public partial class FrmINGVTHEOCS : DevExpress.XtraEditors.XtraForm
    {
        public FrmINGVTHEOCS()
        {
            InitializeComponent();
        }

        private void FrmINGVTHEOCS_Load(object sender, EventArgs e)
        {
            cbxCoso.DataSource = Program.bds_dspm;
            cbxCoso.DisplayMember = "TENCN";
            cbxCoso.ValueMember = "TENSERVER";
            cbxCoso.SelectedIndex = Program.mChinhanh;
            Program.Macs = "CS" + (cbxCoso.SelectedIndex + 1);
        }

        private void cbxCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Macs = "CS" + (cbxCoso.SelectedIndex + 1);
            try
            {
                if (cbxCoso.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cbxCoso.SelectedValue.ToString();

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

            if (cbxCoso.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {

            }
        }
    


        private void button1_Click(object sender, EventArgs e)
        {
            Baocao.rptINGVTHEOCS obj = new Baocao.rptINGVTHEOCS();
            string lenh = "EXEC SP_INGVTHEOCS '" + Program.Macs+"'";
            try
            {
                DataTable tb = Program.ExecSqlDataTable(lenh);
                obj.SetDataSource(tb);
                obj.SetParameterValue("MACS", cbxCoso.Text.ToUpper());
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