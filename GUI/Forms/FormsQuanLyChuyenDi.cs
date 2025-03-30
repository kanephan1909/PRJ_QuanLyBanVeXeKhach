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
            loadChuyenDi();

            dgvChuyenDi.SelectionChanged += new EventHandler(dgvChuyenDi_SelectionChanged);
        }

        private void FormsQuanLyChuyenDi_Load(object sender, EventArgs e)
        {
            loadChuyenDi();
        }

        private void dgvChuyenDi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChuyenDi.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvChuyenDi.SelectedRows[0];

                // Hiển thị dữ liệu lên các TextBox
                txtMaCD.Text = row.Cells["colChuyenDi"].Value?.ToString() ?? "";
                dateNgayDi.Text = row.Cells["colNgayDi"].Value?.ToString() ?? "";
                txtGioKhoiHanh.Text = row.Cells["colGioDi"].Value?.ToString() ?? "";
                txtDiemDi.Text = row.Cells["colNoiXuatPhat"].Value?.ToString() ?? "";
                txtDiemDen.Text = row.Cells["colDiemDen"].Value?.ToString() ?? "";
                txtGiaVe.Text = row.Cells["colGiaVe"].Value?.ToString() ?? "";
            }
        }


        ChuyenDiBLL bll_chuyendi = new ChuyenDiBLL();
        DataTable table_chuyendi = new DataTable();
        private void loadChuyenDi()
        {
            table_chuyendi = bll_chuyendi.GetTableChuyenDi();
            dgvChuyenDi.DataSource = table_chuyendi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
