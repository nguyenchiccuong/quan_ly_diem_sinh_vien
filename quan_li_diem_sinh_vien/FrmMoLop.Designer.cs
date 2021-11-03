namespace quan_li_diem_sinh_vien
{
    partial class FrmMoLop
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
            System.Windows.Forms.Label mA_LOP_TCLabel;
            System.Windows.Forms.Label mA_KHOALabel;
            System.Windows.Forms.Label mA_MHLabel;
            System.Windows.Forms.Label mA_NK_HKLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label mA_NVLabel;
            System.Windows.Forms.Label hUYLabel;
            System.Windows.Forms.Label sO_SV_TTHIEULabel;
            System.Windows.Forms.Label hE_SO_CKLabel;
            System.Windows.Forms.Label hE_SO_GKLabel;
            System.Windows.Forms.Label hE_SO_CCLabel;
            System.Windows.Forms.Label mA_LOP_TCLabel2;
            System.Windows.Forms.Label mA_GVLabel;
            System.Windows.Forms.Label tHULabel;
            System.Windows.Forms.Label tIET_BDAULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoLop));
            this.barManagerTong = new DevExpress.XtraBars.BarManager(this.components);
            this.barTong = new DevExpress.XtraBars.Bar();
            this.barBtnThemLop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThemGiang = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraScrollableControlTong = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lblMaGiangVien = new System.Windows.Forms.Label();
            this.giangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.lopTinChiBDS = new System.Windows.Forms.BindingSource(this.components);
            this.DSMLC = new quan_li_diem_sinh_vien.DSMLC();
            this.cboMaGiangVien = new System.Windows.Forms.ComboBox();
            this.tietBatDauSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.thuSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.lblMaLopTinChi2 = new System.Windows.Forms.Label();
            this.xtraScrollableControlThuocTinhLop = new DevExpress.XtraEditors.XtraScrollableControl();
            this.cboNienKhoaHocKy = new System.Windows.Forms.ComboBox();
            this.cboMaMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMaMonHoc = new System.Windows.Forms.Label();
            this.heSoCcSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.heSoGkSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.heSoCkSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.soSvToiThieuSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.huyCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblNhom = new System.Windows.Forms.Label();
            this.lblMaNienKhoaHocKy = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblMaLopTinChi = new System.Windows.Forms.Label();
            this.giangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_LOP_TC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_GV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIET_BDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lopTinChiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewLopTinChi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_LOP_TC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_MH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NK_HK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHE_SO_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHE_SO_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHE_SO_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_SV_TTHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lopTinChiTableAdapter = new quan_li_diem_sinh_vien.DSMLCTableAdapters.LOP_TIN_CHITableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSMLCTableAdapters.TableAdapterManager();
            this.dangKyTableAdapter = new quan_li_diem_sinh_vien.DSMLCTableAdapters.DANG_KITableAdapter();
            this.giangTableAdapter = new quan_li_diem_sinh_vien.DSMLCTableAdapters.GIANGTableAdapter();
            this.dangKyBDS = new System.Windows.Forms.BindingSource(this.components);
            mA_LOP_TCLabel = new System.Windows.Forms.Label();
            mA_KHOALabel = new System.Windows.Forms.Label();
            mA_MHLabel = new System.Windows.Forms.Label();
            mA_NK_HKLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            mA_NVLabel = new System.Windows.Forms.Label();
            hUYLabel = new System.Windows.Forms.Label();
            sO_SV_TTHIEULabel = new System.Windows.Forms.Label();
            hE_SO_CKLabel = new System.Windows.Forms.Label();
            hE_SO_GKLabel = new System.Windows.Forms.Label();
            hE_SO_CCLabel = new System.Windows.Forms.Label();
            mA_LOP_TCLabel2 = new System.Windows.Forms.Label();
            mA_GVLabel = new System.Windows.Forms.Label();
            tHULabel = new System.Windows.Forms.Label();
            tIET_BDAULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).BeginInit();
            this.xtraScrollableControlTong.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tietBatDauSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuSpinEdit.Properties)).BeginInit();
            this.xtraScrollableControlThuocTinhLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heSoCcSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoGkSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoCkSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soSvToiThieuSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huyCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).BeginInit();
            this.panelControlKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // mA_LOP_TCLabel
            // 
            mA_LOP_TCLabel.AutoSize = true;
            mA_LOP_TCLabel.Location = new System.Drawing.Point(81, 15);
            mA_LOP_TCLabel.Name = "mA_LOP_TCLabel";
            mA_LOP_TCLabel.Size = new System.Drawing.Size(84, 15);
            mA_LOP_TCLabel.TabIndex = 0;
            mA_LOP_TCLabel.Text = "Mã lớp tín chỉ:";
            // 
            // mA_KHOALabel
            // 
            mA_KHOALabel.AutoSize = true;
            mA_KHOALabel.Location = new System.Drawing.Point(358, 15);
            mA_KHOALabel.Name = "mA_KHOALabel";
            mA_KHOALabel.Size = new System.Drawing.Size(57, 15);
            mA_KHOALabel.TabIndex = 2;
            mA_KHOALabel.Text = "Mã khoa:";
            // 
            // mA_MHLabel
            // 
            mA_MHLabel.AutoSize = true;
            mA_MHLabel.Location = new System.Drawing.Point(88, 92);
            mA_MHLabel.Name = "mA_MHLabel";
            mA_MHLabel.Size = new System.Drawing.Size(77, 15);
            mA_MHLabel.TabIndex = 4;
            mA_MHLabel.Text = "Mã môn học:";
            // 
            // mA_NK_HKLabel
            // 
            mA_NK_HKLabel.AutoSize = true;
            mA_NK_HKLabel.Location = new System.Drawing.Point(34, 49);
            mA_NK_HKLabel.Name = "mA_NK_HKLabel";
            mA_NK_HKLabel.Size = new System.Drawing.Size(131, 15);
            mA_NK_HKLabel.TabIndex = 6;
            mA_NK_HKLabel.Text = "Mã niên khóa - Học kỳ:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(123, 126);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(42, 15);
            nHOMLabel.TabIndex = 8;
            nHOMLabel.Text = "Nhóm:";
            // 
            // mA_NVLabel
            // 
            mA_NVLabel.AutoSize = true;
            mA_NVLabel.Location = new System.Drawing.Point(330, 160);
            mA_NVLabel.Name = "mA_NVLabel";
            mA_NVLabel.Size = new System.Drawing.Size(84, 15);
            mA_NVLabel.TabIndex = 10;
            mA_NVLabel.Text = "Mã nhân viên:";
            // 
            // hUYLabel
            // 
            hUYLabel.AutoSize = true;
            hUYLabel.Location = new System.Drawing.Point(381, 189);
            hUYLabel.Name = "hUYLabel";
            hUYLabel.Size = new System.Drawing.Size(33, 15);
            hUYLabel.TabIndex = 12;
            hUYLabel.Text = "Hủy:";
            // 
            // sO_SV_TTHIEULabel
            // 
            sO_SV_TTHIEULabel.AutoSize = true;
            sO_SV_TTHIEULabel.Location = new System.Drawing.Point(292, 126);
            sO_SV_TTHIEULabel.Name = "sO_SV_TTHIEULabel";
            sO_SV_TTHIEULabel.Size = new System.Drawing.Size(123, 15);
            sO_SV_TTHIEULabel.TabIndex = 14;
            sO_SV_TTHIEULabel.Text = "Số sinh viên tối thiểu:";
            // 
            // hE_SO_CKLabel
            // 
            hE_SO_CKLabel.AutoSize = true;
            hE_SO_CKLabel.Location = new System.Drawing.Point(82, 229);
            hE_SO_CKLabel.Name = "hE_SO_CKLabel";
            hE_SO_CKLabel.Size = new System.Drawing.Size(83, 15);
            hE_SO_CKLabel.TabIndex = 16;
            hE_SO_CKLabel.Text = "Hệ số cuối kỳ:";
            // 
            // hE_SO_GKLabel
            // 
            hE_SO_GKLabel.AutoSize = true;
            hE_SO_GKLabel.Location = new System.Drawing.Point(86, 192);
            hE_SO_GKLabel.Name = "hE_SO_GKLabel";
            hE_SO_GKLabel.Size = new System.Drawing.Size(79, 15);
            hE_SO_GKLabel.TabIndex = 18;
            hE_SO_GKLabel.Text = "Hệ số giữa kì:";
            // 
            // hE_SO_CCLabel
            // 
            hE_SO_CCLabel.AutoSize = true;
            hE_SO_CCLabel.Location = new System.Drawing.Point(59, 160);
            hE_SO_CCLabel.Name = "hE_SO_CCLabel";
            hE_SO_CCLabel.Size = new System.Drawing.Size(106, 15);
            hE_SO_CCLabel.TabIndex = 20;
            hE_SO_CCLabel.Text = "Hệ số chuyên cần:";
            // 
            // mA_LOP_TCLabel2
            // 
            mA_LOP_TCLabel2.AutoSize = true;
            mA_LOP_TCLabel2.Location = new System.Drawing.Point(34, 15);
            mA_LOP_TCLabel2.Name = "mA_LOP_TCLabel2";
            mA_LOP_TCLabel2.Size = new System.Drawing.Size(84, 15);
            mA_LOP_TCLabel2.TabIndex = 0;
            mA_LOP_TCLabel2.Text = "Mã lớp tín chỉ:";
            // 
            // mA_GVLabel
            // 
            mA_GVLabel.AutoSize = true;
            mA_GVLabel.Location = new System.Drawing.Point(31, 57);
            mA_GVLabel.Name = "mA_GVLabel";
            mA_GVLabel.Size = new System.Drawing.Size(87, 15);
            mA_GVLabel.TabIndex = 2;
            mA_GVLabel.Text = "Mã giảng viên:";
            // 
            // tHULabel
            // 
            tHULabel.AutoSize = true;
            tHULabel.Location = new System.Drawing.Point(86, 97);
            tHULabel.Name = "tHULabel";
            tHULabel.Size = new System.Drawing.Size(32, 15);
            tHULabel.TabIndex = 4;
            tHULabel.Text = "Thứ:";
            // 
            // tIET_BDAULabel
            // 
            tIET_BDAULabel.AutoSize = true;
            tIET_BDAULabel.Location = new System.Drawing.Point(44, 132);
            tIET_BDAULabel.Name = "tIET_BDAULabel";
            tIET_BDAULabel.Size = new System.Drawing.Size(74, 15);
            tIET_BDAULabel.TabIndex = 6;
            tIET_BDAULabel.Text = "Tiết bắt đầu:";
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
            this.barBtnHieuChinh,
            this.barBtnTaiLai,
            this.barBtnThoat,
            this.barBtnThemLop,
            this.barBtnThemGiang,
            this.barBtnGhi,
            this.barBtnXoa});
            this.barManagerTong.MainMenu = this.barTong;
            this.barManagerTong.MaxItemId = 14;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThemLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThemGiang),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnTaiLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThoat)});
            this.barTong.OptionsBar.MultiLine = true;
            this.barTong.OptionsBar.UseWholeRow = true;
            this.barTong.Text = "Main menu";
            // 
            // barBtnThemLop
            // 
            this.barBtnThemLop.Caption = "Thêm lớp";
            this.barBtnThemLop.Id = 9;
            this.barBtnThemLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThemLop.ImageOptions.Image")));
            this.barBtnThemLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThemLop.ImageOptions.LargeImage")));
            this.barBtnThemLop.Name = "barBtnThemLop";
            this.barBtnThemLop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnThemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemLop_ItemClick);
            // 
            // barBtnThemGiang
            // 
            this.barBtnThemGiang.Caption = "Thêm giảng";
            this.barBtnThemGiang.Id = 10;
            this.barBtnThemGiang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThemGiang.ImageOptions.Image")));
            this.barBtnThemGiang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThemGiang.ImageOptions.LargeImage")));
            this.barBtnThemGiang.Name = "barBtnThemGiang";
            this.barBtnThemGiang.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barBtnHieuChinh
            // 
            this.barBtnHieuChinh.Caption = "Hiệu chỉnh";
            this.barBtnHieuChinh.Id = 4;
            this.barBtnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnHieuChinh.ImageOptions.Image")));
            this.barBtnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnHieuChinh.ImageOptions.LargeImage")));
            this.barBtnHieuChinh.Name = "barBtnHieuChinh";
            this.barBtnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHieuChinh_ItemClick);
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 12;
            this.barBtnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.Image")));
            this.barBtnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.LargeImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 13;
            this.barBtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnXoa.ImageOptions.Image")));
            this.barBtnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnXoa.ImageOptions.LargeImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1124, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 790);
            this.barDockControlBottom.Manager = this.barManagerTong;
            this.barDockControlBottom.Size = new System.Drawing.Size(1124, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerTong;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 766);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1124, 24);
            this.barDockControlRight.Manager = this.barManagerTong;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 766);
            // 
            // xtraScrollableControlTong
            // 
            this.xtraScrollableControlTong.Controls.Add(this.xtraScrollableControl1);
            this.xtraScrollableControlTong.Controls.Add(this.xtraScrollableControlThuocTinhLop);
            this.xtraScrollableControlTong.Controls.Add(this.giangGridControl);
            this.xtraScrollableControlTong.Controls.Add(this.lopTinChiGridControl);
            this.xtraScrollableControlTong.Controls.Add(this.panelControlKhoa);
            this.xtraScrollableControlTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlTong.Location = new System.Drawing.Point(0, 24);
            this.xtraScrollableControlTong.Name = "xtraScrollableControlTong";
            this.xtraScrollableControlTong.Size = new System.Drawing.Size(1124, 766);
            this.xtraScrollableControlTong.TabIndex = 4;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.lblMaGiangVien);
            this.xtraScrollableControl1.Controls.Add(this.cboMaGiangVien);
            this.xtraScrollableControl1.Controls.Add(tIET_BDAULabel);
            this.xtraScrollableControl1.Controls.Add(this.tietBatDauSpinEdit);
            this.xtraScrollableControl1.Controls.Add(tHULabel);
            this.xtraScrollableControl1.Controls.Add(this.thuSpinEdit);
            this.xtraScrollableControl1.Controls.Add(mA_GVLabel);
            this.xtraScrollableControl1.Controls.Add(mA_LOP_TCLabel2);
            this.xtraScrollableControl1.Controls.Add(this.lblMaLopTinChi2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(600, 451);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(524, 315);
            this.xtraScrollableControl1.TabIndex = 5;
            // 
            // lblMaGiangVien
            // 
            this.lblMaGiangVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangBDS, "MA_GV", true));
            this.lblMaGiangVien.Location = new System.Drawing.Point(130, 57);
            this.lblMaGiangVien.Name = "lblMaGiangVien";
            this.lblMaGiangVien.Size = new System.Drawing.Size(100, 23);
            this.lblMaGiangVien.TabIndex = 9;
            this.lblMaGiangVien.Text = "Mã giảng viên";
            // 
            // giangBDS
            // 
            this.giangBDS.DataMember = "FK_GIANG_LOP_TIN_CHI";
            this.giangBDS.DataSource = this.lopTinChiBDS;
            // 
            // lopTinChiBDS
            // 
            this.lopTinChiBDS.DataMember = "LOP_TIN_CHI";
            this.lopTinChiBDS.DataSource = this.DSMLC;
            // 
            // DSMLC
            // 
            this.DSMLC.DataSetName = "DSMLC";
            this.DSMLC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboMaGiangVien
            // 
            this.cboMaGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaGiangVien.FormattingEnabled = true;
            this.cboMaGiangVien.Location = new System.Drawing.Point(255, 54);
            this.cboMaGiangVien.Name = "cboMaGiangVien";
            this.cboMaGiangVien.Size = new System.Drawing.Size(200, 23);
            this.cboMaGiangVien.TabIndex = 8;
            this.cboMaGiangVien.SelectedIndexChanged += new System.EventHandler(this.cboMaGiangVien_SelectedIndexChanged);
            // 
            // tietBatDauSpinEdit
            // 
            this.tietBatDauSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangBDS, "TIET_BDAU", true));
            this.tietBatDauSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tietBatDauSpinEdit.Location = new System.Drawing.Point(130, 130);
            this.tietBatDauSpinEdit.MenuManager = this.barManagerTong;
            this.tietBatDauSpinEdit.Name = "tietBatDauSpinEdit";
            this.tietBatDauSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tietBatDauSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tietBatDauSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tietBatDauSpinEdit.Properties.Mask.EditMask = "d";
            this.tietBatDauSpinEdit.Properties.MaxValue = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tietBatDauSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tietBatDauSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.tietBatDauSpinEdit.TabIndex = 7;
            // 
            // thuSpinEdit
            // 
            this.thuSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangBDS, "THU", true));
            this.thuSpinEdit.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.thuSpinEdit.Location = new System.Drawing.Point(130, 95);
            this.thuSpinEdit.MenuManager = this.barManagerTong;
            this.thuSpinEdit.Name = "thuSpinEdit";
            this.thuSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thuSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.thuSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.thuSpinEdit.Properties.Mask.EditMask = "d";
            this.thuSpinEdit.Properties.MaxValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.thuSpinEdit.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.thuSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.thuSpinEdit.TabIndex = 5;
            // 
            // lblMaLopTinChi2
            // 
            this.lblMaLopTinChi2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangBDS, "MA_LOP_TC", true));
            this.lblMaLopTinChi2.Location = new System.Drawing.Point(127, 15);
            this.lblMaLopTinChi2.Name = "lblMaLopTinChi2";
            this.lblMaLopTinChi2.Size = new System.Drawing.Size(100, 23);
            this.lblMaLopTinChi2.TabIndex = 1;
            this.lblMaLopTinChi2.Text = "Mã lớp tín chỉ";
            // 
            // xtraScrollableControlThuocTinhLop
            // 
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.cboNienKhoaHocKy);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.cboMaMonHoc);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.lblMaMonHoc);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(hE_SO_CCLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.heSoCcSpinEdit);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(hE_SO_GKLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.heSoGkSpinEdit);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(hE_SO_CKLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.heSoCkSpinEdit);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(sO_SV_TTHIEULabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.soSvToiThieuSpinEdit);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(hUYLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.huyCheckEdit);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(mA_NVLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.lblMaNhanVien);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(nHOMLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.lblNhom);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(mA_NK_HKLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.lblMaNienKhoaHocKy);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(mA_MHLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(mA_KHOALabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.lblMaKhoa);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(mA_LOP_TCLabel);
            this.xtraScrollableControlThuocTinhLop.Controls.Add(this.lblMaLopTinChi);
            this.xtraScrollableControlThuocTinhLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraScrollableControlThuocTinhLop.Location = new System.Drawing.Point(0, 451);
            this.xtraScrollableControlThuocTinhLop.Name = "xtraScrollableControlThuocTinhLop";
            this.xtraScrollableControlThuocTinhLop.Size = new System.Drawing.Size(600, 315);
            this.xtraScrollableControlThuocTinhLop.TabIndex = 4;
            // 
            // cboNienKhoaHocKy
            // 
            this.cboNienKhoaHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNienKhoaHocKy.FormattingEnabled = true;
            this.cboNienKhoaHocKy.Location = new System.Drawing.Point(313, 46);
            this.cboNienKhoaHocKy.Name = "cboNienKhoaHocKy";
            this.cboNienKhoaHocKy.Size = new System.Drawing.Size(255, 23);
            this.cboNienKhoaHocKy.TabIndex = 25;
            this.cboNienKhoaHocKy.SelectedIndexChanged += new System.EventHandler(this.cboNienKhoaHocKy_SelectedIndexChanged);
            // 
            // cboMaMonHoc
            // 
            this.cboMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaMonHoc.FormattingEnabled = true;
            this.cboMaMonHoc.Location = new System.Drawing.Point(313, 89);
            this.cboMaMonHoc.Name = "cboMaMonHoc";
            this.cboMaMonHoc.Size = new System.Drawing.Size(255, 23);
            this.cboMaMonHoc.TabIndex = 24;
            this.cboMaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMaMonHoc_SelectedIndexChanged);
            // 
            // lblMaMonHoc
            // 
            this.lblMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopTinChiBDS, "MA_MH", true));
            this.lblMaMonHoc.Location = new System.Drawing.Point(192, 92);
            this.lblMaMonHoc.Name = "lblMaMonHoc";
            this.lblMaMonHoc.Size = new System.Drawing.Size(100, 23);
            this.lblMaMonHoc.TabIndex = 23;
            this.lblMaMonHoc.Text = "Mã môn học";
            // 
            // heSoCcSpinEdit
            // 
            this.heSoCcSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopTinChiBDS, "HE_SO_CC", true));
            this.heSoCcSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.heSoCcSpinEdit.Location = new System.Drawing.Point(192, 158);
            this.heSoCcSpinEdit.MenuManager = this.barManagerTong;
            this.heSoCcSpinEdit.Name = "heSoCcSpinEdit";
            this.heSoCcSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.heSoCcSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.heSoCcSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.heSoCcSpinEdit.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heSoCcSpinEdit.Properties.Mask.EditMask = "d";
            this.heSoCcSpinEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.heSoCcSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.heSoCcSpinEdit.TabIndex = 21;
            // 
            // heSoGkSpinEdit
            // 
            this.heSoGkSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopTinChiBDS, "HE_SO_GK", true));
            this.heSoGkSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.heSoGkSpinEdit.Location = new System.Drawing.Point(192, 190);
            this.heSoGkSpinEdit.MenuManager = this.barManagerTong;
            this.heSoGkSpinEdit.Name = "heSoGkSpinEdit";
            this.heSoGkSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.heSoGkSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.heSoGkSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.heSoGkSpinEdit.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heSoGkSpinEdit.Properties.Mask.EditMask = "d";
            this.heSoGkSpinEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.heSoGkSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.heSoGkSpinEdit.TabIndex = 19;
            // 
            // heSoCkSpinEdit
            // 
            this.heSoCkSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopTinChiBDS, "HE_SO_CK", true));
            this.heSoCkSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.heSoCkSpinEdit.Location = new System.Drawing.Point(192, 227);
            this.heSoCkSpinEdit.MenuManager = this.barManagerTong;
            this.heSoCkSpinEdit.Name = "heSoCkSpinEdit";
            this.heSoCkSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.heSoCkSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.heSoCkSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.heSoCkSpinEdit.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heSoCkSpinEdit.Properties.Mask.EditMask = "d";
            this.heSoCkSpinEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.heSoCkSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.heSoCkSpinEdit.TabIndex = 17;
            // 
            // soSvToiThieuSpinEdit
            // 
            this.soSvToiThieuSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopTinChiBDS, "SO_SV_TTHIEU", true));
            this.soSvToiThieuSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soSvToiThieuSpinEdit.Location = new System.Drawing.Point(438, 121);
            this.soSvToiThieuSpinEdit.MenuManager = this.barManagerTong;
            this.soSvToiThieuSpinEdit.Name = "soSvToiThieuSpinEdit";
            this.soSvToiThieuSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soSvToiThieuSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soSvToiThieuSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soSvToiThieuSpinEdit.Properties.Mask.EditMask = "d";
            this.soSvToiThieuSpinEdit.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.soSvToiThieuSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.soSvToiThieuSpinEdit.TabIndex = 15;
            // 
            // huyCheckEdit
            // 
            this.huyCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopTinChiBDS, "HUY", true));
            this.huyCheckEdit.Location = new System.Drawing.Point(438, 187);
            this.huyCheckEdit.MenuManager = this.barManagerTong;
            this.huyCheckEdit.Name = "huyCheckEdit";
            this.huyCheckEdit.Properties.Caption = "";
            this.huyCheckEdit.Size = new System.Drawing.Size(75, 20);
            this.huyCheckEdit.TabIndex = 13;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopTinChiBDS, "MA_NV", true));
            this.lblMaNhanVien.Location = new System.Drawing.Point(435, 160);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(100, 23);
            this.lblMaNhanVien.TabIndex = 11;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // lblNhom
            // 
            this.lblNhom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopTinChiBDS, "NHOM", true));
            this.lblNhom.Location = new System.Drawing.Point(192, 126);
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.Size = new System.Drawing.Size(100, 23);
            this.lblNhom.TabIndex = 9;
            this.lblNhom.Text = "Nhóm";
            // 
            // lblMaNienKhoaHocKy
            // 
            this.lblMaNienKhoaHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopTinChiBDS, "MA_NK_HK", true));
            this.lblMaNienKhoaHocKy.Location = new System.Drawing.Point(192, 49);
            this.lblMaNienKhoaHocKy.Name = "lblMaNienKhoaHocKy";
            this.lblMaNienKhoaHocKy.Size = new System.Drawing.Size(90, 23);
            this.lblMaNienKhoaHocKy.TabIndex = 7;
            this.lblMaNienKhoaHocKy.Text = "Mã niên khóa học kỳ";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopTinChiBDS, "MA_KHOA", true));
            this.lblMaKhoa.Location = new System.Drawing.Point(435, 15);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(100, 23);
            this.lblMaKhoa.TabIndex = 3;
            this.lblMaKhoa.Text = "Mã khoa";
            // 
            // lblMaLopTinChi
            // 
            this.lblMaLopTinChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopTinChiBDS, "MA_LOP_TC", true));
            this.lblMaLopTinChi.Location = new System.Drawing.Point(192, 15);
            this.lblMaLopTinChi.Name = "lblMaLopTinChi";
            this.lblMaLopTinChi.Size = new System.Drawing.Size(100, 23);
            this.lblMaLopTinChi.TabIndex = 1;
            this.lblMaLopTinChi.Text = "Mã lớp tín chỉ";
            // 
            // giangGridControl
            // 
            this.giangGridControl.DataSource = this.giangBDS;
            this.giangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.giangGridControl.Location = new System.Drawing.Point(0, 274);
            this.giangGridControl.MainView = this.gridViewGiang;
            this.giangGridControl.MenuManager = this.barManagerTong;
            this.giangGridControl.Name = "giangGridControl";
            this.giangGridControl.Size = new System.Drawing.Size(1124, 177);
            this.giangGridControl.TabIndex = 3;
            this.giangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiang});
            this.giangGridControl.Click += new System.EventHandler(this.giangGridControl_Click);
            this.giangGridControl.DoubleClick += new System.EventHandler(this.giangGridControl_DoubleClick);
            // 
            // gridViewGiang
            // 
            this.gridViewGiang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_LOP_TC1,
            this.colMA_GV,
            this.colTHU,
            this.colTIET_BDAU});
            this.gridViewGiang.GridControl = this.giangGridControl;
            this.gridViewGiang.Name = "gridViewGiang";
            this.gridViewGiang.OptionsBehavior.Editable = false;
            this.gridViewGiang.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMA_LOP_TC1
            // 
            this.colMA_LOP_TC1.Caption = "Mã lớp tín chỉ";
            this.colMA_LOP_TC1.FieldName = "MA_LOP_TC";
            this.colMA_LOP_TC1.Name = "colMA_LOP_TC1";
            this.colMA_LOP_TC1.Visible = true;
            this.colMA_LOP_TC1.VisibleIndex = 0;
            // 
            // colMA_GV
            // 
            this.colMA_GV.Caption = "Mã giảng viên";
            this.colMA_GV.FieldName = "MA_GV";
            this.colMA_GV.Name = "colMA_GV";
            this.colMA_GV.Visible = true;
            this.colMA_GV.VisibleIndex = 1;
            // 
            // colTHU
            // 
            this.colTHU.Caption = "Thứ";
            this.colTHU.FieldName = "THU";
            this.colTHU.Name = "colTHU";
            this.colTHU.Visible = true;
            this.colTHU.VisibleIndex = 2;
            // 
            // colTIET_BDAU
            // 
            this.colTIET_BDAU.Caption = "Tiết bắt đầu";
            this.colTIET_BDAU.FieldName = "TIET_BDAU";
            this.colTIET_BDAU.Name = "colTIET_BDAU";
            this.colTIET_BDAU.Visible = true;
            this.colTIET_BDAU.VisibleIndex = 3;
            // 
            // lopTinChiGridControl
            // 
            this.lopTinChiGridControl.DataSource = this.lopTinChiBDS;
            this.lopTinChiGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lopTinChiGridControl.Location = new System.Drawing.Point(0, 54);
            this.lopTinChiGridControl.MainView = this.gridViewLopTinChi;
            this.lopTinChiGridControl.MenuManager = this.barManagerTong;
            this.lopTinChiGridControl.Name = "lopTinChiGridControl";
            this.lopTinChiGridControl.Size = new System.Drawing.Size(1124, 220);
            this.lopTinChiGridControl.TabIndex = 3;
            this.lopTinChiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLopTinChi});
            this.lopTinChiGridControl.Click += new System.EventHandler(this.lopTinChiGridControl_Click);
            this.lopTinChiGridControl.DoubleClick += new System.EventHandler(this.lopTinChiGridControl_DoubleClick);
            // 
            // gridViewLopTinChi
            // 
            this.gridViewLopTinChi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_LOP_TC,
            this.colMA_KHOA,
            this.colMA_MH,
            this.colMA_NK_HK,
            this.colNHOM,
            this.colHE_SO_CC,
            this.colHE_SO_GK,
            this.colHE_SO_CK,
            this.colSO_SV_TTHIEU,
            this.colHUY,
            this.colMA_NV});
            this.gridViewLopTinChi.GridControl = this.lopTinChiGridControl;
            this.gridViewLopTinChi.Name = "gridViewLopTinChi";
            this.gridViewLopTinChi.OptionsBehavior.Editable = false;
            this.gridViewLopTinChi.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewLopTinChi.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMA_LOP_TC
            // 
            this.colMA_LOP_TC.Caption = "Mã lớp tín chỉ";
            this.colMA_LOP_TC.FieldName = "MA_LOP_TC";
            this.colMA_LOP_TC.Name = "colMA_LOP_TC";
            this.colMA_LOP_TC.Visible = true;
            this.colMA_LOP_TC.VisibleIndex = 0;
            // 
            // colMA_KHOA
            // 
            this.colMA_KHOA.Caption = "Mã khoa";
            this.colMA_KHOA.FieldName = "MA_KHOA";
            this.colMA_KHOA.Name = "colMA_KHOA";
            this.colMA_KHOA.Visible = true;
            this.colMA_KHOA.VisibleIndex = 1;
            // 
            // colMA_MH
            // 
            this.colMA_MH.Caption = "Mã môn học";
            this.colMA_MH.FieldName = "MA_MH";
            this.colMA_MH.Name = "colMA_MH";
            this.colMA_MH.Visible = true;
            this.colMA_MH.VisibleIndex = 2;
            // 
            // colMA_NK_HK
            // 
            this.colMA_NK_HK.Caption = "Mã niên khóa học kì";
            this.colMA_NK_HK.FieldName = "MA_NK_HK";
            this.colMA_NK_HK.Name = "colMA_NK_HK";
            this.colMA_NK_HK.Visible = true;
            this.colMA_NK_HK.VisibleIndex = 3;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            // 
            // colHE_SO_CC
            // 
            this.colHE_SO_CC.Caption = "Hệ số chuyên cần";
            this.colHE_SO_CC.FieldName = "HE_SO_CC";
            this.colHE_SO_CC.Name = "colHE_SO_CC";
            this.colHE_SO_CC.Visible = true;
            this.colHE_SO_CC.VisibleIndex = 5;
            // 
            // colHE_SO_GK
            // 
            this.colHE_SO_GK.Caption = "Hệ số giữa kỳ";
            this.colHE_SO_GK.FieldName = "HE_SO_GK";
            this.colHE_SO_GK.Name = "colHE_SO_GK";
            this.colHE_SO_GK.Visible = true;
            this.colHE_SO_GK.VisibleIndex = 6;
            // 
            // colHE_SO_CK
            // 
            this.colHE_SO_CK.Caption = "Hệ số cuối kì";
            this.colHE_SO_CK.FieldName = "HE_SO_CK";
            this.colHE_SO_CK.Name = "colHE_SO_CK";
            this.colHE_SO_CK.Visible = true;
            this.colHE_SO_CK.VisibleIndex = 7;
            // 
            // colSO_SV_TTHIEU
            // 
            this.colSO_SV_TTHIEU.Caption = "Số sinh viên tối thiểu";
            this.colSO_SV_TTHIEU.FieldName = "SO_SV_TTHIEU";
            this.colSO_SV_TTHIEU.Name = "colSO_SV_TTHIEU";
            this.colSO_SV_TTHIEU.Visible = true;
            this.colSO_SV_TTHIEU.VisibleIndex = 8;
            // 
            // colHUY
            // 
            this.colHUY.Caption = "Hủy";
            this.colHUY.FieldName = "HUY";
            this.colHUY.Name = "colHUY";
            this.colHUY.Visible = true;
            this.colHUY.VisibleIndex = 9;
            // 
            // colMA_NV
            // 
            this.colMA_NV.Caption = "Mã nhân viên";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 10;
            // 
            // panelControlKhoa
            // 
            this.panelControlKhoa.Controls.Add(this.cboKhoa);
            this.panelControlKhoa.Controls.Add(this.lblKhoa);
            this.panelControlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlKhoa.Location = new System.Drawing.Point(0, 0);
            this.panelControlKhoa.Name = "panelControlKhoa";
            this.panelControlKhoa.Size = new System.Drawing.Size(1124, 54);
            this.panelControlKhoa.TabIndex = 3;
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
            // lopTinChiTableAdapter
            // 
            this.lopTinChiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANG_KITableAdapter = this.dangKyTableAdapter;
            this.tableAdapterManager.GIANGTableAdapter = this.giangTableAdapter;
            this.tableAdapterManager.LOP_TIN_CHITableAdapter = this.lopTinChiTableAdapter;
            this.tableAdapterManager.UpdateOrder = quan_li_diem_sinh_vien.DSMLCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dangKyTableAdapter
            // 
            this.dangKyTableAdapter.ClearBeforeFill = true;
            // 
            // giangTableAdapter
            // 
            this.giangTableAdapter.ClearBeforeFill = true;
            // 
            // dangKyBDS
            // 
            this.dangKyBDS.DataMember = "FK_DANG_KI_LOP_TIN_CHI";
            this.dangKyBDS.DataSource = this.lopTinChiBDS;
            // 
            // FrmMoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 790);
            this.Controls.Add(this.xtraScrollableControlTong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMoLop";
            this.Text = "FrmMoLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).EndInit();
            this.xtraScrollableControlTong.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tietBatDauSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuSpinEdit.Properties)).EndInit();
            this.xtraScrollableControlThuocTinhLop.ResumeLayout(false);
            this.xtraScrollableControlThuocTinhLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heSoCcSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoGkSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoCkSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soSvToiThieuSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huyCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).EndInit();
            this.panelControlKhoa.ResumeLayout(false);
            this.panelControlKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerTong;
        private DevExpress.XtraBars.Bar barTong;
        private DevExpress.XtraBars.BarButtonItem barBtnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem barBtnTaiLai;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlTong;
        private DevExpress.XtraEditors.PanelControl panelControlKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.BindingSource lopTinChiBDS;
        private DSMLC DSMLC;
        private DSMLCTableAdapters.LOP_TIN_CHITableAdapter lopTinChiTableAdapter;
        private DSMLCTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lopTinChiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLopTinChi;
        private DSMLCTableAdapters.GIANGTableAdapter giangTableAdapter;
        private System.Windows.Forms.BindingSource giangBDS;
        private DevExpress.XtraGrid.GridControl giangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiang;
        private DSMLCTableAdapters.DANG_KITableAdapter dangKyTableAdapter;
        private System.Windows.Forms.BindingSource dangKyBDS;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlThuocTinhLop;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_LOP_TC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_GV;
        private DevExpress.XtraGrid.Columns.GridColumn colTHU;
        private DevExpress.XtraGrid.Columns.GridColumn colTIET_BDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_LOP_TC;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_KHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_MH;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NK_HK;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHE_SO_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colHE_SO_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colHE_SO_CK;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_SV_TTHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUY;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraBars.BarButtonItem barBtnThemLop;
        private DevExpress.XtraBars.BarButtonItem barBtnThemGiang;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraEditors.SpinEdit heSoCcSpinEdit;
        private DevExpress.XtraEditors.SpinEdit heSoGkSpinEdit;
        private DevExpress.XtraEditors.SpinEdit heSoCkSpinEdit;
        private DevExpress.XtraEditors.SpinEdit soSvToiThieuSpinEdit;
        private DevExpress.XtraEditors.CheckEdit huyCheckEdit;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.Label lblMaNienKhoaHocKy;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblMaLopTinChi;
        private DevExpress.XtraEditors.SpinEdit tietBatDauSpinEdit;
        private DevExpress.XtraEditors.SpinEdit thuSpinEdit;
        private System.Windows.Forms.Label lblMaLopTinChi2;
        private System.Windows.Forms.ComboBox cboMaMonHoc;
        private System.Windows.Forms.Label lblMaMonHoc;
        private System.Windows.Forms.ComboBox cboMaGiangVien;
        private System.Windows.Forms.Label lblMaGiangVien;
        private System.Windows.Forms.ComboBox cboNienKhoaHocKy;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
    }
}