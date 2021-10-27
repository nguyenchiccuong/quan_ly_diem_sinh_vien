using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmDkiGiangVien : Form
    {
        int viTri = -1;
        String serverHienTai = "";

        public FrmDkiGiangVien()
        {
            InitializeComponent();
        }

        private void FrmDkiGiangVien_Load(object sender, EventArgs e)
        {
            DSGVDKC.EnforceConstraints = false;
            this.giangVienTableAdapter.Connection.ConnectionString = Program.connstr;

            BindingSource bdsKHoaTemp = new BindingSource(Program.bdsDSPM.DataSource, Program.bdsDSPM.DataMember);
            cboKhoa.DataSource = bdsKHoaTemp;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedIndex = 1;
            cboKhoa.SelectedIndex = 0;

            serverHienTai = Program.servername;

            int index = cboKhoa.FindStringExact(Program.mChinhanh);
            cboKhoa.SelectedIndex = index;

            barBtnTaoTk.Enabled = false;
            matKhauTextEdit.Enabled = lapLaiMatKhauTextEdit.Enabled = false;

            if (serverHienTai.Equals(Program.serverNameConLai))
            {
                if (Program.KetNoi(Program.connstrConLai) == 0) return;
            }
            else
            {
                if (Program.KetNoi(Program.connstr) == 0) return;
            }
            string strLenh = "EXEC SP_GIANGVIENKHONGTAIKHOAN";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            int dem = 0;
            String dieuKien = "";
            while (Program.myReader.Read())
            {
                if (dem++ == 0)
                {
                    dieuKien += "MA_GV = '" + Program.myReader.GetString(0) + "'";
                }
                else
                {
                    dieuKien += "OR MA_GV = '" + Program.myReader.GetString(0) + "'";
                }
            }
            Program.myReader.Close();
            Program.conn.Close();
            if (dem > 0)
            {
                giangVienBDS.Filter = dieuKien;
            }
            else
            {
                giangVienBDS.Filter = "MA_GV = ''";
            }
            this.giangVienTableAdapter.Fill(this.DSGVDKC.GIANG_VIEN);
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serverHienTai.Equals(cboKhoa.SelectedValue.ToString()) && serverHienTai != "")
            {
                DSGVDKC.EnforceConstraints = false;
                serverHienTai = cboKhoa.SelectedValue.ToString();
                if (serverHienTai.Equals(Program.serverNameConLai))
                {
                    this.giangVienTableAdapter.Connection.ConnectionString = Program.connstrConLai;
                }
                else
                {
                    this.giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
                }
                viTri = -1;
                barBtnTaiLai.PerformClick();
            }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (serverHienTai.Equals(Program.serverNameConLai))
            {
                if (Program.KetNoi(Program.connstrConLai) == 0) return;
            }
            else
            {
                if (Program.KetNoi(Program.connstr) == 0) return;
            }
            string strLenh = "EXEC SP_GIANGVIENKHONGTAIKHOAN";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            int dem = 0;
            String dieuKien = "";
            while (Program.myReader.Read())
            {
                if (dem++ == 0)
                {
                    dieuKien += "MA_GV = '" + Program.myReader.GetString(0) + "'";
                }
                else
                {
                    dieuKien += "OR MA_GV = '" + Program.myReader.GetString(0) + "'";
                }
            }
            Program.myReader.Close();
            Program.conn.Close();
            if (dem > 0)
            {
                giangVienBDS.Filter = dieuKien;
            }
            else
            {
                giangVienBDS.Filter = "MA_GV = ''";
            }
            this.giangVienTableAdapter.Fill(this.DSGVDKC.GIANG_VIEN);

            if (viTri != -1)
                giangVienBDS.Position = viTri;
            else
                viTri = giangVienBDS.Position;

            giangVienGridControl.Enabled = true;
            barBtnTaoTk.Enabled = false;
            matKhauTextEdit.Enabled = lapLaiMatKhauTextEdit.Enabled = false;

            matKhauTextEdit.Text = lapLaiMatKhauTextEdit.Text = "";
        }

        private void giangVienGridControl_DoubleClick(object sender, EventArgs e)
        {
            matKhauTextEdit.Enabled = lapLaiMatKhauTextEdit.Enabled = true;
            giangVienGridControl.Enabled = false;
            barBtnTaoTk.Enabled = true;

            viTri = giangVienBDS.Position;
        }

        private void barBtnTaoTk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Regex.Match(matKhauTextEdit.Text, "[\\s]+").Success)
            {
                MessageBox.Show("Mật khẩu không chứa khoảng trắng", "Báo lỗi", MessageBoxButtons.OK);
                return;
            }
            if (matKhauTextEdit.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Báo lỗi", MessageBoxButtons.OK);
                return;
            }
            if (!matKhauTextEdit.Text.Equals(lapLaiMatKhauTextEdit.Text))
            {
                MessageBox.Show("2 mật khẩu không trùng nhau", "Báo lỗi", MessageBoxButtons.OK);
                return;
            }
            string strLenh = "EXEC SP_TAOTAIKHOAN @LGNAME = N'" + lblMaGiangVien1.Text.Trim() + "', @PASS = N'" + matKhauTextEdit.Text + "', @USERNAME = N'" + lblMaGiangVien1.Text.Trim() + "', @ROLE = N'KHOA'";
            try
            {
                if (serverHienTai.Equals(Program.serverNameConLai))
                {
                    if (Program.KetNoi(Program.connstrConLai) == 0) return;
                }
                else
                {
                    if (Program.KetNoi(Program.connstr) == 0) return;
                }

                if (Program.ExecSqlNonQuery(strLenh) == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
                    barBtnTaiLai.PerformClick();
                }
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
}
