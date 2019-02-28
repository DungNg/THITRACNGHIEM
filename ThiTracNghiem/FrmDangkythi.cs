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
    public partial class FrmDangkythi : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangkythi()
        {
            InitializeComponent();
        }
        DateTime ngaythi, ngayhientai;

        private void FrmChuanbithi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            //Program.mlogin = Program.remotelogin;
            //Program.password = Program.remotepassword;
            //Program.servername = "DUNGNG\\SERVER1";
            //Program.KetNoi();

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

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
            panel1.Enabled = false;
            mAGVTextEdit.Enabled = false;
            ngayhientai = DateTime.Now;
            //txtNgaythi.Text = ngayhientai.ToString();
        }

        private void tENMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mAMHTextEdit.Text = tENMHComboBox.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void tENLOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mALOPTextEdit.Text = tENLOPComboBox.SelectedValue.ToString();
            }
            catch (Exception)
            {
               
            }
        }



        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
            gIAOVIEN_DANGKYBindingSource.AddNew();
            mAGVTextEdit.Text = Program.username;

            tRINHDOComboBox.SelectedIndex = 1;
            tRINHDOComboBox.SelectedIndex = 0;
            lANNumericUpDown.Value = 2;
            lANNumericUpDown.Value = 1;
            sOCAUTHINumericUpDown.Value = 11;
            sOCAUTHINumericUpDown.Value = 10;
            tHOIGIANNumericUpDown.Value = 16;
            tHOIGIANNumericUpDown.Value = 15;
            nGAYTHIDateTimePicker.Value = ngayhientai;

            tENLOPComboBox.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOn(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show(sOCAUTHINumericUpDown.Value.ToString());
            EditOn(true);
            string lenh = "EXEC SP_Kiemtrasocauhoitrongbode '" + mAMHTextEdit.Text + "','" + tRINHDOComboBox.Text + "'";
            
            try
            {
                nGAYTHIDateTimePicker.Text = txtNgaythi.Text;
                ngaythi = nGAYTHIDateTimePicker.Value;
                if(lANNumericUpDown.Value==2)
                {
                    string lenh1 = "EXEC Kiemtradangkythi '" + mALOPTextEdit.Text + "','" + mAMHTextEdit.Text + "','" + lANNumericUpDown.Value + "'";
                    if(Program.KTTT(lenh1)==0)
                    {
                        MessageBox.Show("Lớp chưa đăng ký thi lần 1!");
                        lANNumericUpDown.Focus();
                        return;
                    }
                }
                if (ngayhientai>ngaythi)
                {
                    MessageBox.Show("Ngày thi phải lớn hơn ngày hiện tại!");
                    nGAYTHIDateTimePicker.Focus();
                    return;
                }
                if (Program.KTTT(lenh) < sOCAUTHINumericUpDown.Value)
                {
                    MessageBox.Show("Số câu hỏi không đủ!");
                    sOCAUTHINumericUpDown.Focus();
                    return;
                }
                gIAOVIEN_DANGKYBindingSource.EndEdit();
                gIAOVIEN_DANGKYTableAdapter.Update(dS.GIAOVIEN_DANGKY);
                gIAOVIEN_DANGKYBindingSource.ResetCurrentItem();
                dsRefresh();
                EditOn(false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAMH"))
                    MessageBox.Show("Lỗi"+ex.Message, string.Empty, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi. " + ex.Message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá đăng ký thi này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                gIAOVIEN_DANGKYBindingSource.RemoveCurrent();
                gIAOVIEN_DANGKYTableAdapter.Update(dS.GIAOVIEN_DANGKY);
                if (gIAOVIEN_DANGKYBindingSource.Count == 0) btnXoa.Enabled = false;
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
            gIAOVIEN_DANGKYTableAdapter.Fill(dS.GIAOVIEN_DANGKY);
            EditOn(false);
        }

        private void EditOn(bool x)
        {
            //gcgIAOVIEN_DANGKY.Enabled = x;
            panel1.Enabled = x;
            gcGiaovien_dangky.Enabled = !x;
            btnThem.Enabled = !x;
            btnSua.Enabled = !x;
            btnGhi.Enabled = x;
            btnXoa.Enabled = !x;
            if (gIAOVIEN_DANGKYBindingSource.Count == 0) btnXoa.Enabled = false;
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
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mALOPTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tENLOPComboBox.SelectedValue = mALOPTextEdit.Text;
            }
            catch (Exception)
            {

            }
        }

        private void mAMHTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tENMHComboBox.SelectedValue = mAMHTextEdit.Text;
            }
            catch (Exception)
            {

            }
        }

        private void nGAYTHIDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtNgaythi.Text = nGAYTHIDateTimePicker.Text;
        }


    }
}