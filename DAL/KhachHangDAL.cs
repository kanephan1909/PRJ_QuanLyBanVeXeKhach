using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> danhSach = new List<KhachHang>();

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                string query = "SELECT * FROM KhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    KhachHang kh = new KhachHang
                    {
                        SoDienThoai = reader["soDienThoai"].ToString(),
                        HoTen = reader["hoTen"].ToString(),
                        CCCD = reader["cccd"].ToString(),
                        GioiTinh = reader["gioiTinh"].ToString(),
                        Gmail = reader["gmail"].ToString(),
                        DiaChi = reader["diaChi"].ToString()
                    };
                    danhSach.Add(kh);
                }
                conn.Close();
            }
            return danhSach;
        }

        // Thêm khách hàng mới
        public bool AddKhachHang(KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    string query = @"INSERT INTO KhachHang (soDienThoai, hoTen, cccd, gioiTinh, gmail, diaChi)
                               VALUES (@soDienThoai, @hoTen, @cccd, @gioiTinh, @gmail, @diaChi)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@soDienThoai", kh.SoDienThoai);
                    cmd.Parameters.AddWithValue("@hoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@cccd", kh.CCCD);
                    cmd.Parameters.AddWithValue("@gioiTinh", kh.GioiTinh);
                    cmd.Parameters.AddWithValue("@gmail", kh.Gmail);
                    cmd.Parameters.AddWithValue("@diaChi", kh.DiaChi);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (có thể log lỗi)
                return false;
            }
        }

        // Cập nhật thông tin khách hàng
        public bool UpdateKhachHang(KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    string query = @"UPDATE KhachHang 
                               SET hoTen = @hoTen, cccd = @cccd, gioiTinh = @gioiTinh, 
                                   gmail = @gmail, diaChi = @diaChi
                               WHERE soDienThoai = @soDienThoai";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@soDienThoai", kh.SoDienThoai);
                    cmd.Parameters.AddWithValue("@hoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@cccd", kh.CCCD);
                    cmd.Parameters.AddWithValue("@gioiTinh", kh.GioiTinh);
                    cmd.Parameters.AddWithValue("@gmail", kh.Gmail);
                    cmd.Parameters.AddWithValue("@diaChi", kh.DiaChi);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Xóa khách hàng
        public bool DeleteKhachHang(string soDienThoai)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    string query = "DELETE FROM KhachHang WHERE soDienThoai = @soDienThoai";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Tìm khách hàng theo số điện thoại
        public KhachHang GetKhachHangBySoDienThoai(string soDienThoai)
        {
            KhachHang kh = null;

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                string query = "SELECT * FROM KhachHang WHERE soDienThoai = @soDienThoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    kh = new KhachHang
                    {
                        SoDienThoai = reader["soDienThoai"].ToString(),
                        HoTen = reader["hoTen"].ToString(),
                        CCCD = reader["cccd"].ToString(),
                        GioiTinh = reader["gioiTinh"].ToString(),
                        Gmail = reader["gmail"].ToString(),
                        DiaChi = reader["diaChi"].ToString()
                    };
                }
                conn.Close();
            }
            return kh;
        }
    }
}
