using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int LoaiTaiKhoan { get; set; }
        public string SoDienThoai { get; set; }

        public TaiKhoan() { }

        public TaiKhoan(string tenDangNhap, string matKhau, int loaiTaiKhoan, string soDienThoai)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            LoaiTaiKhoan = loaiTaiKhoan;
            SoDienThoai = soDienThoai;
        }
    }
}
