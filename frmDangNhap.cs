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
    public partial class frmDangNhap : Form
    {
        frmMain fmain;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(frmMain frm) : this()
        {
            fmain = frm;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
            txtMaNV.Focus();
            fmain.mnuQuanLy.Enabled = false;
            fmain.mnuCapNhat.Enabled = false;
            fmain.mnuDoiMatKhau.Enabled = false;
            fmain.mnuDangXuat.Enabled = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCommand;
            SqlDataReader dataReader;
            string sqlselect;
            try
            {
                MyPublics.ConnectDatabase();
                if(MyPublics.conMyConnection.State == ConnectionState.Open)
                {

                    MyPublics.strMaNV = txtMaNV.Text;
                    sqlselect = "Select MaCV, QuyenSD from NhanVien where MaNV = @MaNV and MatKhau = @MatKhau";

                    cmdCommand = new SqlCommand(sqlselect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmdCommand.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                    dataReader = cmdCommand.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        MyPublics.strMaCV = dataReader.GetString(0);
                        MyPublics.strQuyenSD = dataReader.GetString(1);
                        dataReader.Close();

                        fmain.mnuDangNhap.Enabled = true;
                        fmain.mnuDangXuat.Enabled = true;
                        fmain.mnuDoiMatKhau.Enabled = true;
                        fmain.mnuDangNhap.Enabled = false;
                        fmain.mnuQuanLy.Enabled = true;
                        fmain.mnuCapNhat.Enabled = true;

                        MessageBox.Show("Đăng nhập thành công.", "Thông báo");
                        MyPublics.conMyConnection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo");
                        txtMaNV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công!", "Thông báo");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi khi thực hiện kết nối", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(MyPublics.conMyConnection != null)
            {
                MyPublics.conMyConnection = null;
            }
            fmain.mnuQuanLy.Enabled = false;
            fmain.mnuCapNhat.Enabled = false;
            fmain.mnuDoiMatKhau.Enabled = false;
            fmain.mnuDangXuat.Enabled = false;
            fmain.mnuDangNhap.Enabled = true;
            this.Close();
        }

        private void chkHienAn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienAn.Checked)
                txtMatKhau.PasswordChar = '\0';
            else txtMatKhau.PasswordChar = '*';
        }
    }
}
