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
    public partial class frmChucVu : Form
    {
        DataTable dtChucVu = new DataTable("ChucVu");
        bool blnThem = false;
        public frmChucVu()
        {
            InitializeComponent();
        }
        void GanDuLieu()
        {
            if (dtChucVu.Rows.Count > 0)
            {
                txtMaCV.Text = dgvChucVu[0, dgvChucVu.CurrentRow.Index].Value.ToString();
                txtDienGiai.Text = dgvChucVu[1, dgvChucVu.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaCV.Clear();
                txtDienGiai.Clear();
            }
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

            txtMaCV.ReadOnly = true;
            txtMaCV.BackColor = Color.White;
            txtDienGiai.ReadOnly = true;
            txtDienGiai.BackColor = Color.White;
            dgvChucVu.Enabled = true;
        }
        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            txtMaCV.ReadOnly = false;
            txtDienGiai.ReadOnly = false;
            dgvChucVu.Enabled = false;
            txtMaCV.Focus();
            txtDienGiai.Clear();
            txtMaCV.Clear();
            txtDienGiai.Clear();
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            dgvChucVu.Enabled = false;
            txtDienGiai.ReadOnly = false;
            txtDienGiai.Focus();
        }
        void DieuKhienKhiLuu()
        {
            string strSql;
            if (blnThem)
            {
                strSql = "Insert into ChucVu values(@MaCV, @DienGiai)";
            }
            else
            {
                strSql = "Update ChucVu set DienGiai=@DienGiai where MaCV=@MaCV";
            }
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmd = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text);
            cmd.Parameters.AddWithValue("@DienGiai", txtDienGiai.Text);

            cmd.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            if (blnThem)
            {
                dtChucVu.Rows.Add(txtMaCV.Text, txtDienGiai.Text);
                blnThem = false;
                GanDuLieu();
            }
            else
            {
                int current = dgvChucVu.CurrentRow.Index;
                dtChucVu.Rows[current][0] = txtMaCV.Text;
                dtChucVu.Rows[current][1] = txtDienGiai.Text;
            }
            DieuKhienKhiBinhThuong();
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            string strSql = "Select * from ChucVu";
            MyPublics.OpenData(strSql, dtChucVu);
            dgvChucVu.DataSource = dtChucVu;

            txtMaCV.MaxLength = 4;
            txtDienGiai.MaxLength = 40;
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.AllowUserToDeleteRows = false;
            dgvChucVu.AllowUserToResizeRows = false;
            dgvChucVu.Columns[0].Width = 180;
            dgvChucVu.Columns[0].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns[1].Width = 290;
            dgvChucVu.Columns[1].HeaderText = "Diễn giải";
            dgvChucVu.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvChucVu.EnableHeadersVisualStyles = false;
            dgvChucVu.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dgvChucVu.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            Font font = new System.Drawing.Font("Times New Roman", 14.0f, FontStyle.Bold);
            dgvChucVu.ColumnHeadersDefaultCellStyle.Font = font;
            dgvChucVu.BackgroundColor = Color.White;
            dgvChucVu.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
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
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã Chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCV.Focus();
                return;
            }
            if (txtDienGiai.Text == "")
            {
                MessageBox.Show("Chưa nhập Diễn giải", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienGiai.Focus();
                return;
            }
            if ((blnThem) && MyPublics.TonTaiKhoaChinh(txtMaCV.Text, "MaCV", "ChucVu"))
            {
                MessageBox.Show("Mã chức vụ đã tồn tại!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMaCV.Focus();
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
            if (MyPublics.TonTaiKhoaChinh(txtMaCV.Text, "MaCV", "NhanVien"))
            {
                MessageBox.Show("Phải xóa Nhân viên giữ chức vụ này trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chắc chắn muốn xóa Chức vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string del = "Delete from ChucVu where MaCV=@MaCV";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmd = new SqlCommand(del, MyPublics.conMyConnection);
                    cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text);

                    cmd.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtChucVu.Rows.RemoveAt(dgvChucVu.CurrentRow.Index);
                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }
        
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }
    }
}
