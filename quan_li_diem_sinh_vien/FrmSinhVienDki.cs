using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmSinhVienDki : Form
    {
        int viTriLop = -1;
        int viTriGiang = -1;
        BindingSource nienKhoaHocKyBDS = new BindingSource();
        BindingSource giangVienBDS = new BindingSource();
        BindingSource monHocBDS = new BindingSource();

        public FrmSinhVienDki()
        {
            InitializeComponent();
        }

        private void FrmSinhVienDki_Load(object sender, EventArgs e)
        {
            layDSNKHK("SELECT * FROM V_DS_NK_HK");

            DSSVDKC.EnforceConstraints = false;
            this.lopTinChiTableAdapter.Connection.ConnectionString = Program.connstr;
            if (nienKhoaHocKyBDS.Count > 0)
            {
                lopTinChiBDS.Filter = "MA_NK_HK = " + cboNKHK.SelectedValue;
            }

            this.lopTinChiTableAdapter.Fill(this.DSSVDKC.LOP_TIN_CHI);
            this.dangKyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dangKyTableAdapter.Fill(this.DSSVDKC.DANG_KI);
            this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangTableAdapter.Fill(this.DSSVDKC.GIANG);

            layDSMH("SELECT * FROM V_DS_MH");
            if (lopTinChiBDS.Count > 0)
            {
                viTriLop = lopTinChiBDS.Position;
                int indexOfMonHoc = monHocBDS.Find("MA_MH", ((DataRowView)lopTinChiBDS[viTriLop])["MA_MH"].ToString());
                lblTenMonHoc1.Text = ((DataRowView)monHocBDS[indexOfMonHoc])["TEN_MH"].ToString();
            }
            else
            {
                lblTenMonHoc1.Text = "";
            }

            layDSGV("SELECT * FROM V_DS_GV");
            if (giangBDS.Count > 0)
            {
                viTriGiang = giangBDS.Position;
                int indexOfGiangVien = giangVienBDS.Find("MA_GV", ((DataRowView)giangBDS[viTriGiang])["MA_GV"].ToString());
                lblTenGiangVien.Text = ((DataRowView)giangVienBDS[indexOfGiangVien])["HO_TEN"].ToString();
                lblSoLuongSinhVienDaDki.Text = dangKyBDS.Count.ToString();
            }
            else
            {
                lblTenGiangVien.Text = "";
                lblSoLuongSinhVienDaDki.Text = "";
            }

            DSSVDKC2.EnforceConstraints = false;
            this.dangKyTableAdapter2.Connection.ConnectionString = Program.connstr;
            this.dangKyTableAdapter2.Fill(this.DSSVDKC2.DANG_KI);
            if (dangKyBDS2.Count > 0)
            {
                dangKyBDS2.Filter = "MA_SV = '" + Program.mloginDN + "'";
                for (int i = 0; i < lopTinChiBDS.Count; i++)
                {
                    String maLopTc = ((DataRowView)lopTinChiBDS[i])["MA_LOP_TC"].ToString();
                    dangKyBDS2.Filter += " AND MA_LOP_TC = " + maLopTc;
                }
            }
            this.dangKyTableAdapter2.Fill(this.DSSVDKC2.DANG_KI);

            if (dangKyBDS2.Count > 0)
            {
                int maLopTc = int.Parse(((DataRowView)dangKyBDS2[dangKyBDS2.Position])["MA_LOP_TC"].ToString());
                int indexOfLopTc = lopTinChiBDS.Find("MA_LOP_TC", maLopTc);
                int indexOfMonHoc = monHocBDS.Find("MA_MH", ((DataRowView)lopTinChiBDS[indexOfLopTc])["MA_MH"].ToString());
                lblTenMonHoc2.Text = ((DataRowView)monHocBDS[indexOfMonHoc])["TEN_MH"].ToString();
            }
            else
            {
                lblTenMonHoc2.Text = "";
            }

            if (kiemTraChoPhepHieuChinh() != 0)
            {
                barBtnXoa.Enabled = barBtnDangKi.Enabled = false;
            }
            else
            {
                if (dangKyBDS2.Count > 0)
                    barBtnXoa.Enabled = barBtnDangKi.Enabled = true;
                else
                    barBtnXoa.Enabled = barBtnDangKi.Enabled = false;
            }
        }

        private void layDSNKHK(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.KetNoi(Program.connstr) == 0) return;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            nienKhoaHocKyBDS.DataSource = dt;
            cboNKHK.DataSource = nienKhoaHocKyBDS;
            cboNKHK.DisplayMember = "NK_HK";
            cboNKHK.ValueMember = "MA_NK_HK";
            if (nienKhoaHocKyBDS.Count > 0) cboNKHK.SelectedIndex = 0;
        }

        private void layDSMH(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.KetNoi(Program.connstr) == 0) return;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            monHocBDS.DataSource = dt;
        }

        private void layDSGV(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.KetNoi(Program.connstr) == 0) return;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            giangVienBDS.DataSource = dt;
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lopTinChiTableAdapter.Fill(this.DSSVDKC.LOP_TIN_CHI);
            this.dangKyTableAdapter.Fill(this.DSSVDKC.DANG_KI);
            this.giangTableAdapter.Fill(this.DSSVDKC.GIANG);
            this.dangKyTableAdapter2.Fill(this.DSSVDKC2.DANG_KI);

            if (lopTinChiBDS.Count > 0)
            {
                viTriLop = lopTinChiBDS.Position;
                int indexOfMonHoc = monHocBDS.Find("MA_MH", ((DataRowView)lopTinChiBDS[viTriLop])["MA_MH"].ToString());
                lblTenMonHoc1.Text = ((DataRowView)monHocBDS[indexOfMonHoc])["TEN_MH"].ToString();
            }
            else
            {
                lblTenMonHoc1.Text = "";
            }

            if (giangBDS.Count > 0)
            {
                viTriGiang = giangBDS.Position;
                int indexOfGiangVien = giangVienBDS.Find("MA_GV", ((DataRowView)giangBDS[viTriGiang])["MA_GV"].ToString());
                lblTenGiangVien.Text = ((DataRowView)giangVienBDS[indexOfGiangVien])["HO_TEN"].ToString();
                lblSoLuongSinhVienDaDki.Text = dangKyBDS.Count.ToString();
            }
            else
            {
                lblTenGiangVien.Text = "";
                lblSoLuongSinhVienDaDki.Text = "";
            }

            if (dangKyBDS2.Count > 0)
            {
                int maLopTc = int.Parse(((DataRowView)dangKyBDS2[dangKyBDS2.Position])["MA_LOP_TC"].ToString());
                int indexOfLopTc = lopTinChiBDS.Find("MA_LOP_TC", maLopTc);
                int indexOfMonHoc = monHocBDS.Find("MA_MH", ((DataRowView)lopTinChiBDS[indexOfLopTc])["MA_MH"].ToString());
                lblTenMonHoc2.Text = ((DataRowView)monHocBDS[indexOfMonHoc])["TEN_MH"].ToString();
            }
            else
            {
                lblTenMonHoc2.Text = "";
            }

            if (kiemTraChoPhepHieuChinh() != 0)
            {
                barBtnXoa.Enabled = barBtnDangKi.Enabled = false;
            }
            else
            {
                barBtnXoa.Enabled = barBtnDangKi.Enabled = true;
            }
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraChoPhepHieuChinh() != 0)
            {
                barBtnXoa.Enabled = barBtnDangKi.Enabled = false;
                MessageBox.Show("Ngoài thời gian cho phép hủy đăng kí", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                barBtnXoa.Enabled = barBtnDangKi.Enabled = true;
            }

            if (dangKyBDS2.Count > 0)
            {
                if (Program.KetNoi(Program.connstr) == 0) return;
                String strLenh = String.Format("DELETE FROM DANG_KI WHERE MA_LOP_TC = {0} AND MA_SV ='{1}'", ((DataRowView)lopTinChiBDS[viTriLop])["MA_LOP_TC"].ToString(), Program.mloginDN);
                try
                {
                    Program.ExecSqlNonQuery(strLenh);
                    Program.conn.Close();
                    barBtnTaiLai.PerformClick();
                    MessageBox.Show("Xóa đăng kí môn học thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa đăng kí môn học thất bại \n" + ex, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void barBtnDangKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraChoPhepHieuChinh() != 0)
            {
                barBtnXoa.Enabled = barBtnDangKi.Enabled = false;
                MessageBox.Show("Ngoài thời gian cho phép đăng kí", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                barBtnXoa.Enabled = barBtnDangKi.Enabled = true;
            }

            if (lopTinChiBDS.Count > 0)
            {
                if (Program.KetNoi(Program.connstr) == 0) return;
                string strLenh = String.Format("EXEC SP_CHECKTRUNGMONHOC @maSV = N'{0}', @maMH = N'{1}', @maNKHK = {2}", Program.mloginDN, ((DataRowView)lopTinChiBDS[viTriLop])["MA_MH"].ToString(), cboNKHK.SelectedValue.ToString());
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int ketQua = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                Program.conn.Close();

                if (ketQua == 1)
                {
                    MessageBox.Show("Bạn đã đăng kí môn học này trong học kì này rồi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                for (int i = 0; i < giangBDS.Count; i++)
                {
                    if (Program.KetNoi(Program.connstr) == 0) return;
                    strLenh = String.Format("EXEC SP_CHECKTRUNGLICHHOC @maSV = N'{0}', @maNKHK = N'{1}', @thu = {2}, @tietBDau = {3}", Program.mloginDN, cboNKHK.SelectedValue.ToString(), ((DataRowView)giangBDS[i])["THU"].ToString(), ((DataRowView)giangBDS[i])["TIET_BDAU"].ToString());
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    ketQua = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    Program.conn.Close();

                    if (ketQua == 1)
                    {
                        MessageBox.Show("Bạn bị trùng lịch học", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }

                if (Program.KetNoi(Program.connstr) == 0) return;
                strLenh = String.Format("INSERT INTO DANG_KI (MA_LOP_TC, MA_SV, HUY) VALUES({0}, '{1}', 0); ", ((DataRowView)lopTinChiBDS[viTriLop])["MA_LOP_TC"].ToString(), Program.mloginDN);
                try
                {
                    Program.ExecSqlNonQuery(strLenh);
                    Program.conn.Close();
                    barBtnTaiLai.PerformClick();
                    MessageBox.Show("Đăng kí môn học thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng kí môn học thất bại \n" + ex, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void cboNKHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nienKhoaHocKyBDS.Count > 0)
                {
                    lopTinChiBDS.Filter = "MA_NK_HK = " + cboNKHK.SelectedValue + "AND HUY = false";

                }
                this.lopTinChiTableAdapter.Fill(this.DSSVDKC.LOP_TIN_CHI);
                this.dangKyTableAdapter.Fill(this.DSSVDKC.DANG_KI);
                this.giangTableAdapter.Fill(this.DSSVDKC.GIANG);

                if (lopTinChiBDS.Count > 0)
                {
                    viTriLop = lopTinChiBDS.Position;
                    int indexOfMonHoc = monHocBDS.Find("MA_MH", ((DataRowView)lopTinChiBDS[viTriLop])["MA_MH"].ToString());
                    lblTenMonHoc1.Text = ((DataRowView)monHocBDS[indexOfMonHoc])["TEN_MH"].ToString();
                }
                else
                {
                    lblTenMonHoc1.Text = "";
                }

                if (giangBDS.Count > 0)
                {
                    viTriGiang = giangBDS.Position;
                    int indexOfGiangVien = giangVienBDS.Find("MA_GV", ((DataRowView)giangBDS[viTriGiang])["MA_GV"].ToString());
                    lblTenGiangVien.Text = ((DataRowView)giangVienBDS[indexOfGiangVien])["HO_TEN"].ToString();
                    lblSoLuongSinhVienDaDki.Text = dangKyBDS.Count.ToString();
                }
                else
                {
                    lblTenGiangVien.Text = "";
                    lblSoLuongSinhVienDaDki.Text = "";
                }

                dangKyBDS2.Filter = "";
                this.dangKyTableAdapter2.Fill(this.DSSVDKC2.DANG_KI);
                if (dangKyBDS2.Count > 0)
                {
                    dangKyBDS2.Filter = "MA_SV = '" + Program.mloginDN + "'";
                    for (int i = 0; i < lopTinChiBDS.Count; i++)
                    {
                        String maLopTc = ((DataRowView)lopTinChiBDS[i])["MA_LOP_TC"].ToString();
                        dangKyBDS2.Filter += " AND MA_LOP_TC = " + maLopTc;
                    }
                }
                this.dangKyTableAdapter2.Fill(this.DSSVDKC2.DANG_KI);

                if (dangKyBDS2.Count > 0)
                {
                    int maLopTc = int.Parse(((DataRowView)dangKyBDS2[dangKyBDS2.Position])["MA_LOP_TC"].ToString());
                    int indexOfLopTc = lopTinChiBDS.Find("MA_LOP_TC", maLopTc);
                    int indexOfMonHoc = monHocBDS.Find("MA_MH", ((DataRowView)lopTinChiBDS[indexOfLopTc])["MA_MH"].ToString());
                    lblTenMonHoc2.Text = ((DataRowView)monHocBDS[indexOfMonHoc])["TEN_MH"].ToString();
                }
                else
                {
                    lblTenMonHoc2.Text = "";
                }

                if (kiemTraChoPhepHieuChinh() != 0)
                {
                    barBtnXoa.Enabled = barBtnDangKi.Enabled = false;
                }
                else
                {
                    barBtnXoa.Enabled = barBtnDangKi.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void lopTinChiGridControl_Click(object sender, EventArgs e)
        {
            if (lopTinChiBDS.Count > 0)
            {
                viTriLop = lopTinChiBDS.Position;
                int indexOfMonHoc = monHocBDS.Find("MA_MH", ((DataRowView)lopTinChiBDS[viTriLop])["MA_MH"].ToString());
                lblTenMonHoc1.Text = ((DataRowView)monHocBDS[indexOfMonHoc])["TEN_MH"].ToString();
                lblSoLuongSinhVienDaDki.Text = dangKyBDS.Count.ToString();
            }
        }

        private void giangGridControl_Click(object sender, EventArgs e)
        {
            if (giangBDS.Count > 0)
            {
                viTriGiang = giangBDS.Position;
                int indexOfGiangVien = giangVienBDS.Find("MA_GV", ((DataRowView)giangBDS[viTriGiang])["MA_GV"].ToString());
                lblTenGiangVien.Text = ((DataRowView)giangVienBDS[indexOfGiangVien])["HO_TEN"].ToString();
            }
        }

        private int kiemTraChoPhepHieuChinh()
        {
            int indexOfNKHK = nienKhoaHocKyBDS.Find("MA_NK_HK", cboNKHK.SelectedValue);
            DateTime ngayBatDau = Convert.ToDateTime(((DataRowView)nienKhoaHocKyBDS[indexOfNKHK])["NGAY_BDAU_DKI"].ToString());
            DateTime ngayKetThuc = Convert.ToDateTime(((DataRowView)nienKhoaHocKyBDS[indexOfNKHK])["NGAY_KTHUC_DKI"].ToString());
            if ((DateTime.Compare(DateTime.Now, ngayBatDau) < 0))
            {
                return -1;
            }
            else if ((DateTime.Compare(ngayBatDau, DateTime.Now) <= 0) && (DateTime.Compare(DateTime.Now, ngayKetThuc) < 0))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
