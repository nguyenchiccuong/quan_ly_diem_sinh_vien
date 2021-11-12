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
    public partial class FrmLop : DevExpress.XtraEditors.XtraForm
    {

        int year = DateTime.Now.Year;
        string makhoa = "";
        string malop = "";
        int vitri = 0;
        int chon = 0;
        int thuchien = 0;
        String lenhUpdate = "";//Update lop
        String lenhThem = "";
        String lenhUpdate1 = "";//Update sv
        String lenhThem1 = "";
        Stack<String> myStack = new Stack<String>();
        public FrmLop()
        {

            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.SINH_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINH_VIENTableAdapter.Fill(this.DS.SINH_VIEN);
            this.cHUYEN_NGANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUYEN_NGANHTableAdapter.Fill(this.DS.CHUYEN_NGANH);
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
            while (year >= 2000)
            {
                cboNamNhapHoc.Items.Add(year.ToString());
                year--;
            }
            if (myStack.Count > 0) btnPhucHoi.Enabled = true;
            else btnPhucHoi.Enabled = false;
            dateSV.Properties.MaxValue = DateTime.Now;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnGhi.Enabled = false;
            btnLop.Enabled = true;
            btnSV.Enabled = true;
            panelLop.Enabled = false;
            panelSV.Enabled = false;
            if (String.Compare(Program.mGroup.Trim(), "PGV", true) == 0) panelControl1.Enabled = true;
            else panelControl1.Enabled = false;
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
                        DS.EnforceConstraints = false;
                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Fill(this.DS.LOP);
                        this.SINH_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINH_VIENTableAdapter.Fill(this.DS.SINH_VIEN);
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnThem.Enabled = false;
                        btnGhi.Enabled = false;
                        btnLop.Enabled = true;
                        btnSV.Enabled = true;
                        panelLop.Enabled = false;
                        panelSV.Enabled = false;
                        myStack = new Stack<String>();
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
                        DS.EnforceConstraints = false;
                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Fill(this.DS.LOP);
                        this.SINH_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINH_VIENTableAdapter.Fill(this.DS.SINH_VIEN);
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnThem.Enabled = false;
                        btnGhi.Enabled = false;
                        btnLop.Enabled = true;
                        btnSV.Enabled = true;
                        panelLop.Enabled = false;
                        panelSV.Enabled = false;
                        myStack = new Stack<String>();
                    }
                }
            }
            catch (Exception)
            {
            }


        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chon == 1)
            {
                panelLop.Enabled = true;
                panelSV.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                btnGhi.Enabled = true;
                vitri = bdsLop.Position;
                bdsLop.AddNew();
                thuchien = 1;
                if (Program.mChinhanh == "Công Nghệ Thông Tin")
                {
                    tbMaKhoa.Text = "CNTT";
                }
                if (Program.mChinhanh == "Viễn Thông")
                {
                    tbMaKhoa.Text = "VT";
                }
                cboNamNhapHoc.Text = DateTime.Now.Year.ToString();
            }
            else if (chon == 2)
            {

                panelLop.Enabled = false;
                panelSV.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                btnGhi.Enabled = true;
                gcLop.Enabled = false;
                vitri = bdsSinhVien.Position;
                bdsSinhVien.AddNew();
                checkPhai.Checked = true;
                string str1 = tbMaLop.Text;
                tbMaLop2.Text = tbMaLop.Text;

                thuchien = 1;
                dateSV.Text = "";

            }


        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chon == 1)
            {
                try
                {


                    if (tbTenLop.Text.Trim() == "")
                    {
                        MessageBox.Show("Không để tên lớp rỗng", "", MessageBoxButtons.OK);
                        tbTenLop.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }
                    if (cboNamNhapHoc.Text.Trim() == "")
                    {
                        MessageBox.Show("Không để năm nhập học rỗng", "", MessageBoxButtons.OK);
                        tbMaLop.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }
                    if (tbMaKhoa.Text.Trim() == "")
                    {
                        MessageBox.Show("Không để mã khoa rỗng", "", MessageBoxButtons.OK);
                        tbMaKhoa.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }
                    if (thuchien == 1)
                    {
                        if (Program.KetNoi() == 0)
                        {
                            //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                            return;
                        }

                        string strLenh = "exec SP_XINMALOP '" + tbMaKhoa.Text.Trim() + "'," + cboNamNhapHoc.Text.Trim();

                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        int temp = Program.myReader.GetInt32(0);
                        string str = "";
                        if (temp < 10) str = "00" + temp;
                        else if (temp < 100 && temp > 9) str = "0" + temp;
                        tbMaLop.Text = tbMaKhoa.Text.Trim() + cboNamNhapHoc.Text.Trim() + "L" + str;
                        if (tbMaLop.Text.Trim() == "")
                        {
                            MessageBox.Show("Không để mã lớp rỗng", "", MessageBoxButtons.OK);
                            tbMaLop.Focus(); // dua con tro ve vi tri form dang nhap
                            return;
                        }

                        String lenh = "DELETE FROM LOP WHERE MA_LOP = '" + tbMaLop.Text.Trim() + "'";
                        myStack.Push(lenh);


                    }
                    else if (thuchien == 2)
                    {


                        Console.WriteLine(lenhUpdate);
                        myStack.Push(lenhUpdate);

                    }
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.DS.LOP);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnGhi.Enabled = false;
                    MessageBox.Show("Ghi Thành Công", "Thông báo", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
                    
                }
                finally
                {
                    btnLoad.PerformClick();
                    Program.conn.Close();
                }
            }
            else if (chon == 2)
            {
                try
                {

                    if (tbTen.Text.Trim() == "")
                    {
                        MessageBox.Show("Không để tên sinh viên rỗng", "", MessageBoxButtons.OK);
                        tbTen.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }
                    if (tbHoSV.Text.Trim() == "")
                    {
                        MessageBox.Show("Không để họ sinh viên rỗng", "", MessageBoxButtons.OK);
                        tbHoSV.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }
                    if (tbDCSV.Text.Trim() == "")
                    {
                        MessageBox.Show("Không để địa chỉ rỗng", "", MessageBoxButtons.OK);
                        tbDCSV.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }
                    if (dateSV.Text.Trim() == "")
                    {
                        MessageBox.Show("Chưa chọn ngày sinh", "", MessageBoxButtons.OK);
                        dateSV.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }
                    if (thuchien == 1)
                    {
                        if (Program.KetNoi() == 0)
                        {
                            //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                            return;
                        }
                        string strLenh = "exec SP_XINMASINHVIEN '" + cboNamNhapHoc.Text.Trim() + "'";

                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        int temp = Program.myReader.GetInt16(0);
                        string str = "";
                        if (temp < 10) str = "0000" + temp;
                        else if (temp < 100 && temp > 9) str = "000" + temp;
                        else if (temp < 1000 && temp > 99) str = "00" + temp;
                        else if (temp < 10000 && temp > 999) str = "0" + temp;
                        tbMaSV.Text = cboNamNhapHoc.Text.Trim() + "S" + str;

                        String lenh = "DELETE FROM SINH_VIEN WHERE MA_SV = '" + tbMaSV.Text.Trim() + "'";
                        myStack.Push(lenh);


                    }

                    else if (thuchien == 2)
                    {
                        Console.WriteLine(lenhUpdate1);
                        myStack.Push(lenhUpdate1);
                    }
                    tbMCN.Text = cboChuyenNganh.SelectedValue.ToString().Trim();
                    bdsSinhVien.EndEdit();
                    bdsSinhVien.ResetCurrentItem();
                    this.SINH_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINH_VIENTableAdapter.Update(this.DS.SINH_VIEN);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnThem.Enabled = true;
                    gcLop.Enabled = true;
                    MessageBox.Show("Ghi Thành Công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
                   
                }
                finally
                {
                    btnLoad.PerformClick();
                    Program.conn.Close();
                }

            }
            else if (chon == 3)
            {
                try
                {
                    int i=0;
                    
                    if(tbMaLop2.Text.Trim().Contains("CNTT")==true)
                    {
                        i = int.Parse(tbMaLop2.Text.Trim().Substring(4, 4));
                        
                    }
                    else
                    {
                        i = int.Parse(tbMaLop2.Text.Trim().Substring(2, 4));
                        
                        
                    }
                    int sv= int.Parse(tbMaSV.Text.Trim().Substring(0, 4));

                    if (i<sv)
                    {
                        MessageBox.Show("Lớp phải là lớp mới so với năm sinh viên nhập học \n ", "", MessageBoxButtons.OK);
                        tbMaLop2.Focus(); // dua con tro ve vi tri form dang nhap
                        return;
                    }    
                    
                    if (Program.KetNoi() == 0) return;
                    
                    SqlCommand cmd = new SqlCommand("SP_CHUYENSV", Program.conn);
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    //B3. Gắn các Parameter và giá trị cho đối tượng Command
                    cmd.Parameters.Add(new SqlParameter("@MA_SV", tbMaSV.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@HO", tbHoSV.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@TEN", tbTen.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@PHAI", checkPhai.Checked));
                    cmd.Parameters.Add(new SqlParameter("@DIA_CHI", tbDCSV.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAY_SINH", dateSV.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@MA_LOP", tbMaLop2.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@MA_CH_NGANH", cboChuyenNganh.SelectedValue.ToString().Trim()));
                    //B4. Thực thi Stored Procedure
                    cmd.ExecuteNonQuery();
                    Program.conn.Close();
                    
                    MessageBox.Show("Ghi Thành Công \n ", "", MessageBoxButtons.OK);
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
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chon == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa lớp này không ??", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        malop = ((DataRowView)bdsLop[bdsLop.Position])["MA_LOP"].ToString();
                        bdsLop.RemoveCurrent();
                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Update(this.DS.LOP);
                        thuchien = 3;
                        myStack.Push(lenhThem);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa lớp thất bại. Vui lòng kiểm tra lại khóa ngoại " + ex.Message, "", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        btnLoad.PerformClick();
                        Program.conn.Close();

                    }
                }
            }
            else if (chon == 2)
            {
                if (MessageBox.Show("Bạn có muốn xóa sinh viên này không ??", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        malop = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MA_SV"].ToString();
                        bdsSinhVien.RemoveCurrent();
                        this.SINH_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINH_VIENTableAdapter.Update(this.DS.SINH_VIEN);
                        thuchien = 3;
                        myStack.Push(lenhThem1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa sinh viên thất bại. Vui lòng kiểm tra lại khóa ngoại " + ex.Message, "", MessageBoxButtons.OK);
                    }
                    finally
                    {

                        btnLoad.PerformClick();
                        Program.conn.Close();
                    }
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DS.EnforceConstraints = false;
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
                this.SINH_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINH_VIENTableAdapter.Fill(this.DS.SINH_VIEN);
                if (myStack.Count > 0) btnPhucHoi.Enabled = true;
                else btnPhucHoi.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnGhi.Enabled = false;
                btnLop.Enabled = true;
                btnSV.Enabled = true;
                panelLop.Enabled = false;
                panelSV.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
            }

        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            chon = 1;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnLop.Enabled = false;
            btnSV.Enabled = true;
            panelLop.Enabled = false;
            panelSV.Enabled = false;
            if (myStack.Count > 0) btnPhucHoi.Enabled = true;
            else btnPhucHoi.Enabled = false;
            if (bdsLop.Count < 1) btnSua.Enabled = btnXoa.Enabled = false;
            else btnSua.Enabled = btnXoa.Enabled = true;
            btnChuyenLop.Enabled = false;
        }

        private void btnSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From CHUYEN_NGANH", Program.connstr);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboChuyenNganh.DataSource = dt;
                cboChuyenNganh.ValueMember = "MA_CH_NGANH";
                cboChuyenNganh.DisplayMember = "TEN_CH_NGANH";
                if (bdsSinhVien.Count < 1) btnSua.Enabled = btnXoa.Enabled = false;
                else btnSua.Enabled = btnXoa.Enabled = true;
                if (String.Compare(Program.mGroup.Trim(), "PGV", true) == 0) btnChuyenLop.Enabled = true;
                else btnChuyenLop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
            chon = 2;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnLop.Enabled = true;
            btnSV.Enabled = false;
            panelLop.Enabled = false;
            panelSV.Enabled = false;
            if (myStack.Count > 0) btnPhucHoi.Enabled = true;
            else btnPhucHoi.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if (chon == 1)
            {
                try
                {
                    panelLop.Enabled = true;
                    panelSV.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = false;
                    btnGhi.Enabled = true;
                    tbMaLop.Enabled = false;
                    cboChuyenNganh.Enabled = true;
                    cboNamNhapHoc.Enabled = false;
                    thuchien = 2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
                    btnLoad.PerformClick();
                }
                finally
                {
                    Program.conn.Close();
                }
            }
            else if (chon == 2)
            {
                try
                {
                    panelLop.Enabled = false;
                    panelSV.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnGhi.Enabled = true;
                    tbMaLop.Enabled = false;
                    cboChuyenNganh.Enabled = true;
                    cboNamNhapHoc.Enabled = false;
                    gcLop.Enabled = false;
                    thuchien = 2;
                    if (Program.KetNoi() == 0)
                    {

                        return;
                    }
                    string strLenh = "Select TEN_CH_NGANH From CHUYEN_NGANH Where MA_CH_NGANH ='" + tbMCN.Text.Trim() + "'";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    cboChuyenNganh.Text = Program.myReader.GetString(0);
                    Program.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
                    btnLoad.PerformClick();
                }
                finally
                {

                    Program.conn.Close();
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                String lenh = myStack.Peek();
                if (Program.ExecSqlNonQuery(lenh) == 0)
                {
                    myStack.Pop();
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
                btnLoad.PerformClick();
            }
            finally
            {

                Program.conn.Close();
            }
        }


        private void gcLop_Click(object sender, EventArgs e)
        {
            lenhUpdate = "UPDATE LOP SET   TEN_LOP = '" + tbTenLop.Text.Trim() + "' WHERE MA_LOP = '" + tbMaLop.Text.Trim() + "'";
            lenhThem = "INSERT INTO LOP (MA_LOP, TEN_LOP, NAM_NHAP_HOC, MA_KHOA) VALUES('" + tbMaLop.Text.Trim() + "', N'" + tbTenLop.Text.Trim() + "', N'" + cboNamNhapHoc.Text.Trim() + "', N'" + tbMaKhoa.Text.Trim() + "') ";
            if (chon == 2 && bdsSinhVien.Count < 1) btnSua.Enabled = btnXoa.Enabled = false;
            else btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void sINH_VIENGridControl_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0)
            {
                //MessageBox.Show("Tài khoản không tồn tại", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                return;
            }

            string strLenh = "Select TEN_CH_NGANH From CHUYEN_NGANH Where MA_CH_NGANH ='" + tbMCN.Text.Trim() + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            cboChuyenNganh.Text = Program.myReader.GetString(0);

            Program.conn.Close();

            lenhUpdate1 = "UPDATE SINH_VIEN SET   TEN = '" + tbTen.Text.Trim() + "', PHAI = N'" + checkPhai.Checked + "', HO = N'" + tbHoSV.Text.Trim() + "', DIA_CHI = N'" + tbDCSV.Text.Trim() + "', NGAY_SINH = N'" + dateSV.Text.Trim() + "', MA_CH_NGANH = N'" + tbMCN.Text.Trim() + "' WHERE MA_SV = '" + tbMaSV.Text.Trim() + "'";
            lenhThem1 = "INSERT INTO SINH_VIEN (MA_SV, HO, TEN, PHAI, DIA_CHI,NGAY_SINH, MA_CH_NGANH, MA_LOP) VALUES('" + tbMaSV.Text.Trim() + "', N'" + tbHoSV.Text.Trim() + "', N'" + tbTen.Text.Trim() + "',N'" + checkPhai.Checked + "',N'" + tbDCSV.Text.Trim() + "',N'" + dateSV.Text.Trim() + "',N'" + tbMCN.Text.Trim() + "',N'" + tbMaLop.Text.Trim() + "') ";
        }

        public static string VietHoa(string strChuoiChuyen)
        {
            if (String.IsNullOrEmpty(strChuoiChuyen))
            {
                return strChuoiChuyen;
            }
            string result = "";
            //lấy danh sách các từ
            string[] words = strChuoiChuyen.Split(' ');
            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                    {
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    }
                    else
                    {
                        result += word.ToUpper() + " ";
                    }
                }
            }
            return result.Trim();
        }

        private void btnChuyenLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From LINK0.QLDSV_TC.dbo.CHUYEN_NGANH", Program.connstr);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboChuyenNganh.DataSource = dt;
                cboChuyenNganh.ValueMember = "MA_CH_NGANH";
                cboChuyenNganh.DisplayMember = "TEN_CH_NGANH";
                SqlDataAdapter da1 = new SqlDataAdapter("Select * From LINK0.QLDSV_TC.dbo.LOP", Program.connstr);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                tbMaLop2.DataSource = dt1;
                tbMaLop2.ValueMember = "MA_LOP";
                tbMaLop2.DisplayMember = "MA_LOP";
                if (bdsSinhVien.Count < 1) btnSua.Enabled = btnXoa.Enabled = false;
                else btnSua.Enabled = btnXoa.Enabled = true;
                if (String.Compare(Program.mGroup.Trim(), "PGV", true) == 0) btnChuyenLop.Enabled = true;
                else btnChuyenLop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
            panelLop.Enabled = false;
            panelSV.Enabled = true;
            tbMaLop2.Enabled = true;
            cboChuyenNganh.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            tbMaSV.Enabled = tbTen.Enabled = tbHoSV.Enabled = checkPhai.Enabled = tbDCSV.Enabled = dateSV.Enabled = false;
            tbMaLop2.Text = tbMaLop.Text;
            chon = 3;
        }
    }

}
