namespace GUI.Forms
{
    partial class FormsDatVeXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsDatVeXe));
            this.grChonLichTrinh = new System.Windows.Forms.GroupBox();
            this.dateNgayDi = new System.Windows.Forms.DateTimePicker();
            this.iconTimKiem = new FontAwesome.Sharp.IconButton();
            this.comboDiemDen = new System.Windows.Forms.ComboBox();
            this.comboDiemDi = new System.Windows.Forms.ComboBox();
            this.comboChonGio = new System.Windows.Forms.ComboBox();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.lblDiemDi = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblChonGio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLuuY = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChonGhe = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTangDuoi = new System.Windows.Forms.Label();
            this.panelGheTangTren = new System.Windows.Forms.Panel();
            this.panelGheTangDuoi = new System.Windows.Forms.Panel();
            this.grChonLichTrinh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grChonLichTrinh
            // 
            this.grChonLichTrinh.Controls.Add(this.dateNgayDi);
            this.grChonLichTrinh.Controls.Add(this.iconTimKiem);
            this.grChonLichTrinh.Controls.Add(this.comboDiemDen);
            this.grChonLichTrinh.Controls.Add(this.comboDiemDi);
            this.grChonLichTrinh.Controls.Add(this.comboChonGio);
            this.grChonLichTrinh.Controls.Add(this.lblDiemDen);
            this.grChonLichTrinh.Controls.Add(this.lblDiemDi);
            this.grChonLichTrinh.Controls.Add(this.lblNgayDi);
            this.grChonLichTrinh.Controls.Add(this.lblChonGio);
            this.grChonLichTrinh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grChonLichTrinh.Location = new System.Drawing.Point(25, 21);
            this.grChonLichTrinh.Name = "grChonLichTrinh";
            this.grChonLichTrinh.Size = new System.Drawing.Size(531, 100);
            this.grChonLichTrinh.TabIndex = 0;
            this.grChonLichTrinh.TabStop = false;
            this.grChonLichTrinh.Text = "Chọn Lịch Trình";
            // 
            // dateNgayDi
            // 
            this.dateNgayDi.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayDi.Location = new System.Drawing.Point(78, 63);
            this.dateNgayDi.Name = "dateNgayDi";
            this.dateNgayDi.Size = new System.Drawing.Size(145, 22);
            this.dateNgayDi.TabIndex = 9;
            // 
            // iconTimKiem
            // 
            this.iconTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTimKiem.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassLocation;
            this.iconTimKiem.IconColor = System.Drawing.Color.Black;
            this.iconTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTimKiem.Location = new System.Drawing.Point(461, 31);
            this.iconTimKiem.Name = "iconTimKiem";
            this.iconTimKiem.Size = new System.Drawing.Size(61, 58);
            this.iconTimKiem.TabIndex = 8;
            this.iconTimKiem.UseVisualStyleBackColor = true;
            // 
            // comboDiemDen
            // 
            this.comboDiemDen.DisplayMember = "diemDen";
            this.comboDiemDen.FormattingEnabled = true;
            this.comboDiemDen.Location = new System.Drawing.Point(307, 63);
            this.comboDiemDen.Name = "comboDiemDen";
            this.comboDiemDen.Size = new System.Drawing.Size(145, 26);
            this.comboDiemDen.TabIndex = 7;
            // 
            // comboDiemDi
            // 
            this.comboDiemDi.DisplayMember = "diemDi";
            this.comboDiemDi.FormattingEnabled = true;
            this.comboDiemDi.Location = new System.Drawing.Point(307, 31);
            this.comboDiemDi.Name = "comboDiemDi";
            this.comboDiemDi.Size = new System.Drawing.Size(145, 26);
            this.comboDiemDi.TabIndex = 6;
            // 
            // comboChonGio
            // 
            this.comboChonGio.DisplayMember = "gioDi";
            this.comboChonGio.FormattingEnabled = true;
            this.comboChonGio.Location = new System.Drawing.Point(78, 31);
            this.comboChonGio.Name = "comboChonGio";
            this.comboChonGio.Size = new System.Drawing.Size(145, 26);
            this.comboChonGio.TabIndex = 0;
            this.comboChonGio.ValueMember = "gioDi";
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDen.Location = new System.Drawing.Point(233, 66);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(69, 16);
            this.lblDiemDen.TabIndex = 4;
            this.lblDiemDen.Text = "Điểm Đến:";
            // 
            // lblDiemDi
            // 
            this.lblDiemDi.AutoSize = true;
            this.lblDiemDi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDi.Location = new System.Drawing.Point(233, 34);
            this.lblDiemDi.Name = "lblDiemDi";
            this.lblDiemDi.Size = new System.Drawing.Size(58, 16);
            this.lblDiemDi.TabIndex = 2;
            this.lblDiemDi.Text = "Điểm Đi:";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(6, 66);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(56, 16);
            this.lblNgayDi.TabIndex = 1;
            this.lblNgayDi.Text = "Ngày Đi:";
            // 
            // lblChonGio
            // 
            this.lblChonGio.AutoSize = true;
            this.lblChonGio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonGio.Location = new System.Drawing.Point(6, 34);
            this.lblChonGio.Name = "lblChonGio";
            this.lblChonGio.Size = new System.Drawing.Size(63, 16);
            this.lblChonGio.TabIndex = 0;
            this.lblChonGio.Text = "Chọn Giờ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLuuY);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(562, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 535);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xác Nhận Thông Tin";
            // 
            // lblLuuY
            // 
            this.lblLuuY.AutoSize = true;
            this.lblLuuY.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblLuuY.Location = new System.Drawing.Point(254, 315);
            this.lblLuuY.Name = "lblLuuY";
            this.lblLuuY.Size = new System.Drawing.Size(220, 195);
            this.lblLuuY.TabIndex = 4;
            this.lblLuuY.Text = resources.GetString("lblLuuY.Text");
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(65, 63);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(183, 26);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(65, 34);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(183, 26);
            this.txtHoTen.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Số Lượng Ghế:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Giá Vé:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Số Ghế:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Thời Gian:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chuyến:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Họ Tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChonGhe);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblTangDuoi);
            this.groupBox3.Controls.Add(this.panelGheTangTren);
            this.groupBox3.Controls.Add(this.panelGheTangDuoi);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 429);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn Ghế Ngồi";
            // 
            // btnChonGhe
            // 
            this.btnChonGhe.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChonGhe.IconColor = System.Drawing.Color.Black;
            this.btnChonGhe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonGhe.Location = new System.Drawing.Point(50, 321);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(123, 52);
            this.btnChonGhe.TabIndex = 9;
            this.btnChonGhe.Text = "Chọn Ghế";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tầng Dưới";
            // 
            // lblTangDuoi
            // 
            this.lblTangDuoi.AutoSize = true;
            this.lblTangDuoi.Location = new System.Drawing.Point(78, 33);
            this.lblTangDuoi.Name = "lblTangDuoi";
            this.lblTangDuoi.Size = new System.Drawing.Size(82, 18);
            this.lblTangDuoi.TabIndex = 7;
            this.lblTangDuoi.Text = "Tầng Trên";
            // 
            // panelGheTangTren
            // 
            this.panelGheTangTren.Location = new System.Drawing.Point(225, 54);
            this.panelGheTangTren.Name = "panelGheTangTren";
            this.panelGheTangTren.Size = new System.Drawing.Size(180, 210);
            this.panelGheTangTren.TabIndex = 6;
            this.panelGheTangTren.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGheTangTren_Load);
            // 
            // panelGheTangDuoi
            // 
            this.panelGheTangDuoi.Location = new System.Drawing.Point(30, 54);
            this.panelGheTangDuoi.Name = "panelGheTangDuoi";
            this.panelGheTangDuoi.Size = new System.Drawing.Size(180, 210);
            this.panelGheTangDuoi.TabIndex = 5;
            this.panelGheTangDuoi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGheTangDuoi_Load);
            // 
            // FormsDatVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grChonLichTrinh);
            this.Name = "FormsDatVeXe";
            this.Text = "Đặt Vé Xe";
            this.Load += new System.EventHandler(this.FormsDatVeXe_Load);
            this.grChonLichTrinh.ResumeLayout(false);
            this.grChonLichTrinh.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grChonLichTrinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboDiemDen;
        private System.Windows.Forms.ComboBox comboDiemDi;
        private System.Windows.Forms.ComboBox comboChonGio;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.Label lblDiemDi;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblChonGio;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconTimKiem;
        private System.Windows.Forms.DateTimePicker dateNgayDi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLuuY;
        private System.Windows.Forms.Panel panelGheTangTren;
        private System.Windows.Forms.Panel panelGheTangDuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTangDuoi;
        private FontAwesome.Sharp.IconButton btnChonGhe;
    }
}