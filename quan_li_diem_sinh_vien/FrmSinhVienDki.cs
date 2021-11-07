using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmSinhVienDki : Form
    {
        public FrmSinhVienDki()
        {
            InitializeComponent();
        }

        private void FrmSinhVienDki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSVDKC.DANG_KI' table. You can move, or remove it, as needed.
            this.dangKyTableAdapter.Fill(this.DSSVDKC.DANG_KI);
            // TODO: This line of code loads data into the 'dSSVDKC.GIANG' table. You can move, or remove it, as needed.
            this.giangTableAdapter.Fill(this.DSSVDKC.GIANG);
            // TODO: This line of code loads data into the 'dSSVDKC.LOP_TIN_CHI' table. You can move, or remove it, as needed.
            this.lopTinChiTableAdapter.Fill(this.DSSVDKC.LOP_TIN_CHI);

        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnDangKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void cboNKHK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
