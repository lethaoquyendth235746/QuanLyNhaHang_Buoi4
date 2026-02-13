using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string TenNhanVien { get; set; }

        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public int VaiTroID { get; set; }
        public VaiTro VaiTro { get; set; }

        public bool TrangThai { get; set; }
        public ICollection<DonHang> DonHang { get; set; }
    }
}
