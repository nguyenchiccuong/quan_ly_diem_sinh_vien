using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class Frm_BAOCAO_BANGDIEM : DevExpress.XtraEditors.XtraForm
    {
        int nienkhoa = DateTime.Now.Year + 1;
        int sonienkhoa = 5;
        int sohocky = 3;
        int hocky = 1;
        string makhoa = "";
        int maltc = 0;
        public Frm_BAOCAO_BANGDIEM()
        {
            InitializeComponent();
        }

        private void Frm_BAOCAO_BANGDIEM_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0)
            {
                //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                return;
            }
            if (Program.mChinhanh == "Công Nghệ Thông Tin")
            {
                makhoa = "CNTT";
            }
            if (Program.mChinhanh == "Viễn Thông")
            {
                makhoa = "VT";
            }
            BindingSource bdsKHoaTemp = new BindingSource(Program.bdsDSPM.DataSource, Program.bdsDSPM.DataMember);
            cboKhoa.DataSource = bdsKHoaTemp;
            cboKhoa.DataSource = Program.bdsDSPM;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedText = Program.mChinhanh.ToString();
            int index = cboKhoa.FindStringExact(Program.mChinhanh);
            cboKhoa.SelectedIndex = index;
            while (nienkhoa >= DateTime.Now.Year - sonienkhoa)
            {
                int tempnk = nienkhoa;
                cboNK.Items.Add((tempnk - 1) + "-" + nienkhoa.ToString());
                nienkhoa--;
            }
            while (hocky <= sohocky)
            {
                cboHK.Items.Add(hocky.ToString());
                hocky++;
            }
            if (String.Compare(Program.mGroup.Trim(), "PGV", true) == 0) cboKhoa.Enabled = true;
            else cboKhoa.Enabled = false;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MA_MH,TEN_MH From MON_HOC", Program.connstr);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboMonHoc.DataSource = dt;
                cboMonHoc.ValueMember = "MA_MH";
                cboMonHoc.DisplayMember = "TEN_MH";
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT NHOM From LOP_TIN_CHI GROUP BY NHOM", Program.connstr);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                cboNhom.DataSource = dt1;
                cboNhom.ValueMember = "NHOM";
                cboNhom.DisplayMember = "NHOM";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cboKhoa.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                //if(cboKhoa.SelectedValue.ToString().Equals("DESKTOP-IO7NSFT\\SERVER1") || cboKhoa.SelectedValue.ToString().Equals("DESKTOP-IO7NSFT\\SERVER2"))
                {

                    if (cboKhoa.SelectedValue.ToString() == Program.servernameRoot)
                    {

                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                        Program.servername = Program.servernameRoot;
                        Program.mChinhanh = cboKhoa.Text.Trim();
                        if (Program.KetNoi() == 0)
                        {
                            //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                            return;
                        }
                        try
                        {

                            SqlDataAdapter da1 = new SqlDataAdapter("SELECT NHOM From LOP_TIN_CHI GROUP BY NHOM", Program.connstr);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            cboNhom.DataSource = dt1;
                            cboNhom.ValueMember = "NHOM";
                            cboNhom.DisplayMember = "NHOM";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
                        }
                        finally
                        {
                            Program.conn.Close();
                        }
                    }
                    else
                    {
                        Program.mlogin = Program.remotelogin;
                        Program.password = Program.remotepassword;
                        Program.servername = cboKhoa.SelectedValue.ToString();
                        Program.mChinhanh = cboKhoa.Text.Trim();

                        if (Program.KetNoi() == 0)
                        {
                            //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                            return;
                        }
                        try
                        {

                            SqlDataAdapter da1 = new SqlDataAdapter("SELECT NHOM From LOP_TIN_CHI GROUP BY NHOM", Program.connstr);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            cboNhom.DataSource = dt1;
                            cboNhom.ValueMember = "NHOM";
                            cboNhom.DisplayMember = "NHOM";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
                        }
                        finally
                        {
                            Program.conn.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNK.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn niên khóa", "", MessageBoxButtons.OK);
                    cboNK.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (cboHK.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn học kỳ", "", MessageBoxButtons.OK);
                    cboHK.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (Program.KetNoi() == 0)
                {

                    return;
                }
                string strLenh = "exec SP_Search_MaLTC " + cboNK.Text.Trim().Substring(0, 4) + "," + cboHK.Text.Trim() + ",'" + cboMonHoc.SelectedValue.ToString().Trim() + "'," + cboNhom.Text.Trim();

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                maltc = Program.myReader.GetInt32(0);
                Program.conn.Close();


                Xrpt_BAOCAO_BANGDIEM rpt = new Xrpt_BAOCAO_BANGDIEM(maltc);
                rpt.lbTieuDe.Text = "KHOA : " + cboKhoa.Text;
                rpt.lbHocKy.Text = cboHK.Text.Trim();
                rpt.lbNienKhoa.Text = cboNK.Text.Trim();
                rpt.lbMonHoc.Text = "Môn Học : " + cboMonHoc.Text + " - Nhóm : " + cboNhom.Text;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Môn học chưa được mở lớp tín chỉ vui lòng mở lớp tín chỉ hoặc kiểm tra lại thông tin để in báo cáo \n " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}