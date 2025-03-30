using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO; 
using DAL;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal;

        public KhachHangBLL()
        {
            dal = new KhachHangDAL();
        }

        // Lấy tất cả khách hàng
        public List<KhachHang> GetAllKhachHang()
        {
            return dal.GetAllKhachHang();
        }

        // Thêm khách hàng với validation
        public bool AddKhachHang(KhachHang kh, out string errorMessage)
        {
            errorMessage = "";

            // Validation
            if (string.IsNullOrEmpty(kh.SoDienThoai) || kh.SoDienThoai.Length > 12)
            {
                errorMessage = "Số điện thoại không hợp lệ";
                return false;
            }
            if (string.IsNullOrEmpty(kh.HoTen))
            {
                errorMessage = "Họ tên không được để trống";
                return false;
            }
            if (!string.IsNullOrEmpty(kh.Gmail) && !IsValidEmail(kh.Gmail))
            {
                errorMessage = "Địa chỉ Gmail không hợp lệ";
                return false;
            }
            if (dal.GetKhachHangBySoDienThoai(kh.SoDienThoai) != null)
            {
                errorMessage = "Số điện thoại đã tồn tại";
                return false;
            }

            return dal.AddKhachHang(kh);
        }

        // Cập nhật khách hàng với validation
        public bool UpdateKhachHang(KhachHang kh, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrEmpty(kh.HoTen))
            {
                errorMessage = "Họ tên không được để trống";
                return false;
            }
            if (!string.IsNullOrEmpty(kh.Gmail) && !IsValidEmail(kh.Gmail))
            {
                errorMessage = "Địa chỉ Gmail không hợp lệ";
                return false;
            }

            return dal.UpdateKhachHang(kh);
        }

        // Xóa khách hàng
        public bool DeleteKhachHang(string soDienThoai, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrEmpty(soDienThoai))
            {
                errorMessage = "Số điện thoại không được để trống";
                return false;
            }

            return dal.DeleteKhachHang(soDienThoai);
        }

        // Tìm khách hàng theo số điện thoại
        public KhachHang GetKhachHangBySoDienThoai(string soDienThoai)
        {
            return dal.GetKhachHangBySoDienThoai(soDienThoai);
        }

        // Hàm kiểm tra email hợp lệ
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}