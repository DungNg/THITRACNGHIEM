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
    public partial class FrmMonhoc : DevExpress.XtraEditors.XtraForm
    {
        public FrmMonhoc()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            mONHOCBindingSource.AddNew();
            mAMHTextEdit.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            if (mAMHTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                mAMHTextEdit.Focus();
                return;
            }
            if (tENMHTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                tENMHTextEdit.Focus();
                return;
            }
            
            try
            {
                mONHOCBindingSource.EndEdit();
                mONHOCTableAdapter.Update(dS.MONHOC);
                mONHOCBindingSource.ResetCurrentItem();
                dsRefresh();
                EditOn(false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAMH"))
                    MessageBox.Show("Mã môn học trùng", string.Empty, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi. " + ex.Message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bANGDIEMBindingSource.Count > 0)
            {
                MessageBox.Show("Ðang tồn tại bàng điểm của môn học này. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }
            if (bODEBindingSource.Count > 0)
            {
                MessageBox.Show("Ðang tồn tại bộ đề của môn học này. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }
            if (gIAOVIEN_DANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Môn học đã được đăng ký thi. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá môn học này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                mONHOCBindingSource.RemoveCurrent();
                mONHOCTableAdapter.Update(dS.MONHOC);
                if (mONHOCBindingSource.Count == 0) btnXoa.Enabled = false;
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
            mONHOCTableAdapter.Fill(dS.MONHOC);
            gIAOVIEN_DANGKYTableAdapter.Fill(dS.GIAOVIEN_DANGKY);
            bANGDIEMTableAdapter.Fill(dS.BANGDIEM);
            bODETableAdapter.Fill(dS.BODE);
            EditOn(false);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void EditOn(bool x)
        {
            //gcMonhoc.Enabled = x;
            groupBox1.Enabled = x;
            gcMonhoc.Enabled = !x;
            btnThem.Enabled = !x;
            btnSua.Enabled = !x;
            btnGhi.Enabled = x;
            btnXoa.Enabled = !x;
            if (mONHOCBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void FrmMonhoc_Load(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

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
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                    this.bODETableAdapter.Fill(this.dS.BODE);
                    this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}