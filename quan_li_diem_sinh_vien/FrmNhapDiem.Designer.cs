
namespace quan_li_diem_sinh_vien
{
    partial class FrmNhapDiem
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGhiDiem = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnLopTC = new System.Windows.Forms.Button();
            this.cboHK = new System.Windows.Forms.ComboBox();
            this.cboNK = new System.Windows.Forms.ComboBox();
            this.dS = new quan_li_diem_sinh_vien.DS();
            this.sP_DSLTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSLTCTableAdapter = new quan_li_diem_sinh_vien.DSTableAdapters.SP_DSLTCTableAdapter();
            this.tableAdapterManager = new quan_li_diem_sinh_vien.DSTableAdapters.TableAdapterManager();
            this.bdsDSLTC = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSLTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_LOP_TC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_MH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDSSV = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_MA_SV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_HOTEN_SV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DIEMHETMON = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGhiDiem);
            this.panelControl1.Controls.Add(this.btnNhapDiem);
            this.panelControl1.Controls.Add(this.btnLopTC);
            this.panelControl1.Controls.Add(this.cboHK);
            this.panelControl1.Controls.Add(this.cboNK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(935, 58);
            this.panelControl1.TabIndex = 0;
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Location = new System.Drawing.Point(660, 12);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(75, 23);
            this.btnGhiDiem.TabIndex = 1;
            this.btnGhiDiem.Text = "Ghi Điểm";
            this.btnGhiDiem.UseVisualStyleBackColor = true;
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(555, 10);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(75, 23);
            this.btnNhapDiem.TabIndex = 1;
            this.btnNhapDiem.Text = "Nhập Điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnLopTC
            // 
            this.btnLopTC.Location = new System.Drawing.Point(445, 12);
            this.btnLopTC.Name = "btnLopTC";
            this.btnLopTC.Size = new System.Drawing.Size(75, 23);
            this.btnLopTC.TabIndex = 1;
            this.btnLopTC.Text = "Tìm Lớp Tín Chỉ";
            this.btnLopTC.UseVisualStyleBackColor = true;
            this.btnLopTC.Click += new System.EventHandler(this.btnLopTC_Click);
            // 
            // cboHK
            // 
            this.cboHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHK.FormattingEnabled = true;
            this.cboHK.Location = new System.Drawing.Point(205, 12);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(121, 21);
            this.cboHK.TabIndex = 0;
            // 
            // cboNK
            // 
            this.cboNK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNK.FormattingEnabled = true;
            this.cboNK.Location = new System.Drawing.Point(40, 12);
            this.cboNK.Name = "cboNK";
            this.cboNK.Size = new System.Drawing.Size(121, 21);
            this.cboNK.TabIndex = 0;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DSLTCBindingSource
            // 
            this.sP_DSLTCBindingSource.DataSource = this.dS;
            this.sP_DSLTCBindingSource.Position = 0;
            // 
            // sP_DSLTCTableAdapter
            // 
            this.sP_DSLTCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUYEN_NGANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANG_KITableAdapter = null;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.GIANGTableAdapter = null;
            this.tableAdapterManager.KE_HOACH_GIANGTableAdapter = null;
            this.tableAdapterManager.KHA_NANG_GIANGTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP_TIN_CHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MON_HOCTableAdapter = null;
            this.tableAdapterManager.NIEN_KHOA_HOC_KYTableAdapter = null;
            this.tableAdapterManager.PHONG_GIAO_VUTableAdapter = null;
            this.tableAdapterManager.QUAN_LYTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quan_li_diem_sinh_vien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDSLTC
            // 
            this.bdsDSLTC.DataMember = "SP_DSLTC";
            this.bdsDSLTC.DataSource = this.dS;
            // 
            // sP_DSLTCGridControl
            // 
            this.sP_DSLTCGridControl.DataSource = this.bdsDSLTC;
            this.sP_DSLTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_DSLTCGridControl.Location = new System.Drawing.Point(0, 58);
            this.sP_DSLTCGridControl.MainView = this.gridView1;
            this.sP_DSLTCGridControl.Name = "sP_DSLTCGridControl";
            this.sP_DSLTCGridControl.Size = new System.Drawing.Size(935, 173);
            this.sP_DSLTCGridControl.TabIndex = 2;
            this.sP_DSLTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_LOP_TC,
            this.colTEN_MH,
            this.colNHOM,
            this.colHOTEN});
            this.gridView1.GridControl = this.sP_DSLTCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colMA_LOP_TC
            // 
            this.colMA_LOP_TC.Caption = "Mã Lớp Tín Chỉ";
            this.colMA_LOP_TC.FieldName = "MA_LOP_TC";
            this.colMA_LOP_TC.Name = "colMA_LOP_TC";
            this.colMA_LOP_TC.Visible = true;
            this.colMA_LOP_TC.VisibleIndex = 0;
            // 
            // colTEN_MH
            // 
            this.colTEN_MH.Caption = "Tên Môn Học";
            this.colTEN_MH.FieldName = "TEN_MH";
            this.colTEN_MH.Name = "colTEN_MH";
            this.colTEN_MH.Visible = true;
            this.colTEN_MH.VisibleIndex = 1;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên Giảng Viên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            // 
            // gcDSSV
            // 
            this.gcDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSSV.Location = new System.Drawing.Point(0, 231);
            this.gcDSSV.MainView = this.gridView2;
            this.gcDSSV.Name = "gcDSSV";
            this.gcDSSV.Size = new System.Drawing.Size(935, 295);
            this.gcDSSV.TabIndex = 3;
            this.gcDSSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcDSSV.TextChanged += new System.EventHandler(this.gcDSSV_TextChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_MA_SV,
            this.col_HOTEN_SV,
            this.col_DIEM_CC,
            this.col_DIEM_GK,
            this.col_DIEM_CK,
            this.col_DIEMHETMON});
            this.gridView2.GridControl = this.gcDSSV;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView2_ValidatingEditor);
            this.gridView2.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.gridView2_InvalidValueException);
            // 
            // col_MA_SV
            // 
            this.col_MA_SV.Caption = "Mã Sinh Viên";
            this.col_MA_SV.FieldName = "MA_SV";
            this.col_MA_SV.Name = "col_MA_SV";
            this.col_MA_SV.OptionsColumn.AllowEdit = false;
            this.col_MA_SV.Visible = true;
            this.col_MA_SV.VisibleIndex = 0;
            // 
            // col_HOTEN_SV
            // 
            this.col_HOTEN_SV.Caption = "Họ Tên Sinh Viên";
            this.col_HOTEN_SV.FieldName = "HOTENSV";
            this.col_HOTEN_SV.Name = "col_HOTEN_SV";
            this.col_HOTEN_SV.OptionsColumn.AllowEdit = false;
            this.col_HOTEN_SV.Visible = true;
            this.col_HOTEN_SV.VisibleIndex = 1;
            // 
            // col_DIEM_CC
            // 
            this.col_DIEM_CC.Caption = "Điểm Chuyên Cần";
            this.col_DIEM_CC.FieldName = "DIEM_CC";
            this.col_DIEM_CC.Name = "col_DIEM_CC";
            this.col_DIEM_CC.Visible = true;
            this.col_DIEM_CC.VisibleIndex = 2;
            this.col_DIEM_CC.Width = 175;
            // 
            // col_DIEM_GK
            // 
            this.col_DIEM_GK.Caption = "Điểm Giữa Kỳ";
            this.col_DIEM_GK.FieldName = "DIEM_GK";
            this.col_DIEM_GK.Name = "col_DIEM_GK";
            this.col_DIEM_GK.Visible = true;
            this.col_DIEM_GK.VisibleIndex = 3;
            // 
            // col_DIEM_CK
            // 
            this.col_DIEM_CK.Caption = "Điểm Cuối Kỳ";
            this.col_DIEM_CK.FieldName = "DIEM_CK";
            this.col_DIEM_CK.Name = "col_DIEM_CK";
            this.col_DIEM_CK.Visible = true;
            this.col_DIEM_CK.VisibleIndex = 4;
            // 
            // col_DIEMHETMON
            // 
            this.col_DIEMHETMON.Caption = "Điểm Hết Môn";
            this.col_DIEMHETMON.FieldName = "DIEMHETMON";
            this.col_DIEMHETMON.Name = "col_DIEMHETMON";
            this.col_DIEMHETMON.OptionsColumn.AllowEdit = false;
            this.col_DIEMHETMON.Visible = true;
            this.col_DIEMHETMON.VisibleIndex = 5;
            // 
            // FrmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 526);
            this.Controls.Add(this.gcDSSV);
            this.Controls.Add(this.sP_DSLTCGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmNhapDiem";
            this.Text = "FrmNhapDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_DSLTCBindingSource;
        private DSTableAdapters.SP_DSLTCTableAdapter sP_DSLTCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnGhiDiem;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnLopTC;
        private System.Windows.Forms.ComboBox cboHK;
        private System.Windows.Forms.ComboBox cboNK;
        private System.Windows.Forms.BindingSource bdsDSLTC;
        private DevExpress.XtraGrid.GridControl sP_DSLTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_LOP_TC;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_MH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.GridControl gcDSSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_MA_SV;
        private DevExpress.XtraGrid.Columns.GridColumn col_HOTEN_SV;
        private DevExpress.XtraGrid.Columns.GridColumn col_DIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn col_DIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn col_DIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn col_DIEMHETMON;
    }
}