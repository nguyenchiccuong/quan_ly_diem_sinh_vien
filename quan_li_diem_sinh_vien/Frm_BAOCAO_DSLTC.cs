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
    public partial class Frm_BAOCAO_DSLTC : DevExpress.XtraEditors.XtraForm
    {
        int nienkhoa = DateTime.Now.Year+1;
        int sonienkhoa = 5;
        int sohocky = 3;
        int hocky = 1;
        string makhoa = "";
        public Frm_BAOCAO_DSLTC()
        {
            InitializeComponent();
        }

        private void Frm_BAOCAO_DSLTC_Load(object sender, EventArgs e)
        {
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
                cboNK.Items.Add((tempnk-1)+"-"+nienkhoa.ToString());
                nienkhoa--;
            }
            while (hocky <= sohocky)
            {
                cboHK.Items.Add(hocky.ToString());
                hocky++;
            }
            if (String.Compare(Program.mGroup.Trim(), "PGV", true) == 0) cboKhoa.Enabled = true;
            else cboKhoa.Enabled = false;
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cboHK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn học kỳ", "", MessageBoxButtons.OK);
                cboHK.Focus(); // dua con tro ve vi tri form dang nhap
                return;
            }
            if (cboNK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn niên khóa", "", MessageBoxButtons.OK);
                cboNK.Focus(); // dua con tro ve vi tri form dang nhap
                return;
            }
            Xrpt_BAOCAO_DSLTC rpt = new Xrpt_BAOCAO_DSLTC(cboNK.Text.Trim(), int.Parse(cboHK.Text));

            rpt.lbTieuDe.Text = "KHOA : " +cboKhoa.Text;
            rpt.lbHocKy.Text = cboHK.Text.Trim();
            rpt.lbNienKhoa.Text = cboNK.Text.Trim();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}