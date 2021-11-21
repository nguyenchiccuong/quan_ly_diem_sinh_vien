using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class Frm_BAOCAO_BDTK : DevExpress.XtraEditors.XtraForm
    {
        string makhoa = "";
        public Frm_BAOCAO_BDTK()
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

        private void Frm_BAOCAO_BDTK_Load(object sender, EventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLop.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mã lớp", "", MessageBoxButtons.OK);
                    tbLop.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (Program.KetNoi() == 0)
                {

                    return;
                }
                string strLenh = "Select TEN_LOP,NAM_NHAP_HOC FROM LOP WHERE MA_LOP=N'" + tbLop.Text.Trim()+"'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                string tenlop = Program.myReader.GetString(0);
                int nam = Program.myReader.GetInt16(1);
                Program.conn.Close();


                string malop = tbLop.Text.Trim();
                Xrpt_BAOCAO_BDTK rpt = new Xrpt_BAOCAO_BDTK(malop);
                rpt.lbLop.Text = "LỚP : " + tenlop +" - KHÓA : "+nam;
                rpt.lbKhoa.Text ="KHOA : "+cboKhoa.Text;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy lớp vui lòng kiểm tra lại \n " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
        }
    }
}