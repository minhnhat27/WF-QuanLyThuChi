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
using System.Drawing.Text;

namespace QL_ThuChi
{
    public partial class frmThuTheoLyDo : Form
    {
        DataTable dtThu = new DataTable("Thu");
        DataTable dtLyDoThu = new DataTable("LyDoThuChi");
        DataTable dtNVThu = new DataTable("NhanVien");
        DataTable dtNVNop = new DataTable("NhanVien");
        DataView dvThu = new DataView();
        int VTLyDo, ThemSua = 0;

        public frmThuTheoLyDo()
        {
            InitializeComponent();
        }

        private void frmThu_Load(object sender, EventArgs e)
        {
            NhanDuLieu();
            string strSelect;
            strSelect = "Select * from LyDoThuChi Where MaLyDo like 'THU%' ";
            MyPublics.OpenData(strSelect, dtLyDoThu);
            cboLyDoThu.DataSource = dtLyDoThu;
            cboLyDoThu.DisplayMember = "DienGiai";
            cboLyDoThu.ValueMember = "MaLyDo";
            cboLyDoThu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLyDoThu.AutoCompleteSource = AutoCompleteSource.ListItems;

            strSelect = "Select MaNV, HoTen From NhanVien ";
            MyPublics.OpenData(strSelect, dtNVThu);
            MyPublics.OpenData(strSelect, dtNVNop);                 
       
            cboNVThu.DataSource = dtNVThu;
            cboNVThu.DisplayMember = "HoTen";
            cboNVThu.ValueMember = "MaNV";
            cboNVThu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNVThu.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboNVNop.DataSource = dtNVNop;
            cboNVNop.DisplayMember = "HoTen";
            cboNVNop.ValueMember = "MaNV";
            cboNVNop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNVNop.AutoCompleteSource = AutoCompleteSource.ListItems;
       
            txtSTTPhieu.MaxLength = 4;            
            txtSoTien.MaxLength = 30;

            dvThu.Table = dtThu;
            dvThu.RowFilter = "LyDoThu like '" + cboLyDoThu.SelectedValue + "'";
            dgvThu.DataSource = dvThu;
            dgvThu.AllowUserToAddRows = false;
            dgvThu.AllowUserToDeleteRows = false;
            dgvThu.Columns[0].Width = 85;
            dgvThu.Columns[0].HeaderText = "STT Phiếu";
            dgvThu.Columns[1].Width = 105;
            dgvThu.Columns[1].HeaderText = "Mã NV Thu";
            dgvThu.Columns[2].Width = 105;
            dgvThu.Columns[2].HeaderText = "Mã NV Nộp";
            dgvThu.Columns[3].Width = 150;
            dgvThu.Columns[3].HeaderText = "Số Tiền";
            dgvThu.Columns[4].Width = 120;
            dgvThu.Columns[4].HeaderText = "Ngày Thu";
            dgvThu.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvThu.Columns[5].Width = 120;
            dgvThu.Columns[5].HeaderText = "Lý Do Thu";
            dgvThu.EnableHeadersVisualStyles = false;
            dgvThu.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dgvThu.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            Font font = new System.Drawing.Font("Times New Roman", 14.0f, FontStyle.Bold);
            dgvThu.ColumnHeadersDefaultCellStyle.Font = font;
            dgvThu.BackgroundColor = Color.White;
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
            if (dvThu.Count <= 0)
            {
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
            cboNVThu.Enabled = false;
            cboNVNop.Enabled = false;
            dtpNgayThu.Enabled = false;
            cboLyDoThu.Enabled = true;
            dgvThu.Enabled = true;
        }

        void NhanDuLieu()
        {
            string strSelect = "Select * From Thu Order by STTPhieu";
            MyPublics.OpenData(strSelect, dtThu);
        }

        void GanDuLieu()
        {
            if (dvThu.Count > 0)
            {
                txtSTTPhieu.Text = dgvThu[0, dgvThu.CurrentRow.Index].Value.ToString();
                cboNVThu.SelectedValue = dgvThu[1, dgvThu.CurrentRow.Index].Value.ToString();
                cboNVNop.SelectedValue = dgvThu[2, dgvThu.CurrentRow.Index].Value.ToString();
                txtSoTien.Text =  dgvThu[3, dgvThu.CurrentRow.Index].Value.ToString();
                dtpNgayThu.Value = DateTime.Parse(dgvThu[4, dgvThu.CurrentRow.Index].Value.ToString());
                DKBinhThuong();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtSTTPhieu.Clear();
                txtSoTien.Clear();
                cboNVThu.SelectedIndex = -1;
                cboNVNop.SelectedIndex = -1;
            }
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThu_CellClick(object sender, DataGridViewCellEventArgs e)
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
            dtpNgayThu.Value = DateTime.Today;            
            cboNVThu.Enabled = true;
            cboNVThu.SelectedIndex = 0;
            cboNVNop.Enabled = true;
            cboNVNop.SelectedIndex = 0;
            cboLyDoThu.Enabled = false;
            dgvThu.Enabled = false;
            dtpNgayThu.Enabled = true;
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
            cboNVThu.Enabled = true;
            cboNVNop.Enabled = true;
            cboLyDoThu.Enabled = true;
            dgvThu.Enabled = false;
            dtpNgayThu.Enabled = true;
            txtSoTien.Focus();
        }

        void LuuPhieuMoi()
        {
            string strSql;
            if (ThemSua == 1)
            {
                strSql = "Insert into Thu values(@STTPhieu, @MaNVThu, @MaNVNop, @SoTien, @NgayThu, @LyDoThu)";
            }
            else
                strSql = "Update Thu Set MaNV_Thu = @MaNVThu, MaNV_Nop = @MaNVNop, SoTien = @SoTien,  NgayThu = @NgayThu, LyDoThu = @LyDoThu Where STTPhieu = @STTPhieu";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();

            string strNVThu, strNVNop, strLyDoThu;
            strNVThu = cboNVThu.SelectedValue.ToString();
            strNVNop = cboNVNop.SelectedValue.ToString();
            strLyDoThu = cboLyDoThu.SelectedValue.ToString();
            
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@STTPhieu", txtSTTPhieu.Text);
            cmdCommand.Parameters.AddWithValue("@MaNVThu", strNVThu);
            cmdCommand.Parameters.AddWithValue("@MaNVNop",strNVNop );
            cmdCommand.Parameters.AddWithValue("@SoTien", txtSoTien.Text);
            cmdCommand.Parameters.AddWithValue("@NgayThu", dtpNgayThu.Value);
            cmdCommand.Parameters.AddWithValue("@LyDoThu", strLyDoThu);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            ThemSua = 0;
            dtThu.Clear();
            NhanDuLieu();

            if (cboLyDoThu.SelectedIndex == VTLyDo)
            {
                dvThu.Sort = "STTPhieu";
                int curRow = dvThu.Find(txtSTTPhieu.Text);
                dgvThu.CurrentCell = dgvThu[0, curRow];
            }
            else
            {
                cboLyDoThu.SelectedIndex = VTLyDo;
                if (dvThu.Count > 0)
                    dgvThu.CurrentCell = dgvThu[0, 0];
            }
            DKBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float fSoTien;
            if (txtSTTPhieu.Text == "")
            {
                MessageBox.Show("Chưa nhập số thứ tự phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTTPhieu.Focus();
                return;
            }
            if (txtSoTien.Text == "" || !float.TryParse(txtSoTien.Text, out fSoTien))
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.Focus();
                return;
            }
            if (cboNVThu.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Nhân viên thu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNVThu.Focus();
                return;
            }
            if (cboNVNop.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Nhân viên nộp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNVNop.Focus();
                return;
            }
            if (cboLyDoThu.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Lý do thu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLyDoThu.Focus();
                return;
            }
            if (ThemSua == 1 && MyPublics.TonTaiKhoaChinh(txtSTTPhieu.Text, "STTPhieu", "Thu"))
            {
                MessageBox.Show("Phiếu thu này đã có rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSTTPhieu.Focus();
            }
            else
                LuuPhieuMoi();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            ThemSua = 0;
            DKBinhThuong();
            GanDuLieu();
            cboLyDoThu.SelectedIndex = VTLyDo;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {         
            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (blnDongY == DialogResult.Yes)
            {
                string strDel = "Delete Thu Where STTPhieu = @STTPhieu";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strDel, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@STTPhieu", txtSTTPhieu.Text);

                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();

                int curRow = dgvThu.CurrentRow.Index;
                dvThu.Delete(curRow);
                DKBinhThuong();
                GanDuLieu();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSua = 1;
            VTLyDo = cboLyDoThu.SelectedIndex;
            DKThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ThemSua = 2;
            VTLyDo = cboLyDoThu.SelectedIndex;
            DKChinhSua();
        }

        private void cboLyDoThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboLyDoThu.SelectedIndex != -1) && (ThemSua == 0))
            {
                dvThu.RowFilter = "LyDoThu like '" + cboLyDoThu.SelectedValue + "'";
                dgvThu.DataSource = dvThu;
                GanDuLieu();
                if (MyPublics.strQuyenSD != "Admin")
                {
                    btnThem.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
            }
        }

    }
}
