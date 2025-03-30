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
using DTO;

namespace GUI.Forms
{
    public partial class FormsQuanLyKhachHang : Form
    {
        private KhachHangBLL khachHangBLL;
        private List<KhachHang> danhSachKhachHang;

        public FormsQuanLyKhachHang()
        {
            InitializeComponent();
            khachHangBLL = new KhachHangBLL();
            LoadData(); // Tải dữ liệu khi form khởi động

            // Đăng ký sự kiện SelectionChanged cho DataGridView
            dgvKhachHang.SelectionChanged += new EventHandler(dgvKhachHang_SelectionChanged);
        }

        // Tải dữ liệu vào DataGridView
        private void LoadData()
        {
            danhSachKhachHang = khachHangBLL.GetAllKhachHang();
            dgvKhachHang.DataSource = danhSachKhachHang; 
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvKhachHang.SelectedRows[0];

                // Hiển thị dữ liệu lên các TextBox
                txtSoDienThoai.Text = row.Cells["colSoDienThoai"].Value?.ToString() ?? "";
                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString() ?? "";
                txtCCCD.Text = row.Cells["colCanCuoc"].Value?.ToString() ?? "";
                txtGioiTinh.Text = row.Cells["colGioiTinh"].Value?.ToString() ?? "";
                txtGmail.Text = row.Cells["colGmail"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["colDiaChi"].Value?.ToString() ?? "";
            }
        }

        // Thêm khách hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang
            {
                SoDienThoai = txtSoDienThoai.Text,
                HoTen = txtHoTen.Text,
                CCCD = txtCCCD.Text,
                GioiTinh = txtGioiTinh.Text,
                Gmail = txtGmail.Text,
                DiaChi = txtDiaChi.Text
            };

            string error;
            if (khachHangBLL.AddKhachHang(kh, out error))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Cập nhật lại danh sách
                ClearInputs(); // Xóa các trường nhập liệu
            }
            else
            {
                MessageBox.Show($"Lỗi: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cập nhật danh sách
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadData(); // Cập nhật lại danh sách
            MessageBox.Show("Danh sách đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sửa thông tin khách hàng
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                KhachHang kh = new KhachHang
                {
                    SoDienThoai = txtSoDienThoai.Text,
                    HoTen = txtHoTen.Text,
                    CCCD = txtCCCD.Text,
                    GioiTinh = txtGioiTinh.Text,
                    Gmail = txtGmail.Text,
                    DiaChi = txtDiaChi.Text
                };

                string error;
                if (khachHangBLL.UpdateKhachHang(kh, out error))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show($"Lỗi: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadData();
        }

        // Xóa khách hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                string soDienThoai = dgvKhachHang.SelectedRows[0].Cells["colSoDienThoai"].Value.ToString();
                string error;
                if (khachHangBLL.DeleteKhachHang(soDienThoai, out error))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show($"Lỗi: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xóa trắng các trường nhập liệu
        private void ClearInputs()
        {
            txtSoDienThoai.Clear();
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtGioiTinh.Clear();
            txtGmail.Clear();
            txtDiaChi.Clear();
        }
    }
}