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
    public partial class Frm_BAOCAO_PHIEUDIEM : DevExpress.XtraEditors.XtraForm
    {
        string makhoa = "";
        public Frm_BAOCAO_PHIEUDIEM()
        {
            InitializeComponent();
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
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_BAOCAO_PHIEUDIEM_Load(object sender, EventArgs e)
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
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaSV.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mã số sinh viên", "", MessageBoxButtons.OK);
                    tbMaSV.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                string masv = tbMaSV.Text.Trim();
                string strLenh = "SELECT HO,TEN,TEN_LOP FROM LINK0.QLDSV_TC.dbo.SINH_VIEN, LINK0.QLDSV_TC.dbo.LOP WHERE SINH_VIEN.MA_LOP=LOP.MA_LOP AND MA_SV='" + masv + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                string ho = Program.myReader.GetString(0);
                string ten = Program.myReader.GetString(1);
                string tenLop = Program.myReader.GetString(2);
                Program.conn.Close();
                Xrpt_BAOCAO_PHIEUDIEM rpt = new Xrpt_BAOCAO_PHIEUDIEM(masv);
                rpt.lbSV.Text = "Mã Sinh Viên : " + tbMaSV.Text+ " - Họ và tên : "+ho+' '+ten;
                rpt.lbLK.Text = "Lớp : " + tenLop ;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy mã sinh viên vui lòng kiểm tra lại thông tin để in báo cáo \n " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
        }
    }
}