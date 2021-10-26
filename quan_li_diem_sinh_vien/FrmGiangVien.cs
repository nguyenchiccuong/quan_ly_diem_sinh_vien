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
        String serverHienTai = "";

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

            if (Program.mChinhanh.Equals("Công Nghệ Thông Tin"))
                giangVienBDS.Filter = "MA_KHOA = 'CNTT'";
            else
                giangVienBDS.Filter = "MA_KHOA = 'VT'";


            this.giangVienTableAdapter.Fill(this.DSGVC.GIANG_VIEN);
            this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangTableAdapter.Fill(this.DSGVC.GIANG);
            this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khaNangGiangTableAdapter.Fill(this.DSGVC.KHA_NANG_GIANG);
            this.quanLyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.quanLyTableAdapter.Fill(this.DSGVC.QUAN_LY);

            BindingSource bdsKHoaTemp = new BindingSource(Program.bdsDSPM.DataSource, Program.bdsDSPM.DataMember);
            cboKhoa.DataSource = bdsKHoaTemp;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedIndex = 1;
            cboKhoa.SelectedIndex = 0;

            serverHienTai = Program.servername;

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
            if (!serverHienTai.Equals(cboKhoa.SelectedValue.ToString()) && serverHienTai != "")
            {
                DSGVC.EnforceConstraints = false;
                serverHienTai = cboKhoa.SelectedValue.ToString();
                if (serverHienTai.Equals(Program.serverNameConLai))
                {
                    this.giangVienTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                    this.giangTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                    this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                    this.quanLyTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                    if (Program.mChinhanh.Equals("Công Nghệ Thông Tin"))
                        giangVienBDS.Filter = "MA_KHOA = 'VT'";
                    else
                        giangVienBDS.Filter = "MA_KHOA = 'CNTT'";
                }
                else
                {
                    this.giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.giangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.quanLyTableAdapter.Connection.ConnectionString = Program.connstr;
                    if (Program.mChinhanh.Equals("Công Nghệ Thông Tin"))
                        giangVienBDS.Filter = "MA_KHOA = 'CNTT'";
                    else
                        giangVienBDS.Filter = "MA_KHOA = 'VT'";
                }
                viTri = -1;
                myStack = new Stack<String>();
                barBtnTaiLai.PerformClick();
            }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.giangVienTableAdapter.Fill(this.DSGVC.GIANG_VIEN);
            this.giangTableAdapter.Fill(this.DSGVC.GIANG);
            this.khaNangGiangTableAdapter.Fill(this.DSGVC.KHA_NANG_GIANG);
            this.quanLyTableAdapter.Fill(this.DSGVC.QUAN_LY);
            if (viTri != -1)
                giangVienBDS.Position = viTri;
            else
                viTri = giangVienBDS.Position;

            barBtnHieuChinh.Enabled = barBtnGhi.Enabled = barBtnXoa.Enabled = barBtnPhucHoi.Enabled = false;
            barBtnThem.Enabled = true;
            hoTextEdit.Enabled = tenTextEdit.Enabled = hocViTextEdit.Enabled = hocHamTextEdit.Enabled = chuyenMonTextEdit.Enabled = false;

            giangVienGridControl.Enabled = true;

            if (myStack.Count > 0) barBtnPhucHoi.Enabled = true;
            else barBtnPhucHoi.Enabled = false;
        }

        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (serverHienTai.Equals(Program.serverNameConLai))
            {
                if (Program.KetNoi(Program.connstrConLai) == 0) return;
            }
            else
            {
                if (Program.KetNoi(Program.connstr) == 0) return;
            }
            String lenh = myStack.Peek();
            if (Program.ExecSqlNonQuery(lenh) == 0)
            {
                myStack.Pop();
                barBtnTaiLai.PerformClick();
            }
            Program.conn.Close();
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn xóa giáo viên " + hoTextEdit.Text.Trim() + " " + tenTextEdit.Text.Trim() + " (mã: " + lblMaGiangVien1.Text.Trim() + ")", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    giangVienBDS.RemoveCurrent();
                    this.giangVienTableAdapter.Update(this.DSGVC.GIANG_VIEN);
                    myStack.Push(lenhThem);
                    viTri = -1;
                    barBtnTaiLai.PerformClick();
                    MessageBox.Show("Xóa giảng viên thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa, vui lòng thử lại sau.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraRong()) return;

            if (serverHienTai.Equals(Program.serverNameConLai))
            {
                if (Program.KetNoi(Program.connstrConLai) == 0) return;
            }
            else
            {
                if (Program.KetNoi(Program.connstr) == 0) return;
            }
            string strLenh = "EXEC SP_XINMAGIANGVIEN";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int maGV = Program.myReader.GetInt16(0);
            Program.myReader.Close();
            Program.conn.Close();
            lblMaGiangVien1.Text = "TH" + maGV.ToString("D4");

            try
            {
                giangVienBDS.EndEdit();
                giangVienBDS.ResetCurrentItem();
                if (DSGVC.HasChanges())
                {
                    this.giangVienTableAdapter.Update(this.DSGVC.GIANG_VIEN);
                }

                viTri = giangVienBDS.Position;
                String lenh = "DELETE FROM GIANG_VIEN WHERE MA_GV = '" + lblMaGiangVien1.Text.Trim() + "'";
                myStack.Push(lenh);
                barBtnTaiLai.PerformClick();
                MessageBox.Show("Thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã giảng viên trùng.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
            }
        }

        public bool kiemTraRong()
        {
            if (hoTextEdit.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Không để họ rỗng", "Báo lỗi", MessageBoxButtons.OK);
                hoTextEdit.Focus(); // dua con tro ve vi tri form dang nhap
                return true;
            }
            if (tenTextEdit.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Không để tên rỗng", "Báo lỗi", MessageBoxButtons.OK);
                tenTextEdit.Focus(); // dua con tro ve vi tri form dang nhap
                return true;
            }
            return false;
        }

        private void barBtnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraRong()) return;
            try
            {
                giangVienBDS.EndEdit();
                giangVienBDS.ResetCurrentItem();
                if (DSGVC.HasChanges())
                {
                    this.giangVienTableAdapter.Update(this.DSGVC.GIANG_VIEN);
                }
                myStack.Push(lenhUpdate);
                barBtnTaiLai.PerformClick();
                MessageBox.Show("Sửa giảng viên thành công", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã giảng viên trùng.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
            }
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnThem.Enabled = false;
            barBtnGhi.Enabled = true;
            hoTextEdit.Enabled = tenTextEdit.Enabled = hocViTextEdit.Enabled = hocHamTextEdit.Enabled = chuyenMonTextEdit.Enabled = true;

            giangVienBDS.AddNew();
            giangVienGridControl.Enabled = false;

            if (serverHienTai.Equals(Program.serverNameConLai))
            {
                if (Program.mChinhanh.Equals("Công Nghệ Thông Tin"))
                    lblMaKhoa1.Text = "VT";
                else
                    lblMaKhoa1.Text = "CNTT";
            }
            else
            {
                if (Program.mChinhanh.Equals("Công Nghệ Thông Tin"))
                    lblMaKhoa1.Text = "CNTT";
                else
                    lblMaKhoa1.Text = "VT";
            }
        }

        private void giangVienGridControl_DoubleClick(object sender, EventArgs e)
        {
            hoTextEdit.Enabled = tenTextEdit.Enabled = hocViTextEdit.Enabled = hocHamTextEdit.Enabled = chuyenMonTextEdit.Enabled = true;
            barBtnThem.Enabled = false;
            barBtnHieuChinh.Enabled = true;
            if (!tonTaiXoaMonHoc()) barBtnXoa.Enabled = true;
            giangVienGridControl.Enabled = false;
            viTri = giangVienBDS.Position;

            lenhThem = "INSERT INTO GIANG_VIEN (MA_GV, HO, TEN, HOC_VI, HOC_HAM, CHUYEN_MON, MA_KHOA) VALUES('" + lblMaGiangVien1.Text.Trim() + "', '" + hoTextEdit.Text.Trim() + "', '" + tenTextEdit.Text.Trim() + "', '" + hocViTextEdit.Text.Trim() + "', '" + hocHamTextEdit.Text.Trim() + "', '" + chuyenMonTextEdit.Text.Trim() + "', '" + lblMaKhoa1.Text.Trim() + "') ";
            lenhUpdate = "UPDATE GIANG_VIEN SET HO = '" + hoTextEdit.Text.Trim() + "', TEN = '" + tenTextEdit.Text.Trim() + "', HOC_VI = '" + hocViTextEdit.Text.Trim() + "', HOC_HAM = '" + hocHamTextEdit.Text.Trim() + "', CHUYEN_MON = '" + chuyenMonTextEdit.Text.Trim() + "' WHERE MA_GV = '" + lblMaGiangVien1.Text.Trim() + "'";
            Console.WriteLine(lenhThem);
            Console.WriteLine(lenhUpdate);
        }

        public bool tonTaiXoaMonHoc()
        {
            if (giangBDS.Count > 0 || khaNangGiangBDS.Count > 0 || quanLyBDS.Count > 0) return true; //da ton tai

            if (serverHienTai.Equals(Program.serverNameConLai))
            {
                if (Program.KetNoi(Program.connstrConLai) == 0) return true;
            }
            else
            {
                if (Program.KetNoi(Program.connstr) == 0) return true;
            }
            string strLenh = "EXEC SP_KIEMTRAXOAGIANGVIEN @MA_GV = '" + lblMaGiangVien1.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int ketQua = Program.myReader.GetInt32(0);
            Program.myReader.Close();
            Program.conn.Close();
            Console.WriteLine(ketQua);
            if (ketQua != 0) return true;


            return false; // chua ton tai
        }
    }
}
