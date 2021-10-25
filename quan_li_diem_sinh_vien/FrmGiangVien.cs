using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmGiangVien : Form
    {
        int viTri = -1;
        Stack<String> myStack = new Stack<String>();
        String lenhUpdate;
        String lenhThem;

        public FrmGiangVien()
        {
            InitializeComponent();
        }

        private void gIANG_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giangVienBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSGVC);

        }

        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            DSGVC.EnforceConstraints = false;
            this.giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangVienTableAdapter.Fill(this.DSGVC.GIANG_VIEN);
            this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangTableAdapter.Fill(this.DSGVC.GIANG);
            this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khaNangGiangTableAdapter.Fill(this.DSGVC.KHA_NANG_GIANG);
            this.quanLyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.quanLyTableAdapter.Fill(this.DSGVC.QUAN_LY);

            cboKhoa.DataSource = Program.bdsDSPM;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";

            int index = cboKhoa.FindStringExact(Program.mChinhanh);
            cboKhoa.SelectedIndex = index;

            barBtnHieuChinh.Enabled = barBtnGhi.Enabled = barBtnXoa.Enabled = barBtnPhucHoi.Enabled = false;
            lblMaGiangVien1.Enabled = hoTextEdit.Enabled = tenTextEdit.Enabled = lblMaKhoa1.Enabled = hocViTextEdit.Enabled = hocHamTextEdit.Enabled = chuyenMonTextEdit.Enabled = false;
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSGVC.EnforceConstraints = false;
            String serverName = cboKhoa.SelectedValue.ToString();
            if (serverName.Equals(Program.serverNameConLai))
            {
                this.giangVienTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                this.giangVienTableAdapter.Fill(this.DSGVC.GIANG_VIEN);
                this.giangTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                this.giangTableAdapter.Fill(this.DSGVC.GIANG);
                this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                this.khaNangGiangTableAdapter.Fill(this.DSGVC.KHA_NANG_GIANG);
                this.quanLyTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                this.quanLyTableAdapter.Fill(this.DSGVC.QUAN_LY);
            }
            else
            {
                this.giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.giangVienTableAdapter.Fill(this.DSGVC.GIANG_VIEN);
                this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.giangTableAdapter.Fill(this.DSGVC.GIANG);
                this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khaNangGiangTableAdapter.Fill(this.DSGVC.KHA_NANG_GIANG);
                this.quanLyTableAdapter.Connection.ConnectionString = Program.connstr;
                this.quanLyTableAdapter.Fill(this.DSGVC.QUAN_LY);
            }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
