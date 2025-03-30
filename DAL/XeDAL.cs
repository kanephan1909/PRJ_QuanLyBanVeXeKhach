using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class XeDAL
    {
        SqlConnectionData sql = new SqlConnectionData();

        public DataTable GetAllXe()
        {
            DataTable table_xe = new DataTable();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "SELECT * FROM Xe";
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table_xe);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading Xe data: " + ex.Message);
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            return table_xe;
        }

        public bool UpdateXe(string bienSo, string tenXe, string taiXe, string soDienThoai)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Xe SET tenXe = @tenXe, taiXe = @taiXe, soDienThoai = @soDienThoai WHERE bienSo = @bienSo";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@bienSo", bienSo);
                    command.Parameters.AddWithValue("@tenXe", tenXe);
                    command.Parameters.AddWithValue("@taiXe", taiXe);
                    command.Parameters.AddWithValue("@soDienThoai", soDienThoai);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi cập nhật xe: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteXe(string bienSo)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Xe WHERE bienSo = @bienSo";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@bienSo", bienSo);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi xóa xe: " + ex.Message);
                    return false;
                }
            }
        }





    }
}
