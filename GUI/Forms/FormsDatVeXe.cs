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
using FontAwesome.Sharp;

namespace GUI.Forms
{
    public partial class FormsDatVeXe : Form
    {
        public FormsDatVeXe()
        {
            InitializeComponent();
        }

        private void panelGheTangTren_Load(object sender, EventArgs e)
        {
            KhoiTaoSoGheTren(6, 3);
        }

        private void KhoiTaoSoGheTren(int dong, int cot)
        {
            int x, y = 20, khoangcachX = 55, khoangcachY = 50;
            int dem = 1;
            IconButton btnGhe;

            for (int i = 0; i < dong; i++)
            {
                x = 20;
                for (int j = 0; j < cot; j++)
                {
                    if (dem > 13) return;

                    btnGhe = new IconButton();
                    btnGhe.Location = new Point(x, y);
                    btnGhe.Size = new Size(40, 40);
                    btnGhe.Text = "B" + dem.ToString();  
                    btnGhe.BackColor = Color.LightGray;
                    btnGhe.ForeColor = Color.Black;
                    btnGhe.Font = new Font("Arial", 8, FontStyle.Bold);
                    btnGhe.FlatStyle = FlatStyle.Flat;
                    btnGhe.FlatAppearance.BorderSize = 1;
                    panelGheTangTren.Controls.Add(btnGhe);
                    x += khoangcachX;
                    dem++;  
                }
                y += khoangcachY;
            }
        }



        private void KhoiTaoSoGheDuoi(int dong, int cot)
        {
            int x, y = 20, khoangcachX = 55, khoangcachY = 50, dem = 1;
            IconButton btnGhe;
            for (int i = 0; i < dong; i++)
            {
                x = 20;
                for (int j = 0; j < cot; j++)
                {
                    if (dem > 17) return; 
                    btnGhe = new IconButton();
                    btnGhe.Location = new Point(x, y);
                    btnGhe.Size = new Size(40, 40);
                    btnGhe.Text = "A" + dem.ToString();
                    btnGhe.BackColor = Color.LightGray;
                    btnGhe.ForeColor = Color.Black;
                    btnGhe.Font = new Font("Arial", 8, FontStyle.Bold);
                    btnGhe.FlatStyle = FlatStyle.Flat;
                    btnGhe.Click += BtnGhe_Click;
                    btnGhe.FlatAppearance.BorderSize = 1;
                    panelGheTangDuoi.Controls.Add(btnGhe);
                    x += khoangcachX;
                    dem++;
                }
                y += khoangcachY;
            }
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            IconButton btnGhe = (IconButton)sender;
            if(btnGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã có người đặt!!!!");
                return;
            }
            btnGhe.BackColor = (btnGhe.BackColor == Color.LightGray) ? Color.DarkOrange : Color.LightGray;
        }

        private void panelGheTangDuoi_Load(object sender, EventArgs e)
        {
            KhoiTaoSoGheDuoi(6, 3);
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {

        }

        ChuyenDiBLL bll_chuyendi = new ChuyenDiBLL();
        DataTable table_chuyendi = new DataTable();


        private void FormsDatVeXe_Load(object sender, EventArgs e)
        {
            loadLichTrinh();
        }

        private void loadLichTrinh()
        {
            table_chuyendi = bll_chuyendi.GetTableChuyenDi();
            comboChonGio.DataSource = table_chuyendi;
            comboDiemDen.DataSource = table_chuyendi;
            comboDiemDi.DataSource = table_chuyendi;
        }
    }
}
