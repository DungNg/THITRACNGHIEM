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
    public partial class FrmNhapde : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhapde()
        {
            InitializeComponent();
        }

        private void FrmNhapde_Load(object sender, EventArgs e)
        {
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

            cbxCoso.DataSource = Program.bds_dspm;
            cbxCoso.DisplayMember = "TENDAYDU";
            cbxCoso.ValueMember = "TENSERVER";
            cbxCoso.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "TRUONG")
            {
                cbxCoso.Enabled = true;
                Bar2.Visible = false;
            }
            else
            {
                cbxCoso.Enabled = false;
            }
            groupBox1.Enabled = false;
            mAGVTextEdit.Enabled = false;
            cAUHOISpinEdit.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            bODEBindingSource.AddNew();
            mAGVTextEdit.Text = Program.username;
            tRINHDOComboBox.SelectedIndex = 1;
            tRINHDOComboBox.SelectedIndex = 0;
            cAUHOISpinEdit.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            if (cAUHOISpinEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                cAUHOISpinEdit.Focus();
                return;
            }
            if (tRINHDOComboBox.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                tRINHDOComboBox.Focus();
                return;
            }
            if (nOIDUNGTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                nOIDUNGTextEdit.Focus();
                return;
            }
            if (dAP_ANTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                dAP_ANTextEdit.Focus();
                return;
            }
            try
            {
                bODEBindingSource.EndEdit();
                bODETableAdapter.Update(dS.BODE);
                bODEBindingSource.ResetCurrentItem();
                dsRefresh();
                EditOn(false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("CAUHOI"))
                    MessageBox.Show("Số câu hỏi bị trùng", string.Empty, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi. " + ex.Message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {          
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá câu hỏi này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                bODEBindingSource.RemoveCurrent();
                bODETableAdapter.Update(dS.BODE);
                if (bODEBindingSource.Count == 0) btnXoa.Enabled = false;
            }
            else if (rs == DialogResult.No)
            {
                return;
            }
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsRefresh();
        }

        private void dsRefresh()
        {
            bODETableAdapter.Fill(dS.BODE);
            EditOn(false);
        }

        private void EditOn(bool x)
        {
            //gcbODE.Enabled = x;
            groupBox1.Enabled = x;
            gcBode.Enabled = !x;
            btnThem.Enabled = !x;
            btnSua.Enabled = !x;
            btnGhi.Enabled = x;
            btnXoa.Enabled = !x;
            if (bODEBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(bODEBindingSource.Count.ToString());
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cbxCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCoso.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cbxCoso.SelectedValue.ToString();

            }
            catch (Exception )
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
                try
                {
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.dS.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}