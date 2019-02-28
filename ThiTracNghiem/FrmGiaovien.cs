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
    public partial class FrmGiaovien : DevExpress.XtraEditors.XtraForm
    {
        public FrmGiaovien()
        {
            InitializeComponent();
        }

        private void FrmGiaovien_Load(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;

            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            this.kHOATableAdapter.Fill(this.dS.KHOA);           

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
            //mAKHTextEdit.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            gIAOVIENBindingSource.AddNew();
            mAKHTextEdit.Text = ((DataRowView)kHOABindingSource[gridView1.FocusedRowHandle])["MAKH"].ToString();
            mAGVTextEdit.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            if (mAGVTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                mAGVTextEdit.Focus();
                return;
            }
            string lenh = "EXEC SP_Kiemtramagv '" + mAGVTextEdit.Text + "'";
            if ((Program.KTTT(lenh)) == 1)
            {
                MessageBox.Show("Mã giáo viên trùng!");
                mAGVTextEdit.Focus();
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
            if (mAKHTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                mAKHTextEdit.Focus();
                return;
            }
            try
            {
                gIAOVIENBindingSource.EndEdit();
                gIAOVIENTableAdapter.Update(dS.GIAOVIEN);
                gIAOVIENBindingSource.ResetCurrentItem();
                dsRefresh();
                EditOn(false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAGV"))
                    MessageBox.Show("Mã giáo viên trùng", string.Empty, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi. " + ex.Message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bODEBindingSource.Count > 0)
            {
                MessageBox.Show("Ðang tồn tại bộ đề của giáo viên này. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }
            if (gIAOVIEN_DANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Giáo viên này đã đăng ký thi. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá giáo viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    gIAOVIENBindingSource.RemoveCurrent();
                    gIAOVIENTableAdapter.Update(dS.GIAOVIEN);
                    if (gIAOVIENBindingSource.Count == 0) btnXoa.Enabled = false;
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
            gIAOVIENTableAdapter.Fill(dS.GIAOVIEN);
            gIAOVIEN_DANGKYTableAdapter.Fill(dS.GIAOVIEN_DANGKY);            
            bODETableAdapter.Fill(dS.BODE);
            kHOATableAdapter.Fill(dS.KHOA);
            EditOn(false);
        }

        private void EditOn(bool x)
        {
            //gcgIAOVIEN.Enabled = x;
            groupBox1.Enabled = x;
            gcGiaovien.Enabled = !x;
            gcKhoa.Enabled = !x;
            btnThem.Enabled = !x;
            btnSua.Enabled = !x;
            btnGhi.Enabled = x;
            btnXoa.Enabled = !x;
            if (gIAOVIENBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                try
                {
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;

                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                    this.bODETableAdapter.Fill(this.dS.BODE);
                    this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}