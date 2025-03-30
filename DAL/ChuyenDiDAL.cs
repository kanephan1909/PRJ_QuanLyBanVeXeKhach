using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuyenDiDAL
    {
        SqlConnectionData sql = new SqlConnectionData();

        public DataTable LoadDSChuyenDi()
        {
            DataTable table_chuyendi = new DataTable();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "SELECT * FROM ChuyenDi";
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table_chuyendi);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading ChuyenDi data: " + ex.Message);
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            return table_chuyendi;
        }
    }
}