using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmDangNhap : Form
    {
        private SqlConnection connPublisher = new SqlConnection();

        private void layDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (connPublisher.State == ConnectionState.Closed) connPublisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            da.Fill(dt);
            connPublisher.Close();
            Program.bdsDSPM.DataSource = dt;
            cboKhoa.DataSource = Program.bdsDSPM;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
        }

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.frmMain.Close();
        }

        private int ketNoiCSDLGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (ketNoiCSDLGoc() == 0) return;
            layDSPM("SELECT * FROM V_DS_PHANMANH");
            cboKhoa.SelectedIndex = 1;
            cboKhoa.SelectedIndex = 0;
        }



        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cboKhoa.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            txbTenDangNhap.Text = Program.xoaSpaceID(txbTenDangNhap.Text);

            if (txbTenDangNhap.Text == "")
            {

                MessageBox.Show("Không để tên đăng nhập rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txbTenDangNhap.Focus(); // dua con tro ve vi tri form dang nhap
                return;
            }
            if (txbMatKhau.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được tồn tại khoảng trắng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txbMatKhau.Focus(); // dua con tro ve vi tri form dang nhap
                return;
            }

            if (txbMatKhau.Text != "") // pgv va giang viên
            {
                Program.mlogin = txbTenDangNhap.Text;
                Program.password = txbMatKhau.Text;

                if (Program.KetNoi() == 0)
                {
                    //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                    return;
                }

                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                string strLenh = null;
                if (Program.mloginDN.Contains("PGV"))
                {
                    strLenh = "EXEC SP_DANGNHAPPGV '" + Program.mloginDN + "'";
                }
                else
                {
                    strLenh = "EXEC SP_DANGNHAPGIANGVIEN '" + Program.mloginDN + "'";
                }

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read(); //doc 1 dong, tra ve trang thái cau lenh, true doc duoc, false ko, neu niheu de torng vong while

                if (Program.myReader.IsDBNull(1))
                {
                    if (Program.mloginDN.Contains("PGV"))
                    {
                        MessageBox.Show("Nhân viên không tồn tại.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Giảng viên không tồn tại.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                        return;
                    }
                }

                Program.username = Program.myReader.GetString(0);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    if (Program.mloginDN.Contains("PGV"))
                    {
                        MessageBox.Show("Nhân viên không tồn tại.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Giảng viên không tồn tại.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                        return;
                    }
                }

                Program.mHoten = Program.myReader.GetString(1); // doc cột 1
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                if (Program.mloginDN.Contains("PGV"))
                {
                    Program.frmMain.sttMaNV.Text = "Mã nhân vien: " + Program.username;
                }
                else
                {
                    Program.frmMain.sttMaNV.Text = "Mã giảng viên: " + Program.username;
                }
            }
            else
            {
                Program.mlogin = "SV";
                Program.password = "123456";

                if (Program.KetNoi() == 0)
                {
                    //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                    return;
                }

                Program.mloginDN = txbTenDangNhap.Text;
                Program.passwordDN = "";

                string strLenh = "EXEC SP_DANGNHAPSINHVIEN '" + Program.mloginDN + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read(); //doc 1 dong, tra ve trang thái cau lenh, true doc duoc, false ko, neu niheu de torng vong while

                if (Program.myReader.IsDBNull(1))
                {
                    MessageBox.Show("Sinh viên không tồn tại.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                    return;
                }
                Program.username = Program.myReader.GetString(1);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Sinh viên không tồn tại.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                    return;
                }

                Program.mHoten = Program.myReader.GetString(1); // doc cột 1
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                Program.frmMain.sttMaNV.Text = "Mã sinh viên: " + Program.mloginDN;
            }

            Program.mChinhanh = ((DataRowView)cboKhoa.SelectedItem).Row.ItemArray[0].ToString();
            int index = cboKhoa.FindStringExact(Program.mChinhanh);
            if (index == 1) index = 0;
            else index = 1;
            cboKhoa.SelectedIndex = index;
            Program.serverNameConLai = cboKhoa.SelectedValue.ToString();
            Program.connstrConLai = "Data Source=" + Program.serverNameConLai + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.remotelogin + ";password=" + Program.remotepassword;
            if (index == 1) index = 0;
            else index = 1;
            cboKhoa.SelectedIndex = index;

            Program.frmMain.sttHoTen.Text = "Họ tên: " + Program.mHoten;
            Program.frmMain.sttNhom.Text = "Nhóm: " + Program.mGroup;
            Program.frmMain.sttKhoa.Text = "Khoa: " + Program.mChinhanh;

            Program.frmMain.barBtnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            Program.frmMain.barBtnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            if (Program.mGroup == "PGV")
            {
                Program.frmMain.ribbonPagePGV.Visible = true;
            }
            else if (Program.mGroup == "KHOA")
            {
                Program.frmMain.ribbonPageGV.Visible = true;
            }
            else
            {
                Program.frmMain.ribbonPageSV.Visible = true;
                Program.frmMain.ribbonPageGroupBc1.Visible = false;
                Program.frmMain.ribbonPageGroupBc2.Visible = false;
                Program.frmMain.ribbonPageGroupBc3.Visible = false;
                Program.frmMain.ribbonPageGroupBc4.Visible = false;
                Program.frmMain.ribbonPageGroupBc6.Visible = false;
            }
            Program.frmMain.ribbonPageBaoCao.Visible = true;
            Close();

        }
    }
}
