using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.Forms
{
    public partial class FormsQuanLyChuyenDi : Form
    {
        public FormsQuanLyChuyenDi()
        {
            InitializeComponent();
        }

        private void FormsQuanLyChuyenDi_Load(object sender, EventArgs e)
        {
            loadChuyenDi();
        }


        ChuyenDiBLL bll_chuyendi = new ChuyenDiBLL();
        DataTable table_chuyendi = new DataTable();
        private void loadChuyenDi()
        {
            table_chuyendi = bll_chuyendi.GetTableChuyenDi();
            grid_DSChuyenDi.DataSource = table_chuyendi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
