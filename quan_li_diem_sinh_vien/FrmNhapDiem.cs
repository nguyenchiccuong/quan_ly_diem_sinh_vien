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
    public partial class FrmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        int nienkhoa = DateTime.Now.Year;
        int sonienkhoa = 5;
        int sohocky = 3;
        int hocky = 1;
        string maltc = "";
        DataTable dt = new DataTable();

        public FrmNhapDiem()
        {
            InitializeComponent();
        }



        private void FrmNhapDiem_Load(object sender, EventArgs e)
        {
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
            col_MA_SV.OptionsColumn.ReadOnly = true;
            colHOTEN.OptionsColumn.ReadOnly = true;

        }

        private void btnLopTC_Click(object sender, EventArgs e)
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
            try
            {
                this.sP_DSLTCTableAdapter.Fill(this.dS.SP_DSLTC, int.Parse(cboNK.Text.Trim()), int.Parse(cboHK.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            try
            {
                maltc = ((DataRowView)bdsDSLTC[bdsDSLTC.Position])["MA_LOP_TC"].ToString();
                string lenh = "EXEC SP_LAY_DSSV_DANGKY " + maltc;
                dt = Program.ExecSqlDataTable(lenh);
                gcDSSV.DataSource = dt;
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

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Columns.Add("MA_LOP_TC", typeof(int));
                dt1.Columns.Add("MA_SV", typeof(string));
                dt1.Columns.Add("DIEM_CC", typeof(float));
                dt1.Columns.Add("DIEM_GK", typeof(float));
                dt1.Columns.Add("DIEM_CK", typeof(float));
                int intmaltc = int.Parse(maltc);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt1.Rows.Add(intmaltc, dt.Rows[i]["MA_SV"], dt.Rows[i]["DIEM_CC"], dt.Rows[i]["DIEM_GK"], dt.Rows[i]["DIEM_CK"]);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKI";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt1;
                if (Program.KetNoi() == 0) return;
                SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_DIEM", Program.conn);
                Sqlcmd.Parameters.Clear();
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
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
                btnNhapDiem.PerformClick();
            }
        }
        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

            if (gridView2.FocusedColumn.FieldName == "DIEM_CC")
            {
                double diemcc = 0;
                if (!Double.TryParse(e.Value as String, out diemcc))
                {
                    e.Valid = false;
                    e.ErrorText = "Không được để trống.";
                }
                else if (diemcc > 10 || diemcc < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Giá trị nhập 0-10.";
                }
            }
            if (gridView2.FocusedColumn.FieldName == "DIEM_GK")
            {
                double diemgk = 0;
                if (!Double.TryParse(e.Value as String, out diemgk))
                {
                    e.Valid = false;
                    e.ErrorText = "Không được để trống.";
                }
                else if (diemgk > 10 || diemgk < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Giá trị nhập 0-10.";
                }
            }
            if (gridView2.FocusedColumn.FieldName == "DIEM_CK")
            {
                double diemck = 0;
                if (!Double.TryParse(e.Value as String, out diemck))
                {
                    e.Valid = false;
                    e.ErrorText = "Không được để trống.";
                }
                else if (diemck > 10 || diemck < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Giá trị nhập 0-10.";
                }
            }
        }
    }
}