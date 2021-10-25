namespace quan_li_diem_sinh_vien
{
    partial class FrmGiangVien
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
            System.Windows.Forms.Label lblMaGiangVIen;
            System.Windows.Forms.Label lblHo;
            System.Windows.Forms.Label lblTen;
            System.Windows.Forms.Label lblHocVi;
            System.Windows.Forms.Label lblHocHam;
            System.Windows.Forms.Label lblChuyenMon;
            System.Windows.Forms.Label lblMaKhoa;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiangVien));
            this.xtraScrollableControlTong = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControlThuocTinh = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lblMaKhoa1 = new System.Windows.Forms.Label();
            this.giangVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.DSGVC = new quan_li_diem_sinh_vien.DSGVC();
            this.chuyenMonTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barManagerTong = new DevExpress.XtraBars.BarManager(this.components);
            this.barTong = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.hocHamTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hocViTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lblMaGiangVien1 = new System.Windows.Forms.Label();
            this.giangVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_GV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOC_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOC_HAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUYEN_MON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.giangVienTableAdapter = new quan_li_diem_sinh_vien.DSGVCTableAdapters.GIANG_VIENTableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSGVCTableAdapters.TableAdapterManager();
            this.giangTableAdapter = new quan_li_diem_sinh_vien.DSGVCTableAdapters.GIANGTableAdapter();
            this.khaNangGiangTableAdapter = new quan_li_diem_sinh_vien.DSGVCTableAdapters.KHA_NANG_GIANGTableAdapter();
            this.quanLyTableAdapter = new quan_li_diem_sinh_vien.DSGVCTableAdapters.QUAN_LYTableAdapter();
            this.quanLyBDS = new System.Windows.Forms.BindingSource(this.components);
            this.khaNangGiangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.giangBDS = new System.Windows.Forms.BindingSource(this.components);
            lblMaGiangVIen = new System.Windows.Forms.Label();
            lblHo = new System.Windows.Forms.Label();
            lblTen = new System.Windows.Forms.Label();
            lblHocVi = new System.Windows.Forms.Label();
            lblHocHam = new System.Windows.Forms.Label();
            lblChuyenMon = new System.Windows.Forms.Label();
            lblMaKhoa = new System.Windows.Forms.Label();
            this.xtraScrollableControlTong.SuspendLayout();
            this.xtraScrollableControlThuocTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenMonTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocHamTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocViTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).BeginInit();
            this.panelControlKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaNangGiangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaGiangVIen
            // 
            lblMaGiangVIen.AutoSize = true;
            lblMaGiangVIen.Location = new System.Drawing.Point(29, 34);
            lblMaGiangVIen.Name = "lblMaGiangVIen";
            lblMaGiangVIen.Size = new System.Drawing.Size(87, 15);
            lblMaGiangVIen.TabIndex = 0;
            lblMaGiangVIen.Text = "Mã giảng viên:";
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new System.Drawing.Point(90, 74);
            lblHo.Name = "lblHo";
            lblHo.Size = new System.Drawing.Size(26, 15);
            lblHo.TabIndex = 2;
            lblHo.Text = "Họ:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new System.Drawing.Point(85, 115);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(31, 15);
            lblTen.TabIndex = 4;
            lblTen.Text = "Tên:";
            // 
            // lblHocVi
            // 
            lblHocVi.AutoSize = true;
            lblHocVi.Location = new System.Drawing.Point(412, 74);
            lblHocVi.Name = "lblHocVi";
            lblHocVi.Size = new System.Drawing.Size(45, 15);
            lblHocVi.TabIndex = 6;
            lblHocVi.Text = "Học vị:";
            // 
            // lblHocHam
            // 
            lblHocHam.AutoSize = true;
            lblHocHam.Location = new System.Drawing.Point(400, 118);
            lblHocHam.Name = "lblHocHam";
            lblHocHam.Size = new System.Drawing.Size(57, 15);
            lblHocHam.TabIndex = 8;
            lblHocHam.Text = "Học hàm:";
            // 
            // lblChuyenMon
            // 
            lblChuyenMon.AutoSize = true;
            lblChuyenMon.Location = new System.Drawing.Point(379, 162);
            lblChuyenMon.Name = "lblChuyenMon";
            lblChuyenMon.Size = new System.Drawing.Size(78, 15);
            lblChuyenMon.TabIndex = 10;
            lblChuyenMon.Text = "Chuyên môn:";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new System.Drawing.Point(400, 34);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new System.Drawing.Size(57, 15);
            lblMaKhoa.TabIndex = 12;
            lblMaKhoa.Text = "Mã khoa:";
            // 
            // xtraScrollableControlTong
            // 
            this.xtraScrollableControlTong.Controls.Add(this.xtraScrollableControlThuocTinh);
            this.xtraScrollableControlTong.Controls.Add(this.giangVienGridControl);
            this.xtraScrollableControlTong.Controls.Add(this.panelControlKhoa);
            this.xtraScrollableControlTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlTong.Location = new System.Drawing.Point(0, 24);
            this.xtraScrollableControlTong.Name = "xtraScrollableControlTong";
            this.xtraScrollableControlTong.Size = new System.Drawing.Size(1030, 621);
            this.xtraScrollableControlTong.TabIndex = 0;
            // 
            // xtraScrollableControlThuocTinh
            // 
            this.xtraScrollableControlThuocTinh.Controls.Add(lblMaKhoa);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblMaKhoa1);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblChuyenMon);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.chuyenMonTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblHocHam);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.hocHamTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblHocVi);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.hocViTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblTen);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.tenTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblHo);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.hoTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblMaGiangVIen);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblMaGiangVien1);
            this.xtraScrollableControlThuocTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlThuocTinh.Location = new System.Drawing.Point(0, 274);
            this.xtraScrollableControlThuocTinh.Name = "xtraScrollableControlThuocTinh";
            this.xtraScrollableControlThuocTinh.Size = new System.Drawing.Size(1030, 347);
            this.xtraScrollableControlThuocTinh.TabIndex = 2;
            // 
            // lblMaKhoa1
            // 
            this.lblMaKhoa1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "MA_KHOA", true));
            this.lblMaKhoa1.Location = new System.Drawing.Point(473, 34);
            this.lblMaKhoa1.Name = "lblMaKhoa1";
            this.lblMaKhoa1.Size = new System.Drawing.Size(100, 23);
            this.lblMaKhoa1.TabIndex = 13;
            this.lblMaKhoa1.Text = "lblMaKhoa";
            // 
            // giangVienBDS
            // 
            this.giangVienBDS.DataMember = "GIANG_VIEN";
            this.giangVienBDS.DataSource = this.DSGVC;
            // 
            // DSGVC
            // 
            this.DSGVC.DataSetName = "DSGVC";
            this.DSGVC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuyenMonTextEdit
            // 
            this.chuyenMonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBDS, "CHUYEN_MON", true));
            this.chuyenMonTextEdit.Location = new System.Drawing.Point(473, 160);
            this.chuyenMonTextEdit.MenuManager = this.barManagerTong;
            this.chuyenMonTextEdit.Name = "chuyenMonTextEdit";
            this.chuyenMonTextEdit.Size = new System.Drawing.Size(191, 20);
            this.chuyenMonTextEdit.TabIndex = 11;
            // 
            // barManagerTong
            // 
            this.barManagerTong.AllowCustomization = false;
            this.barManagerTong.AllowMoveBarOnToolbar = false;
            this.barManagerTong.AllowQuickCustomization = false;
            this.barManagerTong.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTong});
            this.barManagerTong.DockControls.Add(this.barDockControlTop);
            this.barManagerTong.DockControls.Add(this.barDockControlBottom);
            this.barManagerTong.DockControls.Add(this.barDockControlLeft);
            this.barManagerTong.DockControls.Add(this.barDockControlRight);
            this.barManagerTong.Form = this;
            this.barManagerTong.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThem,
            this.barBtnHieuChinh,
            this.barBtnGhi,
            this.barBtnXoa,
            this.barBtnPhucHoi,
            this.barBtnTaiLai,
            this.barBtnThoat});
            this.barManagerTong.MainMenu = this.barTong;
            this.barManagerTong.MaxItemId = 9;
            this.barManagerTong.OptionsLayout.AllowAddNewItems = false;
            // 
            // barTong
            // 
            this.barTong.BarName = "Main menu";
            this.barTong.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barTong.DockCol = 0;
            this.barTong.DockRow = 0;
            this.barTong.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barTong.FloatLocation = new System.Drawing.Point(133, 247);
            this.barTong.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnTaiLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThoat)});
            this.barTong.OptionsBar.MultiLine = true;
            this.barTong.OptionsBar.UseWholeRow = true;
            this.barTong.Text = "Main menu";
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Id = 2;
            this.barBtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThem.ImageOptions.Image")));
            this.barBtnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThem.ImageOptions.LargeImage")));
            this.barBtnThem.Name = "barBtnThem";
            this.barBtnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThem_ItemClick);
            // 
            // barBtnHieuChinh
            // 
            this.barBtnHieuChinh.Caption = "Hiệu chỉnh";
            this.barBtnHieuChinh.Id = 3;
            this.barBtnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnHieuChinh.ImageOptions.Image")));
            this.barBtnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnHieuChinh.ImageOptions.LargeImage")));
            this.barBtnHieuChinh.Name = "barBtnHieuChinh";
            this.barBtnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHieuChinh_ItemClick);
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.Image")));
            this.barBtnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.LargeImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 5;
            this.barBtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnXoa.ImageOptions.Image")));
            this.barBtnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnXoa.ImageOptions.LargeImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoa_ItemClick);
            // 
            // barBtnPhucHoi
            // 
            this.barBtnPhucHoi.Caption = "Phục hồi";
            this.barBtnPhucHoi.Id = 6;
            this.barBtnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPhucHoi.ImageOptions.Image")));
            this.barBtnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPhucHoi.ImageOptions.LargeImage")));
            this.barBtnPhucHoi.Name = "barBtnPhucHoi";
            this.barBtnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPhucHoi_ItemClick);
            // 
            // barBtnTaiLai
            // 
            this.barBtnTaiLai.Caption = "Tải lại";
            this.barBtnTaiLai.Id = 7;
            this.barBtnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnTaiLai.ImageOptions.Image")));
            this.barBtnTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnTaiLai.ImageOptions.LargeImage")));
            this.barBtnTaiLai.Name = "barBtnTaiLai";
            this.barBtnTaiLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaiLai_ItemClick);
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 8;
            this.barBtnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.Image")));
            this.barBtnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.LargeImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerTong;
            this.barDockControlTop.Size = new System.Drawing.Size(1030, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 645);
            this.barDockControlBottom.Manager = this.barManagerTong;
            this.barDockControlBottom.Size = new System.Drawing.Size(1030, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerTong;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 621);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1030, 24);
            this.barDockControlRight.Manager = this.barManagerTong;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 621);
            // 
            // hocHamTextEdit
            // 
            this.hocHamTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBDS, "HOC_HAM", true));
            this.hocHamTextEdit.Location = new System.Drawing.Point(473, 116);
            this.hocHamTextEdit.MenuManager = this.barManagerTong;
            this.hocHamTextEdit.Name = "hocHamTextEdit";
            this.hocHamTextEdit.Size = new System.Drawing.Size(191, 20);
            this.hocHamTextEdit.TabIndex = 9;
            // 
            // hocViTextEdit
            // 
            this.hocViTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBDS, "HOC_VI", true));
            this.hocViTextEdit.Location = new System.Drawing.Point(473, 72);
            this.hocViTextEdit.MenuManager = this.barManagerTong;
            this.hocViTextEdit.Name = "hocViTextEdit";
            this.hocViTextEdit.Size = new System.Drawing.Size(191, 20);
            this.hocViTextEdit.TabIndex = 7;
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBDS, "TEN", true));
            this.tenTextEdit.Location = new System.Drawing.Point(140, 113);
            this.tenTextEdit.MenuManager = this.barManagerTong;
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Size = new System.Drawing.Size(160, 20);
            this.tenTextEdit.TabIndex = 5;
            // 
            // hoTextEdit
            // 
            this.hoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBDS, "HO", true));
            this.hoTextEdit.Location = new System.Drawing.Point(140, 72);
            this.hoTextEdit.MenuManager = this.barManagerTong;
            this.hoTextEdit.Name = "hoTextEdit";
            this.hoTextEdit.Size = new System.Drawing.Size(160, 20);
            this.hoTextEdit.TabIndex = 3;
            // 
            // lblMaGiangVien1
            // 
            this.lblMaGiangVien1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "MA_GV", true));
            this.lblMaGiangVien1.Location = new System.Drawing.Point(137, 34);
            this.lblMaGiangVien1.Name = "lblMaGiangVien1";
            this.lblMaGiangVien1.Size = new System.Drawing.Size(100, 23);
            this.lblMaGiangVien1.TabIndex = 1;
            this.lblMaGiangVien1.Text = "lblMaGiangVien";
            // 
            // giangVienGridControl
            // 
            this.giangVienGridControl.DataSource = this.giangVienBDS;
            this.giangVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.giangVienGridControl.Location = new System.Drawing.Point(0, 54);
            this.giangVienGridControl.MainView = this.gridViewGiangVien;
            this.giangVienGridControl.MenuManager = this.barManagerTong;
            this.giangVienGridControl.Name = "giangVienGridControl";
            this.giangVienGridControl.Size = new System.Drawing.Size(1030, 220);
            this.giangVienGridControl.TabIndex = 1;
            this.giangVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            // 
            // gridViewGiangVien
            // 
            this.gridViewGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_GV,
            this.colHO,
            this.colTEN,
            this.colHOC_VI,
            this.colHOC_HAM,
            this.colCHUYEN_MON,
            this.colMA_KHOA});
            this.gridViewGiangVien.GridControl = this.giangVienGridControl;
            this.gridViewGiangVien.Name = "gridViewGiangVien";
            this.gridViewGiangVien.OptionsBehavior.Editable = false;
            this.gridViewGiangVien.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewGiangVien.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMA_GV
            // 
            this.colMA_GV.Caption = "Mã giảng viên";
            this.colMA_GV.FieldName = "MA_GV";
            this.colMA_GV.Name = "colMA_GV";
            this.colMA_GV.Visible = true;
            this.colMA_GV.VisibleIndex = 0;
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
            // colHOC_VI
            // 
            this.colHOC_VI.Caption = "Học vị";
            this.colHOC_VI.FieldName = "HOC_VI";
            this.colHOC_VI.Name = "colHOC_VI";
            this.colHOC_VI.Visible = true;
            this.colHOC_VI.VisibleIndex = 3;
            // 
            // colHOC_HAM
            // 
            this.colHOC_HAM.Caption = "Học hàm";
            this.colHOC_HAM.FieldName = "HOC_HAM";
            this.colHOC_HAM.Name = "colHOC_HAM";
            this.colHOC_HAM.Visible = true;
            this.colHOC_HAM.VisibleIndex = 4;
            // 
            // colCHUYEN_MON
            // 
            this.colCHUYEN_MON.Caption = "Chuyên môn";
            this.colCHUYEN_MON.FieldName = "CHUYEN_MON";
            this.colCHUYEN_MON.Name = "colCHUYEN_MON";
            this.colCHUYEN_MON.Visible = true;
            this.colCHUYEN_MON.VisibleIndex = 5;
            // 
            // colMA_KHOA
            // 
            this.colMA_KHOA.Caption = "Mã khoa";
            this.colMA_KHOA.FieldName = "MA_KHOA";
            this.colMA_KHOA.Name = "colMA_KHOA";
            this.colMA_KHOA.Visible = true;
            this.colMA_KHOA.VisibleIndex = 6;
            // 
            // panelControlKhoa
            // 
            this.panelControlKhoa.Controls.Add(this.cboKhoa);
            this.panelControlKhoa.Controls.Add(this.lblKhoa);
            this.panelControlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlKhoa.Location = new System.Drawing.Point(0, 0);
            this.panelControlKhoa.Name = "panelControlKhoa";
            this.panelControlKhoa.Size = new System.Drawing.Size(1030, 54);
            this.panelControlKhoa.TabIndex = 1;
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(114, 18);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(255, 21);
            this.cboKhoa.TabIndex = 2;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(44, 21);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(35, 13);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "Khoa:";
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANG_VIENTableAdapter = this.giangVienTableAdapter;
            this.tableAdapterManager.GIANGTableAdapter = this.giangTableAdapter;
            this.tableAdapterManager.KHA_NANG_GIANGTableAdapter = this.khaNangGiangTableAdapter;
            this.tableAdapterManager.QUAN_LYTableAdapter = this.quanLyTableAdapter;
            this.tableAdapterManager.UpdateOrder = quan_li_diem_sinh_vien.DSGVCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // giangTableAdapter
            // 
            this.giangTableAdapter.ClearBeforeFill = true;
            // 
            // khaNangGiangTableAdapter
            // 
            this.khaNangGiangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyTableAdapter
            // 
            this.quanLyTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBDS
            // 
            this.quanLyBDS.DataMember = "FK_QUAN_LY_GIANG_VIEN";
            this.quanLyBDS.DataSource = this.giangVienBDS;
            // 
            // khaNangGiangBDS
            // 
            this.khaNangGiangBDS.DataMember = "FK_KHA_NANG_GIANG_GIANG_VIEN";
            this.khaNangGiangBDS.DataSource = this.giangVienBDS;
            // 
            // giangBDS
            // 
            this.giangBDS.DataMember = "FK_GIANG_GIANG_VIEN";
            this.giangBDS.DataSource = this.giangVienBDS;
            // 
            // FrmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 645);
            this.Controls.Add(this.xtraScrollableControlTong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmGiangVien";
            this.Text = "FrmGiangVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGiangVien_Load);
            this.xtraScrollableControlTong.ResumeLayout(false);
            this.xtraScrollableControlThuocTinh.ResumeLayout(false);
            this.xtraScrollableControlThuocTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenMonTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocHamTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocViTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).EndInit();
            this.panelControlKhoa.ResumeLayout(false);
            this.panelControlKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaNangGiangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlTong;
        private DevExpress.XtraBars.BarManager barManagerTong;
        private DevExpress.XtraBars.Bar barTong;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem barBtnTaiLai;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControlKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.BindingSource giangVienBDS;
        private DSGVC DSGVC;
        private DSGVCTableAdapters.GIANG_VIENTableAdapter giangVienTableAdapter;
        private DSGVCTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl giangVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DSGVCTableAdapters.QUAN_LYTableAdapter quanLyTableAdapter;
        private System.Windows.Forms.BindingSource quanLyBDS;
        private DSGVCTableAdapters.KHA_NANG_GIANGTableAdapter khaNangGiangTableAdapter;
        private System.Windows.Forms.BindingSource khaNangGiangBDS;
        private DSGVCTableAdapters.GIANGTableAdapter giangTableAdapter;
        private System.Windows.Forms.BindingSource giangBDS;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlThuocTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_GV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOC_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOC_HAM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUYEN_MON;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_KHOA;
        private System.Windows.Forms.Label lblMaKhoa1;
        private DevExpress.XtraEditors.TextEdit chuyenMonTextEdit;
        private DevExpress.XtraEditors.TextEdit hocHamTextEdit;
        private DevExpress.XtraEditors.TextEdit hocViTextEdit;
        private DevExpress.XtraEditors.TextEdit tenTextEdit;
        private DevExpress.XtraEditors.TextEdit hoTextEdit;
        private System.Windows.Forms.Label lblMaGiangVien1;
    }
}