using System;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmMonHoc : Form
    {
        int viTri = -1;

        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            DSMHC.EnforceConstraints = false;
            this.monHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.monHocTableAdapter.Fill(this.DSMHC.MON_HOC);
            this.keHoachGiangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.keHoachGiangTableAdapter.Fill(this.DSMHC.KE_HOACH_GIANG);
            this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khaNangGiangTableAdapter.Fill(this.DSMHC.KHA_NANG_GIANG);
            this.LopTinChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTinChiTableAdapter.Fill(this.DSMHC.LOP_TIN_CHI);
            viTri = monHocBDS.Position;
        }


    }
}
