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
            barBtnThemLop.Enabled = true;
            cboNienKhoaHocKy.Enabled = cboMaMonHoc.Enabled = heSoCcSpinEdit.Enabled = heSoCkSpinEdit.Enabled = heSoGkSpinEdit.Enabled = soSvToiThieuSpinEdit.Enabled = huyCheckEdit.Enabled = cboMaGiangVien.Enabled = thuSpinEdit.Enabled = tietBatDauSpinEdit.Enabled = false;
            lopTinChiGridControl.Enabled = giangGridControl.Enabled = true;
        }

        private void lopTinChiGridControl_DoubleClick(object sender, EventArgs e)
        {
            if (lopTinChiBDS.Count > 0 && viTriLop >= 0)
            {
                int ketQuaHieuChinh = kiemTraChoPhepHieuChinh();
                if (ketQuaHieuChinh == -1)// truoc ngày dki
                {
                    barBtnThemGiang.Enabled = barBtnHieuChinh.Enabled = true;
                    heSoCcSpinEdit.Enabled = heSoCkSpinEdit.Enabled = heSoGkSpinEdit.Enabled = soSvToiThieuSpinEdit.Enabled = huyCheckEdit.Enabled = true;
                    lopTinChiGridControl.Enabled = giangGridControl.Enabled = false;
                    barBtnThemLop.Enabled = false;
                }
                else if (ketQuaHieuChinh == 1) // sau thoi gian dki
                {
                    if (serverHienTai.Equals(Program.serverNameConLai))
                    {
                        if (Program.KetNoi(Program.connstrConLai) == 0) return;
                    }
                    else
                    {
                        if (Program.KetNoi(Program.connstr) == 0) return;
                    }
                    string strLenh = "EXEC SP_CHECKCHOPHEPHIEUCHINHLOPTC @maLop = " + lblMaLopTinChi.Text.Trim();
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int ketQua = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    Program.conn.Close();
                    //neu chua nhap diem
                    if (ketQua == 1)
                    {
                        barBtnThemGiang.Enabled = barBtnHieuChinh.Enabled = true;
                        heSoCcSpinEdit.Enabled = heSoCkSpinEdit.Enabled = heSoGkSpinEdit.Enabled = soSvToiThieuSpinEdit.Enabled = huyCheckEdit.Enabled = true;
                        lopTinChiGridControl.Enabled = giangGridControl.Enabled = false;
                        barBtnThemLop.Enabled = false;
                    }
                }

            }
        }

        private void giangGridControl_DoubleClick(object sender, EventArgs e)
        {
            if (giangBDS.Count > 0 && viTriGiang >= 0)
            {

                int ketQuaHieuChinh = kiemTraChoPhepHieuChinh();
                if (ketQuaHieuChinh == -1)
                {
                    lopTinChiGridControl.Enabled = giangGridControl.Enabled = false;
                    barBtnThemLop.Enabled = false;
                    barBtnHieuChinh.Enabled = barBtnXoa.Enabled = true;
                    cboMaGiangVien.Enabled = thuSpinEdit.Enabled = tietBatDauSpinEdit.Enabled = true;
                }
                else if (ketQuaHieuChinh == 1)
                {
                    if (serverHienTai.Equals(Program.serverNameConLai))
                    {
                        if (Program.KetNoi(Program.connstrConLai) == 0) return;
                    }
                    else
                    {
                        if (Program.KetNoi(Program.connstr) == 0) return;
                    }
                    string strLenh = "EXEC SP_CHECKCHOPHEPHIEUCHINHLOPTC @maLop = " + lblMaLopTinChi.Text.Trim();
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int ketQua = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    Program.conn.Close();
                    //neu chua nhap diem
                    if (ketQua == 1)
                    {
                        lopTinChiGridControl.Enabled = giangGridControl.Enabled = false;
                        barBtnThemLop.Enabled = false;
                        barBtnHieuChinh.Enabled = barBtnXoa.Enabled = true;
                        cboMaGiangVien.Enabled = true;
                    }
                }
            }
        }

        private int kiemTraChoPhepHieuChinh()
        {
            DateTime ngayBatDau = Convert.ToDateTime(((DataRowView)nienKhoaHocKyBDS[nienKhoaHocKyBDS.Position])["NGAY_BDAU_DKI"].ToString());
            DateTime ngayKetThuc = Convert.ToDateTime(((DataRowView)nienKhoaHocKyBDS[nienKhoaHocKyBDS.Position])["NGAY_KTHUC_DKI"].ToString());
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

        private void barBtnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nienKhoaHocKyBDS.Count > 0 && monHocBDS.Count > 0)
            {
                lopTinChiGridControl.Enabled = giangGridControl.Enabled = false;
                barBtnThemLop.Enabled = false;
                barBtnGhi.Enabled = true;
                cboNienKhoaHocKy.Enabled = cboMaMonHoc.Enabled = heSoCcSpinEdit.Enabled = heSoCkSpinEdit.Enabled = heSoGkSpinEdit.Enabled = soSvToiThieuSpinEdit.Enabled = true;

                lopTinChiBDS.AddNew();

                lblMaNienKhoaHocKy.Text = cboNienKhoaHocKy.SelectedValue.ToString();
                lblMaMonHoc.Text = cboMaMonHoc.SelectedValue.ToString();
                lblMaLopTinChi.Text = null;
                if (serverHienTai.Equals(Program.serverNameConLai))
                {
                    if (Program.mChinhanh.Equals("Công Nghệ Thông Tin"))
                        lblMaKhoa.Text = "VT";
                    else
                        lblMaKhoa.Text = "CNTT";
                }
                else
                {
                    if (Program.mChinhanh.Equals("Công Nghệ Thông Tin"))
                        lblMaKhoa.Text = "CNTT";
                    else
                        lblMaKhoa.Text = "VT";
                }
                lblMaNhanVien.Text = Program.mloginDN;
                heSoCcSpinEdit.Value = heSoGkSpinEdit.Value = heSoCkSpinEdit.Value = 0;
            }
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboMaGiangVien.Enabled == true) //them giang vien
            {

            }
            else //them lop
            {
                if (kiemTraThemLopTinChi()) return;

                int ketQuaHieuChinh = kiemTraChoPhepHieuChinh();
                if (ketQuaHieuChinh != -1)
                {
                    MessageBox.Show("Ngoài thời gian cho phép mở lớp của niên khóa học kỳ", "Báo lỗi niên khóa học kỳ", MessageBoxButtons.OK);
                    return;
                }

                if (serverHienTai.Equals(Program.serverNameConLai))
                {
                    if (Program.KetNoi(Program.connstrConLai) == 0) return;
                }
                else
                {
                    if (Program.KetNoi(Program.connstr) == 0) return;
                }
                string strLenh = "EXEC SP_XINMANHOM @maNKHK = " + lblMaNienKhoaHocKy.Text.Trim() + ", @maMH = '" + lblMaMonHoc.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int ketQua = Program.myReader.GetInt16(0);
                Program.myReader.Close();
                Program.conn.Close();
                lblNhom.Text = ketQua.ToString();

                huyCheckEdit.Checked = false;
                try
                {
                    lopTinChiBDS.EndEdit();
                    lopTinChiBDS.ResetCurrentItem();
                    if (DSMLC.HasChanges())
                    {
                        this.lopTinChiTableAdapter.Update(this.DSMLC.LOP_TIN_CHI);
                    }

                    viTriLop = lopTinChiBDS.Position;
                    barBtnTaiLai.PerformClick();
                    MessageBox.Show("Mở lớp thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mãlớp tín chỉ trùng.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private Boolean kiemTraThemLopTinChi()
        {
            if (soSvToiThieuSpinEdit.Value == 0)
            {
                MessageBox.Show("Lớp cần ít nhất 1 sinh viên", "Báo lỗi số sinh viên tối thiểu", MessageBoxButtons.OK);
                soSvToiThieuSpinEdit.Focus();
                return true;
            }
            if (heSoCcSpinEdit.Value % 10 != 0 || heSoGkSpinEdit.Value % 10 != 0 || heSoCkSpinEdit.Value % 10 != 0 || heSoCcSpinEdit.Value + heSoGkSpinEdit.Value + heSoCkSpinEdit.Value != 100)
            {
                MessageBox.Show("Hệ số cần chia hết cho 10 và tổng của 3 hệ số bé hơn 100", "Báo lỗi hệ số", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private void barBtnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ketQuaHieuChinh = kiemTraChoPhepHieuChinh();
            if (ketQuaHieuChinh == -1)// truoc ngày dki
            {
                if (heSoCcSpinEdit.Enabled == true)
                {
                    if (kiemTraThemLopTinChi()) return;
                    lblMaNhanVien.Text = Program.mloginDN;
                    try
                    {
                        lopTinChiBDS.EndEdit();
                        lopTinChiBDS.ResetCurrentItem();
                        if (DSMLC.HasChanges())
                        {
                            this.lopTinChiTableAdapter.Update(this.DSMLC.LOP_TIN_CHI);
                        }

                        barBtnTaiLai.PerformClick();
                        MessageBox.Show("Sửa lớp thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("PRIMARY"))
                        {
                            MessageBox.Show("Mãlớp tín chỉ trùng.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                    }
                }
                else
                {

                }
            }
            else if (ketQuaHieuChinh == 1) // sau thoi gian dki
            {
                if (serverHienTai.Equals(Program.serverNameConLai))
                {
                    if (Program.KetNoi(Program.connstrConLai) == 0) return;
                }
                else
                {
                    if (Program.KetNoi(Program.connstr) == 0) return;
                }
                string strLenh = "EXEC SP_CHECKCHOPHEPHIEUCHINHLOPTC @maLop = " + lblMaLopTinChi.Text.Trim();
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int ketQua = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                Program.conn.Close();
                //neu chua nhap diem
                if (ketQua == 1)
                {
                    if (heSoCcSpinEdit.Enabled == true)
                    {
                        if (kiemTraThemLopTinChi()) return;

                        if (serverHienTai.Equals(Program.serverNameConLai))
                        {
                            if (Program.KetNoi(Program.connstrConLai) == 0) return;
                        }
                        else
                        {
                            if (Program.KetNoi(Program.connstr) == 0) return;
                        }
                        strLenh = "EXEC SP_DEMSODKI @maLop = " + lblMaLopTinChi.Text.Trim();
                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        Program.myReader.Read();
                        ketQua = Program.myReader.GetInt32(0);
                        Program.myReader.Close();
                        Program.conn.Close();

                        if (ketQua <= soSvToiThieuSpinEdit.Value)
                        {
                            lblMaNhanVien.Text = Program.mloginDN;
                            try
                            {
                                lopTinChiBDS.EndEdit();
                                lopTinChiBDS.ResetCurrentItem();
                                if (DSMLC.HasChanges())
                                {
                                    this.lopTinChiTableAdapter.Update(this.DSMLC.LOP_TIN_CHI);
                                }

                                barBtnTaiLai.PerformClick();
                                MessageBox.Show("Sửa lớp thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                if (ex.Message.Contains("PRIMARY"))
                                {
                                    MessageBox.Show("Mãlớp tín chỉ trùng.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                                }
                                else
                                    MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số sinh viên tối thiểu chưa đủ so với số lượng đã đăng kí: " + ketQua + " sinh viên", "Báo lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Đã nhập điểm, không thể chỉnh sửa", "Báo lỗi niên khóa học kỳ", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ngoài thời gian cho phép chỉnh sửa lớp của niên khóa học kỳ", "Báo lỗi niên khóa học kỳ", MessageBoxButtons.OK);
                return;
            }
        }

        private void barBtnThemGiang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ketQuaHieuChinh = kiemTraChoPhepHieuChinh();
            if (ketQuaHieuChinh == -1)// truoc ngày dki
            {
                if (giangVienBDS.Count > 0)
                {
                    barBtnHieuChinh.Enabled = barBtnThemGiang.Enabled = false;
                    barBtnGhi.Enabled = true;
                    heSoCcSpinEdit.Enabled = heSoCkSpinEdit.Enabled = heSoGkSpinEdit.Enabled = soSvToiThieuSpinEdit.Enabled = huyCheckEdit.Enabled = false;
                    cboMaGiangVien.Enabled = thuSpinEdit.Enabled = tietBatDauSpinEdit.Enabled = true;


                    giangBDS.AddNew();
                    lblMaLopTinChi2.Text = lblMaLopTinChi.Text.Trim();
                    thuSpinEdit.Value = 2;
                    tietBatDauSpinEdit.Value = 1;
                    lblMaGiangVien.Text = cboMaGiangVien.SelectedValue.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ngoài thời gian cho phép thêm giảng của niên khóa học kỳ", "Báo lỗi niên khóa học kỳ", MessageBoxButtons.OK);
                return;
            }
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
