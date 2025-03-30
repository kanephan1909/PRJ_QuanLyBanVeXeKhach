using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ChuyenDiBLL
    {
        ChuyenDiDAL chuyendi = new ChuyenDiDAL();

        public DataTable GetTableChuyenDi()
        {
            return chuyendi.GetChuyenDi();
        }
    }
}
