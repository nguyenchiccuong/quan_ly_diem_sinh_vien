
namespace quan_li_diem_sinh_vien
{
    partial class FrmNKHK
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
            System.Windows.Forms.Label mA_NK_HKLabel;
            System.Windows.Forms.Label nIEN_KHOALabel;
            System.Windows.Forms.Label nGAY_BDAU_DKILabel;
            System.Windows.Forms.Label nGAY_KTHUC_DKILabel;
            System.Windows.Forms.Label hOC_KYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNKHK));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new quan_li_diem_sinh_vien.DS();
            this.bdsNKHK = new System.Windows.Forms.BindingSource(this.components);
            this.NIEN_KHOA_HOC_KYTableAdapter = new quan_li_diem_sinh_vien.DSTableAdapters.NIEN_KHOA_HOC_KYTableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSTableAdapters.TableAdapterManager();
            this.nIEN_KHOA_HOC_KYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_NK_HK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIEN_KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOC_KY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_BDAU_DKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_KTHUC_DKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNKHK = new DevExpress.XtraEditors.PanelControl();
            this.cboHK = new System.Windows.Forms.ComboBox();
            this.dateKT = new DevExpress.XtraEditors.DateEdit();
            this.dateBD = new DevExpress.XtraEditors.DateEdit();
            this.cboNK = new System.Windows.Forms.ComboBox();
            this.tbMaNKHK = new System.Windows.Forms.TextBox();
            mA_NK_HKLabel = new System.Windows.Forms.Label();
            nIEN_KHOALabel = new System.Windows.Forms.Label();
            nGAY_BDAU_DKILabel = new System.Windows.Forms.Label();
            nGAY_KTHUC_DKILabel = new System.Windows.Forms.Label();
            hOC_KYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNKHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIEN_KHOA_HOC_KYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNKHK)).BeginInit();
            this.panelNKHK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mA_NK_HKLabel
            // 
            mA_NK_HKLabel.AutoSize = true;
            mA_NK_HKLabel.Location = new System.Drawing.Point(3, 19);
            mA_NK_HKLabel.Name = "mA_NK_HKLabel";
            mA_NK_HKLabel.Size = new System.Drawing.Size(119, 13);
            mA_NK_HKLabel.TabIndex = 0;
            mA_NK_HKLabel.Text = "Mã Niên Khóa - Học Kỳ:";
            // 
            // nIEN_KHOALabel
            // 
            nIEN_KHOALabel.AutoSize = true;
            nIEN_KHOALabel.Location = new System.Drawing.Point(58, 79);
            nIEN_KHOALabel.Name = "nIEN_KHOALabel";
            nIEN_KHOALabel.Size = new System.Drawing.Size(59, 13);
            nIEN_KHOALabel.TabIndex = 2;
            nIEN_KHOALabel.Text = "Niên Khóa:";
            nIEN_KHOALabel.Click += new System.EventHandler(this.nIEN_KHOALabel_Click);
            // 
            // nGAY_BDAU_DKILabel
            // 
            nGAY_BDAU_DKILabel.AutoSize = true;
            nGAY_BDAU_DKILabel.Location = new System.Drawing.Point(289, 32);
            nGAY_BDAU_DKILabel.Name = "nGAY_BDAU_DKILabel";
            nGAY_BDAU_DKILabel.Size = new System.Drawing.Size(78, 13);
            nGAY_BDAU_DKILabel.TabIndex = 6;
            nGAY_BDAU_DKILabel.Text = "Ngày Bắt Đầu:";
            // 
            // nGAY_KTHUC_DKILabel
            // 
            nGAY_KTHUC_DKILabel.AutoSize = true;
            nGAY_KTHUC_DKILabel.Location = new System.Drawing.Point(283, 79);
            nGAY_KTHUC_DKILabel.Name = "nGAY_KTHUC_DKILabel";
            nGAY_KTHUC_DKILabel.Size = new System.Drawing.Size(81, 13);
            nGAY_KTHUC_DKILabel.TabIndex = 8;
            nGAY_KTHUC_DKILabel.Text = "Ngày Kết Thúc:";
            // 
            // hOC_KYLabel
            // 
            hOC_KYLabel.AutoSize = true;
            hOC_KYLabel.Location = new System.Drawing.Point(73, 122);
            hOC_KYLabel.Name = "hOC_KYLabel";
            hOC_KYLabel.Size = new System.Drawing.Size(44, 13);
            hOC_KYLabel.TabIndex = 9;
            hOC_KYLabel.Text = "Học Kỳ:";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 45);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(903, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLoad,
            this.btnThoat,
            this.btnGhi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 5;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Cập Nhật";
            this.btnLoad.Id = 3;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.LargeImage")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(903, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(903, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 691);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(903, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 691);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNKHK
            // 
            this.bdsNKHK.DataMember = "NIEN_KHOA_HOC_KY";
            this.bdsNKHK.DataSource = this.DS;
            // 
            // NIEN_KHOA_HOC_KYTableAdapter
            // 
            this.NIEN_KHOA_HOC_KYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUYEN_NGANHTableAdapter = null;
            this.tableAdapterManager.DANG_KITableAdapter = null;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.GIANGTableAdapter = null;
            this.tableAdapterManager.KE_HOACH_GIANGTableAdapter = null;
            this.tableAdapterManager.KHA_NANG_GIANGTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP_TIN_CHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MON_HOCTableAdapter = null;
            this.tableAdapterManager.NIEN_KHOA_HOC_KYTableAdapter = this.NIEN_KHOA_HOC_KYTableAdapter;
            this.tableAdapterManager.PHONG_GIAO_VUTableAdapter = null;
            this.tableAdapterManager.QUAN_LYTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quan_li_diem_sinh_vien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nIEN_KHOA_HOC_KYGridControl
            // 
            this.nIEN_KHOA_HOC_KYGridControl.DataSource = this.bdsNKHK;
            this.nIEN_KHOA_HOC_KYGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "FK_DANG_KI_LOP_TIN_CHI";
            gridLevelNode3.RelationName = "FK_GIANG_LOP_TIN_CHI";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2,
            gridLevelNode3});
            gridLevelNode1.RelationName = "FK_LOP_TIN_CHI_NIEN_KHOA_HOC_KY";
            this.nIEN_KHOA_HOC_KYGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.nIEN_KHOA_HOC_KYGridControl.Location = new System.Drawing.Point(0, 45);
            this.nIEN_KHOA_HOC_KYGridControl.MainView = this.gridView1;
            this.nIEN_KHOA_HOC_KYGridControl.MenuManager = this.barManager1;
            this.nIEN_KHOA_HOC_KYGridControl.Name = "nIEN_KHOA_HOC_KYGridControl";
            this.nIEN_KHOA_HOC_KYGridControl.Size = new System.Drawing.Size(903, 691);
            this.nIEN_KHOA_HOC_KYGridControl.TabIndex = 7;
            this.nIEN_KHOA_HOC_KYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_NK_HK,
            this.colNIEN_KHOA,
            this.colHOC_KY,
            this.colNGAY_BDAU_DKI,
            this.colNGAY_KTHUC_DKI});
            this.gridView1.GridControl = this.nIEN_KHOA_HOC_KYGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNIEN_KHOA, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colHOC_KY, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMA_NK_HK
            // 
            this.colMA_NK_HK.Caption = "Mã Niên Khóa Học Kỳ";
            this.colMA_NK_HK.FieldName = "MA_NK_HK";
            this.colMA_NK_HK.Name = "colMA_NK_HK";
            this.colMA_NK_HK.Visible = true;
            this.colMA_NK_HK.VisibleIndex = 0;
            // 
            // colNIEN_KHOA
            // 
            this.colNIEN_KHOA.Caption = "Niên Khóa";
            this.colNIEN_KHOA.FieldName = "NIEN_KHOA";
            this.colNIEN_KHOA.Name = "colNIEN_KHOA";
            this.colNIEN_KHOA.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colNIEN_KHOA.Visible = true;
            this.colNIEN_KHOA.VisibleIndex = 1;
            // 
            // colHOC_KY
            // 
            this.colHOC_KY.Caption = "Học Kỳ";
            this.colHOC_KY.FieldName = "HOC_KY";
            this.colHOC_KY.Name = "colHOC_KY";
            this.colHOC_KY.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colHOC_KY.Visible = true;
            this.colHOC_KY.VisibleIndex = 2;
            // 
            // colNGAY_BDAU_DKI
            // 
            this.colNGAY_BDAU_DKI.Caption = "Ngày Bắt Đầu";
            this.colNGAY_BDAU_DKI.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY_BDAU_DKI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY_BDAU_DKI.FieldName = "NGAY_BDAU_DKI";
            this.colNGAY_BDAU_DKI.Name = "colNGAY_BDAU_DKI";
            this.colNGAY_BDAU_DKI.Visible = true;
            this.colNGAY_BDAU_DKI.VisibleIndex = 3;
            // 
            // colNGAY_KTHUC_DKI
            // 
            this.colNGAY_KTHUC_DKI.Caption = "Ngày Kết Thúc";
            this.colNGAY_KTHUC_DKI.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY_KTHUC_DKI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY_KTHUC_DKI.FieldName = "NGAY_KTHUC_DKI";
            this.colNGAY_KTHUC_DKI.Name = "colNGAY_KTHUC_DKI";
            this.colNGAY_KTHUC_DKI.Visible = true;
            this.colNGAY_KTHUC_DKI.VisibleIndex = 4;
            // 
            // panelNKHK
            // 
            this.panelNKHK.Controls.Add(hOC_KYLabel);
            this.panelNKHK.Controls.Add(this.cboHK);
            this.panelNKHK.Controls.Add(nGAY_KTHUC_DKILabel);
            this.panelNKHK.Controls.Add(this.dateKT);
            this.panelNKHK.Controls.Add(nGAY_BDAU_DKILabel);
            this.panelNKHK.Controls.Add(this.dateBD);
            this.panelNKHK.Controls.Add(nIEN_KHOALabel);
            this.panelNKHK.Controls.Add(this.cboNK);
            this.panelNKHK.Controls.Add(mA_NK_HKLabel);
            this.panelNKHK.Controls.Add(this.tbMaNKHK);
            this.panelNKHK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNKHK.Location = new System.Drawing.Point(0, 590);
            this.panelNKHK.Name = "panelNKHK";
            this.panelNKHK.Size = new System.Drawing.Size(903, 146);
            this.panelNKHK.TabIndex = 8;
            // 
            // cboHK
            // 
            this.cboHK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNKHK, "HOC_KY", true));
            this.cboHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHK.FormattingEnabled = true;
            this.cboHK.Location = new System.Drawing.Point(128, 114);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(121, 21);
            this.cboHK.TabIndex = 10;
            // 
            // dateKT
            // 
            this.dateKT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNKHK, "NGAY_KTHUC_DKI", true));
            this.dateKT.EditValue = null;
            this.dateKT.Location = new System.Drawing.Point(383, 76);
            this.dateKT.MenuManager = this.barManager1;
            this.dateKT.Name = "dateKT";
            this.dateKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKT.Size = new System.Drawing.Size(100, 20);
            this.dateKT.TabIndex = 9;
            // 
            // dateBD
            // 
            this.dateBD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNKHK, "NGAY_BDAU_DKI", true));
            this.dateBD.EditValue = null;
            this.dateBD.Location = new System.Drawing.Point(383, 29);
            this.dateBD.MenuManager = this.barManager1;
            this.dateBD.Name = "dateBD";
            this.dateBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBD.Size = new System.Drawing.Size(100, 20);
            this.dateBD.TabIndex = 7;
            // 
            // cboNK
            // 
            this.cboNK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNKHK, "NIEN_KHOA", true));
            this.cboNK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNK.FormattingEnabled = true;
            this.cboNK.Location = new System.Drawing.Point(128, 71);
            this.cboNK.Name = "cboNK";
            this.cboNK.Size = new System.Drawing.Size(121, 21);
            this.cboNK.TabIndex = 3;
            // 
            // tbMaNKHK
            // 
            this.tbMaNKHK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNKHK, "MA_NK_HK", true));
            this.tbMaNKHK.Enabled = false;
            this.tbMaNKHK.Location = new System.Drawing.Point(128, 16);
            this.tbMaNKHK.Name = "tbMaNKHK";
            this.tbMaNKHK.Size = new System.Drawing.Size(121, 21);
            this.tbMaNKHK.TabIndex = 1;
            // 
            // FrmNKHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(903, 756);
            this.Controls.Add(this.panelNKHK);
            this.Controls.Add(this.nIEN_KHOA_HOC_KYGridControl);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FrmNKHK";
            this.Text = "FrmNKHK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNKHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNKHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIEN_KHOA_HOC_KYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNKHK)).EndInit();
            this.panelNKHK.ResumeLayout(false);
            this.panelNKHK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsNKHK;
        private DS DS;
        private DSTableAdapters.NIEN_KHOA_HOC_KYTableAdapter NIEN_KHOA_HOC_KYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nIEN_KHOA_HOC_KYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelNKHK;
        private DevExpress.XtraEditors.DateEdit dateKT;
        private DevExpress.XtraEditors.DateEdit dateBD;
        private System.Windows.Forms.ComboBox cboNK;
        private System.Windows.Forms.TextBox tbMaNKHK;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NK_HK;
        private DevExpress.XtraGrid.Columns.GridColumn colNIEN_KHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOC_KY;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_BDAU_DKI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_KTHUC_DKI;
        private System.Windows.Forms.ComboBox cboHK;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
    }
}