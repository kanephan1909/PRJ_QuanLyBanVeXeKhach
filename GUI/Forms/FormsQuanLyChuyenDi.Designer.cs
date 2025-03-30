namespace GUI.Forms
{
    partial class FormsQuanLyChuyenDi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaCD = new System.Windows.Forms.Label();
            this.lblGioKhoiHanh = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblDiemDi = new System.Windows.Forms.Label();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.txtGioKhoiHanh = new System.Windows.Forms.TextBox();
            this.dateNgayDi = new System.Windows.Forms.DateTimePicker();
            this.txtDiemDi = new System.Windows.Forms.TextBox();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.dgvChuyenDi = new System.Windows.Forms.DataGridView();
            this.colChuyenDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiXuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaCD
            // 
            this.lblMaCD.AutoSize = true;
            this.lblMaCD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCD.Location = new System.Drawing.Point(134, 48);
            this.lblMaCD.Name = "lblMaCD";
            this.lblMaCD.Size = new System.Drawing.Size(95, 16);
            this.lblMaCD.TabIndex = 0;
            this.lblMaCD.Text = "Mã Chuyến Đi";
            // 
            // lblGioKhoiHanh
            // 
            this.lblGioKhoiHanh.AutoSize = true;
            this.lblGioKhoiHanh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioKhoiHanh.Location = new System.Drawing.Point(344, 48);
            this.lblGioKhoiHanh.Name = "lblGioKhoiHanh";
            this.lblGioKhoiHanh.Size = new System.Drawing.Size(94, 16);
            this.lblGioKhoiHanh.TabIndex = 1;
            this.lblGioKhoiHanh.Text = "Giờ Khởi Hành";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(552, 48);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(56, 16);
            this.lblNgayDi.TabIndex = 2;
            this.lblNgayDi.Text = "Ngày Đi";
            // 
            // lblDiemDi
            // 
            this.lblDiemDi.AutoSize = true;
            this.lblDiemDi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDi.Location = new System.Drawing.Point(134, 106);
            this.lblDiemDi.Name = "lblDiemDi";
            this.lblDiemDi.Size = new System.Drawing.Size(95, 16);
            this.lblDiemDi.TabIndex = 3;
            this.lblDiemDi.Text = "Nơi Xuất Phát";
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDen.Location = new System.Drawing.Point(344, 106);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(69, 16);
            this.lblDiemDen.TabIndex = 4;
            this.lblDiemDen.Text = "Điểm Đến";
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaVe.Location = new System.Drawing.Point(552, 106);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(47, 16);
            this.lblGiaVe.TabIndex = 5;
            this.lblGiaVe.Text = "Giá Vé";
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(137, 67);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(146, 20);
            this.txtMaCD.TabIndex = 6;
            this.txtMaCD.Enabled = false;
            // 
            // txtGioKhoiHanh
            // 
            this.txtGioKhoiHanh.Location = new System.Drawing.Point(347, 67);
            this.txtGioKhoiHanh.Name = "txtGioKhoiHanh";
            this.txtGioKhoiHanh.Size = new System.Drawing.Size(134, 20);
            this.txtGioKhoiHanh.TabIndex = 7;
            // 
            // dateNgayDi
            // 
            this.dateNgayDi.Location = new System.Drawing.Point(555, 67);
            this.dateNgayDi.Name = "dateNgayDi";
            this.dateNgayDi.Size = new System.Drawing.Size(216, 20);
            this.dateNgayDi.TabIndex = 8;
            // 
            // txtDiemDi
            // 
            this.txtDiemDi.Location = new System.Drawing.Point(137, 125);
            this.txtDiemDi.Name = "txtDiemDi";
            this.txtDiemDi.Size = new System.Drawing.Size(146, 20);
            this.txtDiemDi.TabIndex = 9;
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Location = new System.Drawing.Point(347, 125);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(134, 20);
            this.txtDiemDen.TabIndex = 10;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(555, 125);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(148, 20);
            this.txtGiaVe.TabIndex = 11;
            // 
            // dgvChuyenDi
            // 
            this.dgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChuyenDi,
            this.colNgayDi,
            this.colGioDi,
            this.colNoiXuatPhat,
            this.colDiemDen,
            this.colGiaVe});
            this.dgvChuyenDi.Location = new System.Drawing.Point(138, 184);
            this.dgvChuyenDi.Name = "dgvChuyenDi";
            this.dgvChuyenDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenDi.Size = new System.Drawing.Size(783, 290);
            this.dgvChuyenDi.TabIndex = 12;
            // 
            // colChuyenDi
            // 
            this.colChuyenDi.DataPropertyName = "maCD";
            this.colChuyenDi.HeaderText = "Mã Chuyến Đi";
            this.colChuyenDi.Name = "colChuyenDi";
            // 
            // colNgayDi
            // 
            this.colNgayDi.DataPropertyName = "ngayDi";
            this.colNgayDi.HeaderText = "Ngày Đi";
            this.colNgayDi.Name = "colNgayDi";
            // 
            // colGioDi
            // 
            this.colGioDi.DataPropertyName = "gioDi";
            this.colGioDi.HeaderText = "Giờ Đi";
            this.colGioDi.Name = "colGioDi";
            // 
            // colNoiXuatPhat
            // 
            this.colNoiXuatPhat.DataPropertyName = "diemDi";
            this.colNoiXuatPhat.HeaderText = "Nơi Xuất Phát";
            this.colNoiXuatPhat.Name = "colNoiXuatPhat";
            // 
            // colDiemDen
            // 
            this.colDiemDen.DataPropertyName = "diemDen";
            this.colDiemDen.HeaderText = "Điểm Đến";
            this.colDiemDen.Name = "colDiemDen";
            // 
            // colGiaVe
            // 
            this.colGiaVe.DataPropertyName = "giaVe";
            this.colGiaVe.HeaderText = "Giá Vé";
            this.colGiaVe.Name = "colGiaVe";
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(442, 489);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem.Size = new System.Drawing.Size(105, 42);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnCapNhat.IconColor = System.Drawing.Color.Black;
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.IconSize = 30;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(564, 489);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(111, 42);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(691, 489);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 42);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(815, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 42);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // FormsQuanLyChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvChuyenDi);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.txtDiemDen);
            this.Controls.Add(this.txtDiemDi);
            this.Controls.Add(this.dateNgayDi);
            this.Controls.Add(this.txtGioKhoiHanh);
            this.Controls.Add(this.txtMaCD);
            this.Controls.Add(this.lblGiaVe);
            this.Controls.Add(this.lblDiemDen);
            this.Controls.Add(this.lblDiemDi);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.lblGioKhoiHanh);
            this.Controls.Add(this.lblMaCD);
            this.Name = "FormsQuanLyChuyenDi";
            this.Text = "Quản Lý Chuyến Đi";
            this.Load += new System.EventHandler(this.FormsQuanLyChuyenDi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCD;
        private System.Windows.Forms.Label lblGioKhoiHanh;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblDiemDi;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.TextBox txtGioKhoiHanh;
        private System.Windows.Forms.DateTimePicker dateNgayDi;
        private System.Windows.Forms.TextBox txtDiemDi;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.DataGridView dgvChuyenDi;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiXuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaVe;
    }
}