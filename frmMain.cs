using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuChi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap(this);
            frm.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu frm = new frmChucVu();
            frm.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng Quản lý Thu - Chi v1.0 \n\t(Đề tài 10) Nhóm 06", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap(this);
            frm.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            mnuQuanLy.Enabled = false;
            mnuCapNhat.Enabled = false;
            mnuDangNhap.Enabled = true;
            mnuDoiMatKhau.Enabled = false;
            mnuDangXuat.Enabled = false;
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuChi_Click(object sender, EventArgs e)
        {
            frmChi frm = new frmChi();
            frm.ShowDialog();
        }

        private void mnuNhanVienTheoCV_Click(object sender, EventArgs e)
        {
            frmNVTheoCV frm = new frmNVTheoCV();
            frm.ShowDialog();
        }

        private void mnuThuTheoLD_Click(object sender, EventArgs e)
        {
            frmThuTheoLyDo frm = new frmThuTheoLyDo();
            frm.ShowDialog();
        }

        private void ChiTheoLD_Click(object sender, EventArgs e)
        {
            frmChiTheoLyDo frm = new frmChiTheoLyDo();
            frm.ShowDialog();
        }

        private void mnuLyDoThuChi_Click(object sender, EventArgs e)
        {
            frmCNLyDoThuChi frm = new frmCNLyDoThuChi();
            frm.ShowDialog();
        }

        private void mnuThu_Click(object sender, EventArgs e)
        {
            frmThu frm = new frmThu();
            frm.ShowDialog();
        }
    }
}
