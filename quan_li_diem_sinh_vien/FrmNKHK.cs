using DevExpress.XtraEditors;
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
    public partial class FrmNKHK : DevExpress.XtraEditors.XtraForm
    {
        string makhoa = "";
        string mankhk = "";
        int nienkhoa = DateTime.Now.Year;
        int sonienkhoa = 5;
        int sohocky = 3;
        int hocky = 1;
        int vitri = 0;
        int thuchien = 1;
        public FrmNKHK()
        {
            InitializeComponent();
        }

        private void nIEN_KHOA_HOC_KYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNKHK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmNKHK_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.NIEN_KHOA_HOC_KYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NIEN_KHOA_HOC_KYTableAdapter.Fill(this.DS.NIEN_KHOA_HOC_KY);

            while (nienkhoa >= DateTime.Now.Year - sonienkhoa)
            {
                cboNK.Items.Add(nienkhoa.ToString());
                nienkhoa--;
            }
            while (hocky <= sohocky)
            {
                cboHK.Items.Add(hocky.ToString());
                hocky++;
            }
            dateBD.Properties.MinValue = DateTime.Now;
            dateKT.Properties.MinValue = DateTime.Now;
            if (bdsNKHK.Count > 0) btnSua.Enabled = btnXoa.Enabled = true;
            else btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = false;
            btnThem.Enabled = true;
            panelNKHK.Enabled = false;
        }

        private void nIEN_KHOALabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmNKHK_Load(sender, e);
            }
            catch (Exception)
            { }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNKHK.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            cboHK.Enabled = true;
            cboNK.Enabled = true;
            vitri = bdsNKHK.Position;
            bdsNKHK.AddNew();
            thuchien = 1;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (cboNK.Text.Trim() == "")
                {
                    MessageBox.Show("Không để niên khóa rỗng", "", MessageBoxButtons.OK);
                    cboNK.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (cboHK.Text.Trim() == "")
                {
                    MessageBox.Show("Không để học kỳ rỗng", "", MessageBoxButtons.OK);
                    cboHK.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (dateBD.Text.Trim() == "")
                {
                    MessageBox.Show("Không để ngày bắt đầu rỗng", "", MessageBoxButtons.OK);
                    dateBD.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (dateKT.Text.Trim() == "")
                {
                    MessageBox.Show("Không để ngày kết thúc rỗng", "", MessageBoxButtons.OK);
                    dateKT.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (DateTime.Parse(dateBD.Text) >= DateTime.Parse(dateKT.Text))
                {
                    MessageBox.Show("Ngày kết thúc đăng ký phải lớn hơn ngày bắt đầu đăng ký", "", MessageBoxButtons.OK);
                    dateKT.Focus(); // dua con tro ve vi tri form dang nhap
                    return;
                }
                if (thuchien == 1)
                {
                    string lenh = "INSERT INTO NIEN_KHOA_HOC_KY(NIEN_KHOA , HOC_KY,NGAY_BDAU_DKI,NGAY_KTHUC_DKI)VALUES (" +
                    cboNK.Text.Trim() + "," + cboHK.Text.Trim() + ",'" + dateBD.Text.Trim() + "','" + dateKT.Text.Trim() + "')";
                    if (Program.ExecSqlNonQuery(lenh) != 0)
                    {
                        MessageBox.Show("Thêm Thất Bại \n ", "", MessageBoxButtons.OK);
                    }
                }
                else if (thuchien == 2)
                {
                    string lenh = "UPDATE NIEN_KHOA_HOC_KY SET NGAY_BDAU_DKI='" + dateBD.Text.Trim() + "', NGAY_KTHUC_DKI= '" + dateKT.Text.Trim() + "' WHERE MA_NK_HK=" + tbMaNKHK.Text.Trim();
                    if (Program.ExecSqlNonQuery(lenh) != 0)
                    {
                        MessageBox.Show("Sửa Thất Bại \n ", "", MessageBoxButtons.OK);
                    }
                }
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnGhi.Enabled = false;
                MessageBox.Show("Ghi Thành Công", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Niên Khóa - Học Kỳ đã tồn tại không thể thêm \n " + ex.Message, "", MessageBoxButtons.OK);
                btnLoad.PerformClick();
            }
            finally
            {
                btnLoad.PerformClick();
                Program.conn.Close();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thuchien = 2;
            panelNKHK.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            cboHK.Enabled = false;
            cboNK.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa lớp này không ??", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        mankhk = ((DataRowView)bdsNKHK[bdsNKHK.Position])["MA_NK_HK"].ToString();
                        bdsNKHK.RemoveCurrent();
                        this.NIEN_KHOA_HOC_KYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.NIEN_KHOA_HOC_KYTableAdapter.Update(this.DS.NIEN_KHOA_HOC_KY);
                        thuchien = 3;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại khóa ngoại " + ex.Message, "", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        btnLoad.PerformClick();
                        Program.conn.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niên Khóa đã tồn tại không thể thêm \n " + ex.Message, "", MessageBoxButtons.OK);
                btnLoad.PerformClick();
            }
            finally
            {
                btnLoad.PerformClick();
                Program.conn.Close();
            }
        }
    }
}