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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            string strSql = "Select MaNV + ' - ' + HoTen AS ThongTinNV from NhanVien where MaNV=@MaNV";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmd = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmd.Parameters.AddWithValue("@MaNV", MyPublics.strMaNV);

            SqlDataReader drReader = cmd.ExecuteReader();
            drReader.Read();
            txtMaNV.Text = drReader.GetString(0);
            drReader.Close();
            MyPublics.conMyConnection.Close();
            txtMaNV.ReadOnly = true;
            txtMaNV.BackColor = Color.White;
            txtMatKhauMoi.Focus();
            txtMatKhauMoi.PasswordChar = '*';
            txtXacNhanMK.PasswordChar = '*';
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập Mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.Focus();
                return;
            }
            if (txtXacNhanMK.Text == "")
            {
                MessageBox.Show("Chưa xác nhận Mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhanMK.Focus();
                return;
            }
            if (txtMatKhauMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu mới phải giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhanMK.Clear();
                txtXacNhanMK.Focus();
                return;
            }
            string strSql = "Update NhanVien set MatKhau=@MatKhau where MaNV=@MaNV";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmd = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmd.Parameters.AddWithValue("@MatKhau", txtXacNhanMK.Text);
            cmd.Parameters.AddWithValue("@MaNV", MyPublics.strMaNV);

            cmd.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
