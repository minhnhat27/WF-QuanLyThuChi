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
    public partial class frmNhanVien : Form
    {
        DataTable dtNhanVien = new DataTable("NhanVien");
        DataTable dtChucVu = new DataTable("ChucVu");
        DataTable dtQuyenSD = new DataTable("QuyenSD");
        bool blnThem = false;
        public frmNhanVien()
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
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            txtMaNV.ReadOnly = true;
            txtMaNV.BackColor = Color.White;
            txtHoTen.ReadOnly = true;
            txtHoTen.BackColor = Color.White;
            cbbChucVu.Enabled = false;
            cbbQuyenSD.Enabled = false;
            dgvNhanVien.Enabled = true;
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            txtHoTen.ReadOnly = false;
            cbbChucVu.Enabled = true;
            cbbQuyenSD.Enabled = true;
            dgvNhanVien.Enabled = false;
            txtHoTen.Focus();
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
            cbbChucVu.Enabled = true;
            cbbChucVu.SelectedIndex = -1;
            cbbQuyenSD.Enabled = true;
            cbbQuyenSD.SelectedIndex = 0;
            dgvNhanVien.Enabled = false;
            txtMaNV.Focus();
            txtHoTen.Clear();
            txtMaNV.Clear();
        }
        void GanDuLieu()
        {
            if (dtNhanVien.Rows.Count > 0)
            {
                txtMaNV.Text = dgvNhanVien[0, dgvNhanVien.CurrentRow.Index].Value.ToString();
                txtHoTen.Text = dgvNhanVien[1, dgvNhanVien.CurrentRow.Index].Value.ToString();
                cbbChucVu.SelectedValue = dgvNhanVien[2, dgvNhanVien.CurrentRow.Index].Value.ToString();
                cbbQuyenSD.SelectedValue = dgvNhanVien[4, dgvNhanVien.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtHoTen.Clear();
                txtMaNV.Clear();
                cbbChucVu.SelectedIndex = -1;
                cbbQuyenSD.SelectedIndex = -1;
            }
        }
        void DieuKhienKhiLuu()
        {
            string strSql, strMatKhau="", strCV = "", strQuyen;
            if (blnThem)
            {
                if(cbbChucVu.SelectedIndex >= 0)
                    strSql = "Insert into NhanVien values(@MaNV, @HoTen, @MaCV, @MatKhau, @QuyenSD)";
                else strSql = "Insert into NhanVien values(@MaNV, @HoTen, NULL, @MatKhau, @QuyenSD)";
            }
            else
            {
                if (cbbChucVu.SelectedIndex >= 0)
                    strSql = "Update NhanVien set HoTen=@HoTen, MaCV=@MaCV, QuyenSD=@QuyenSD where MaNV=@MaNV";
                else strSql = "Update NhanVien set HoTen=@HoTen, MaCV=NULL, QuyenSD=@QuyenSD where MaNV=@MaNV";
            }
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmd = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            if(cbbChucVu.SelectedIndex >= 0)
            {
                strCV = cbbChucVu.SelectedValue.ToString();
                cmd.Parameters.AddWithValue("@MaCV", strCV);
            }
            if (blnThem)
            {
                strMatKhau = txtMaNV.Text;
                cmd.Parameters.AddWithValue("@MatKhau", strMatKhau);
            }
            strQuyen = cbbQuyenSD.SelectedValue.ToString();
            cmd.Parameters.AddWithValue("@QuyenSD", strQuyen);

            cmd.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            if (blnThem)
            {
                dtNhanVien.Rows.Add(txtMaNV.Text, txtHoTen.Text, strCV, strMatKhau, strQuyen);
                blnThem = false;
                GanDuLieu();
            }
            else
            {
                int current = dgvNhanVien.CurrentRow.Index;
                dtNhanVien.Rows[current][0] = txtMaNV.Text;
                dtNhanVien.Rows[current][1] = txtHoTen.Text;
                dtNhanVien.Rows[current][2] = strCV;
                dtNhanVien.Rows[current][3] = strMatKhau;
                dtNhanVien.Rows[current][4] = strQuyen;
            }
            DieuKhienKhiBinhThuong();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string strSql = "Select * from NhanVien";
            MyPublics.OpenData(strSql, dtNhanVien);
            strSql = "Select * from ChucVu";
            MyPublics.OpenData(strSql, dtChucVu);

            dtQuyenSD.Columns.Add("QuyenSD");
            dtQuyenSD.Rows.Add("User");
            dtQuyenSD.Rows.Add("Admin");
            
            cbbQuyenSD.DataSource = dtQuyenSD;
            cbbQuyenSD.DisplayMember = "QuyenSD";
            cbbQuyenSD.ValueMember = "QuyenSD";

            txtMaNV.MaxLength = 7;
            txtHoTen.MaxLength = 30;
            cbbChucVu.DataSource = dtChucVu;
            cbbChucVu.DisplayMember = "DienGiai";
            cbbChucVu.ValueMember = "MaCV";
            cbbChucVu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbChucVu.AutoCompleteSource = AutoCompleteSource.ListItems;

            dgvNhanVien.DataSource = dtNhanVien;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AllowUserToResizeRows = false;
            dgvNhanVien.Columns[0].Width = 120;
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].Width = 170;
            dgvNhanVien.Columns[1].HeaderText = "Họ và tên";
            dgvNhanVien.Columns[2].Width = 120;
            dgvNhanVien.Columns[2].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[3].Visible = false;
            dgvNhanVien.Columns[4].Width = 140;
            dgvNhanVien.Columns[4].HeaderText = "Quyền sử dụng";
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            Font font = new System.Drawing.Font("Times New Roman", 14.0f, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = font;
            dgvNhanVien.BackgroundColor = Color.White;

            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã Nhân viên!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Họ và tên Nhân viên","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if(cbbQuyenSD.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Quyền sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbQuyenSD.Focus();
                return;
            }
            
            if((blnThem) && MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MaNV", "NhanVien"))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
            }
            else
            {
                DieuKhienKhiLuu();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
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
                DialogResult result;
                result = MessageBox.Show("Bạn chắc chắn muốn xóa Nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string del = "Delete from NhanVien where MaNV=@MaNV";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmd = new SqlCommand(del, MyPublics.conMyConnection);
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtNhanVien.Rows.RemoveAt(dgvNhanVien.CurrentRow.Index);
                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }
    }
}
