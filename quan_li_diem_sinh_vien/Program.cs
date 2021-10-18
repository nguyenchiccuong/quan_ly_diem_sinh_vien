using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection(); //tra ve ket noi, thuoc tih quan torng là connection string
        public static string connstr; // chuoi ket noi
        public static string connstrPublisher = "Data Source=DESKTOP-BR976AR;Initial Catalog=QLDSV_TC;Integrated Security=True"; //dung pass hdh

        public static SqlDataReader myReader;
        public static String servername = ""; //ten server ket noi thoi diem hien tai
        public static String username = ""; //ma nhan vien de biet ai dang dung phan mem
        public static String mlogin = ""; //ten dang nhap cho nãy go vào
        public static String password = ""; //pass

        public static String database = "QLDSV_TC";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = ""; // group
        public static String mHoten = ""; // ho ten nhan vein
        public static int mChinhanh = 0;

        public static String serverNameConLai = "";
        public static String connstrConLai = ""; //connstr su dung tai khoan htkn va ten server con lai
        public static String connstrTraCuu = "Data Source=DESKTOP-BR976AR;Initial Catalog=QLDSV_TC;Persist Security Info=True;User ID=" +
                      Program.remotelogin + ";password=" + Program.remotepassword;

        public static BindingSource bdsDSPM = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static FrmMain frmMain;


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh) // exec sp, select, view, truy vấn nhanh, chỉ dc xem, có nhiều dòng chỉ cho phép di xuống
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd) // co the sử và cập nhật
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static bool kiemTraChuoi(String chuoi)
        {
            //		String patternTen = "[a-zA-Z\\ ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệếỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+";
            String patternTen = "^[a-zA-Z\\ aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ]+$";
            return Regex.Match(chuoi, patternTen).Success;
        }

        public static String xoaSpaceChuoi(String chuoi)
        {
            Regex rgx = new Regex("[\\s]{2,}");
            return rgx.Replace(chuoi.Trim(), " ");
        }

        public static String xoaSpaceID(String chuoi)
        {
            Regex rgx = new Regex("[\\s]");
            return rgx.Replace(chuoi.Trim(), "");
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new FrmMain();
            Application.Run(frmMain);
        }
    }
}
