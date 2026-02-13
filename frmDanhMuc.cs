using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.Data;

namespace QuanLyNhaHang
{
    public partial class frmDanhMuc : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        bool xuLyThem = false;
        int id;
        public frmDanhMuc()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtTenDanhMuc.Clear();
            chkTrangThai.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells["ID"].Value);
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {

        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenDanhMuc.Enabled = giaTri;
            chkTrangThai.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells["ID"].Value);
                DanhMuc dm = context.DanhMuc.Find(id);
                if (dm != null)
                {
                    context.DanhMuc.Remove(dm);
                    context.SaveChanges();

                }
                frmDanhMuc_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xuLyThem)
            {
                DanhMuc dm = new DanhMuc();
                dm.TenDanhMuc = txtTenDanhMuc.Text;
                dm.TrangThai = chkTrangThai.Checked;
                context.DanhMuc.Add(dm);
            }
            else
            {
                DanhMuc dm = context.DanhMuc.Find(id);
                if (dm != null)
                {
                    dm.TenDanhMuc = txtTenDanhMuc.Text;
                    dm.TrangThai = chkTrangThai.Checked;
                    context.DanhMuc.Update(dm);
                }
            }
            context.SaveChanges();
            frmDanhMuc_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDanhMuc_Load(sender, e);
        }
    }
}
