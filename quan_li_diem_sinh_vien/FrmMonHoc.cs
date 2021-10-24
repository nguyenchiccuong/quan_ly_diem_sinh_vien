using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmMonHoc : Form
    {
        int viTri = -1;
        String tenMHBanDau;
        Stack<String> myStack = new Stack<String>();
        String lenhUpdate;
        String lenhThem;

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

            cboKhoa.DataSource = Program.bdsDSPM;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";

            int index = cboKhoa.FindStringExact(Program.mChinhanh);
            cboKhoa.SelectedIndex = index;

            barBtnHieuChinh.Enabled = barBtnGhi.Enabled = barBtnXoa.Enabled = barBtnPhucHoi.Enabled = false;
            maMHTextEdit.Enabled = tenMHTextEdit.Enabled = soTietLTSpinEdit.Enabled = soTietThucHanhSpinEdit.Enabled = false;
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.monHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.monHocTableAdapter.Fill(this.DSMHC.MON_HOC);
            this.keHoachGiangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.keHoachGiangTableAdapter.Fill(this.DSMHC.KE_HOACH_GIANG);
            this.khaNangGiangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khaNangGiangTableAdapter.Fill(this.DSMHC.KHA_NANG_GIANG);
            this.LopTinChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTinChiTableAdapter.Fill(this.DSMHC.LOP_TIN_CHI);
            if (viTri != -1)
                monHocBDS.Position = viTri;
            else
                viTri = monHocBDS.Position;

            maMHTextEdit.Enabled = false;

            barBtnHieuChinh.Enabled = barBtnGhi.Enabled = barBtnXoa.Enabled = barBtnPhucHoi.Enabled = false;
            barBtnThem.Enabled = true;
            maMHTextEdit.Enabled = tenMHTextEdit.Enabled = soTietLTSpinEdit.Enabled = soTietThucHanhSpinEdit.Enabled = false;

            monHocGridControl.Enabled = true;

            if (myStack.Count > 0) barBtnPhucHoi.Enabled = true;
            else barBtnPhucHoi.Enabled = false;
        }

        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            String lenh = myStack.Peek();
            if (Program.ExecSqlNonQuery(lenh) == 0)
            {
                myStack.Pop();
                barBtnTaiLai.PerformClick();
            }
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn xóa môn học " + tenMHTextEdit.Text + " (mã: " + maMHTextEdit.Text.Trim() + ")", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    monHocBDS.RemoveCurrent();
                    this.monHocTableAdapter.Update(this.DSMHC.MON_HOC);
                    myStack.Push(lenhThem);
                    viTri = -1;
                    barBtnTaiLai.PerformClick();
                    MessageBox.Show("Xóa môn học thành công", "Thông báo", MessageBoxButtons.OK);

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
            if (tonTaiThemMonHoc()) return;

            try
            {
                monHocBDS.EndEdit();
                monHocBDS.ResetCurrentItem();
                if (DSMHC.HasChanges())
                {
                    this.monHocTableAdapter.Update(this.DSMHC);
                }

                viTri = monHocBDS.Position;
                String lenh = "DELETE FROM MON_HOC WHERE MA_MH = '" + maMHTextEdit.Text.Trim() + "'";
                myStack.Push(lenh);
                barBtnTaiLai.PerformClick();
                MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã môn học hoặc tên trùng.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                    maMHTextEdit.Focus();
                }
                else
                    MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
            }
        }

        public bool kiemTraRong()
        {
            if (maMHTextEdit.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Không để mã môn học rỗng", "Báo lỗi", MessageBoxButtons.OK);
                maMHTextEdit.Focus(); // dua con tro ve vi tri form dang nhap
                return true;
            }
            if (tenMHTextEdit.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Không để tên môn học rỗng", "Báo lỗi", MessageBoxButtons.OK);
                tenMHTextEdit.Focus(); // dua con tro ve vi tri form dang nhap
                return true;
            }
            if (soTietLTSpinEdit.Value + soTietLTSpinEdit.Value == 0)
            {
                MessageBox.Show("Tổng số tiết cần lớn hơn 0", "Báo lỗi", MessageBoxButtons.OK);
                tenMHTextEdit.Focus(); // dua con tro ve vi tri form dang nhap
                return true;
            }
            return false;
        }

        private bool tonTaiThemMonHoc()
        {
            maMHTextEdit.Text = Program.xoaSpaceID(maMHTextEdit.Text.Trim().ToUpper());
            tenMHTextEdit.Text = Program.xoaSpaceChuoi(tenMHTextEdit.Text.Trim().ToUpper());
            BindingSource bdsMonHocTemp = new BindingSource(monHocBDS.DataSource, monHocBDS.DataMember);
            DataView dt = (DataView)bdsMonHocTemp.List;
            dt.Sort = "MA_MH";
            if (dt.FindRows(maMHTextEdit.Text).Length != 0)
            {
                MessageBox.Show("Mã môn học trùng", "Báo lỗi", MessageBoxButtons.OK);
                maMHTextEdit.Focus();
                return true; //da ton tai
            }
            dt.Sort = "TEN_MH";
            if (dt.FindRows(tenMHTextEdit.Text).Length != 0)
            {
                MessageBox.Show("Tên môn học trùng", "Báo lỗi", MessageBoxButtons.OK);
                tenMHTextEdit.Focus();
                return true; //da ton tai
            }
            return false; // chua ton tai
        }

        private void barBtnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraRong()) return;
            if (tonTaiSuaMonHoc()) return;
            try
            {
                monHocBDS.EndEdit();
                monHocBDS.ResetCurrentItem();
                if (DSMHC.HasChanges())
                {
                    this.monHocTableAdapter.Update(this.DSMHC.MON_HOC);
                }
                myStack.Push(lenhUpdate);
                barBtnTaiLai.PerformClick();
                MessageBox.Show("Sửa môn học thành công", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã môn học trùng.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
                    maMHTextEdit.Focus();
                }
                else
                    MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi.\n" + ex.Message, "Báo lỗi", MessageBoxButtons.OK);
            }
        }

        public bool tonTaiSuaMonHoc()
        {
            tenMHTextEdit.Text = Program.xoaSpaceChuoi(tenMHTextEdit.Text.Trim().ToUpper());
            BindingSource bdsMonHocTemp = new BindingSource(monHocBDS.DataSource, monHocBDS.DataMember);
            DataView dt = (DataView)bdsMonHocTemp.List;
            dt.Sort = "TEN_MH";
            if (dt.FindRows(tenMHTextEdit.Text).Length == 1 && !tenMHTextEdit.Text.Equals(tenMHBanDau))
            {
                MessageBox.Show("Tên môn học trùng", "Báo lỗi", MessageBoxButtons.OK);
                tenMHTextEdit.Focus();
                return true; //da ton tai
            }
            return false; // chua ton tai
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnThem.Enabled = false;
            barBtnGhi.Enabled = true;
            maMHTextEdit.Enabled = tenMHTextEdit.Enabled = soTietLTSpinEdit.Enabled = soTietThucHanhSpinEdit.Enabled = true;

            monHocBDS.AddNew();
            monHocGridControl.Enabled = false;
            soTietLTSpinEdit.Value = soTietThucHanhSpinEdit.Value = 0;
        }

        private void monHocGridControl_DoubleClick(object sender, EventArgs e)
        {
            tenMHTextEdit.Enabled = soTietLTSpinEdit.Enabled = soTietThucHanhSpinEdit.Enabled = true;
            barBtnThem.Enabled = false;
            barBtnHieuChinh.Enabled = true;
            if (!tonTaiXoaMonHoc()) barBtnXoa.Enabled = true;
            monHocGridControl.Enabled = false;
            tenMHBanDau = tenMHTextEdit.Text;
            viTri = monHocBDS.Position;

            lenhThem = "INSERT INTO MON_HOC (MA_MH, TEN_MH, SO_TIET_LT, SO_TIET_TH) VALUES('" + maMHTextEdit.Text.Trim() + "', '" + tenMHTextEdit.Text.Trim() + "', " + soTietLTSpinEdit.Value + ", " + soTietThucHanhSpinEdit.Value + ") ";
            lenhUpdate = "UPDATE MON_HOC SET TEN_MH = '" + tenMHTextEdit.Text.Trim() + "', SO_TIET_LT = " + soTietLTSpinEdit.Value + ", SO_TIET_TH = " + soTietThucHanhSpinEdit.Value + " WHERE MA_MH = '" + maMHTextEdit.Text.Trim() + "'";
        }

        public bool tonTaiXoaMonHoc()
        {
            if (lopTinChiBDS.Count > 0 || khaNangGiangBDS.Count > 0 || keHoachGiangBDS.Count > 0) return true; //da ton tai
            return false; // chua ton tai
        }
    }
}
