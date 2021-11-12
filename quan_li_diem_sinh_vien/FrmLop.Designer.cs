
namespace quan_li_diem_sinh_vien
{
    partial class FrmLop
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
            System.Windows.Forms.Label mA_LOPLabel;
            System.Windows.Forms.Label tEN_LOPLabel;
            System.Windows.Forms.Label mA_KHOALabel;
            System.Windows.Forms.Label nAM_NHAP_HOCLabel;
            System.Windows.Forms.Label mA_SVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIA_CHILabel;
            System.Windows.Forms.Label nGAY_SINHLabel;
            System.Windows.Forms.Label mA_LOPLabel1;
            System.Windows.Forms.Label tEN_CH_NGANHLabel;
            System.Windows.Forms.Label mA_CH_NGANHLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new quan_li_diem_sinh_vien.DS();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new quan_li_diem_sinh_vien.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSTableAdapters.TableAdapterManager();
            this.SINH_VIENTableAdapter = new quan_li_diem_sinh_vien.DSTableAdapters.SINH_VIENTableAdapter();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_LOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_LOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAM_NHAP_HOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sINH_VIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_SV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIA_CHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_SINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_CH_NGANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_LOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelLop = new DevExpress.XtraEditors.PanelControl();
            this.cboNamNhapHoc = new System.Windows.Forms.ComboBox();
            this.tbMaKhoa = new System.Windows.Forms.TextBox();
            this.tbTenLop = new System.Windows.Forms.TextBox();
            this.tbMaLop = new System.Windows.Forms.TextBox();
            this.cboChuyenNganh = new System.Windows.Forms.ComboBox();
            this.panelSV = new DevExpress.XtraEditors.PanelControl();
            this.checkPhai = new DevExpress.XtraEditors.CheckEdit();
            this.tbMCN = new System.Windows.Forms.ComboBox();
            this.dateSV = new DevExpress.XtraEditors.DateEdit();
            this.tbDCSV = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbHoSV = new System.Windows.Forms.TextBox();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.cHUYEN_NGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUYEN_NGANHTableAdapter = new quan_li_diem_sinh_vien.DSTableAdapters.CHUYEN_NGANHTableAdapter();
            this.btnChuyenLop = new DevExpress.XtraBars.BarButtonItem();
            this.tbMaLop2 = new System.Windows.Forms.ComboBox();
            mA_LOPLabel = new System.Windows.Forms.Label();
            tEN_LOPLabel = new System.Windows.Forms.Label();
            mA_KHOALabel = new System.Windows.Forms.Label();
            nAM_NHAP_HOCLabel = new System.Windows.Forms.Label();
            mA_SVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIA_CHILabel = new System.Windows.Forms.Label();
            nGAY_SINHLabel = new System.Windows.Forms.Label();
            mA_LOPLabel1 = new System.Windows.Forms.Label();
            tEN_CH_NGANHLabel = new System.Windows.Forms.Label();
            mA_CH_NGANHLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINH_VIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLop)).BeginInit();
            this.panelLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSV)).BeginInit();
            this.panelSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_NGANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mA_LOPLabel
            // 
            mA_LOPLabel.AutoSize = true;
            mA_LOPLabel.Location = new System.Drawing.Point(78, 18);
            mA_LOPLabel.Name = "mA_LOPLabel";
            mA_LOPLabel.Size = new System.Drawing.Size(45, 13);
            mA_LOPLabel.TabIndex = 0;
            mA_LOPLabel.Text = "Mã Lớp:";
            // 
            // tEN_LOPLabel
            // 
            tEN_LOPLabel.AutoSize = true;
            tEN_LOPLabel.Location = new System.Drawing.Point(74, 45);
            tEN_LOPLabel.Name = "tEN_LOPLabel";
            tEN_LOPLabel.Size = new System.Drawing.Size(49, 13);
            tEN_LOPLabel.TabIndex = 2;
            tEN_LOPLabel.Text = "Tên Lớp:";
            // 
            // mA_KHOALabel
            // 
            mA_KHOALabel.AutoSize = true;
            mA_KHOALabel.Location = new System.Drawing.Point(310, 49);
            mA_KHOALabel.Name = "mA_KHOALabel";
            mA_KHOALabel.Size = new System.Drawing.Size(52, 13);
            mA_KHOALabel.TabIndex = 6;
            mA_KHOALabel.Text = "Mã Khoa:";
            // 
            // nAM_NHAP_HOCLabel
            // 
            nAM_NHAP_HOCLabel.AutoSize = true;
            nAM_NHAP_HOCLabel.Location = new System.Drawing.Point(279, 18);
            nAM_NHAP_HOCLabel.Name = "nAM_NHAP_HOCLabel";
            nAM_NHAP_HOCLabel.Size = new System.Drawing.Size(81, 13);
            nAM_NHAP_HOCLabel.TabIndex = 7;
            nAM_NHAP_HOCLabel.Text = "Năm Nhập Học:";
            // 
            // mA_SVLabel
            // 
            mA_SVLabel.AutoSize = true;
            mA_SVLabel.Location = new System.Drawing.Point(33, 36);
            mA_SVLabel.Name = "mA_SVLabel";
            mA_SVLabel.Size = new System.Drawing.Size(40, 13);
            mA_SVLabel.TabIndex = 0;
            mA_SVLabel.Text = "Mã SV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(48, 63);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(44, 94);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIA_CHILabel
            // 
            dIA_CHILabel.AutoSize = true;
            dIA_CHILabel.Location = new System.Drawing.Point(283, 63);
            dIA_CHILabel.Name = "dIA_CHILabel";
            dIA_CHILabel.Size = new System.Drawing.Size(45, 13);
            dIA_CHILabel.TabIndex = 8;
            dIA_CHILabel.Text = "Địa Chỉ:";
            // 
            // nGAY_SINHLabel
            // 
            nGAY_SINHLabel.AutoSize = true;
            nGAY_SINHLabel.Location = new System.Drawing.Point(268, 94);
            nGAY_SINHLabel.Name = "nGAY_SINHLabel";
            nGAY_SINHLabel.Size = new System.Drawing.Size(59, 13);
            nGAY_SINHLabel.TabIndex = 10;
            nGAY_SINHLabel.Text = "Ngày Sinh:";
            // 
            // mA_LOPLabel1
            // 
            mA_LOPLabel1.AutoSize = true;
            mA_LOPLabel1.Location = new System.Drawing.Point(26, 9);
            mA_LOPLabel1.Name = "mA_LOPLabel1";
            mA_LOPLabel1.Size = new System.Drawing.Size(45, 13);
            mA_LOPLabel1.TabIndex = 14;
            mA_LOPLabel1.Text = "Mã Lớp:";
            // 
            // tEN_CH_NGANHLabel
            // 
            tEN_CH_NGANHLabel.AutoSize = true;
            tEN_CH_NGANHLabel.Location = new System.Drawing.Point(230, 13);
            tEN_CH_NGANHLabel.Name = "tEN_CH_NGANHLabel";
            tEN_CH_NGANHLabel.Size = new System.Drawing.Size(103, 13);
            tEN_CH_NGANHLabel.TabIndex = 8;
            tEN_CH_NGANHLabel.Text = "Tên Chuyên Ngành:";
            // 
            // mA_CH_NGANHLabel
            // 
            mA_CH_NGANHLabel.AutoSize = true;
            mA_CH_NGANHLabel.Location = new System.Drawing.Point(308, 185);
            mA_CH_NGANHLabel.Name = "mA_CH_NGANHLabel";
            mA_CH_NGANHLabel.Size = new System.Drawing.Size(81, 13);
            mA_CH_NGANHLabel.TabIndex = 16;
            mA_CH_NGANHLabel.Text = "MA CH NGANH:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(298, 37);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(35, 13);
            pHAILabel.TabIndex = 17;
            pHAILabel.Text = "PHAI:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnSua,
            this.btnLop,
            this.btnSV,
            this.btnLoad,
            this.btnThoat,
            this.btnPhucHoi,
            this.btnChuyenLop});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenLop)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 4;
            this.btnLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.Image")));
            this.btnLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.LargeImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnSV
            // 
            this.btnSV.Caption = "Sinh Viên";
            this.btnSV.Id = 5;
            this.btnSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSV.ImageOptions.Image")));
            this.btnSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSV.ImageOptions.LargeImage")));
            this.btnSV.Name = "btnSV";
            this.btnSV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSV_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.ActAsDropDown = true;
            this.btnThem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnThem.Caption = "Thêm";
            this.btnThem.DropDownControl = this.galleryDropDown1;
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = this.barManager1;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Enabled = false;
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Cập Nhật";
            this.btnLoad.Id = 6;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.LargeImage")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 8;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1357, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1357, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1357, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 691);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1357, 47);
            this.panelControl1.TabIndex = 4;
            // 
            // cboKhoa
            // 
            this.cboKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.ItemHeight = 24;
            this.cboKhoa.Location = new System.Drawing.Point(211, 6);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(261, 32);
            this.cboKhoa.TabIndex = 16;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Khoa:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MON_HOCTableAdapter = null;
            this.tableAdapterManager.NIEN_KHOA_HOC_KYTableAdapter = null;
            this.tableAdapterManager.PHONG_GIAO_VUTableAdapter = null;
            this.tableAdapterManager.QUAN_LYTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = this.SINH_VIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = quan_li_diem_sinh_vien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SINH_VIENTableAdapter
            // 
            this.SINH_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.Location = new System.Drawing.Point(0, 92);
            this.gcLop.MainView = this.gridView1;
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1357, 125);
            this.gcLop.TabIndex = 6;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcLop.Click += new System.EventHandler(this.gcLop_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_LOP,
            this.colTEN_LOP,
            this.colNAM_NHAP_HOC,
            this.colMA_KHOA});
            this.gridView1.GridControl = this.gcLop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colMA_LOP
            // 
            this.colMA_LOP.Caption = "Mã Lớp";
            this.colMA_LOP.FieldName = "MA_LOP";
            this.colMA_LOP.Name = "colMA_LOP";
            this.colMA_LOP.Visible = true;
            this.colMA_LOP.VisibleIndex = 0;
            // 
            // colTEN_LOP
            // 
            this.colTEN_LOP.Caption = "Tên Lớp";
            this.colTEN_LOP.FieldName = "TEN_LOP";
            this.colTEN_LOP.Name = "colTEN_LOP";
            this.colTEN_LOP.Visible = true;
            this.colTEN_LOP.VisibleIndex = 1;
            // 
            // colNAM_NHAP_HOC
            // 
            this.colNAM_NHAP_HOC.Caption = "Năm Nhập Học";
            this.colNAM_NHAP_HOC.FieldName = "NAM_NHAP_HOC";
            this.colNAM_NHAP_HOC.Name = "colNAM_NHAP_HOC";
            this.colNAM_NHAP_HOC.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.colNAM_NHAP_HOC.Visible = true;
            this.colNAM_NHAP_HOC.VisibleIndex = 2;
            // 
            // colMA_KHOA
            // 
            this.colMA_KHOA.Caption = "Mã Khoa";
            this.colMA_KHOA.FieldName = "MA_KHOA";
            this.colMA_KHOA.Name = "colMA_KHOA";
            this.colMA_KHOA.Visible = true;
            this.colMA_KHOA.VisibleIndex = 3;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINH_VIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // sINH_VIENGridControl
            // 
            this.sINH_VIENGridControl.DataSource = this.bdsSinhVien;
            this.sINH_VIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sINH_VIENGridControl.Location = new System.Drawing.Point(0, 217);
            this.sINH_VIENGridControl.MainView = this.gridView2;
            this.sINH_VIENGridControl.MenuManager = this.barManager1;
            this.sINH_VIENGridControl.Name = "sINH_VIENGridControl";
            this.sINH_VIENGridControl.Size = new System.Drawing.Size(1357, 166);
            this.sINH_VIENGridControl.TabIndex = 6;
            this.sINH_VIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.sINH_VIENGridControl.Click += new System.EventHandler(this.sINH_VIENGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_SV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIA_CHI,
            this.colNGAY_SINH,
            this.colMA_CH_NGANH,
            this.colMA_LOP1});
            this.gridView2.GridControl = this.sINH_VIENGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colMA_SV
            // 
            this.colMA_SV.Caption = "Mã Sinh Viên";
            this.colMA_SV.FieldName = "MA_SV";
            this.colMA_SV.Name = "colMA_SV";
            this.colMA_SV.Visible = true;
            this.colMA_SV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            // 
            // colDIA_CHI
            // 
            this.colDIA_CHI.Caption = "Địa Chỉ";
            this.colDIA_CHI.FieldName = "DIA_CHI";
            this.colDIA_CHI.Name = "colDIA_CHI";
            this.colDIA_CHI.Visible = true;
            this.colDIA_CHI.VisibleIndex = 4;
            // 
            // colNGAY_SINH
            // 
            this.colNGAY_SINH.Caption = "Ngày Sinh";
            this.colNGAY_SINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY_SINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY_SINH.FieldName = "NGAY_SINH";
            this.colNGAY_SINH.Name = "colNGAY_SINH";
            this.colNGAY_SINH.Visible = true;
            this.colNGAY_SINH.VisibleIndex = 5;
            // 
            // colMA_CH_NGANH
            // 
            this.colMA_CH_NGANH.Caption = "Mã Chuyên Ngành";
            this.colMA_CH_NGANH.FieldName = "MA_CH_NGANH";
            this.colMA_CH_NGANH.Name = "colMA_CH_NGANH";
            this.colMA_CH_NGANH.Visible = true;
            this.colMA_CH_NGANH.VisibleIndex = 6;
            // 
            // colMA_LOP1
            // 
            this.colMA_LOP1.Caption = "Mã Lớp";
            this.colMA_LOP1.FieldName = "MA_LOP";
            this.colMA_LOP1.Name = "colMA_LOP1";
            this.colMA_LOP1.Visible = true;
            this.colMA_LOP1.VisibleIndex = 7;
            // 
            // panelLop
            // 
            this.panelLop.Controls.Add(nAM_NHAP_HOCLabel);
            this.panelLop.Controls.Add(this.cboNamNhapHoc);
            this.panelLop.Controls.Add(mA_KHOALabel);
            this.panelLop.Controls.Add(this.tbMaKhoa);
            this.panelLop.Controls.Add(tEN_LOPLabel);
            this.panelLop.Controls.Add(this.tbTenLop);
            this.panelLop.Controls.Add(mA_LOPLabel);
            this.panelLop.Controls.Add(this.tbMaLop);
            this.panelLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLop.Enabled = false;
            this.panelLop.Location = new System.Drawing.Point(0, 383);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(613, 353);
            this.panelLop.TabIndex = 11;
            // 
            // cboNamNhapHoc
            // 
            this.cboNamNhapHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "NAM_NHAP_HOC", true));
            this.cboNamNhapHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamNhapHoc.FormattingEnabled = true;
            this.cboNamNhapHoc.Location = new System.Drawing.Point(373, 15);
            this.cboNamNhapHoc.Name = "cboNamNhapHoc";
            this.cboNamNhapHoc.Size = new System.Drawing.Size(121, 21);
            this.cboNamNhapHoc.TabIndex = 8;
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MA_KHOA", true));
            this.tbMaKhoa.Enabled = false;
            this.tbMaKhoa.Location = new System.Drawing.Point(373, 46);
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.Size = new System.Drawing.Size(100, 21);
            this.tbMaKhoa.TabIndex = 7;
            // 
            // tbTenLop
            // 
            this.tbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TEN_LOP", true));
            this.tbTenLop.Location = new System.Drawing.Point(132, 42);
            this.tbTenLop.Name = "tbTenLop";
            this.tbTenLop.Size = new System.Drawing.Size(141, 21);
            this.tbTenLop.TabIndex = 3;
            // 
            // tbMaLop
            // 
            this.tbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MA_LOP", true));
            this.tbMaLop.Enabled = false;
            this.tbMaLop.Location = new System.Drawing.Point(132, 15);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Size = new System.Drawing.Size(141, 21);
            this.tbMaLop.TabIndex = 1;
            // 
            // cboChuyenNganh
            // 
            this.cboChuyenNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenNganh.FormattingEnabled = true;
            this.cboChuyenNganh.Location = new System.Drawing.Point(339, 5);
            this.cboChuyenNganh.Name = "cboChuyenNganh";
            this.cboChuyenNganh.Size = new System.Drawing.Size(121, 21);
            this.cboChuyenNganh.TabIndex = 9;
            // 
            // panelSV
            // 
            this.panelSV.Controls.Add(this.tbMaLop2);
            this.panelSV.Controls.Add(pHAILabel);
            this.panelSV.Controls.Add(this.checkPhai);
            this.panelSV.Controls.Add(mA_CH_NGANHLabel);
            this.panelSV.Controls.Add(this.tbMCN);
            this.panelSV.Controls.Add(tEN_CH_NGANHLabel);
            this.panelSV.Controls.Add(mA_LOPLabel1);
            this.panelSV.Controls.Add(this.cboChuyenNganh);
            this.panelSV.Controls.Add(nGAY_SINHLabel);
            this.panelSV.Controls.Add(this.dateSV);
            this.panelSV.Controls.Add(dIA_CHILabel);
            this.panelSV.Controls.Add(this.tbDCSV);
            this.panelSV.Controls.Add(tENLabel);
            this.panelSV.Controls.Add(this.tbTen);
            this.panelSV.Controls.Add(hOLabel);
            this.panelSV.Controls.Add(this.tbHoSV);
            this.panelSV.Controls.Add(mA_SVLabel);
            this.panelSV.Controls.Add(this.tbMaSV);
            this.panelSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSV.Enabled = false;
            this.panelSV.Location = new System.Drawing.Point(613, 383);
            this.panelSV.Name = "panelSV";
            this.panelSV.Size = new System.Drawing.Size(744, 353);
            this.panelSV.TabIndex = 12;
            // 
            // checkPhai
            // 
            this.checkPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "PHAI", true));
            this.checkPhai.EditValue = true;
            this.checkPhai.Location = new System.Drawing.Point(339, 34);
            this.checkPhai.MenuManager = this.barManager1;
            this.checkPhai.Name = "checkPhai";
            this.checkPhai.Properties.Caption = "Nam";
            this.checkPhai.Size = new System.Drawing.Size(75, 20);
            this.checkPhai.TabIndex = 18;
            // 
            // tbMCN
            // 
            this.tbMCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MA_CH_NGANH", true));
            this.tbMCN.FormattingEnabled = true;
            this.tbMCN.Location = new System.Drawing.Point(395, 182);
            this.tbMCN.Name = "tbMCN";
            this.tbMCN.Size = new System.Drawing.Size(121, 21);
            this.tbMCN.TabIndex = 17;
            // 
            // dateSV
            // 
            this.dateSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "NGAY_SINH", true));
            this.dateSV.EditValue = null;
            this.dateSV.Location = new System.Drawing.Point(339, 91);
            this.dateSV.MenuManager = this.barManager1;
            this.dateSV.Name = "dateSV";
            this.dateSV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSV.Properties.MinValue = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateSV.Size = new System.Drawing.Size(100, 20);
            this.dateSV.TabIndex = 11;
            // 
            // tbDCSV
            // 
            this.tbDCSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "DIA_CHI", true));
            this.tbDCSV.Location = new System.Drawing.Point(339, 60);
            this.tbDCSV.Name = "tbDCSV";
            this.tbDCSV.Size = new System.Drawing.Size(170, 21);
            this.tbDCSV.TabIndex = 9;
            // 
            // tbTen
            // 
            this.tbTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "TEN", true));
            this.tbTen.Location = new System.Drawing.Point(80, 91);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(161, 21);
            this.tbTen.TabIndex = 5;
            // 
            // tbHoSV
            // 
            this.tbHoSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "HO", true));
            this.tbHoSV.Location = new System.Drawing.Point(80, 60);
            this.tbHoSV.Name = "tbHoSV";
            this.tbHoSV.Size = new System.Drawing.Size(161, 21);
            this.tbHoSV.TabIndex = 3;
            // 
            // tbMaSV
            // 
            this.tbMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MA_SV", true));
            this.tbMaSV.Enabled = false;
            this.tbMaSV.Location = new System.Drawing.Point(80, 33);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(161, 21);
            this.tbMaSV.TabIndex = 1;
            // 
            // cHUYEN_NGANHBindingSource
            // 
            this.cHUYEN_NGANHBindingSource.DataMember = "CHUYEN_NGANH";
            this.cHUYEN_NGANHBindingSource.DataSource = this.DS;
            // 
            // cHUYEN_NGANHTableAdapter
            // 
            this.cHUYEN_NGANHTableAdapter.ClearBeforeFill = true;
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.Caption = "Chuyển Lớp";
            this.btnChuyenLop.Enabled = false;
            this.btnChuyenLop.Id = 9;
            this.btnChuyenLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenLop.ImageOptions.Image")));
            this.btnChuyenLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenLop.ImageOptions.LargeImage")));
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChuyenLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenLop_ItemClick);
            // 
            // tbMaLop2
            // 
            this.tbMaLop2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MA_LOP", true));
            this.tbMaLop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbMaLop2.Enabled = false;
            this.tbMaLop2.FormattingEnabled = true;
            this.tbMaLop2.Location = new System.Drawing.Point(80, 6);
            this.tbMaLop2.Name = "tbMaLop2";
            this.tbMaLop2.Size = new System.Drawing.Size(121, 21);
            this.tbMaLop2.TabIndex = 19;
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1357, 756);
            this.Controls.Add(this.panelSV);
            this.Controls.Add(this.panelLop);
            this.Controls.Add(this.sINH_VIENGridControl);
            this.Controls.Add(this.gcLop);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmLop";
            this.Text = "FrmLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINH_VIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLop)).EndInit();
            this.panelLop.ResumeLayout(false);
            this.panelLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSV)).EndInit();
            this.panelSV.ResumeLayout(false);
            this.panelSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_NGANHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.SINH_VIENTableAdapter SINH_VIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DevExpress.XtraGrid.GridControl sINH_VIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_SV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIA_CHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_SINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_CH_NGANH;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_LOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_LOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_LOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNAM_NHAP_HOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_KHOA;
        private DevExpress.XtraEditors.PanelControl panelSV;
        private DevExpress.XtraEditors.PanelControl panelLop;
        private System.Windows.Forms.TextBox tbMaKhoa;
        private System.Windows.Forms.TextBox tbTenLop;
        private System.Windows.Forms.TextBox tbMaLop;
        private System.Windows.Forms.ComboBox cboNamNhapHoc;
        private DevExpress.XtraEditors.DateEdit dateSV;
        private System.Windows.Forms.TextBox tbDCSV;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbHoSV;
        private System.Windows.Forms.TextBox tbMaSV;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnSV;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.ComboBox cboChuyenNganh;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private System.Windows.Forms.BindingSource cHUYEN_NGANHBindingSource;
        private DSTableAdapters.CHUYEN_NGANHTableAdapter cHUYEN_NGANHTableAdapter;
        private System.Windows.Forms.ComboBox tbMCN;
        private DevExpress.XtraEditors.CheckEdit checkPhai;
        private DevExpress.XtraBars.BarButtonItem btnChuyenLop;
        private System.Windows.Forms.ComboBox tbMaLop2;
    }
}