namespace QL_ThuChi
{
    partial class frmThuTheoLyDo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSTTPhieu = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.cboLyDoThu = new System.Windows.Forms.ComboBox();
            this.dgvThu = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDongForm = new System.Windows.Forms.Button();
            this.cboNVThu = new System.Windows.Forms.ComboBox();
            this.cboNVNop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phiếu thu theo lý do";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(108, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "STT Phiếu:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(108, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên thu:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(108, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên nộp:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(108, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(108, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày thu:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(108, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lý do thu:";
            // 
            // txtSTTPhieu
            // 
            this.txtSTTPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTTPhieu.Location = new System.Drawing.Point(256, 101);
            this.txtSTTPhieu.Name = "txtSTTPhieu";
            this.txtSTTPhieu.Size = new System.Drawing.Size(373, 30);
            this.txtSTTPhieu.TabIndex = 0;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(257, 209);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(374, 30);
            this.txtSoTien.TabIndex = 3;
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThu.Location = new System.Drawing.Point(256, 245);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(373, 30);
            this.dtpNgayThu.TabIndex = 4;
            // 
            // cboLyDoThu
            // 
            this.cboLyDoThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLyDoThu.FormattingEnabled = true;
            this.cboLyDoThu.Location = new System.Drawing.Point(257, 65);
            this.cboLyDoThu.Name = "cboLyDoThu";
            this.cboLyDoThu.Size = new System.Drawing.Size(373, 30);
            this.cboLyDoThu.TabIndex = 5;
            this.cboLyDoThu.SelectedIndexChanged += new System.EventHandler(this.cboLyDoThu_SelectedIndexChanged);
            // 
            // dgvThu
            // 
            this.dgvThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThu.Location = new System.Drawing.Point(12, 281);
            this.dgvThu.Name = "dgvThu";
            this.dgvThu.RowHeadersWidth = 51;
            this.dgvThu.RowTemplate.Height = 24;
            this.dgvThu.Size = new System.Drawing.Size(745, 275);
            this.dgvThu.TabIndex = 7;
            this.dgvThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThu_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(64, 567);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 43);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm phiếu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChinhSua.Location = new System.Drawing.Point(232, 567);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(144, 42);
            this.btnChinhSua.TabIndex = 9;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuu.Location = new System.Drawing.Point(394, 567);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(138, 42);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnKhongLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhongLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKhongLuu.Location = new System.Drawing.Point(538, 567);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(144, 42);
            this.btnKhongLuu.TabIndex = 11;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(232, 614);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 44);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa phiếu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDongForm
            // 
            this.btnDongForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnDongForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDongForm.Location = new System.Drawing.Point(394, 614);
            this.btnDongForm.Name = "btnDongForm";
            this.btnDongForm.Size = new System.Drawing.Size(138, 44);
            this.btnDongForm.TabIndex = 13;
            this.btnDongForm.Text = "Đóng";
            this.btnDongForm.UseVisualStyleBackColor = true;
            this.btnDongForm.Click += new System.EventHandler(this.btnDongForm_Click);
            // 
            // cboNVThu
            // 
            this.cboNVThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNVThu.FormattingEnabled = true;
            this.cboNVThu.Location = new System.Drawing.Point(257, 137);
            this.cboNVThu.Name = "cboNVThu";
            this.cboNVThu.Size = new System.Drawing.Size(373, 30);
            this.cboNVThu.TabIndex = 14;
            // 
            // cboNVNop
            // 
            this.cboNVNop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNVNop.FormattingEnabled = true;
            this.cboNVNop.Location = new System.Drawing.Point(256, 173);
            this.cboNVNop.Name = "cboNVNop";
            this.cboNVNop.Size = new System.Drawing.Size(373, 30);
            this.cboNVNop.TabIndex = 15;
            // 
            // frmThuTheoLyDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::QL_ThuChi.Properties.Resources._9d59ed441d94dbca8285;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 670);
            this.ControlBox = false;
            this.Controls.Add(this.cboNVNop);
            this.Controls.Add(this.cboNVThu);
            this.Controls.Add(this.btnDongForm);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThu);
            this.Controls.Add(this.cboLyDoThu);
            this.Controls.Add(this.dtpNgayThu);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtSTTPhieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThuTheoLyDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phiếu thu";
            this.Load += new System.EventHandler(this.frmThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSTTPhieu;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.ComboBox cboLyDoThu;
        private System.Windows.Forms.DataGridView dgvThu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDongForm;
        private System.Windows.Forms.ComboBox cboNVThu;
        private System.Windows.Forms.ComboBox cboNVNop;
    }
}