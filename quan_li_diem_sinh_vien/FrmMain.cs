using System;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            barBtnDangNhap.PerformClick();
        }

        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barBtnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FrmDangNhap f = new FrmDangNhap();
                f.MdiParent = this;
                f.Show();
                //f.StartPosition = FormStartPosition.Manual;
                //f.Location = new Point((this.ClientSize.Width - f.Width) / 2,
                //                       (this.ClientSize.Height - f.Height) / 2);
            }
        }

        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sttMaNV.Text = "";
            sttHoTen.Text = "";
            sttNhom.Text = "";
            sttKhoa.Text = "";

            Program.frmMain.barBtnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            Program.frmMain.barBtnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            Program.frmMain.ribbonPagePGV.Visible = false;
            Program.frmMain.ribbonPageGV.Visible = false;
            Program.frmMain.ribbonPageSV.Visible = false;

            Form[] childArray = this.MdiChildren;
            foreach (Form childForm in childArray)
            {
                childForm.Close();
            }
            barBtnDangNhap.PerformClick();
        }

        private void barBtnMocHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FrmMonHoc f = new FrmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBtnGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmGiangVien));
            if (frm != null) frm.Activate();
            else
            {
                FrmGiangVien f = new FrmGiangVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBtnTaoTk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDkiGiangVien));
            if (frm != null) frm.Activate();
            else
            {
                FrmDkiGiangVien f = new FrmDkiGiangVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBtnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmLop));
            if (frm != null) frm.Activate();
            else
            {
                FrmLop f = new FrmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bartbnNienKhoaHocKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmNKHK));
            if (frm != null) frm.Activate();
            else
            {
                FrmNKHK f = new FrmNKHK();
                f.MdiParent = this;
                f.Show();
            }
        }
    }


}
