namespace ThiTracNghiem
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhapmonhoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhaplop = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapsinhvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapgiaovien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapde = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangkythi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapkhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaotaikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangdiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stManv = new System.Windows.Forms.ToolStripStatusLabel();
            this.stHoten = new System.Windows.Forms.ToolStripStatusLabel();
            this.stNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNhapmonhoc,
            this.btnNhaplop,
            this.btnNhapsinhvien,
            this.btnNhapgiaovien,
            this.btnNhapde,
            this.btnDangkythi,
            this.btnThi,
            this.btnNhapkhoa,
            this.btnDangxuat,
            this.btnTaotaikhoan,
            this.btnBangdiem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(797, 141);
            // 
            // btnNhapmonhoc
            // 
            this.btnNhapmonhoc.Caption = "Nhập môn học";
            this.btnNhapmonhoc.Id = 1;
            this.btnNhapmonhoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapmonhoc.ImageOptions.Image")));
            this.btnNhapmonhoc.Name = "btnNhapmonhoc";
            this.btnNhapmonhoc.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNhapmonhoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapmonhoc_ItemClick);
            // 
            // btnNhaplop
            // 
            this.btnNhaplop.Caption = "Nhập lớp";
            this.btnNhaplop.Id = 2;
            this.btnNhaplop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaplop.ImageOptions.Image")));
            this.btnNhaplop.Name = "btnNhaplop";
            this.btnNhaplop.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNhaplop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapkhoalop_ItemClick);
            // 
            // btnNhapsinhvien
            // 
            this.btnNhapsinhvien.Caption = "Nhập sinh viên";
            this.btnNhapsinhvien.Id = 3;
            this.btnNhapsinhvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapsinhvien.ImageOptions.Image")));
            this.btnNhapsinhvien.Name = "btnNhapsinhvien";
            this.btnNhapsinhvien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNhapsinhvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapsinhvien_ItemClick);
            // 
            // btnNhapgiaovien
            // 
            this.btnNhapgiaovien.Caption = "Nhập giáo viên";
            this.btnNhapgiaovien.Id = 4;
            this.btnNhapgiaovien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapgiaovien.ImageOptions.Image")));
            this.btnNhapgiaovien.Name = "btnNhapgiaovien";
            this.btnNhapgiaovien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNhapgiaovien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapgiaovien_ItemClick);
            // 
            // btnNhapde
            // 
            this.btnNhapde.Caption = "Nhập đề";
            this.btnNhapde.Id = 5;
            this.btnNhapde.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapde.ImageOptions.Image")));
            this.btnNhapde.Name = "btnNhapde";
            this.btnNhapde.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNhapde.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapde_ItemClick);
            // 
            // btnDangkythi
            // 
            this.btnDangkythi.Caption = "Đăng ký thi";
            this.btnDangkythi.Id = 6;
            this.btnDangkythi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangkythi.ImageOptions.Image")));
            this.btnDangkythi.Name = "btnDangkythi";
            this.btnDangkythi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangkythi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuanbithi_ItemClick);
            // 
            // btnThi
            // 
            this.btnThi.Caption = "Thi";
            this.btnThi.Id = 7;
            this.btnThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThi.ImageOptions.Image")));
            this.btnThi.Name = "btnThi";
            this.btnThi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThi_ItemClick);
            // 
            // btnNhapkhoa
            // 
            this.btnNhapkhoa.Caption = "Nhập khoa";
            this.btnNhapkhoa.Id = 8;
            this.btnNhapkhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapkhoa.ImageOptions.Image")));
            this.btnNhapkhoa.Name = "btnNhapkhoa";
            this.btnNhapkhoa.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNhapkhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapkhoa_ItemClick);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Đăng xuất";
            this.btnDangxuat.Id = 9;
            this.btnDangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.ImageOptions.Image")));
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangxuat_ItemClick);
            // 
            // btnTaotaikhoan
            // 
            this.btnTaotaikhoan.Caption = "Tạo tài khoản";
            this.btnTaotaikhoan.Id = 10;
            this.btnTaotaikhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaotaikhoan.ImageOptions.Image")));
            this.btnTaotaikhoan.Name = "btnTaotaikhoan";
            this.btnTaotaikhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTaotaikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaotaikhoan_ItemClick);
            // 
            // btnBangdiem
            // 
            this.btnBangdiem.Caption = "Bảng điểm";
            this.btnBangdiem.Id = 11;
            this.btnBangdiem.Name = "btnBangdiem";
            this.btnBangdiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangdiem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh sách giáo viên";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Bài thi";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng chính";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapkhoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhaplop);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapmonhoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapgiaovien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapsinhvien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapde);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Nhập liệu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangkythi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thi";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Mở rộng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangxuat);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTaotaikhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hệ thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangdiem);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo cáo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stManv,
            this.stHoten,
            this.stNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stManv
            // 
            this.stManv.Name = "stManv";
            this.stManv.Size = new System.Drawing.Size(42, 17);
            this.stManv.Text = "MANV";
            // 
            // stHoten
            // 
            this.stHoten.Name = "stHoten";
            this.stHoten.Size = new System.Drawing.Size(46, 17);
            this.stHoten.Text = "HOTEN";
            // 
            // stNhom
            // 
            this.stNhom.Name = "stNhom";
            this.stNhom.Size = new System.Drawing.Size(45, 17);
            this.stNhom.Text = "NHOM";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 452);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public System.Windows.Forms.ToolStripStatusLabel stHoten;
        public System.Windows.Forms.ToolStripStatusLabel stNhom;
        public System.Windows.Forms.ToolStripStatusLabel stManv;
        private DevExpress.XtraBars.BarButtonItem btnNhapmonhoc;
        private DevExpress.XtraBars.BarButtonItem btnNhaplop;
        private DevExpress.XtraBars.BarButtonItem btnNhapsinhvien;
        private DevExpress.XtraBars.BarButtonItem btnNhapgiaovien;
        private DevExpress.XtraBars.BarButtonItem btnNhapde;
        private DevExpress.XtraBars.BarButtonItem btnDangkythi;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnNhapkhoa;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private DevExpress.XtraBars.BarButtonItem btnTaotaikhoan;
        private DevExpress.XtraBars.BarButtonItem btnBangdiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}