using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var user = context.NhanVien
        .FirstOrDefault(p =>
            p.TenDangNhap == txtTenDangNhap.Text &&
            p.MatKhau == txtMatKhau.Text &&
            p.TrangThai == true);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công");

                frmMain f = new frmMain(user);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
