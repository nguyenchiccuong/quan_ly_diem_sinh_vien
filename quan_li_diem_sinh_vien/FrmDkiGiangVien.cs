using System;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmDkiGiangVien : Form
    {
        public FrmDkiGiangVien()
        {
            InitializeComponent();
        }

        private void gIANG_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giangVienBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSGVDKC);

        }

        private void FrmDkiGiangVien_Load(object sender, EventArgs e)
        {
            DSGVDKC.EnforceConstraints = false;
            this.giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangVienTableAdapter.Fill(this.DSGVDKC.GIANG_VIEN);

        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
