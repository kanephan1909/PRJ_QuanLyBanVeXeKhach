namespace GUI.Forms
{
    partial class FormsQuanLyXe
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
            this.grThongTinXe = new System.Windows.Forms.GroupBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTaiXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grThongTinVeXe = new System.Windows.Forms.GroupBox();
            this.UDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtMaChuyen = new System.Windows.Forms.TextBox();
            this.lblMaChuyen = new System.Windows.Forms.Label();
            this.txtBienSo_TTVX = new System.Windows.Forms.TextBox();
            this.lblBienSo_TTVX = new System.Windows.Forms.Label();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.colBienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDSThongTinVeXe = new System.Windows.Forms.GroupBox();
            this.dgvTTVX = new System.Windows.Forms.DataGridView();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnThem_TTVX = new FontAwesome.Sharp.IconButton();
            this.btnXoa_TTVX = new FontAwesome.Sharp.IconButton();
            this.btnSua_TTVX = new FontAwesome.Sharp.IconButton();
            this.colBienSoTTVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTinXe.SuspendLayout();
            this.grThongTinVeXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.grDSThongTinVeXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTVX)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinXe
            // 
            this.grThongTinXe.Controls.Add(this.txtSoDienThoai);
            this.grThongTinXe.Controls.Add(this.txtTaiXe);
            this.grThongTinXe.Controls.Add(this.txtTenXe);
            this.grThongTinXe.Controls.Add(this.txtBienSo);
            this.grThongTinXe.Controls.Add(this.label4);
            this.grThongTinXe.Controls.Add(this.label3);
            this.grThongTinXe.Controls.Add(this.label2);
            this.grThongTinXe.Controls.Add(this.label1);
            this.grThongTinXe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinXe.Location = new System.Drawing.Point(116, 57);
            this.grThongTinXe.Name = "grThongTinXe";
            this.grThongTinXe.Size = new System.Drawing.Size(403, 100);
            this.grThongTinXe.TabIndex = 0;
            this.grThongTinXe.TabStop = false;
            this.grThongTinXe.Text = "Thông Tin Xe";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(260, 66);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(137, 23);
            this.txtSoDienThoai.TabIndex = 7;
            // 
            // txtTaiXe
            // 
            this.txtTaiXe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiXe.Location = new System.Drawing.Point(261, 30);
            this.txtTaiXe.Name = "txtTaiXe";
            this.txtTaiXe.Size = new System.Drawing.Size(136, 23);
            this.txtTaiXe.TabIndex = 6;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.Location = new System.Drawing.Point(65, 66);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(134, 23);
            this.txtTenXe.TabIndex = 5;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Location = new System.Drawing.Point(65, 31);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(134, 23);
            this.txtBienSo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài Xế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển Số:";
            // 
            // grThongTinVeXe
            // 
            this.grThongTinVeXe.Controls.Add(this.UDSoLuong);
            this.grThongTinVeXe.Controls.Add(this.lblSoLuong);
            this.grThongTinVeXe.Controls.Add(this.txtMaChuyen);
            this.grThongTinVeXe.Controls.Add(this.lblMaChuyen);
            this.grThongTinVeXe.Controls.Add(this.txtBienSo_TTVX);
            this.grThongTinVeXe.Controls.Add(this.lblBienSo_TTVX);
            this.grThongTinVeXe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinVeXe.Location = new System.Drawing.Point(572, 57);
            this.grThongTinVeXe.Name = "grThongTinVeXe";
            this.grThongTinVeXe.Size = new System.Drawing.Size(416, 100);
            this.grThongTinVeXe.TabIndex = 1;
            this.grThongTinVeXe.TabStop = false;
            this.grThongTinVeXe.Text = "Thông Tin Vé Xe";
            // 
            // UDSoLuong
            // 
            this.UDSoLuong.Location = new System.Drawing.Point(320, 27);
            this.UDSoLuong.Name = "UDSoLuong";
            this.UDSoLuong.Size = new System.Drawing.Size(78, 27);
            this.UDSoLuong.TabIndex = 13;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(243, 32);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(66, 16);
            this.lblSoLuong.TabIndex = 12;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // txtMaChuyen
            // 
            this.txtMaChuyen.Location = new System.Drawing.Point(88, 62);
            this.txtMaChuyen.Name = "txtMaChuyen";
            this.txtMaChuyen.Size = new System.Drawing.Size(134, 27);
            this.txtMaChuyen.TabIndex = 11;
            // 
            // lblMaChuyen
            // 
            this.lblMaChuyen.AutoSize = true;
            this.lblMaChuyen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuyen.Location = new System.Drawing.Point(7, 69);
            this.lblMaChuyen.Name = "lblMaChuyen";
            this.lblMaChuyen.Size = new System.Drawing.Size(75, 16);
            this.lblMaChuyen.TabIndex = 10;
            this.lblMaChuyen.Text = "Mã Chuyến:";
            // 
            // txtBienSo_TTVX
            // 
            this.txtBienSo_TTVX.Location = new System.Drawing.Point(88, 25);
            this.txtBienSo_TTVX.Name = "txtBienSo_TTVX";
            this.txtBienSo_TTVX.Size = new System.Drawing.Size(134, 27);
            this.txtBienSo_TTVX.TabIndex = 9;
            // 
            // lblBienSo_TTVX
            // 
            this.lblBienSo_TTVX.AutoSize = true;
            this.lblBienSo_TTVX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienSo_TTVX.Location = new System.Drawing.Point(7, 32);
            this.lblBienSo_TTVX.Name = "lblBienSo_TTVX";
            this.lblBienSo_TTVX.Size = new System.Drawing.Size(55, 16);
            this.lblBienSo_TTVX.TabIndex = 8;
            this.lblBienSo_TTVX.Text = "Biển Số:";
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBienSo,
            this.colTenXe,
            this.colTaiXe,
            this.colSoDienThoai});
            this.dgvXe.Location = new System.Drawing.Point(116, 196);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXe.Size = new System.Drawing.Size(403, 244);
            this.dgvXe.TabIndex = 2;
            // 
            // colBienSo
            // 
            this.colBienSo.DataPropertyName = "bienSo";
            this.colBienSo.HeaderText = "Biển Số";
            this.colBienSo.Name = "colBienSo";
            // 
            // colTenXe
            // 
            this.colTenXe.DataPropertyName = "tenXe";
            this.colTenXe.HeaderText = "Tên Xe";
            this.colTenXe.Name = "colTenXe";
            // 
            // colTaiXe
            // 
            this.colTaiXe.DataPropertyName = "taiXe";
            this.colTaiXe.HeaderText = "Tài Xế";
            this.colTaiXe.Name = "colTaiXe";
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.DataPropertyName = "soDienThoai";
            this.colSoDienThoai.HeaderText = "Số Điện Thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            // 
            // grDSThongTinVeXe
            // 
            this.grDSThongTinVeXe.Controls.Add(this.dgvTTVX);
            this.grDSThongTinVeXe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSThongTinVeXe.Location = new System.Drawing.Point(572, 177);
            this.grDSThongTinVeXe.Name = "grDSThongTinVeXe";
            this.grDSThongTinVeXe.Size = new System.Drawing.Size(416, 271);
            this.grDSThongTinVeXe.TabIndex = 10;
            this.grDSThongTinVeXe.TabStop = false;
            this.grDSThongTinVeXe.Text = "Bảng Thông Tin Vé Xe";
            // 
            // dgvTTVX
            // 
            this.dgvTTVX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTVX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBienSoTTVX,
            this.colMaChuyen,
            this.colSoLuong});
            this.dgvTTVX.Location = new System.Drawing.Point(6, 19);
            this.dgvTTVX.Name = "dgvTTVX";
            this.dgvTTVX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTVX.Size = new System.Drawing.Size(404, 244);
            this.dgvTTVX.TabIndex = 0;
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
            this.btnXoa.Location = new System.Drawing.Point(413, 454);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 42);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(269, 454);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 42);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(116, 454);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(111, 42);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem_TTVX
            // 
            this.btnThem_TTVX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_TTVX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_TTVX.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem_TTVX.IconColor = System.Drawing.Color.Black;
            this.btnThem_TTVX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem_TTVX.IconSize = 30;
            this.btnThem_TTVX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_TTVX.Location = new System.Drawing.Point(578, 454);
            this.btnThem_TTVX.Name = "btnThem_TTVX";
            this.btnThem_TTVX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem_TTVX.Size = new System.Drawing.Size(105, 42);
            this.btnThem_TTVX.TabIndex = 17;
            this.btnThem_TTVX.Text = "Thêm";
            this.btnThem_TTVX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_TTVX.UseVisualStyleBackColor = true;
            // 
            // btnXoa_TTVX
            // 
            this.btnXoa_TTVX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_TTVX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_TTVX.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa_TTVX.IconColor = System.Drawing.Color.Black;
            this.btnXoa_TTVX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa_TTVX.IconSize = 30;
            this.btnXoa_TTVX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_TTVX.Location = new System.Drawing.Point(876, 454);
            this.btnXoa_TTVX.Name = "btnXoa_TTVX";
            this.btnXoa_TTVX.Size = new System.Drawing.Size(106, 42);
            this.btnXoa_TTVX.TabIndex = 22;
            this.btnXoa_TTVX.Text = "Xóa";
            this.btnXoa_TTVX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_TTVX.UseVisualStyleBackColor = true;
            // 
            // btnSua_TTVX
            // 
            this.btnSua_TTVX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_TTVX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_TTVX.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnSua_TTVX.IconColor = System.Drawing.Color.Black;
            this.btnSua_TTVX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua_TTVX.IconSize = 30;
            this.btnSua_TTVX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_TTVX.Location = new System.Drawing.Point(726, 454);
            this.btnSua_TTVX.Name = "btnSua_TTVX";
            this.btnSua_TTVX.Size = new System.Drawing.Size(107, 42);
            this.btnSua_TTVX.TabIndex = 21;
            this.btnSua_TTVX.Text = "Sửa";
            this.btnSua_TTVX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_TTVX.UseVisualStyleBackColor = true;
            // 
            // colBienSoTTVX
            // 
            this.colBienSoTTVX.DataPropertyName = "bienSo";
            this.colBienSoTTVX.HeaderText = "Biển Số";
            this.colBienSoTTVX.Name = "colBienSoTTVX";
            // 
            // colMaChuyen
            // 
            this.colMaChuyen.DataPropertyName = "maChuyen";
            this.colMaChuyen.HeaderText = "Mã Chuyến";
            this.colMaChuyen.Name = "colMaChuyen";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "soLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // FormsQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 522);
            this.Controls.Add(this.btnXoa_TTVX);
            this.Controls.Add(this.btnSua_TTVX);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem_TTVX);
            this.Controls.Add(this.grDSThongTinVeXe);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.grThongTinVeXe);
            this.Controls.Add(this.grThongTinXe);
            this.Name = "FormsQuanLyXe";
            this.Text = "Quản Lý Xe";
            this.Load += new System.EventHandler(this.FormsQuanLyXe_Load);
            this.grThongTinXe.ResumeLayout(false);
            this.grThongTinXe.PerformLayout();
            this.grThongTinVeXe.ResumeLayout(false);
            this.grThongTinVeXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.grDSThongTinVeXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTVX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTinXe;
        private System.Windows.Forms.GroupBox grThongTinVeXe;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTaiXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtMaChuyen;
        private System.Windows.Forms.Label lblMaChuyen;
        private System.Windows.Forms.TextBox txtBienSo_TTVX;
        private System.Windows.Forms.Label lblBienSo_TTVX;
        private System.Windows.Forms.NumericUpDown UDSoLuong;
        private System.Windows.Forms.GroupBox grDSThongTinVeXe;
        private System.Windows.Forms.DataGridView dgvTTVX;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnThem_TTVX;
        private FontAwesome.Sharp.IconButton btnXoa_TTVX;
        private FontAwesome.Sharp.IconButton btnSua_TTVX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBienSoTTVX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}