using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class XeBLL
    {
        XeDAL xe = new XeDAL();
        public DataTable GetTableXe()
        {
            return xe.GetAllXe();
        }

        public bool UpdateXe(string bienSo, string tenXe, string taiXe, string soDienThoai)
        {
            return xe.UpdateXe(bienSo, tenXe, taiXe, soDienThoai);
        }

        public bool DeleteXe(string bienSo)
        {
            return xe.DeleteXe(bienSo);
        }
    }
}
