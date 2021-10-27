namespace quan_li_diem_sinh_vien
{
    partial class FrmDkiGiangVien
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
            System.Windows.Forms.Label lblMaGiangVien;
            System.Windows.Forms.Label lblHo;
            System.Windows.Forms.Label lblTen;
            System.Windows.Forms.Label lblMaKhoa;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDkiGiangVien));
            this.xtraScrollableControlTong = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControlThuocTinh = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lapLaiMatKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barManagerTong = new DevExpress.XtraBars.BarManager(this.components);
            this.barTong = new DevExpress.XtraBars.Bar();
            this.barBtnTaoTk = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lblLapLaiMatKhau = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblMakhoa1 = new System.Windows.Forms.Label();
            this.giangVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.DSGVDKC = new quan_li_diem_sinh_vien.DSGVDKC();
            this.lblTen1 = new System.Windows.Forms.Label();
            this.lblHo1 = new System.Windows.Forms.Label();
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
            this.giangVienTableAdapter = new quan_li_diem_sinh_vien.DSGVDKCTableAdapters.GIANG_VIENTableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSGVDKCTableAdapters.TableAdapterManager();
            lblMaGiangVien = new System.Windows.Forms.Label();
            lblHo = new System.Windows.Forms.Label();
            lblTen = new System.Windows.Forms.Label();
            lblMaKhoa = new System.Windows.Forms.Label();
            this.xtraScrollableControlTong.SuspendLayout();
            this.xtraScrollableControlThuocTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapLaiMatKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVDKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).BeginInit();
            this.panelControlKhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaGiangVien
            // 
            lblMaGiangVien.AutoSize = true;
            lblMaGiangVien.Location = new System.Drawing.Point(12, 23);
            lblMaGiangVien.Name = "lblMaGiangVien";
            lblMaGiangVien.Size = new System.Drawing.Size(87, 15);
            lblMaGiangVien.TabIndex = 0;
            lblMaGiangVien.Text = "Mã giảng viên:";
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new System.Drawing.Point(73, 61);
            lblHo.Name = "lblHo";
            lblHo.Size = new System.Drawing.Size(26, 15);
            lblHo.TabIndex = 2;
            lblHo.Text = "Họ:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new System.Drawing.Point(277, 61);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(31, 15);
            lblTen.TabIndex = 4;
            lblTen.Text = "Tên:";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new System.Drawing.Point(251, 23);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new System.Drawing.Size(57, 15);
            lblMaKhoa.TabIndex = 6;
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
            this.xtraScrollableControlTong.Size = new System.Drawing.Size(933, 495);
            this.xtraScrollableControlTong.TabIndex = 0;
            // 
            // xtraScrollableControlThuocTinh
            // 
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lapLaiMatKhauTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.matKhauTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblLapLaiMatKhau);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblMatKhau);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblMaKhoa);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblMakhoa1);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblTen);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblTen1);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblHo);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblHo1);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblMaGiangVien);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.lblMaGiangVien1);
            this.xtraScrollableControlThuocTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlThuocTinh.Location = new System.Drawing.Point(0, 274);
            this.xtraScrollableControlThuocTinh.Name = "xtraScrollableControlThuocTinh";
            this.xtraScrollableControlThuocTinh.Size = new System.Drawing.Size(933, 221);
            this.xtraScrollableControlThuocTinh.TabIndex = 3;
            // 
            // lapLaiMatKhauTextEdit
            // 
            this.lapLaiMatKhauTextEdit.Location = new System.Drawing.Point(637, 59);
            this.lapLaiMatKhauTextEdit.MenuManager = this.barManagerTong;
            this.lapLaiMatKhauTextEdit.Name = "lapLaiMatKhauTextEdit";
            this.lapLaiMatKhauTextEdit.Properties.UseSystemPasswordChar = true;
            this.lapLaiMatKhauTextEdit.Size = new System.Drawing.Size(154, 20);
            this.lapLaiMatKhauTextEdit.TabIndex = 11;
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
            this.barBtnTaoTk,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnTaoTk),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnTaiLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThoat)});
            this.barTong.OptionsBar.MultiLine = true;
            this.barTong.OptionsBar.UseWholeRow = true;
            this.barTong.Text = "Main menu";
            // 
            // barBtnTaoTk
            // 
            this.barBtnTaoTk.Caption = "Tạo tài khoản";
            this.barBtnTaoTk.Id = 4;
            this.barBtnTaoTk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTk.ImageOptions.Image")));
            this.barBtnTaoTk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTk.ImageOptions.LargeImage")));
            this.barBtnTaoTk.Name = "barBtnTaoTk";
            this.barBtnTaoTk.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnTaoTk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaoTk_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(933, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 519);
            this.barDockControlBottom.Manager = this.barManagerTong;
            this.barDockControlBottom.Size = new System.Drawing.Size(933, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerTong;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 495);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(933, 24);
            this.barDockControlRight.Manager = this.barManagerTong;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 495);
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.Location = new System.Drawing.Point(637, 21);
            this.matKhauTextEdit.MenuManager = this.barManagerTong;
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Properties.UseSystemPasswordChar = true;
            this.matKhauTextEdit.Size = new System.Drawing.Size(154, 20);
            this.matKhauTextEdit.TabIndex = 10;
            // 
            // lblLapLaiMatKhau
            // 
            this.lblLapLaiMatKhau.AutoSize = true;
            this.lblLapLaiMatKhau.Location = new System.Drawing.Point(502, 61);
            this.lblLapLaiMatKhau.Name = "lblLapLaiMatKhau";
            this.lblLapLaiMatKhau.Size = new System.Drawing.Size(96, 15);
            this.lblLapLaiMatKhau.TabIndex = 9;
            this.lblLapLaiMatKhau.Text = "Lặp lại mật khẩu:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(537, 23);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(61, 15);
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblMakhoa1
            // 
            this.lblMakhoa1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "MA_KHOA", true));
            this.lblMakhoa1.Location = new System.Drawing.Point(336, 23);
            this.lblMakhoa1.Name = "lblMakhoa1";
            this.lblMakhoa1.Size = new System.Drawing.Size(100, 23);
            this.lblMakhoa1.TabIndex = 7;
            this.lblMakhoa1.Text = "lblMaKhoa";
            // 
            // giangVienBDS
            // 
            this.giangVienBDS.DataMember = "GIANG_VIEN";
            this.giangVienBDS.DataSource = this.DSGVDKC;
            // 
            // DSGVDKC
            // 
            this.DSGVDKC.DataSetName = "DSGVDKC";
            this.DSGVDKC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTen1
            // 
            this.lblTen1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "TEN", true));
            this.lblTen1.Location = new System.Drawing.Point(336, 61);
            this.lblTen1.Name = "lblTen1";
            this.lblTen1.Size = new System.Drawing.Size(100, 23);
            this.lblTen1.TabIndex = 5;
            this.lblTen1.Text = "lblTen";
            // 
            // lblHo1
            // 
            this.lblHo1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "HO", true));
            this.lblHo1.Location = new System.Drawing.Point(116, 61);
            this.lblHo1.Name = "lblHo1";
            this.lblHo1.Size = new System.Drawing.Size(100, 23);
            this.lblHo1.TabIndex = 3;
            this.lblHo1.Text = "lblHo";
            // 
            // lblMaGiangVien1
            // 
            this.lblMaGiangVien1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "MA_GV", true));
            this.lblMaGiangVien1.Location = new System.Drawing.Point(116, 23);
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
            this.giangVienGridControl.Size = new System.Drawing.Size(933, 220);
            this.giangVienGridControl.TabIndex = 2;
            this.giangVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            this.giangVienGridControl.DoubleClick += new System.EventHandler(this.giangVienGridControl_DoubleClick);
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
            this.panelControlKhoa.Size = new System.Drawing.Size(933, 54);
            this.panelControlKhoa.TabIndex = 2;
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
            this.tableAdapterManager.UpdateOrder = quan_li_diem_sinh_vien.DSGVDKCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmDkiGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.xtraScrollableControlTong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDkiGiangVien";
            this.Text = "FrmDkiGiangVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDkiGiangVien_Load);
            this.xtraScrollableControlTong.ResumeLayout(false);
            this.xtraScrollableControlThuocTinh.ResumeLayout(false);
            this.xtraScrollableControlThuocTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapLaiMatKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVDKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).EndInit();
            this.panelControlKhoa.ResumeLayout(false);
            this.panelControlKhoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlTong;
        private DevExpress.XtraBars.BarManager barManagerTong;
        private DevExpress.XtraBars.Bar barTong;
        private DevExpress.XtraBars.BarButtonItem barBtnTaoTk;
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
        private DSGVDKC DSGVDKC;
        private DSGVDKCTableAdapters.GIANG_VIENTableAdapter giangVienTableAdapter;
        private DSGVDKCTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl giangVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_GV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOC_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOC_HAM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUYEN_MON;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_KHOA;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlThuocTinh;
        private System.Windows.Forms.Label lblMakhoa1;
        private System.Windows.Forms.Label lblTen1;
        private System.Windows.Forms.Label lblHo1;
        private System.Windows.Forms.Label lblMaGiangVien1;
        private System.Windows.Forms.Label lblLapLaiMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private DevExpress.XtraEditors.TextEdit lapLaiMatKhauTextEdit;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
    }
}