using System;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmMoLop : Form
    {
        public FrmMoLop()
        {
            InitializeComponent();
        }

        private void lOP_TIN_CHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lopTinChiBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSMLC);

        }

        private void FrmMoLop_Load(object sender, EventArgs e)
        {
            DSMLC.EnforceConstraints = false;
            this.dangKyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dangKyTableAdapter.Fill(this.DSMLC.DANG_KI);
            this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangTableAdapter.Fill(this.DSMLC.GIANG);
            this.lopTinChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTinChiTableAdapter.Fill(this.DSMLC.LOP_TIN_CHI);

        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
