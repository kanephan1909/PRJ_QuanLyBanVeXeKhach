using System.Data.SqlClient;

namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=KANEPHAN;Initial Catalog=DB_QLBanVeXe;Persist Security Info=True;User ID=sa;Password=1";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}