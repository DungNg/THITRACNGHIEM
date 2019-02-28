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
    public partial class FrmKhoa : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhoa()
        {
            InitializeComponent();
        }


        private void FrmKhoa_Load(object sender, EventArgs e)
        {

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;

            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            this.kHOATableAdapter.Fill(this.dS.KHOA);
                      
            cbxCoso.DataSource = Program.bds_dspm;
            cbxCoso.DisplayMember = "TENDAYDU";
            cbxCoso.ValueMember = "TENSERVER";
            cbxCoso.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "TRUONG")
            {
                cbxCoso.Enabled = true;
                bar3.Visible = false;
            }
            else
            {
                cbxCoso.Enabled = false;
            }
            groupBox1.Enabled = false;
            mACSTextEdit.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            kHOABindingSource.AddNew();
            mACSTextEdit.Text = ((DataRowView)kHOABindingSource[0])["MACS"].ToString();
            mAKHTextEdit.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            if (mAKHTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                mAKHTextEdit.Focus();
                return;
            }
            string lenh = "EXEC SP_Kiemtramakhoa '" + mAKHTextEdit.Text + "'";
            if ((Program.KTTT(lenh)) == 1)
            {
                MessageBox.Show("Mã khoa trùng!");
                mAKHTextEdit.Focus();
                return;
            }
            if (tENKHTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                tENKHTextEdit.Focus();
                return;
            }
            string lenh1 = "EXEC SP_Kiemtratenkhoa N'" + tENKHTextEdit.Text + "'";
            if ((Program.KTTT(lenh1)) == 1)
            {
                MessageBox.Show("Tên khoa trùng!");
                tENKHTextEdit.Focus();
                return;
            }
            try
            {
                kHOABindingSource.EndEdit();
                kHOATableAdapter.Update(dS.KHOA);
                kHOABindingSource.ResetCurrentItem();
                dsRefresh();
                EditOn(false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAKH"))
                    MessageBox.Show("Mã khoa trùng", string.Empty, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi. " + ex.Message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            if (lOPBindingSource.Count > 0)
            {
                MessageBox.Show("Ðang tồn tại lớp thuộc khoa này. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }
            if (gIAOVIENBindingSource.Count > 0)
            {
                MessageBox.Show("Đang tồn tại giáo viên thuộc khoa này. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá khoa này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                kHOABindingSource.RemoveCurrent();
                kHOATableAdapter.Update(dS.KHOA);
                if (kHOABindingSource.Count == 0) btnXoa.Enabled = false;
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
            kHOATableAdapter.Fill(dS.KHOA);
            gIAOVIENTableAdapter.Fill(dS.GIAOVIEN);
            lOPTableAdapter.Fill(dS.LOP);
            EditOn(false);
        }

        private void EditOn(bool x)
        {
            //gckHOA.Enabled = x;\
            groupBox1.Enabled = x;
            gcKhoa.Enabled = !x;
            btnThem.Enabled = !x;
            btnSua.Enabled = !x;
            btnGhi.Enabled = x;
            btnXoa.Enabled = !x;
            if (kHOABindingSource.Count == 0) btnXoa.Enabled = false;
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;

                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

    }
}