using System;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            this.barBtnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
    }


}
