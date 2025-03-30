namespace GUI.Forms
{
    partial class FormsThongKe
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
            this.grDanhSachVeXeKhachDat = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grThongTinChuyenDi = new System.Windows.Forms.GroupBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.iconTimKiem = new FontAwesome.Sharp.IconButton();
            this.iconThongKe = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_DSVeXeKhachDat = new System.Windows.Forms.DataGridView();
            this.grid_DSChuyenDi = new System.Windows.Forms.DataGridView();
            this.colChuyenDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiXuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhSachVeXeKhachDat.SuspendLayout();
            this.grThongTinChuyenDi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSVeXeKhachDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSChuyenDi)).BeginInit();
            this.SuspendLayout();
            // 
            // grDanhSachVeXeKhachDat
            // 
            this.grDanhSachVeXeKhachDat.Controls.Add(this.grid_DSVeXeKhachDat);
            this.grDanhSachVeXeKhachDat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhSachVeXeKhachDat.Location = new System.Drawing.Point(75, 85);
            this.grDanhSachVeXeKhachDat.Name = "grDanhSachVeXeKhachDat";
            this.grDanhSachVeXeKhachDat.Size = new System.Drawing.Size(453, 384);
            this.grDanhSachVeXeKhachDat.TabIndex = 0;
            this.grDanhSachVeXeKhachDat.TabStop = false;
            this.grDanhSachVeXeKhachDat.Text = "Danh Sách Vé Xe Khách Đặt";
            // 
            // grThongTinChuyenDi
            // 
            this.grThongTinChuyenDi.Controls.Add(this.grid_DSChuyenDi);
            this.grThongTinChuyenDi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinChuyenDi.Location = new System.Drawing.Point(549, 85);
            this.grThongTinChuyenDi.Name = "grThongTinChuyenDi";
            this.grThongTinChuyenDi.Size = new System.Drawing.Size(453, 384);
            this.grThongTinChuyenDi.TabIndex = 1;
            this.grThongTinChuyenDi.TabStop = false;
            this.grThongTinChuyenDi.Text = "Thông Tin Chuyến Đi";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(72, 504);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(99, 16);
            this.lblSoDienThoai.TabIndex = 2;
            this.lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(177, 503);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(151, 20);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // iconTimKiem
            // 
            this.iconTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconTimKiem.IconColor = System.Drawing.Color.Black;
            this.iconTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTimKiem.IconSize = 20;
            this.iconTimKiem.Location = new System.Drawing.Point(345, 497);
            this.iconTimKiem.Name = "iconTimKiem";
            this.iconTimKiem.Size = new System.Drawing.Size(30, 30);
            this.iconTimKiem.TabIndex = 4;
            this.iconTimKiem.UseVisualStyleBackColor = true;
            // 
            // iconThongKe
            // 
            this.iconThongKe.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconThongKe.IconColor = System.Drawing.Color.Black;
            this.iconThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconThongKe.Location = new System.Drawing.Point(921, 484);
            this.iconThongKe.Name = "iconThongKe";
            this.iconThongKe.Size = new System.Drawing.Size(81, 76);
            this.iconThongKe.TabIndex = 5;
            this.iconThongKe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(918, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "THỐNG KÊ";
            // 
            // grid_DSVeXeKhachDat
            // 
            this.grid_DSVeXeKhachDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DSVeXeKhachDat.Location = new System.Drawing.Point(6, 22);
            this.grid_DSVeXeKhachDat.Name = "grid_DSVeXeKhachDat";
            this.grid_DSVeXeKhachDat.Size = new System.Drawing.Size(441, 356);
            this.grid_DSVeXeKhachDat.TabIndex = 0;
            // 
            // grid_DSChuyenDi
            // 
            this.grid_DSChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DSChuyenDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChuyenDi,
            this.colNgayDi,
            this.colGioDi,
            this.colNoiXuatPhat,
            this.colDiemDen,
            this.colGiaVe});
            this.grid_DSChuyenDi.Location = new System.Drawing.Point(6, 23);
            this.grid_DSChuyenDi.Name = "grid_DSChuyenDi";
            this.grid_DSChuyenDi.Size = new System.Drawing.Size(441, 355);
            this.grid_DSChuyenDi.TabIndex = 13;
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
            // FormsThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconThongKe);
            this.Controls.Add(this.iconTimKiem);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.grThongTinChuyenDi);
            this.Controls.Add(this.grDanhSachVeXeKhachDat);
            this.Name = "FormsThongKe";
            this.Text = "Thống Kê";
            this.grDanhSachVeXeKhachDat.ResumeLayout(false);
            this.grThongTinChuyenDi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSVeXeKhachDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSChuyenDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSachVeXeKhachDat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grThongTinChuyenDi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private FontAwesome.Sharp.IconButton iconTimKiem;
        private FontAwesome.Sharp.IconButton iconThongKe;
        private System.Windows.Forms.DataGridView grid_DSVeXeKhachDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_DSChuyenDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiXuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaVe;
    }
}