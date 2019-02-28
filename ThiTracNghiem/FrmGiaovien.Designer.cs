namespace ThiTracNghiem
{
    partial class FrmGiaovien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaovien));
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mAGVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new ThiTracNghiem.DS();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCoso = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGiaovien = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kHOATableAdapter = new ThiTracNghiem.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.bODETableAdapter = new ThiTracNghiem.DSTableAdapters.BODETableAdapter();
            this.gIAOVIEN_DANGKYTableAdapter = new ThiTracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gIAOVIENTableAdapter = new ThiTracNghiem.DSTableAdapters.GIAOVIENTableAdapter();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaovien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(12, 17);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(12, 43);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(12, 69);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(12, 95);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(12, 121);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "MAKH:";
            // 
            // BarManager1
            // 
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar2});
            this.BarManager1.DockControls.Add(this.barDockControlTop);
            this.BarManager1.DockControls.Add(this.barDockControlBottom);
            this.BarManager1.DockControls.Add(this.barDockControlLeft);
            this.BarManager1.DockControls.Add(this.barDockControlRight);
            this.BarManager1.Form = this;
            this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhuchoi,
            this.btnRefresh,
            this.btnIn,
            this.btnThoat});
            this.BarManager1.MainMenu = this.Bar2;
            this.BarManager1.MaxItemId = 8;
            // 
            // Bar2
            // 
            this.Bar2.BarName = "Main menu";
            this.Bar2.DockCol = 0;
            this.Bar2.DockRow = 0;
            this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar2.FloatLocation = new System.Drawing.Point(71, 154);
            this.Bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.Bar2.OptionsBar.MultiLine = true;
            this.Bar2.OptionsBar.UseWholeRow = true;
            this.Bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "Phục hồi";
            this.btnPhuchoi.Enabled = false;
            this.btnPhuchoi.Id = 4;
            this.btnPhuchoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.ImageOptions.Image")));
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(876, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 386);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(876, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.BarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 346);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(876, 40);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 346);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.mAGVTextEdit);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hOTextEdit);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.tENTextEdit);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.dIACHITextEdit);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.mAKHTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // mAGVTextEdit
            // 
            this.mAGVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "MAGV", true));
            this.mAGVTextEdit.Location = new System.Drawing.Point(65, 14);
            this.mAGVTextEdit.MenuManager = this.BarManager1;
            this.mAGVTextEdit.Name = "mAGVTextEdit";
            this.mAGVTextEdit.Size = new System.Drawing.Size(209, 20);
            this.mAGVTextEdit.TabIndex = 1;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "FK_GIAOVIEN_KHOA";
            this.gIAOVIENBindingSource.DataSource = this.kHOABindingSource;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(65, 40);
            this.hOTextEdit.MenuManager = this.BarManager1;
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Size = new System.Drawing.Size(209, 20);
            this.hOTextEdit.TabIndex = 3;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(65, 66);
            this.tENTextEdit.MenuManager = this.BarManager1;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Size = new System.Drawing.Size(209, 20);
            this.tENTextEdit.TabIndex = 5;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(65, 92);
            this.dIACHITextEdit.MenuManager = this.BarManager1;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(209, 20);
            this.dIACHITextEdit.TabIndex = 7;
            // 
            // mAKHTextEdit
            // 
            this.mAKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "MAKH", true));
            this.mAKHTextEdit.Location = new System.Drawing.Point(65, 118);
            this.mAKHTextEdit.MenuManager = this.BarManager1;
            this.mAKHTextEdit.Name = "mAKHTextEdit";
            this.mAKHTextEdit.Size = new System.Drawing.Size(209, 20);
            this.mAKHTextEdit.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxCoso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 35);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở : ";
            // 
            // cbxCoso
            // 
            this.cbxCoso.DisplayMember = "TENDAYDU";
            this.cbxCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoso.FormattingEnabled = true;
            this.cbxCoso.Location = new System.Drawing.Point(62, 8);
            this.cbxCoso.Name = "cbxCoso";
            this.cbxCoso.Size = new System.Drawing.Size(169, 21);
            this.cbxCoso.TabIndex = 0;
            this.cbxCoso.ValueMember = "TENSERVER";
            this.cbxCoso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.gcKhoa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.gcGiaovien);
            this.splitContainer1.Size = new System.Drawing.Size(876, 152);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 31;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.kHOABindingSource;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoa.Location = new System.Drawing.Point(0, 0);
            this.gcKhoa.MainView = this.gridView1;
            this.gcKhoa.MenuManager = this.BarManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(292, 152);
            this.gcKhoa.TabIndex = 0;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.gcKhoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            // 
            // gcGiaovien
            // 
            this.gcGiaovien.DataSource = this.gIAOVIENBindingSource;
            this.gcGiaovien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiaovien.Location = new System.Drawing.Point(0, 0);
            this.gcGiaovien.MainView = this.gridView2;
            this.gcGiaovien.MenuManager = this.BarManager1;
            this.gcGiaovien.Name = "gcGiaovien";
            this.gcGiaovien.Size = new System.Drawing.Size(580, 152);
            this.gcGiaovien.TabIndex = 0;
            this.gcGiaovien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH1});
            this.gridView2.GridControl = this.gcGiaovien;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 4;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "FK_BODE_GIAOVIEN";
            this.bODEBindingSource.DataSource = this.gIAOVIENBindingSource;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.gIAOVIENBindingSource;
            // 
            // FrmGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 386);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmGiaovien";
            this.Text = "Giáo viên";
            this.Load += new System.EventHandler(this.FrmGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaovien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraBars.BarManager BarManager1;
        internal DevExpress.XtraBars.Bar Bar2;
        internal DevExpress.XtraBars.BarButtonItem btnThem;
        internal DevExpress.XtraBars.BarButtonItem btnSua;
        internal DevExpress.XtraBars.BarButtonItem btnGhi;
        internal DevExpress.XtraBars.BarButtonItem btnXoa;
        internal DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        internal DevExpress.XtraBars.BarButtonItem btnRefresh;
        internal DevExpress.XtraBars.BarButtonItem btnIn;
        internal DevExpress.XtraBars.BarButtonItem btnThoat;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCoso;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DS dS;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraGrid.GridControl gcGiaovien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraEditors.TextEdit mAGVTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit mAKHTextEdit;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
    }
}