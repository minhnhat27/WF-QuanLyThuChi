namespace QL_ThuChi
{
    partial class frmChi
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
            this.cboNVNhan = new System.Windows.Forms.ComboBox();
            this.cboNVChi = new System.Windows.Forms.ComboBox();
            this.btnDongForm = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.cboLyDoChi = new System.Windows.Forms.ComboBox();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtSTTPhieu = new System.Windows.Forms.TextBox();
            this.lblLyDoChi = new System.Windows.Forms.Label();
            this.lblNgayChi = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblNhanVienNhan = new System.Windows.Forms.Label();
            this.lblNhanVienChi = new System.Windows.Forms.Label();
            this.lblSTTPhieu = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNVNhan
            // 
            this.cboNVNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNVNhan.FormattingEnabled = true;
            this.cboNVNhan.Location = new System.Drawing.Point(294, 124);
            this.cboNVNhan.Name = "cboNVNhan";
            this.cboNVNhan.Size = new System.Drawing.Size(317, 30);
            this.cboNVNhan.TabIndex = 35;
            // 
            // cboNVChi
            // 
            this.cboNVChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNVChi.FormattingEnabled = true;
            this.cboNVChi.Location = new System.Drawing.Point(294, 84);
            this.cboNVChi.Name = "cboNVChi";
            this.cboNVChi.Size = new System.Drawing.Size(317, 30);
            this.cboNVChi.TabIndex = 34;
            // 
            // btnDongForm
            // 
            this.btnDongForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongForm.Location = new System.Drawing.Point(402, 648);
            this.btnDongForm.Name = "btnDongForm";
            this.btnDongForm.Size = new System.Drawing.Size(144, 41);
            this.btnDongForm.TabIndex = 33;
            this.btnDongForm.Text = "Đóng";
            this.btnDongForm.UseVisualStyleBackColor = true;
            this.btnDongForm.Click += new System.EventHandler(this.btnDongForm_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(242, 648);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 41);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa phiếu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.Location = new System.Drawing.Point(565, 601);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(144, 41);
            this.btnKhongLuu.TabIndex = 31;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(402, 601);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 41);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(242, 601);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(144, 41);
            this.btnChinhSua.TabIndex = 29;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(71, 601);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 41);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm phiếu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvChi
            // 
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Location = new System.Drawing.Point(12, 293);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.RowHeadersWidth = 51;
            this.dgvChi.RowTemplate.Height = 24;
            this.dgvChi.Size = new System.Drawing.Size(745, 302);
            this.dgvChi.TabIndex = 27;
            this.dgvChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChi_CellClick);
            // 
            // cboLyDoChi
            // 
            this.cboLyDoChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLyDoChi.FormattingEnabled = true;
            this.cboLyDoChi.Location = new System.Drawing.Point(293, 244);
            this.cboLyDoChi.Name = "cboLyDoChi";
            this.cboLyDoChi.Size = new System.Drawing.Size(318, 30);
            this.cboLyDoChi.TabIndex = 25;
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChi.Location = new System.Drawing.Point(293, 204);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(318, 30);
            this.dtpNgayChi.TabIndex = 23;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(293, 164);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(318, 30);
            this.txtSoTien.TabIndex = 21;
            // 
            // txtSTTPhieu
            // 
            this.txtSTTPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTTPhieu.Location = new System.Drawing.Point(293, 44);
            this.txtSTTPhieu.Name = "txtSTTPhieu";
            this.txtSTTPhieu.Size = new System.Drawing.Size(318, 30);
            this.txtSTTPhieu.TabIndex = 17;
            // 
            // lblLyDoChi
            // 
            this.lblLyDoChi.AutoSize = true;
            this.lblLyDoChi.BackColor = System.Drawing.Color.Transparent;
            this.lblLyDoChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyDoChi.ForeColor = System.Drawing.Color.Navy;
            this.lblLyDoChi.Location = new System.Drawing.Point(147, 251);
            this.lblLyDoChi.Name = "lblLyDoChi";
            this.lblLyDoChi.Size = new System.Drawing.Size(94, 23);
            this.lblLyDoChi.TabIndex = 26;
            this.lblLyDoChi.Text = "Lý do chi:";
            // 
            // lblNgayChi
            // 
            this.lblNgayChi.AutoSize = true;
            this.lblNgayChi.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayChi.ForeColor = System.Drawing.Color.Navy;
            this.lblNgayChi.Location = new System.Drawing.Point(147, 211);
            this.lblNgayChi.Name = "lblNgayChi";
            this.lblNgayChi.Size = new System.Drawing.Size(90, 23);
            this.lblNgayChi.TabIndex = 24;
            this.lblNgayChi.Text = "Ngày chi:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.BackColor = System.Drawing.Color.Transparent;
            this.lblSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.Color.Navy;
            this.lblSoTien.Location = new System.Drawing.Point(147, 171);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(75, 23);
            this.lblSoTien.TabIndex = 22;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // lblNhanVienNhan
            // 
            this.lblNhanVienNhan.AutoSize = true;
            this.lblNhanVienNhan.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVienNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVienNhan.ForeColor = System.Drawing.Color.Navy;
            this.lblNhanVienNhan.Location = new System.Drawing.Point(147, 131);
            this.lblNhanVienNhan.Name = "lblNhanVienNhan";
            this.lblNhanVienNhan.Size = new System.Drawing.Size(145, 23);
            this.lblNhanVienNhan.TabIndex = 20;
            this.lblNhanVienNhan.Text = "Nhân viên nhận:";
            // 
            // lblNhanVienChi
            // 
            this.lblNhanVienChi.AutoSize = true;
            this.lblNhanVienChi.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVienChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVienChi.ForeColor = System.Drawing.Color.Navy;
            this.lblNhanVienChi.Location = new System.Drawing.Point(147, 91);
            this.lblNhanVienChi.Name = "lblNhanVienChi";
            this.lblNhanVienChi.Size = new System.Drawing.Size(129, 23);
            this.lblNhanVienChi.TabIndex = 19;
            this.lblNhanVienChi.Text = "Nhân viên chi:";
            // 
            // lblSTTPhieu
            // 
            this.lblSTTPhieu.AutoSize = true;
            this.lblSTTPhieu.BackColor = System.Drawing.Color.Transparent;
            this.lblSTTPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTTPhieu.ForeColor = System.Drawing.Color.Navy;
            this.lblSTTPhieu.Location = new System.Drawing.Point(147, 51);
            this.lblSTTPhieu.Name = "lblSTTPhieu";
            this.lblSTTPhieu.Size = new System.Drawing.Size(106, 23);
            this.lblSTTPhieu.TabIndex = 18;
            this.lblSTTPhieu.Text = "STT Phiếu:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(277, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(251, 32);
            this.lblTieuDe.TabIndex = 16;
            this.lblTieuDe.Text = "Thông tin phiếu chi";
            // 
            // frmChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_ThuChi.Properties.Resources._9d59ed441d94dbca8285;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 709);
            this.ControlBox = false;
            this.Controls.Add(this.cboNVNhan);
            this.Controls.Add(this.cboNVChi);
            this.Controls.Add(this.btnDongForm);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvChi);
            this.Controls.Add(this.cboLyDoChi);
            this.Controls.Add(this.dtpNgayChi);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtSTTPhieu);
            this.Controls.Add(this.lblLyDoChi);
            this.Controls.Add(this.lblNgayChi);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.lblNhanVienNhan);
            this.Controls.Add(this.lblNhanVienChi);
            this.Controls.Add(this.lblSTTPhieu);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phiếu chi";
            this.Load += new System.EventHandler(this.frmChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNVNhan;
        private System.Windows.Forms.ComboBox cboNVChi;
        private System.Windows.Forms.Button btnDongForm;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.ComboBox cboLyDoChi;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtSTTPhieu;
        private System.Windows.Forms.Label lblLyDoChi;
        private System.Windows.Forms.Label lblNgayChi;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblNhanVienNhan;
        private System.Windows.Forms.Label lblNhanVienChi;
        private System.Windows.Forms.Label lblSTTPhieu;
        private System.Windows.Forms.Label lblTieuDe;
    }
}