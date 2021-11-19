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
    public partial class Frm_BAOCAO_DSSV : DevExpress.XtraEditors.XtraForm
    {
        string makhoa = "";
        public Frm_BAOCAO_DSSV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_BAOCAO_DSSV_Load(object sender, EventArgs e)
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
            if (String.Compare(Program.mGroup.Trim(), "PGV", true) == 0) cboKhoa.Enabled = true;
            else cboKhoa.Enabled = false;

            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT MA_LOP,TEN_LOP From LOP", Program.connstr);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                cboLop.DataSource = dt1;
                cboLop.ValueMember = "MA_LOP";
                cboLop.DisplayMember = "TEN_LOP";
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

                            SqlDataAdapter da1 = new SqlDataAdapter("SELECT MA_LOP,TEN_LOP From LOP", Program.connstr);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            cboLop.DataSource = dt1;
                            cboLop.ValueMember = "MA_LOP";
                            cboLop.DisplayMember = "TEN_LOP";
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

                            SqlDataAdapter da1 = new SqlDataAdapter("SELECT MA_LOP,TEN_LOP From LOP", Program.connstr);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            cboLop.DataSource = dt1;
                            cboLop.ValueMember = "MA_LOP";
                            cboLop.DisplayMember = "TEN_LOP";
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
                if (cboLop.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn lớp", "", MessageBoxButtons.OK);
                    cboLop.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }



                string malop = cboLop.SelectedValue.ToString().Trim();
                Xrpt_BAOCAO_DSSV rpt = new Xrpt_BAOCAO_DSSV(malop);
                rpt.lbLop.Text = "LỚP : " + cboLop.Text;
                
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
    }
}