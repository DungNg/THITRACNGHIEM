using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;

namespace ThiTracNghiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "TN_CSDLPT";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "htkn";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        //---------------Thông tin thi----------------------
        public static String Lopthi = "";
        public static String Monthi = "";
        public static DateTime Ngaythi;
        public static int Lanthi;
        public static String Macs = "";

        public static int Socauhoithi;
        public static int Thoigianthi;
        public static float DiemChoMoiCauHoi;
        public static float DiemBaiThi;
        public static String Noidungthi = "";
        //-------------------------------------------------
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập 
        
            public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source="      +Program.servername + 
                                  ";Initial Catalog=" +Program.database + 
                                  ";User ID="         +Program.mlogin + 
                                  ";password="        +Program.password;
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

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;               
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
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
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
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

        public static int ExecSqlScalar(String strlenh)
        {
            int kq = 0;
            SqlCommand cmd = new SqlCommand(strlenh, conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                kq = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return kq;
        }

        public static int KTTT(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                conn.Close();
                return dt.Rows.Count;
            }
            else
            {
                conn.Close();
                return dt.Rows.Count;                
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new FrmLogin());
        }
    }
}
