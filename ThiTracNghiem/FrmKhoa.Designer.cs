namespace ThiTracNghiem
{
    partial class FrmKhoa
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoa));
            this.Bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
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
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCoso = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mAKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new ThiTracNghiem.DS();
            this.tENKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mACSTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kHOATableAdapter = new ThiTracNghiem.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.gIAOVIENTableAdapter = new ThiTracNghiem.DSTableAdapters.GIAOVIENTableAdapter();
            this.lOPTableAdapter = new ThiTracNghiem.DSTableAdapters.LOPTableAdapter();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACSTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(6, 17);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(6, 43);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(43, 13);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "TENKH:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(6, 69);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(39, 13);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "MACS:";
            // 
            // Bar2
            // 
            this.Bar2.BarName = "Main menu";
            this.Bar2.DockCol = 0;
            this.Bar2.DockRow = 0;
            this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar2.FloatLocation = new System.Drawing.Point(71, 154);
            this.Bar2.OptionsBar.MultiLine = true;
            this.Bar2.OptionsBar.UseWholeRow = true;
            this.Bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(71, 154);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // BarManager1
            // 
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
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
            this.BarManager1.MainMenu = this.bar3;
            this.BarManager1.MaxItemId = 9;
            this.BarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(71, 154);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(765, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(765, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.BarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 351);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(765, 40);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 351);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "TENDAYDU";
            this.repositoryItemLookUpEdit1.KeyMember = "TENCN;TENSERVER";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "TENSERVER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxCoso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 34);
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
            this.cbxCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoso.FormattingEnabled = true;
            this.cbxCoso.Location = new System.Drawing.Point(62, 8);
            this.cbxCoso.Name = "cbxCoso";
            this.cbxCoso.Size = new System.Drawing.Size(169, 21);
            this.cbxCoso.TabIndex = 0;
            this.cbxCoso.SelectedIndexChanged += new System.EventHandler(this.cbxCoso_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.mAKHTextEdit);
            this.groupBox1.Controls.Add(tENKHLabel);
            this.groupBox1.Controls.Add(this.tENKHTextEdit);
            this.groupBox1.Controls.Add(mACSLabel);
            this.groupBox1.Controls.Add(this.mACSTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 101);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // mAKHTextEdit
            // 
            this.mAKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "MAKH", true));
            this.mAKHTextEdit.Location = new System.Drawing.Point(55, 14);
            this.mAKHTextEdit.MenuManager = this.BarManager1;
            this.mAKHTextEdit.Name = "mAKHTextEdit";
            this.mAKHTextEdit.Size = new System.Drawing.Size(151, 20);
            this.mAKHTextEdit.TabIndex = 1;
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
            // tENKHTextEdit
            // 
            this.tENKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "TENKH", true));
            this.tENKHTextEdit.Location = new System.Drawing.Point(55, 40);
            this.tENKHTextEdit.MenuManager = this.BarManager1;
            this.tENKHTextEdit.Name = "tENKHTextEdit";
            this.tENKHTextEdit.Size = new System.Drawing.Size(151, 20);
            this.tENKHTextEdit.TabIndex = 3;
            // 
            // mACSTextEdit
            // 
            this.mACSTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "MACS", true));
            this.mACSTextEdit.Location = new System.Drawing.Point(55, 66);
            this.mACSTextEdit.MenuManager = this.BarManager1;
            this.mACSTextEdit.Name = "mACSTextEdit";
            this.mACSTextEdit.Size = new System.Drawing.Size(151, 20);
            this.mACSTextEdit.TabIndex = 5;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.kHOABindingSource;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoa.Location = new System.Drawing.Point(0, 74);
            this.gcKhoa.MainView = this.gridView1;
            this.gcKhoa.MenuManager = this.BarManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(765, 216);
            this.gcKhoa.TabIndex = 27;
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
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "FK_GIAOVIEN_KHOA";
            this.gIAOVIENBindingSource.DataSource = this.kHOABindingSource;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "FK_LOP_KHOA";
            this.lOPBindingSource.DataSource = this.kHOABindingSource;
            // 
            // FrmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 391);
            this.Controls.Add(this.gcKhoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmKhoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.FrmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACSTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraBars.Bar Bar2;
        internal DevExpress.XtraBars.Bar bar1;
        internal DevExpress.XtraBars.BarManager BarManager1;
        internal DevExpress.XtraBars.Bar bar3;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCoso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DS dS;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.TextEdit mAKHTextEdit;
        private DevExpress.XtraEditors.TextEdit tENKHTextEdit;
        private DevExpress.XtraEditors.TextEdit mACSTextEdit;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
    }
}