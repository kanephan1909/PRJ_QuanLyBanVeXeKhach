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
    public partial class FormsQuanLyXe : Form
    {
        public FormsQuanLyXe()
        {
            InitializeComponent();

            dgvXe.SelectionChanged += new EventHandler(dgvXe_SelectionChanged);

        }

        private void FormsQuanLyXe_Load(object sender, EventArgs e)
        {
            loadXe();
        }

        private void dgvXe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvXe.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvXe.SelectedRows[0];

                // Hiển thị dữ liệu lên các TextBox
                txtBienSo.Text = row.Cells["colBienSo"].Value?.ToString() ?? "";
                txtTenXe.Text = row.Cells["colTenXe"].Value?.ToString() ?? "";
                txtTaiXe.Text = row.Cells["colTaiXe"].Value?.ToString() ?? "";
                txtSoDienThoai.Text = row.Cells["colSoDienThoai"].Value?.ToString() ?? "";
            }
        }

        XeBLL xe = new XeBLL();
        DataTable table_xe = new DataTable();
        private void loadXe()
        {
            table_xe = xe.GetTableXe();
            dgvXe.DataSource = table_xe;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            loadXe();
            MessageBox.Show("Danh sách đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvXe.SelectedRows.Count > 0)
            {
                string bienSo = txtBienSo.Text;
                string tenXe = txtTenXe.Text;
                string taiXe = txtTaiXe.Text;
                string soDienThoai = txtSoDienThoai.Text;

                if (xe.UpdateXe(bienSo, tenXe, taiXe, soDienThoai))
                {
                    MessageBox.Show("Cập nhật xe thành công!");
                    btnCapNhat_Click(sender, e); // Tải lại danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe để sửa!");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvXe.SelectedRows.Count > 0)
            {
                string bienSo = txtBienSo.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (xe.DeleteXe(bienSo))
                    {
                        MessageBox.Show("Xóa xe thành công!");
                        btnCapNhat_Click(sender, e); // Tải lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa!");
            }
        }

    }
}
