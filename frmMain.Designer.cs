
namespace QL_ThuChi
{
    partial class frmMain
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
            this.mnuThuChi = new System.Windows.Forms.MenuStrip();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhanVienTheoCV = new System.Windows.Forms.ToolStripMenuItem();
            this.thuChiTheoLýDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuTheoLD = new System.Windows.Forms.ToolStripMenuItem();
            this.ChiTheoLD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLyDoThuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuChi.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuThuChi
            // 
            this.mnuThuChi.BackColor = System.Drawing.Color.White;
            this.mnuThuChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuThuChi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuThuChi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy,
            this.mnuCapNhat,
            this.mnuTienIch});
            this.mnuThuChi.Location = new System.Drawing.Point(0, 0);
            this.mnuThuChi.Name = "mnuThuChi";
            this.mnuThuChi.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuThuChi.Size = new System.Drawing.Size(1053, 34);
            this.mnuThuChi.TabIndex = 1;
            this.mnuThuChi.Text = "menuStrip1";
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuChucVu,
            this.toolStripSeparator3,
            this.mnuNhanVienTheoCV,
            this.thuChiTheoLýDoToolStripMenuItem});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(106, 30);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(322, 30);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuChucVu
            // 
            this.mnuChucVu.Name = "mnuChucVu";
            this.mnuChucVu.Size = new System.Drawing.Size(322, 30);
            this.mnuChucVu.Text = "Chức vụ";
            this.mnuChucVu.Click += new System.EventHandler(this.mnuChucVu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(319, 6);
            // 
            // mnuNhanVienTheoCV
            // 
            this.mnuNhanVienTheoCV.Name = "mnuNhanVienTheoCV";
            this.mnuNhanVienTheoCV.Size = new System.Drawing.Size(322, 30);
            this.mnuNhanVienTheoCV.Text = "Nhân viên theo chức vụ";
            this.mnuNhanVienTheoCV.Click += new System.EventHandler(this.mnuNhanVienTheoCV_Click);
            // 
            // thuChiTheoLýDoToolStripMenuItem
            // 
            this.thuChiTheoLýDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuTheoLD,
            this.ChiTheoLD});
            this.thuChiTheoLýDoToolStripMenuItem.Name = "thuChiTheoLýDoToolStripMenuItem";
            this.thuChiTheoLýDoToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.thuChiTheoLýDoToolStripMenuItem.Text = "Thu chi theo lý do";
            // 
            // mnuThuTheoLD
            // 
            this.mnuThuTheoLD.Name = "mnuThuTheoLD";
            this.mnuThuTheoLD.Size = new System.Drawing.Size(125, 30);
            this.mnuThuTheoLD.Text = "Thu";
            this.mnuThuTheoLD.Click += new System.EventHandler(this.mnuThuTheoLD_Click);
            // 
            // ChiTheoLD
            // 
            this.ChiTheoLD.Name = "ChiTheoLD";
            this.ChiTheoLD.Size = new System.Drawing.Size(125, 30);
            this.ChiTheoLD.Text = "Chi";
            this.ChiTheoLD.Click += new System.EventHandler(this.ChiTheoLD_Click);
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThu,
            this.mnuChi,
            this.toolStripSeparator4,
            this.mnuLyDoThuChi});
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(118, 30);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuThu
            // 
            this.mnuThu.Name = "mnuThu";
            this.mnuThu.Size = new System.Drawing.Size(220, 30);
            this.mnuThu.Text = "Thu";
            this.mnuThu.Click += new System.EventHandler(this.mnuThu_Click);
            // 
            // mnuChi
            // 
            this.mnuChi.Name = "mnuChi";
            this.mnuChi.Size = new System.Drawing.Size(220, 30);
            this.mnuChi.Text = "Chi";
            this.mnuChi.Click += new System.EventHandler(this.mnuChi_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // mnuLyDoThuChi
            // 
            this.mnuLyDoThuChi.Name = "mnuLyDoThuChi";
            this.mnuLyDoThuChi.Size = new System.Drawing.Size(220, 30);
            this.mnuLyDoThuChi.Text = "Lý do thu chi";
            this.mnuLyDoThuChi.Click += new System.EventHandler(this.mnuLyDoThuChi_Click);
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDoiMatKhau,
            this.mnuDangXuat,
            this.toolStripSeparator1,
            this.mnuGioiThieu,
            this.toolStripSeparator2,
            this.mnuThoat});
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(107, 30);
            this.mnuTienIch.Text = "Tiện ích";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(222, 30);
            this.mnuDangNhap.Text = "Đăng nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(222, 30);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(222, 30);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(222, 30);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(222, 30);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_ThuChi.Properties.Resources.picQLTC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 600);
            this.Controls.Add(this.mnuThuChi);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuThuChi;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Quản Lý Thu Chi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuThuChi.ResumeLayout(false);
            this.mnuThuChi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuThuChi;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuChucVu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVienTheoCV;
        private System.Windows.Forms.ToolStripMenuItem mnuLyDoThuChi;
        private System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        public System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        public System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        public System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        public System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThu;
        private System.Windows.Forms.ToolStripMenuItem mnuChi;
        private System.Windows.Forms.ToolStripMenuItem thuChiTheoLýDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThuTheoLD;
        private System.Windows.Forms.ToolStripMenuItem ChiTheoLD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}