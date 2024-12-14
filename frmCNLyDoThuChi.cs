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
    public partial class frmCNLyDoThuChi : Form
    {
        DataTable dtLyDoTC = new DataTable("LyDoThuChi");
        bool blnThem = false;

        public frmCNLyDoThuChi()
        {
            InitializeComponent();
        }

        private void frmCNLyDoThuChi_Load(object sender, EventArgs e)
        {
            string strSql = "Select * From LyDoThuChi Order by MaLyDo";
            MyPublics.OpenData(strSql, dtLyDoTC);
            txtMaLyDo.MaxLength = 6;
            txtDienGiai.MaxLength = 100;

            dgvLyDoTC.DataSource = dtLyDoTC;
            dgvLyDoTC.AllowUserToAddRows = false;
            dgvLyDoTC.AllowUserToDeleteRows = false;
            dgvLyDoTC.Columns[0].Width = 115;
            dgvLyDoTC.Columns[0].HeaderText = "Mã lý do";
            dgvLyDoTC.Columns[1].Width = 300;
            dgvLyDoTC.Columns[1].HeaderText = "Diễn giải";
            dgvLyDoTC.EnableHeadersVisualStyles = false;
            dgvLyDoTC.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dgvLyDoTC.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            Font font = new System.Drawing.Font("Times New Roman", 14.0f, FontStyle.Bold);
            dgvLyDoTC.ColumnHeadersDefaultCellStyle.Font = font;
            dgvLyDoTC.BackgroundColor = Color.White;
            dgvLyDoTC.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            txtMaLyDo.ReadOnly = true;
            txtMaLyDo.BackColor = Color.White;
            txtDienGiai.ReadOnly = true;
            txtDienGiai.BackColor = Color.White;
            dgvLyDoTC.Enabled = true;
        }

        void DKThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;
            txtMaLyDo.ReadOnly = false;
            txtDienGiai.ReadOnly = false;
            txtMaLyDo.Clear();
            txtDienGiai.Clear();
            txtMaLyDo.Focus();
            dgvLyDoTC.Enabled = false;
        }

        void DKChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;
            txtMaLyDo.ReadOnly = true;
            txtDienGiai.ReadOnly = false;
            dgvLyDoTC.Enabled = false;
            txtDienGiai.Focus();           
        }

        void GanDuLieu()
        {
            if (dtLyDoTC.Rows.Count > 0)
            {
                txtMaLyDo.Text = dgvLyDoTC[0, dgvLyDoTC.CurrentRow.Index].Value.ToString();
                txtDienGiai.Text = dgvLyDoTC[1, dgvLyDoTC.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaLyDo.Clear();
                txtDienGiai.Clear();
            }
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ThemLyDo()
        {
            string strSql;
            if (blnThem)
            {
                strSql = "Insert Into LyDoThuChi Values(@MaLyDo, @DienGiai)";
            }
            else
                strSql = "Update LyDoThuChi Set DienGiai = @DienGiai Where MaLyDo = @MaLyDo";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();

            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaLyDo", txtMaLyDo.Text);
            cmdCommand.Parameters.AddWithValue("@DienGiai", txtDienGiai.Text);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            if (blnThem)
            {
                dtLyDoTC.Rows.Add(txtMaLyDo.Text, txtDienGiai.Text);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvLyDoTC.CurrentRow.Index;
                dtLyDoTC.Rows[curRow][1] = txtDienGiai.Text;
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

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DKBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaLyDo.Text, "LyDoThu", "Thu") || MyPublics.TonTaiKhoaChinh(txtMaLyDo.Text, "LyDoThu", "Chi"))
            {
                MessageBox.Show("Lý do thu chi đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strDel = "Delete LyDoThuChi Where MaLyDo = @MaLyDo";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strDel, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaLyDo", txtMaLyDo.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    int curRow = dgvLyDoTC.CurrentRow.Index;
                    dtLyDoTC.Rows.RemoveAt(curRow);
                    GanDuLieu();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLyDo.Text == "")
            {
                MessageBox.Show("Chưa nhập mã lý do!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLyDo.Focus();
                return;
            }
            if (txtDienGiai.Text == "")
            {
                MessageBox.Show("Chưa diễn giải cho lý do!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienGiai.Focus();
                return;
            }
            if (blnThem && MyPublics.TonTaiKhoaChinh(txtMaLyDo.Text, "MaLyDo", "LyDoThuChi"))
            {
                MessageBox.Show("Lý do này đã có rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLyDo.Focus();
            }
            else
                ThemLyDo();
        }

        private void dgvLyDoTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }


    }
}