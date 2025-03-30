using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tkDAL = new TaiKhoanDAL();

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                throw new ArgumentException("Tên đăng nhập và mật khẩu không được để trống.");
            }

            return tkDAL.KiemTraDangNhap(tenDangNhap, matKhau);
        }
    }
}
