using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuChi
{
    public partial class frmNVTheoCV : Form
    {
        DataTable dtNhanVien = new DataTable("NhanVien");
        DataView dvNhanVien = new DataView();
        DataTable dtChucVu = new DataTable("ChucVu");
        DataTable dtQuyenSD = new DataTable("QuyenSD");
        int ViTriChucVu, ThemSua = 0;
        public frmNVTheoCV()
        {
            InitializeComponent();
        }

        void DieuKhienKhiBinhThuong()
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
            if (dvNhanVien.Count <= 0)
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            cboChucVu.Enabled = true;
            txtMaNV.ReadOnly = true;
            txtMaNV.BackColor = Color.White;
            txtHoTen.ReadOnly = true;
            txtHoTen.BackColor = Color.White;
            cboQuyenSD.Enabled = false;
            dgvNhanVien.Enabled = true;

        }

        void GanDuLieu()
        {
            if (dvNhanVien.Count > 0)
            {
                txtMaNV.Text = dgvNhanVien[0, dgvNhanVien.CurrentRow.Index].Value.ToString();
                txtHoTen.Text = dgvNhanVien[1, dgvNhanVien.CurrentRow.Index].Value.ToString();
                cboQuyenSD.SelectedValue = dgvNhanVien[4, dgvNhanVien.CurrentRow.Index].Value.ToString();
                DieuKhienKhiBinhThuong();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtHoTen.Clear();
                txtMaNV.Clear();
                cboQuyenSD.SelectedIndex = -1;
            }
        }

        void NhanDuLieu()
        {
            string strSelect = "Select * From NhanVien";
            MyPublics.OpenData(strSelect, dtNhanVien);
        }

        private void frmNVTheoCV_Load(object sender, EventArgs e)
        {
            //string strSql = "Select * from ChucVu";
            string strSql = "Select cv.MaCV, DIENGIAI, COUNT(nv.MACV) SOLUONG " +
                "from CHUCVU cv left join NHANVIEN nv on cv.MACV=nv.MACV " +
                "group by cv.MaCV, DIENGIAI order by SOLUONG desc";
            MyPublics.OpenData(strSql, dtChucVu);
            cboChucVu.DataSource = dtChucVu;
            cboChucVu.DisplayMember = "DienGiai";
            cboChucVu.ValueMember = "MaCV";
            cboChucVu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboChucVu.AutoCompleteSource = AutoCompleteSource.ListItems;

            NhanDuLieu();
            dtQuyenSD.Columns.Add("QuyenSD");
            dtQuyenSD.Rows.Add("User");
            dtQuyenSD.Rows.Add("Admin");
            cboQuyenSD.DataSource = dtQuyenSD;
            cboQuyenSD.DisplayMember = "QuyenSD";
            cboQuyenSD.ValueMember = "QuyenSD";

            txtMaNV.MaxLength = 6;
            txtHoTen.MaxLength = 30;

            dvNhanVien.Table = dtNhanVien;
            dvNhanVien.RowFilter = "Macv like '" + cboChucVu.SelectedValue + "'";

            dgvNhanVien.Width = 700;
            dgvNhanVien.DataSource = dvNhanVien;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.Columns[0].Width = 130;
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].Width = 170;
            dgvNhanVien.Columns[1].HeaderText = "Họ và tên";
            dgvNhanVien.Columns[2].Width = 90;
            dgvNhanVien.Columns[2].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[3].Width = 100;
            dgvNhanVien.Columns[3].HeaderText = "Mật khẩu";
            dgvNhanVien.Columns[4].Width = 140;
            dgvNhanVien.Columns[4].HeaderText = "Quyền sử dụng";
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            Font font = new System.Drawing.Font("Times New Roman", 14.0f, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = font;
            dgvNhanVien.BackgroundColor = Color.White;
            DieuKhienKhiBinhThuong();
            GanDuLieu();
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaNV.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            cboChucVu.Enabled = false;
            cboQuyenSD.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;
            dgvNhanVien.Enabled = false;
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtMaNV.Focus();
        }

        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
           
            btnDong.Enabled = false;

            txtHoTen.ReadOnly = false;
            txtHoTen.Focus();

            cboChucVu.Enabled = true;
            cboQuyenSD.Enabled = true;
            dgvNhanVien.Enabled = false;
        }

        void ThucThiLuu()
        {
            string strSql, strChucVu, strMatKhau = "", strQuyenSD;
            if (ThemSua == 1)
                strSql = "Insert Into NhanVien Values(@MANV, @HoTen, @MACV, @MatKhau, @QuyenSD)";
            else
                strSql = "Update NhanVien Set HoTen = @HoTen,MACV = @MACV, QuyenSD = @QuyenSD Where MANV = @MANV";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MANV", txtMaNV.Text);
            cmdCommand.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            strChucVu = cboChucVu.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MACV", strChucVu);
            if (ThemSua == 1)
            {
                //strMatKhau = MyPublics.MaHoaPassword(txtMaNV.Text);
                strMatKhau = txtMaNV.Text;
                cmdCommand.Parameters.AddWithValue("@MatKhau", strMatKhau);
            }
            strQuyenSD = cboQuyenSD.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@QuyenSD", strQuyenSD);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            ThemSua = 0;
            dtNhanVien.Clear();
            NhanDuLieu();
            if (cboChucVu.SelectedIndex == ViTriChucVu)
            {
                dvNhanVien.Sort = "MANV";
                int curRow = dvNhanVien.Find(txtMaNV.Text);
                dgvNhanVien.CurrentCell = dgvNhanVien[0, curRow];
            }
            else
            {
                cboChucVu.SelectedIndex = ViTriChucVu;
                if (dvNhanVien.Count > 0)
                    dgvNhanVien.CurrentCell = dgvNhanVien[0, 0];
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSua = 1;
            ViTriChucVu = cboChucVu.SelectedIndex;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ThemSua = 2;
            ViTriChucVu = cboChucVu.SelectedIndex;
            DieuKhienKhiChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mã số nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if(cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn Chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboChucVu.Focus();
                return;
            }
            if (cboQuyenSD.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn Quyền sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboQuyenSD.Focus();
                return;
            }

            if ((ThemSua == 1) && (MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MANV", "NhanVien")))
            {
                MessageBox.Show("Mã số nhân viên này đã có rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
            }
            else
                ThucThiLuu();

        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            ThemSua = 0;
            DieuKhienKhiBinhThuong();
            GanDuLieu();
            cboChucVu.SelectedIndex = ViTriChucVu;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "Manv_Thu", "Thu") ||
                MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "Manv_Nop", "Thu") ||
                MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "Manv_Chi", "Chi") ||
                MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "Manv_Nhan", "Chi"))

                MessageBox.Show("Phải xóa phiếu thu chi do nhân viên đã lập trước !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (blnDongY == DialogResult.Yes)
                {
                    string strDelete = "Delete NhanVien Where MANV = @MANV";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strDelete, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    int curRow = dgvNhanVien.CurrentRow.Index;
                    dvNhanVien.Delete(curRow);
                    DieuKhienKhiBinhThuong();
                    GanDuLieu();
                }
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboChucVu.SelectedIndex != -1) && (ThemSua == 0))
            {
                dvNhanVien.RowFilter = "MACV like '" + cboChucVu.SelectedValue + "'";
                dgvNhanVien.DataSource = dvNhanVien;
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
