namespace quan_li_diem_sinh_vien
{
    partial class FrmMonHoc
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
            System.Windows.Forms.Label lblMaMonHoc;
            System.Windows.Forms.Label lblTenMonHoc;
            System.Windows.Forms.Label lblSoTietLt;
            System.Windows.Forms.Label lblSoTietThucHanh;
            this.xtraScrollableControlTong = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControlThuocTinh = new DevExpress.XtraEditors.XtraScrollableControl();
            this.soTietThucHanhSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.monHocBDS = new System.Windows.Forms.BindingSource(this.components);
            this.DSMHC = new quan_li_diem_sinh_vien.DSMHC();
            this.soTietLTSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tenMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.monHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_MH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_MH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.lblKhoa = new System.Windows.Forms.Label();
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
            this.monHocTableAdapter = new quan_li_diem_sinh_vien.DSMHCTableAdapters.MON_HOCTableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSMHCTableAdapters.TableAdapterManager();
            this.keHoachGiangTableAdapter = new quan_li_diem_sinh_vien.DSMHCTableAdapters.KE_HOACH_GIANGTableAdapter();
            this.khaNangGiangTableAdapter = new quan_li_diem_sinh_vien.DSMHCTableAdapters.KHA_NANG_GIANGTableAdapter();
            this.LopTinChiTableAdapter = new quan_li_diem_sinh_vien.DSMHCTableAdapters.LOP_TIN_CHITableAdapter();
            this.lopTinChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khaNangGiangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keHoachGiangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            lblMaMonHoc = new System.Windows.Forms.Label();
            lblTenMonHoc = new System.Windows.Forms.Label();
            lblSoTietLt = new System.Windows.Forms.Label();
            lblSoTietThucHanh = new System.Windows.Forms.Label();
            this.xtraScrollableControlTong.SuspendLayout();
            this.xtraScrollableControlThuocTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soTietThucHanhSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTietLTSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).BeginInit();
            this.panelControlKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaNangGiangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keHoachGiangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaMonHoc
            // 
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.Location = new System.Drawing.Point(62, 28);
            lblMaMonHoc.Name = "lblMaMonHoc";
            lblMaMonHoc.Size = new System.Drawing.Size(77, 15);
            lblMaMonHoc.TabIndex = 0;
            lblMaMonHoc.Text = "Mã môn hoc:";
            // 
            // lblTenMonHoc
            // 
            lblTenMonHoc.AutoSize = true;
            lblTenMonHoc.Location = new System.Drawing.Point(59, 71);
            lblTenMonHoc.Name = "lblTenMonHoc";
            lblTenMonHoc.Size = new System.Drawing.Size(80, 15);
            lblTenMonHoc.TabIndex = 2;
            lblTenMonHoc.Text = "Tên môn học:";
            // 
            // lblSoTietLt
            // 
            lblSoTietLt.AutoSize = true;
            lblSoTietLt.Location = new System.Drawing.Point(38, 113);
            lblSoTietLt.Name = "lblSoTietLt";
            lblSoTietLt.Size = new System.Drawing.Size(101, 15);
            lblSoTietLt.TabIndex = 4;
            lblSoTietLt.Text = "Số tiết thực hành:";
            // 
            // lblSoTietThucHanh
            // 
            lblSoTietThucHanh.AutoSize = true;
            lblSoTietThucHanh.Location = new System.Drawing.Point(44, 157);
            lblSoTietThucHanh.Name = "lblSoTietThucHanh";
            lblSoTietThucHanh.Size = new System.Drawing.Size(95, 15);
            lblSoTietThucHanh.TabIndex = 6;
            lblSoTietThucHanh.Text = "Số tiết lý thuyết:";
            // 
            // xtraScrollableControlTong
            // 
            this.xtraScrollableControlTong.Controls.Add(this.xtraScrollableControlThuocTinh);
            this.xtraScrollableControlTong.Controls.Add(this.monHocGridControl);
            this.xtraScrollableControlTong.Controls.Add(this.panelControlKhoa);
            this.xtraScrollableControlTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlTong.Location = new System.Drawing.Point(0, 20);
            this.xtraScrollableControlTong.Name = "xtraScrollableControlTong";
            this.xtraScrollableControlTong.Size = new System.Drawing.Size(1038, 476);
            this.xtraScrollableControlTong.TabIndex = 0;
            // 
            // xtraScrollableControlThuocTinh
            // 
            this.xtraScrollableControlThuocTinh.Controls.Add(lblSoTietThucHanh);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.soTietThucHanhSpinEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblSoTietLt);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.soTietLTSpinEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblTenMonHoc);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.tenMHTextEdit);
            this.xtraScrollableControlThuocTinh.Controls.Add(lblMaMonHoc);
            this.xtraScrollableControlThuocTinh.Controls.Add(this.maMHTextEdit);
            this.xtraScrollableControlThuocTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlThuocTinh.Location = new System.Drawing.Point(0, 274);
            this.xtraScrollableControlThuocTinh.Name = "xtraScrollableControlThuocTinh";
            this.xtraScrollableControlThuocTinh.Size = new System.Drawing.Size(1038, 202);
            this.xtraScrollableControlThuocTinh.TabIndex = 2;
            // 
            // soTietThucHanhSpinEdit
            // 
            this.soTietThucHanhSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBDS, "SO_TIET_TH", true));
            this.soTietThucHanhSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soTietThucHanhSpinEdit.Location = new System.Drawing.Point(181, 155);
            this.soTietThucHanhSpinEdit.Name = "soTietThucHanhSpinEdit";
            this.soTietThucHanhSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soTietThucHanhSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soTietThucHanhSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soTietThucHanhSpinEdit.Properties.IsFloatValue = false;
            this.soTietThucHanhSpinEdit.Properties.Mask.EditMask = "N00";
            this.soTietThucHanhSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.soTietThucHanhSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.soTietThucHanhSpinEdit.TabIndex = 7;
            // 
            // monHocBDS
            // 
            this.monHocBDS.DataMember = "MON_HOC";
            this.monHocBDS.DataSource = this.DSMHC;
            // 
            // DSMHC
            // 
            this.DSMHC.DataSetName = "DSMHC";
            this.DSMHC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soTietLTSpinEdit
            // 
            this.soTietLTSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBDS, "SO_TIET_LT", true));
            this.soTietLTSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soTietLTSpinEdit.Location = new System.Drawing.Point(181, 111);
            this.soTietLTSpinEdit.Name = "soTietLTSpinEdit";
            this.soTietLTSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soTietLTSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soTietLTSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soTietLTSpinEdit.Properties.IsFloatValue = false;
            this.soTietLTSpinEdit.Properties.Mask.EditMask = "N00";
            this.soTietLTSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.soTietLTSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.soTietLTSpinEdit.TabIndex = 5;
            // 
            // tenMHTextEdit
            // 
            this.tenMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBDS, "TEN_MH", true));
            this.tenMHTextEdit.Location = new System.Drawing.Point(181, 69);
            this.tenMHTextEdit.Name = "tenMHTextEdit";
            this.tenMHTextEdit.Size = new System.Drawing.Size(308, 20);
            this.tenMHTextEdit.TabIndex = 3;
            // 
            // maMHTextEdit
            // 
            this.maMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBDS, "MA_MH", true));
            this.maMHTextEdit.Location = new System.Drawing.Point(181, 26);
            this.maMHTextEdit.Name = "maMHTextEdit";
            this.maMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maMHTextEdit.TabIndex = 1;
            // 
            // monHocGridControl
            // 
            this.monHocGridControl.DataSource = this.monHocBDS;
            this.monHocGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.monHocGridControl.Location = new System.Drawing.Point(0, 54);
            this.monHocGridControl.MainView = this.gridViewMonHoc;
            this.monHocGridControl.Name = "monHocGridControl";
            this.monHocGridControl.Size = new System.Drawing.Size(1038, 220);
            this.monHocGridControl.TabIndex = 1;
            this.monHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMonHoc});
            // 
            // gridViewMonHoc
            // 
            this.gridViewMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_MH,
            this.colTEN_MH,
            this.colSO_TIET_LT,
            this.colSO_TIET_TH});
            this.gridViewMonHoc.GridControl = this.monHocGridControl;
            this.gridViewMonHoc.Name = "gridViewMonHoc";
            this.gridViewMonHoc.OptionsBehavior.Editable = false;
            this.gridViewMonHoc.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewMonHoc.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMonHoc.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colMA_MH
            // 
            this.colMA_MH.Caption = "Mã môn học";
            this.colMA_MH.FieldName = "MA_MH";
            this.colMA_MH.Name = "colMA_MH";
            this.colMA_MH.Visible = true;
            this.colMA_MH.VisibleIndex = 0;
            // 
            // colTEN_MH
            // 
            this.colTEN_MH.Caption = "Tên môn học";
            this.colTEN_MH.FieldName = "TEN_MH";
            this.colTEN_MH.Name = "colTEN_MH";
            this.colTEN_MH.Visible = true;
            this.colTEN_MH.VisibleIndex = 1;
            // 
            // colSO_TIET_LT
            // 
            this.colSO_TIET_LT.Caption = "Số tiết lý thuyết";
            this.colSO_TIET_LT.FieldName = "SO_TIET_LT";
            this.colSO_TIET_LT.Name = "colSO_TIET_LT";
            this.colSO_TIET_LT.Visible = true;
            this.colSO_TIET_LT.VisibleIndex = 2;
            // 
            // colSO_TIET_TH
            // 
            this.colSO_TIET_TH.Caption = "Số tiết thực hành";
            this.colSO_TIET_TH.FieldName = "SO_TIET_TH";
            this.colSO_TIET_TH.Name = "colSO_TIET_TH";
            this.colSO_TIET_TH.Visible = true;
            this.colSO_TIET_TH.VisibleIndex = 3;
            // 
            // panelControlKhoa
            // 
            this.panelControlKhoa.Controls.Add(this.cboKhoa);
            this.panelControlKhoa.Controls.Add(this.lblKhoa);
            this.panelControlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlKhoa.Location = new System.Drawing.Point(0, 0);
            this.panelControlKhoa.Name = "panelControlKhoa";
            this.panelControlKhoa.Size = new System.Drawing.Size(1038, 54);
            this.panelControlKhoa.TabIndex = 0;
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
            this.barBtnThem.Name = "barBtnThem";
            // 
            // barBtnHieuChinh
            // 
            this.barBtnHieuChinh.Caption = "Hiệu chỉnh";
            this.barBtnHieuChinh.Id = 3;
            this.barBtnHieuChinh.Name = "barBtnHieuChinh";
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.Name = "barBtnGhi";
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 5;
            this.barBtnXoa.Name = "barBtnXoa";
            // 
            // barBtnPhucHoi
            // 
            this.barBtnPhucHoi.Caption = "Phục hồi";
            this.barBtnPhucHoi.Id = 6;
            this.barBtnPhucHoi.Name = "barBtnPhucHoi";
            // 
            // barBtnTaiLai
            // 
            this.barBtnTaiLai.Caption = "Tải lại";
            this.barBtnTaiLai.Id = 7;
            this.barBtnTaiLai.Name = "barBtnTaiLai";
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 8;
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerTong;
            this.barDockControlTop.Size = new System.Drawing.Size(1038, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 496);
            this.barDockControlBottom.Manager = this.barManagerTong;
            this.barDockControlBottom.Size = new System.Drawing.Size(1038, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManagerTong;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 476);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1038, 20);
            this.barDockControlRight.Manager = this.barManagerTong;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 476);
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KE_HOACH_GIANGTableAdapter = this.keHoachGiangTableAdapter;
            this.tableAdapterManager.KHA_NANG_GIANGTableAdapter = this.khaNangGiangTableAdapter;
            this.tableAdapterManager.LOP_TIN_CHITableAdapter = this.LopTinChiTableAdapter;
            this.tableAdapterManager.MON_HOCTableAdapter = this.monHocTableAdapter;
            this.tableAdapterManager.UpdateOrder = quan_li_diem_sinh_vien.DSMHCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // keHoachGiangTableAdapter
            // 
            this.keHoachGiangTableAdapter.ClearBeforeFill = true;
            // 
            // khaNangGiangTableAdapter
            // 
            this.khaNangGiangTableAdapter.ClearBeforeFill = true;
            // 
            // LopTinChiTableAdapter
            // 
            this.LopTinChiTableAdapter.ClearBeforeFill = true;
            // 
            // lopTinChiBindingSource
            // 
            this.lopTinChiBindingSource.DataMember = "FK_LOP_TIN_CHI_MON_HOC";
            this.lopTinChiBindingSource.DataSource = this.monHocBDS;
            // 
            // khaNangGiangBindingSource
            // 
            this.khaNangGiangBindingSource.DataMember = "FK_KHA_NANG_GIANG_MON_HOC";
            this.khaNangGiangBindingSource.DataSource = this.monHocBDS;
            // 
            // keHoachGiangBindingSource
            // 
            this.keHoachGiangBindingSource.DataMember = "FK_KE_HOACH_GIANG_MON_HOC";
            this.keHoachGiangBindingSource.DataSource = this.monHocBDS;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(114, 18);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(255, 21);
            this.cboKhoa.TabIndex = 2;
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 496);
            this.Controls.Add(this.xtraScrollableControlTong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMonHoc";
            this.Text = "FrmMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            this.xtraScrollableControlTong.ResumeLayout(false);
            this.xtraScrollableControlThuocTinh.ResumeLayout(false);
            this.xtraScrollableControlThuocTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soTietThucHanhSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTietLTSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).EndInit();
            this.panelControlKhoa.ResumeLayout(false);
            this.panelControlKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaNangGiangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keHoachGiangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlTong;
        private DevExpress.XtraEditors.PanelControl panelControlKhoa;
        private System.Windows.Forms.BindingSource monHocBDS;
        private DSMHC DSMHC;
        private DSMHCTableAdapters.MON_HOCTableAdapter monHocTableAdapter;
        private DSMHCTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl monHocGridControl;
        private DSMHCTableAdapters.LOP_TIN_CHITableAdapter LopTinChiTableAdapter;
        private System.Windows.Forms.BindingSource lopTinChiBindingSource;
        private DSMHCTableAdapters.KHA_NANG_GIANGTableAdapter khaNangGiangTableAdapter;
        private System.Windows.Forms.BindingSource khaNangGiangBindingSource;
        private DSMHCTableAdapters.KE_HOACH_GIANGTableAdapter keHoachGiangTableAdapter;
        private System.Windows.Forms.BindingSource keHoachGiangBindingSource;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlThuocTinh;
        private DevExpress.XtraEditors.SpinEdit soTietThucHanhSpinEdit;
        private DevExpress.XtraEditors.SpinEdit soTietLTSpinEdit;
        private DevExpress.XtraEditors.TextEdit tenMHTextEdit;
        private DevExpress.XtraEditors.TextEdit maMHTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_MH;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_MH;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIET_TH;
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
        private System.Windows.Forms.Label lblKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMonHoc;
        private System.Windows.Forms.ComboBox cboKhoa;
    }
}