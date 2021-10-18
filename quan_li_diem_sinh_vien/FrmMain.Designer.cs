namespace quan_li_diem_sinh_vien
{
    partial class FrmMain
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHT1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPagePGV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupPGV1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupGV1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSV1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBC1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStripThongTin = new System.Windows.Forms.StatusStrip();
            this.sttMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttNhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.statusStripThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnDangNhap,
            this.barBtnDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHeThong,
            this.ribbonPagePGV,
            this.ribbonPageGV,
            this.ribbonPageSV,
            this.ribbonPageBC});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 158);
            // 
            // barBtnDangNhap
            // 
            this.barBtnDangNhap.Caption = "Đăng nhập";
            this.barBtnDangNhap.Id = 4;
            this.barBtnDangNhap.ImageOptions.Image = global::quan_li_diem_sinh_vien.Properties.Resources.login;
            this.barBtnDangNhap.Name = "barBtnDangNhap";
            // 
            // barBtnDangXuat
            // 
            this.barBtnDangXuat.Caption = "Đăng xuất";
            this.barBtnDangXuat.Id = 6;
            this.barBtnDangXuat.ImageOptions.Image = global::quan_li_diem_sinh_vien.Properties.Resources.logout;
            this.barBtnDangXuat.Name = "barBtnDangXuat";
            this.barBtnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHT1});
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroupHT1
            // 
            this.ribbonPageGroupHT1.ItemLinks.Add(this.barBtnDangNhap);
            this.ribbonPageGroupHT1.ItemLinks.Add(this.barBtnDangXuat);
            this.ribbonPageGroupHT1.Name = "ribbonPageGroupHT1";
            // 
            // ribbonPagePGV
            // 
            this.ribbonPagePGV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupPGV1});
            this.ribbonPagePGV.Name = "ribbonPagePGV";
            this.ribbonPagePGV.Text = "Phòng giáo vụ";
            this.ribbonPagePGV.Visible = false;
            // 
            // ribbonPageGroupPGV1
            // 
            this.ribbonPageGroupPGV1.Name = "ribbonPageGroupPGV1";
            // 
            // ribbonPageGV
            // 
            this.ribbonPageGV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupGV1});
            this.ribbonPageGV.Name = "ribbonPageGV";
            this.ribbonPageGV.Text = "Giảng viên";
            this.ribbonPageGV.Visible = false;
            // 
            // ribbonPageGroupGV1
            // 
            this.ribbonPageGroupGV1.Name = "ribbonPageGroupGV1";
            // 
            // ribbonPageSV
            // 
            this.ribbonPageSV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSV1});
            this.ribbonPageSV.Name = "ribbonPageSV";
            this.ribbonPageSV.Text = "Sinh viên";
            this.ribbonPageSV.Visible = false;
            // 
            // ribbonPageGroupSV1
            // 
            this.ribbonPageGroupSV1.Name = "ribbonPageGroupSV1";
            // 
            // ribbonPageBC
            // 
            this.ribbonPageBC.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBC1});
            this.ribbonPageBC.Name = "ribbonPageBC";
            this.ribbonPageBC.Text = "Báo cáo";
            this.ribbonPageBC.Visible = false;
            // 
            // ribbonPageGroupBC1
            // 
            this.ribbonPageGroupBC1.Name = "ribbonPageGroupBC1";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // statusStripThongTin
            // 
            this.statusStripThongTin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttMaNV,
            this.sttHoTen,
            this.sttNhom});
            this.statusStripThongTin.Location = new System.Drawing.Point(0, 338);
            this.statusStripThongTin.Name = "statusStripThongTin";
            this.statusStripThongTin.Size = new System.Drawing.Size(758, 22);
            this.statusStripThongTin.TabIndex = 2;
            this.statusStripThongTin.Text = "statusStripThongTin";
            // 
            // sttMaNV
            // 
            this.sttMaNV.Name = "sttMaNV";
            this.sttMaNV.Size = new System.Drawing.Size(47, 17);
            this.sttMaNV.Text = "MA_NV";
            // 
            // sttHoTen
            // 
            this.sttHoTen.Name = "sttHoTen";
            this.sttHoTen.Size = new System.Drawing.Size(51, 17);
            this.sttHoTen.Text = "HO_TEN";
            // 
            // sttNhom
            // 
            this.sttNhom.Name = "sttNhom";
            this.sttNhom.Size = new System.Drawing.Size(45, 17);
            this.sttNhom.Text = "NHOM";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.statusStripThongTin);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý điểm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.statusStripThongTin.ResumeLayout(false);
            this.statusStripThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHT1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private System.Windows.Forms.StatusStrip statusStripThongTin;
        private System.Windows.Forms.ToolStripStatusLabel sttMaNV;
        private System.Windows.Forms.ToolStripStatusLabel sttHoTen;
        private System.Windows.Forms.ToolStripStatusLabel sttNhom;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPagePGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPGV1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGV1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSV1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBC1;
        private DevExpress.XtraBars.BarButtonItem barBtnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barBtnDangXuat;
    }
}

