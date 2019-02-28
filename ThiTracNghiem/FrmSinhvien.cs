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
    public partial class FrmSinhvien : DevExpress.XtraEditors.XtraForm
    {
        public FrmSinhvien()
        {
            InitializeComponent();
        }

        private void FrmSinhvien_Load(object sender, EventArgs e)
        {
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Fill(this.dS.LOP);

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
            //mALOPTextEdit.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            sINHVIENBindingSource.AddNew();
            mALOPTextEdit.Text= ((DataRowView)lOPBindingSource[gridView1.FocusedRowHandle])["MALOP"].ToString();
            mASVTextEdit.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            if (mASVTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                mASVTextEdit.Focus();
                return;
            }
            string lenh = "EXEC SP_Kiemtramasv '" + mASVTextEdit.Text + "'";
            if ((Program.KTTT(lenh)) == 1)
            {
                MessageBox.Show("Mã sinh viên trùng!");
                mASVTextEdit.Focus();
                return;
            }
            if (hOTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                hOTextEdit.Focus();
                return;
            }
            if (tENTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                tENTextEdit.Focus();
                return;
            }
            try
            {
                sINHVIENBindingSource.EndEdit();
                sINHVIENTableAdapter.Update(dS.SINHVIEN);
                sINHVIENBindingSource.ResetCurrentItem();
                dsRefresh();
                EditOn(false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MASV"))
                    MessageBox.Show("Mã sinh viên trùng", string.Empty, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi. " + ex.Message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bANGDIEMBindingSource.Count > 0)
            {
                MessageBox.Show("Ðang tồn tại bàng điểm của sinh viên này. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    sINHVIENBindingSource.RemoveCurrent();
                    sINHVIENTableAdapter.Update(dS.SINHVIEN);
                    if (sINHVIENBindingSource.Count == 0) btnXoa.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa! " + ex.Message);
                }
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
            sINHVIENTableAdapter.Fill(dS.SINHVIEN);           
            bANGDIEMTableAdapter.Fill(dS.BANGDIEM);
            lOPTableAdapter.Fill(dS.LOP);
            EditOn(false);
        }

        private void EditOn(bool x)
        {
            //gcsINHVIEN.Enabled = x;
            groupBox1.Enabled = x;
            gcSinhvien.Enabled = !x;
            gcLop.Enabled = !x;
            btnThem.Enabled = !x;
            btnSua.Enabled = !x;
            btnGhi.Enabled = x;
            btnXoa.Enabled = !x;
            if (sINHVIENBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
                    this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}