namespace GUI
{
    partial class TrangChu
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
            this.panelTop = new GUI.Resources.GradientPanel();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblHome = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.PanelMenu = new GUI.Resources.GradientPanel();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnFormQLThongKe = new FontAwesome.Sharp.IconButton();
            this.btnFormQLKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnFormQuanLyXe = new FontAwesome.Sharp.IconButton();
            this.btnFormQLChuyenDi = new FontAwesome.Sharp.IconButton();
            this.btnFormDatVeXe = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Angle = 90F;
            this.panelTop.BackColor = System.Drawing.Color.SandyBrown;
            this.panelTop.BottomColor = System.Drawing.Color.DarkOrange;
            this.panelTop.Controls.Add(this.btnMaximize);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.lblHome);
            this.panelTop.Controls.Add(this.iconCurrentChildForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Wheat;
            this.panelTop.Location = new System.Drawing.Point(230, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1034, 70);
            this.panelTop.TabIndex = 2;
            this.panelTop.TopColor = System.Drawing.Color.SandyBrown;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Bisque;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(965, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 20);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Bisque;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 15;
            this.btnMinimize.Location = new System.Drawing.Point(929, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 20);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnExit.IconColor = System.Drawing.Color.Bisque;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 15;
            this.btnExit.Location = new System.Drawing.Point(1001, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(45, 28);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(72, 16);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Trang Chủ";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Chocolate;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Chocolate;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(10, 20);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // PanelMenu
            // 
            this.PanelMenu.Angle = 90F;
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.BottomColor = System.Drawing.Color.SandyBrown;
            this.PanelMenu.Controls.Add(this.btnThoat);
            this.PanelMenu.Controls.Add(this.btnFormQLThongKe);
            this.PanelMenu.Controls.Add(this.btnFormQLKhachHang);
            this.PanelMenu.Controls.Add(this.btnFormQuanLyXe);
            this.PanelMenu.Controls.Add(this.btnFormQLChuyenDi);
            this.PanelMenu.Controls.Add(this.btnFormDatVeXe);
            this.PanelMenu.Controls.Add(this.btnHome);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.ForeColor = System.Drawing.Color.White;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(230, 681);
            this.PanelMenu.TabIndex = 1;
            this.PanelMenu.TopColor = System.Drawing.Color.DarkOrange;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 32;
            this.btnThoat.Location = new System.Drawing.Point(0, 634);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(230, 47);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnFormQLThongKe
            // 
            this.btnFormQLThongKe.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFormQLThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormQLThongKe.FlatAppearance.BorderSize = 0;
            this.btnFormQLThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormQLThongKe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormQLThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnFormQLThongKe.IconColor = System.Drawing.Color.White;
            this.btnFormQLThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormQLThongKe.IconSize = 32;
            this.btnFormQLThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormQLThongKe.Location = new System.Drawing.Point(0, 353);
            this.btnFormQLThongKe.Name = "btnFormQLThongKe";
            this.btnFormQLThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFormQLThongKe.Size = new System.Drawing.Size(230, 57);
            this.btnFormQLThongKe.TabIndex = 5;
            this.btnFormQLThongKe.Text = "Báo Cáo Thống Kê";
            this.btnFormQLThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormQLThongKe.UseVisualStyleBackColor = false;
            this.btnFormQLThongKe.Click += new System.EventHandler(this.btnFormQLThongKe_Click);
            // 
            // btnFormQLKhachHang
            // 
            this.btnFormQLKhachHang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFormQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnFormQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormQLKhachHang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormQLKhachHang.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnFormQLKhachHang.IconColor = System.Drawing.Color.White;
            this.btnFormQLKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormQLKhachHang.IconSize = 32;
            this.btnFormQLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormQLKhachHang.Location = new System.Drawing.Point(0, 296);
            this.btnFormQLKhachHang.Name = "btnFormQLKhachHang";
            this.btnFormQLKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFormQLKhachHang.Size = new System.Drawing.Size(230, 57);
            this.btnFormQLKhachHang.TabIndex = 4;
            this.btnFormQLKhachHang.Text = "Quản Lý Khách Hàng";
            this.btnFormQLKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormQLKhachHang.UseVisualStyleBackColor = false;
            this.btnFormQLKhachHang.Click += new System.EventHandler(this.btnFormQLKhachHang_Click);
            // 
            // btnFormQuanLyXe
            // 
            this.btnFormQuanLyXe.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFormQuanLyXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormQuanLyXe.FlatAppearance.BorderSize = 0;
            this.btnFormQuanLyXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormQuanLyXe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormQuanLyXe.IconChar = FontAwesome.Sharp.IconChar.Bus;
            this.btnFormQuanLyXe.IconColor = System.Drawing.Color.White;
            this.btnFormQuanLyXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormQuanLyXe.IconSize = 32;
            this.btnFormQuanLyXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormQuanLyXe.Location = new System.Drawing.Point(0, 239);
            this.btnFormQuanLyXe.Name = "btnFormQuanLyXe";
            this.btnFormQuanLyXe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFormQuanLyXe.Size = new System.Drawing.Size(230, 57);
            this.btnFormQuanLyXe.TabIndex = 3;
            this.btnFormQuanLyXe.Text = "Quản Lý Xe";
            this.btnFormQuanLyXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormQuanLyXe.UseVisualStyleBackColor = false;
            this.btnFormQuanLyXe.Click += new System.EventHandler(this.btnFormQuanLyXe_Click);
            // 
            // btnFormQLChuyenDi
            // 
            this.btnFormQLChuyenDi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFormQLChuyenDi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormQLChuyenDi.FlatAppearance.BorderSize = 0;
            this.btnFormQLChuyenDi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormQLChuyenDi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormQLChuyenDi.IconChar = FontAwesome.Sharp.IconChar.MapMarked;
            this.btnFormQLChuyenDi.IconColor = System.Drawing.Color.White;
            this.btnFormQLChuyenDi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormQLChuyenDi.IconSize = 32;
            this.btnFormQLChuyenDi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormQLChuyenDi.Location = new System.Drawing.Point(0, 182);
            this.btnFormQLChuyenDi.Name = "btnFormQLChuyenDi";
            this.btnFormQLChuyenDi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFormQLChuyenDi.Size = new System.Drawing.Size(230, 57);
            this.btnFormQLChuyenDi.TabIndex = 2;
            this.btnFormQLChuyenDi.Text = "Quản Lý Chuyến Đi";
            this.btnFormQLChuyenDi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormQLChuyenDi.UseVisualStyleBackColor = false;
            this.btnFormQLChuyenDi.Click += new System.EventHandler(this.btnFormQLChuyenDi_Click);
            // 
            // btnFormDatVeXe
            // 
            this.btnFormDatVeXe.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFormDatVeXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormDatVeXe.FlatAppearance.BorderSize = 0;
            this.btnFormDatVeXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormDatVeXe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDatVeXe.ForeColor = System.Drawing.Color.White;
            this.btnFormDatVeXe.IconChar = FontAwesome.Sharp.IconChar.TicketSimple;
            this.btnFormDatVeXe.IconColor = System.Drawing.Color.White;
            this.btnFormDatVeXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormDatVeXe.IconSize = 32;
            this.btnFormDatVeXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormDatVeXe.Location = new System.Drawing.Point(0, 125);
            this.btnFormDatVeXe.Name = "btnFormDatVeXe";
            this.btnFormDatVeXe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFormDatVeXe.Size = new System.Drawing.Size(230, 57);
            this.btnFormDatVeXe.TabIndex = 1;
            this.btnFormDatVeXe.Text = "Đặt Vé Xe";
            this.btnFormDatVeXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormDatVeXe.UseVisualStyleBackColor = false;
            this.btnFormDatVeXe.Click += new System.EventHandler(this.btnFormDatVeXe_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Image = global::GUI.Properties.Resources.logo_removebg_preview__1_;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(230, 125);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelBody
            // 
            this.PanelBody.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(230, 70);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(1034, 611);
            this.PanelBody.TabIndex = 3;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.PanelMenu);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.GradientPanel PanelMenu;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnFormQLThongKe;
        private FontAwesome.Sharp.IconButton btnFormQLKhachHang;
        private FontAwesome.Sharp.IconButton btnFormQuanLyXe;
        private FontAwesome.Sharp.IconButton btnFormQLChuyenDi;
        private FontAwesome.Sharp.IconButton btnFormDatVeXe;
        private Resources.GradientPanel panelTop;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblHome;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel PanelBody;
    }
}