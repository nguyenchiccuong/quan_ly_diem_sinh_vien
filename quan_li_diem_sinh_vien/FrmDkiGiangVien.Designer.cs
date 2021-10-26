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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDkiGiangVien));
            System.Windows.Forms.Label mA_GVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mA_KHOALabel;
            this.xtraScrollableControlTong = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.barManagerTong = new DevExpress.XtraBars.BarManager(this.components);
            this.barTong = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DSGVDKC = new quan_li_diem_sinh_vien.DSGVDKC();
            this.giangVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.giangVienTableAdapter = new quan_li_diem_sinh_vien.DSGVDKCTableAdapters.GIANG_VIENTableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSGVDKCTableAdapters.TableAdapterManager();
            this.giangVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_GV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOC_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOC_HAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUYEN_MON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControlThuocTinh = new DevExpress.XtraEditors.XtraScrollableControl();
            this.mA_GVLabel1 = new System.Windows.Forms.Label();
            this.hOLabel1 = new System.Windows.Forms.Label();
            this.tENLabel1 = new System.Windows.Forms.Label();
            this.mA_KHOALabel1 = new System.Windows.Forms.Label();
            mA_GVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mA_KHOALabel = new System.Windows.Forms.Label();
            this.xtraScrollableControlTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).BeginInit();
            this.panelControlKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVDKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            this.xtraScrollableControlThuocTinh.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // barBtnHieuChinh
            // 
            this.barBtnHieuChinh.Caption = "Hiệu chỉnh";
            this.barBtnHieuChinh.Id = 3;
            this.barBtnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnHieuChinh.ImageOptions.Image")));
            this.barBtnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnHieuChinh.ImageOptions.LargeImage")));
            this.barBtnHieuChinh.Name = "barBtnHieuChinh";
            this.barBtnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.Image")));
            this.barBtnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.LargeImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 5;
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
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 8;
            this.barBtnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.Image")));
            this.barBtnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.LargeImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // DSGVDKC
            // 
            this.DSGVDKC.DataSetName = "DSGVDKC";
            this.DSGVDKC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giangVienBDS
            // 
            this.giangVienBDS.DataMember = "GIANG_VIEN";
            this.giangVienBDS.DataSource = this.DSGVDKC;
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
            // xtraScrollableControlThuocTinh
            // 
            this.xtraScrollableControlThuocTinh.Controls.Add(mA_KHOALabel);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.mA_KHOALabel1);
            this.xtraScrollableControlThuocTinh.Controls.Add(tENLabel);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.tENLabel1);
            this.xtraScrollableControlThuocTinh.Controls.Add(hOLabel);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.hOLabel1);
            this.xtraScrollableControlThuocTinh.Controls.Add(mA_GVLabel);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.mA_GVLabel1);
            this.xtraScrollableControlThuocTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlThuocTinh.Location = new System.Drawing.Point(0, 274);
            this.xtraScrollableControlThuocTinh.Name = "xtraScrollableControlThuocTinh";
            this.xtraScrollableControlThuocTinh.Size = new System.Drawing.Size(933, 221);
            this.xtraScrollableControlThuocTinh.TabIndex = 3;
            // 
            // mA_GVLabel
            // 
            mA_GVLabel.AutoSize = true;
            mA_GVLabel.Location = new System.Drawing.Point(35, 23);
            mA_GVLabel.Name = "mA_GVLabel";
            mA_GVLabel.Size = new System.Drawing.Size(49, 15);
            mA_GVLabel.TabIndex = 0;
            mA_GVLabel.Text = "MA GV:";
            // 
            // mA_GVLabel1
            // 
            this.mA_GVLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "MA_GV", true));
            this.mA_GVLabel1.Location = new System.Drawing.Point(90, 23);
            this.mA_GVLabel1.Name = "mA_GVLabel1";
            this.mA_GVLabel1.Size = new System.Drawing.Size(100, 23);
            this.mA_GVLabel1.TabIndex = 1;
            this.mA_GVLabel1.Text = "label1";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(56, 61);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(28, 15);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // hOLabel1
            // 
            this.hOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "HO", true));
            this.hOLabel1.Location = new System.Drawing.Point(90, 61);
            this.hOLabel1.Name = "hOLabel1";
            this.hOLabel1.Size = new System.Drawing.Size(100, 23);
            this.hOLabel1.TabIndex = 3;
            this.hOLabel1.Text = "label1";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(185, 61);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(34, 15);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // tENLabel1
            // 
            this.tENLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "TEN", true));
            this.tENLabel1.Location = new System.Drawing.Point(225, 61);
            this.tENLabel1.Name = "tENLabel1";
            this.tENLabel1.Size = new System.Drawing.Size(100, 23);
            this.tENLabel1.TabIndex = 5;
            this.tENLabel1.Text = "label1";
            // 
            // mA_KHOALabel
            // 
            mA_KHOALabel.AutoSize = true;
            mA_KHOALabel.Location = new System.Drawing.Point(192, 23);
            mA_KHOALabel.Name = "mA_KHOALabel";
            mA_KHOALabel.Size = new System.Drawing.Size(71, 15);
            mA_KHOALabel.TabIndex = 6;
            mA_KHOALabel.Text = "MA KHOA:";
            // 
            // mA_KHOALabel1
            // 
            this.mA_KHOALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBDS, "MA_KHOA", true));
            this.mA_KHOALabel1.Location = new System.Drawing.Point(269, 23);
            this.mA_KHOALabel1.Name = "mA_KHOALabel1";
            this.mA_KHOALabel1.Size = new System.Drawing.Size(100, 23);
            this.mA_KHOALabel1.TabIndex = 7;
            this.mA_KHOALabel1.Text = "label1";
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).EndInit();
            this.panelControlKhoa.ResumeLayout(false);
            this.panelControlKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVDKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            this.xtraScrollableControlThuocTinh.ResumeLayout(false);
            this.xtraScrollableControlThuocTinh.PerformLayout();
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
        private System.Windows.Forms.Label mA_KHOALabel1;
        private System.Windows.Forms.Label tENLabel1;
        private System.Windows.Forms.Label hOLabel1;
        private System.Windows.Forms.Label mA_GVLabel1;
    }
}