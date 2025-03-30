using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        // Thuộc tính
        public string SoDienThoai { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string GioiTinh { get; set; }
        public string Gmail { get; set; }
        public string DiaChi { get; set; }

        // Constructor mặc định
        public KhachHang()
        {
        }

        // Constructor có tham số
        public KhachHang(string soDienThoai, string hoTen, string cccd,
                           string gioiTinh, string gmail, string diaChi)
        {
            SoDienThoai = soDienThoai;
            HoTen = hoTen;
            CCCD = cccd;
            GioiTinh = gioiTinh;
            Gmail = gmail;
            DiaChi = diaChi;
        }
    }
}
