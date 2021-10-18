using System;
using System.Drawing;
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
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point((this.ClientSize.Width - f.Width) / 2,
                                       (this.ClientSize.Height - f.Height) / 2);
            }
        }
    }


}
