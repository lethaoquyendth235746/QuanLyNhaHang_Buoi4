using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class DonHang
    {
        public int ID { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public bool TrangThaiThanhToan { get; set; }

        public int NhanVienID { get; set; }
        public NhanVien NhanVien { get; set; }

        public int BanID { get; set; }
        public Ban Ban { get; set; }

        public ICollection<ChiTietDonHang> ChiTietDonHang { get; set; }
    }
}
