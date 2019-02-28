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
    public partial class FrmLop : DevExpress.XtraEditors.XtraForm
    {
        public FrmLop()
        {
            InitializeComponent();
        }

        

        private void FrmKhoa_Lop_Load(object sender, EventArgs e)
        {
            
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;

            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.lOPTableAdapter.Fill(this.dS.LOP);
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
            lOPBindingSource.AddNew();
            mAKHTextEdit.Text = ((DataRowView)kHOABindingSource[gridView2.FocusedRowHandle])["MAKH"].ToString();
            mALOPTextEdit.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            if (mALOPTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!");
                mALOPTextEdit.Focus();
                return;
            }
            string lenh = "EXEC SP_Kiemtramalop '" + mALOPTextEdit.Text + "'";
            if ((Program.KTTT(lenh)) == 1)
            {
                MessageBox.Show("Mã lớp trùng!");
                mALOPTextEdit.Focus();
                return;
            }
            if (tENLOPTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cần thiết!");
                tENLOPTextEdit.Focus();
                return;
            }
            string lenh1 = "EXEC SP_Kiemtratenlop N'" + tENLOPTextEdit.Text + "'";
            if ((Program.KTTT(lenh1)) == 1)
            {
                MessageBox.Show("Tên lớp trùng!");
                tENLOPTextEdit.Focus();
                return;
            }
            try
            {
                lOPBindingSource.EndEdit();
                lOPTableAdapter.Update(dS.LOP);
                lOPBindingSource.ResetCurrentItem();
                dsRefresh();
                EditOn(false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MALOP"))
                    MessageBox.Show("Mã lớp trùng", string.Empty, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi. " + ex.Message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            if (sINHVIENBindingSource.Count > 0)
            {
                MessageBox.Show("Ðang tồn tại sinh viên đang học lớp này. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }
            if (gIAOVIEN_DANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Lớp đã được đăng ký thi. Không thể xoá!", string.Empty, MessageBoxButtons.OK);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá lớp này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    lOPBindingSource.RemoveCurrent();
                    lOPTableAdapter.Update(dS.LOP);
                    if (lOPBindingSource.Count == 0) btnXoa.Enabled = false;
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
            lOPTableAdapter.Fill(dS.LOP);
            gIAOVIEN_DANGKYTableAdapter.Fill(dS.GIAOVIEN_DANGKY);
            sINHVIENTableAdapter.Fill(dS.SINHVIEN);
            kHOATableAdapter.Fill(dS.KHOA);
            EditOn(false);
        }

        private void EditOn(bool x)
        {
            //gcLop.Enabled = x;
            groupBox1.Enabled = x;
            gcLop.Enabled = !x;
            gcKhoa.Enabled = x;
            gcKhoa.Enabled = !x;
            btnThem.Enabled = !x;
            btnSua.Enabled = !x;
            btnGhi.Enabled = x;
            btnXoa.Enabled = !x;
            if (lOPBindingSource.Count == 0) btnXoa.Enabled = false;
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
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;

                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
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