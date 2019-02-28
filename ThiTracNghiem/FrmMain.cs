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
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if(Program.mGroup=="GIANGVIEN")
            {
                btnTaotaikhoan.Enabled = false;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Bạn muốn thoát ứng dụng?",
                                        "Thoát?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Application.Exit();
                    }                                  
                    break;
            }
        }

        private void btnNhapmonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmMonhoc));
            if (frm != null) frm.Activate();
            else
            {
                FrmMonhoc f = new FrmMonhoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapkhoalop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmLop));
            if (frm != null) frm.Activate();
            else
            {
                FrmLop f = new FrmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapsinhvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmSinhvien));
            if (frm != null) frm.Activate();
            else
            {
                FrmSinhvien f = new FrmSinhvien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapgiaovien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmGiaovien));
            if (frm != null) frm.Activate();
            else
            {
                FrmGiaovien f = new FrmGiaovien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapde_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmNhapde));
            if (frm != null) frm.Activate();
            else
            {
                FrmNhapde f = new FrmNhapde();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChuanbithi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangkythi));
            if (frm != null) frm.Activate();
            else
            {
                FrmDangkythi f = new FrmDangkythi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmChuanbithi));
            if (frm != null) frm.Activate();
            else
            {
                FrmChuanbithi f = new FrmChuanbithi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapkhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmKhoa));
            if (frm != null) frm.Activate();
            else
            {
                FrmKhoa f = new FrmKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void btnTaotaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmTaotaikhoan));
            if (frm != null) frm.Activate();
            else
            {
                FrmTaotaikhoan f = new FrmTaotaikhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangdiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmInBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                FrmInBangDiem f = new FrmInBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmINGVTHEOCS));
            if (frm != null) frm.Activate();
            else
            {
                FrmINGVTHEOCS f = new FrmINGVTHEOCS();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}