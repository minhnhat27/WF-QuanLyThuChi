using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_ThuChi
{
    public partial class frmChi : Form
    {
        DataTable dtChi = new DataTable("Chi");
        DataTable dtLyDoChi = new DataTable("LyDoThuChi");
        DataTable dtNVChi = new DataTable("NhanVien");
        DataTable dtNVNhan = new DataTable("NhanVien");
        bool blnThem = false;

        public frmChi()
        {
            InitializeComponent();
        }

        private void frmChi_Load(object sender, EventArgs e)
        {
            string strSelect = "Select * From Chi Order by STTPhieu";
            MyPublics.OpenData(strSelect, dtChi);

            strSelect = "Select * from LyDoThuChi Where MaLyDo like 'CHI%' ";
            MyPublics.OpenData(strSelect, dtLyDoChi);

            strSelect = "Select * From NhanVien ";
            MyPublics.OpenData(strSelect, dtNVChi);
            MyPublics.OpenData(strSelect, dtNVNhan);

            cboLyDoChi.DataSource = dtLyDoChi;
            cboLyDoChi.DisplayMember = "DienGiai";
            cboLyDoChi.ValueMember = "MaLyDo";
            cboLyDoChi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLyDoChi.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboNVChi.DataSource = dtNVChi;
            cboNVChi.DisplayMember = "HoTen";
            cboNVChi.ValueMember = "MaNV";
            cboNVChi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNVChi.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboNVNhan.DataSource = dtNVNhan;
            cboNVNhan.DisplayMember = "HoTen";
            cboNVNhan.ValueMember = "MaNV";
            cboNVNhan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNVNhan.AutoCompleteSource = AutoCompleteSource.ListItems;

            txtSTTPhieu.MaxLength = 4;
            dgvChi.DataSource = dtChi;
            dgvChi.AllowUserToAddRows = false;
            dgvChi.AllowUserToDeleteRows = false;

            dgvChi.Columns[0].Width = 75;
            dgvChi.Columns[0].HeaderText = "STT Phiếu";
            dgvChi.Columns[1].Width = 105;
            dgvChi.Columns[1].HeaderText = "Mã NV Chi";
            dgvChi.Columns[2].Width = 105;
            dgvChi.Columns[2].HeaderText = "Mã NV Nộp";
            dgvChi.Columns[3].Width = 150;
            dgvChi.Columns[3].HeaderText = "Số Tiền";
            dgvChi.Columns[4].Width = 120;
            dgvChi.Columns[4].HeaderText = "Ngày Chi";
            dgvChi.Columns[5].Width = 120;
            dgvChi.Columns[5].HeaderText = "Lý Do Chi";
            dgvChi.EnableHeadersVisualStyles = false;
            dgvChi.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dgvChi.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            Font font = new System.Drawing.Font("Times New Roman", 14.0f, FontStyle.Bold);
            dgvChi.ColumnHeadersDefaultCellStyle.Font = font;
            dgvChi.BackgroundColor = Color.White;
            GanDuLieu();
            DKBinhThuong();
        }

        void DKBinhThuong()
        {
            if (MyPublics.strQuyenSD == "Admin")
            {
                btnThem.Enabled = true;
                btnChinhSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDongForm.Enabled = true;
            txtSTTPhieu.ReadOnly = true;
            txtSTTPhieu.BackColor = Color.White;
            txtSoTien.ReadOnly = true;
            txtSoTien.BackColor = Color.White;
            cboNVChi.Enabled = false;
            cboNVNhan.Enabled = false;
            dtpNgayChi.Enabled = false;
            cboLyDoChi.Enabled = false;
            dgvChi.Enabled = true;
        }

        void GanDuLieu()
        {
            if (dtChi.Rows.Count > 0)
            {
                txtSTTPhieu.Text = dgvChi[0, dgvChi.CurrentRow.Index].Value.ToString();
                cboNVChi.SelectedValue = dgvChi[1, dgvChi.CurrentRow.Index].Value.ToString();
                cboNVNhan.SelectedValue = dgvChi[2, dgvChi.CurrentRow.Index].Value.ToString();
                txtSoTien.Text = dgvChi[3, dgvChi.CurrentRow.Index].Value.ToString();
                dtpNgayChi.Value = DateTime.Parse(dgvChi[4, dgvChi.CurrentRow.Index].Value.ToString());
                cboLyDoChi.SelectedValue = dgvChi[5, dgvChi.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtSTTPhieu.Clear();
                cboNVChi.SelectedValue = -1;
                cboNVNhan.SelectedValue = -1;
                txtSoTien.Clear();
                cboLyDoChi.SelectedValue = -1;
            }
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        void DKThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;
            txtSTTPhieu.ReadOnly = false;
            txtSoTien.ReadOnly = false;
            dtpNgayChi.Value = DateTime.Today;
            cboNVChi.Enabled = true;
            cboNVChi.SelectedIndex = 0;
            cboNVNhan.Enabled = true;
            cboNVNhan.SelectedIndex = 0;
            cboLyDoChi.Enabled = true;
            cboLyDoChi.SelectedIndex = 0;
            dgvChi.Enabled = false;
            dtpNgayChi.Enabled = true;
            txtSTTPhieu.Clear();
            txtSoTien.Clear();
            txtSTTPhieu.Focus();
        }

        void DKChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;
            txtSTTPhieu.ReadOnly = true;
            txtSoTien.ReadOnly = false;

            cboNVChi.Enabled = true;
            cboNVNhan.Enabled = true;
            cboLyDoChi.Enabled = true;
            dgvChi.Enabled = false;
            dtpNgayChi.Enabled = true;
            txtSoTien.Focus();
        }

        void LuuPhieuMoi()
        {
            string strSql;
            if (blnThem)
            {
                strSql = "Insert into Chi values(@STTPhieu, @MaNVChi, @MaNVNhan, @SoTien, @NgayChi, @LyDoChi)";
            }
            else
                strSql = "Update Chi Set MaNV_Chi = @MaNVChi, MaNV_Nhan = @MaNVNhan, SoTien = @SoTien,  NgayChi = @NgayChi, LyDoChi = @LyDoChi Where STTPhieu = @STTPhieu";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            string strNVChi, strNVNhan, strLyDoChi;
            strNVChi = cboNVChi.SelectedValue.ToString();
            strNVNhan = cboNVNhan.SelectedValue.ToString();
            strLyDoChi = cboLyDoChi.SelectedValue.ToString();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@STTPhieu", txtSTTPhieu.Text);
            cmdCommand.Parameters.AddWithValue("@MaNVChi", strNVChi);
            cmdCommand.Parameters.AddWithValue("@MaNVNhan", strNVNhan);
            cmdCommand.Parameters.AddWithValue("@SoTien", txtSoTien.Text);
            cmdCommand.Parameters.AddWithValue("@NgayChi", dtpNgayChi.Value);
            cmdCommand.Parameters.AddWithValue("@LyDoChi", strLyDoChi);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            if (blnThem)
            {
                dtChi.Rows.Add(txtSTTPhieu.Text, strNVChi, strNVNhan, txtSoTien.Text, dtpNgayChi.Value, strLyDoChi);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvChi.CurrentRow.Index;
                dtChi.Rows[curRow][1] = strNVChi;
                dtChi.Rows[curRow][2] = strNVNhan;
                dtChi.Rows[curRow][3] = txtSoTien.Text;
                dtChi.Rows[curRow][4] = dtpNgayChi.Value;
                dtChi.Rows[curRow][5] = strLyDoChi;
            }
            DKBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float fSoTien;
            if (txtSTTPhieu.Text == "")
            {
                MessageBox.Show("Chưa số thứ tự phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTTPhieu.Focus();
                return;
            }
            if (txtSoTien.Text == "" || !float.TryParse(txtSoTien.Text, out fSoTien))
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.Focus();
                return;
            }
            if (cboNVChi.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Nhân viên chi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNVChi.Focus();
                return;
            }
            if (cboNVNhan.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Nhân viên nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNVNhan.Focus();
                return;
            }
            if (cboLyDoChi.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Lý do chi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLyDoChi.Focus();
                return;
            }
            if (blnThem && MyPublics.TonTaiKhoaChinh(txtSTTPhieu.Text, "STTPhieu", "Chi"))
            {
                MessageBox.Show("Phiếu này đã có rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSTTPhieu.Focus();
            }
            else
                LuuPhieuMoi();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DKBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (blnDongY == DialogResult.Yes)
            {
                string strDel = "Delete Chi Where STTPhieu = @STTPhieu";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strDel, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@STTPhieu", txtSTTPhieu.Text);

                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();

                int curRow = dgvChi.CurrentRow.Index;
                dtChi.Rows.RemoveAt(curRow);
                GanDuLieu();
            }
            DKBinhThuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DKThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DKChinhSua();
        }

    }
}
