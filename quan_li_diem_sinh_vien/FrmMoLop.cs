using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmMoLop : Form
    {

        int viTriLop = -1;
        int viTriGiang = -1;
        String NKHK = "";
        BindingSource nienKhoaHocKyBDS = new BindingSource();
        BindingSource giangVienBDS = new BindingSource();
        BindingSource monHocBDS = new BindingSource();
        String serverHienTai = "";

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
            this.lopTinChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTinChiTableAdapter.Fill(this.DSMLC.LOP_TIN_CHI);
            this.dangKyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dangKyTableAdapter.Fill(this.DSMLC.DANG_KI);
            this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangTableAdapter.Fill(this.DSMLC.GIANG);


            BindingSource bdsKHoaTemp = new BindingSource(Program.bdsDSPM.DataSource, Program.bdsDSPM.DataMember);
            cboKhoa.DataSource = bdsKHoaTemp;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedIndex = 1;
            cboKhoa.SelectedIndex = 0;

            serverHienTai = Program.servername;

            int index = cboKhoa.FindStringExact(Program.mChinhanh);
            cboKhoa.SelectedIndex = index;

            layDSNKHK("SELECT * FROM V_DS_NK_HK");

            layDSMH("SELECT * FROM V_DS_MH");
            if (lopTinChiBDS.Count > 0)
            {
                viTriLop = lopTinChiBDS.Position;
                cboMaMonHoc.SelectedValue = ((DataRowView)lopTinChiBDS[viTriLop])["MA_MH"].ToString();
                cboNienKhoaHocKy.SelectedValue = ((DataRowView)lopTinChiBDS[viTriLop])["MA_NK_HK"].ToString();
            }
            layDSGV("SELECT * FROM V_DS_GV");
            if (giangBDS.Count > 0)
            {
                viTriGiang = giangBDS.Position;
                cboMaGiangVien.SelectedValue = ((DataRowView)giangBDS[viTriGiang])["MA_GV"].ToString();
            }

            barBtnThemGiang.Enabled = barBtnHieuChinh.Enabled = barBtnGhi.Enabled = barBtnXoa.Enabled = false;
            cboNienKhoaHocKy.Enabled = cboMaMonHoc.Enabled = heSoCcSpinEdit.Enabled = heSoCkSpinEdit.Enabled = heSoGkSpinEdit.Enabled = soSvToiThieuSpinEdit.Enabled = huyCheckEdit.Enabled = cboMaGiangVien.Enabled = thuSpinEdit.Enabled = tietBatDauSpinEdit.Enabled = false;

        }

        private void layDSNKHK(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.KetNoi(Program.connstr) == 0) return;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            nienKhoaHocKyBDS.DataSource = dt;
            cboNienKhoaHocKy.DataSource = nienKhoaHocKyBDS;
            cboNienKhoaHocKy.DisplayMember = "NK_HK";
            cboNienKhoaHocKy.ValueMember = "MA_NK_HK";
            if (nienKhoaHocKyBDS.Count > 0) cboNienKhoaHocKy.SelectedIndex = 0;
        }

        private void layDSMH(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.KetNoi(Program.connstr) == 0) return;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            monHocBDS.DataSource = dt;
            cboMaMonHoc.DataSource = monHocBDS;
            cboMaMonHoc.DisplayMember = "TEN_MH";
            cboMaMonHoc.ValueMember = "MA_MH";
            if (monHocBDS.Count > 0) cboMaMonHoc.SelectedIndex = 0;
        }

        private void layDSGV(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.KetNoi(Program.connstr) == 0) return;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            giangVienBDS.DataSource = dt;
            cboMaGiangVien.DataSource = giangVienBDS;
            cboMaGiangVien.DisplayMember = "HO_TEN";
            cboMaGiangVien.ValueMember = "MA_GV";
            if (giangVienBDS.Count > 0) cboMaGiangVien.SelectedIndex = 0;
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void lopTinChiGridControl_Click(object sender, EventArgs e)
        {
            if (lopTinChiBDS.Count > 0)
            {
                cboMaMonHoc.SelectedValue = ((DataRowView)lopTinChiBDS[lopTinChiBDS.Position])["MA_MH"].ToString();
                cboNienKhoaHocKy.SelectedValue = ((DataRowView)lopTinChiBDS[lopTinChiBDS.Position])["MA_NK_HK"].ToString();
                viTriLop = lopTinChiBDS.Position;

            }
        }

        private void giangGridControl_Click(object sender, EventArgs e)
        {
            if (giangBDS.Count > 0)
            {
                cboMaGiangVien.SelectedValue = ((DataRowView)giangBDS[giangBDS.Position])["MA_GV"].ToString();
                viTriGiang = giangBDS.Position;
            }
        }

        private void cboMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viTriLop != -1)
                lblMaMonHoc.Text = cboMaMonHoc.SelectedValue.ToString();
        }

        private void cboMaGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viTriGiang != -1)
                lblMaGiangVien.Text = cboMaGiangVien.SelectedValue.ToString();

        }

        private void cboNienKhoaHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viTriLop != -1)
                lblMaNienKhoaHocKy.Text = cboNienKhoaHocKy.SelectedValue.ToString();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {//nho reset vitri =-1
            viTriLop = -1;
            viTriGiang = -1;
            if (!serverHienTai.Equals(cboKhoa.SelectedValue.ToString()) && serverHienTai != "")
            {
                DSMLC.EnforceConstraints = false;
                serverHienTai = cboKhoa.SelectedValue.ToString();
                if (serverHienTai.Equals(Program.serverNameConLai))
                {
                    this.lopTinChiTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                    this.dangKyTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                    this.giangTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                }
                else
                {
                    this.lopTinChiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dangKyTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
                }
                barBtnTaiLai.PerformClick();
            }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lopTinChiTableAdapter.Fill(this.DSMLC.LOP_TIN_CHI);
            this.dangKyTableAdapter.Fill(this.DSMLC.DANG_KI);
            this.giangTableAdapter.Fill(this.DSMLC.GIANG);

            if (viTriLop != -1)
                lopTinChiBDS.Position = viTriLop;
            else
                viTriLop = lopTinChiBDS.Position;

            if (viTriGiang != -1)
                giangBDS.Position = viTriGiang;
            else
                viTriGiang = giangBDS.Position;

            layDSNKHK("SELECT * FROM V_DS_NK_HK");

            layDSMH("SELECT * FROM V_DS_MH");
            if (lopTinChiBDS.Count > 0)
            {
                cboMaMonHoc.SelectedValue = ((DataRowView)lopTinChiBDS[viTriLop])["MA_MH"].ToString();
                cboNienKhoaHocKy.SelectedValue = ((DataRowView)lopTinChiBDS[viTriLop])["MA_NK_HK"].ToString();
            }
            layDSGV("SELECT * FROM V_DS_GV");
            if (giangBDS.Count > 0)
            {
                cboMaGiangVien.SelectedValue = ((DataRowView)giangBDS[viTriGiang])["MA_GV"].ToString();
            }

            barBtnThemGiang.Enabled = barBtnHieuChinh.Enabled = barBtnGhi.Enabled = barBtnXoa.Enabled = false;
            cboMaMonHoc.Enabled = heSoCcSpinEdit.Enabled = heSoCkSpinEdit.Enabled = heSoGkSpinEdit.Enabled = soSvToiThieuSpinEdit.Enabled = huyCheckEdit.Enabled = cboMaGiangVien.Enabled = thuSpinEdit.Enabled = tietBatDauSpinEdit.Enabled = false;
            lopTinChiGridControl.Enabled = giangGridControl.Enabled = true;
        }
    }
}
