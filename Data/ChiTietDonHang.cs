using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class ChiTietDonHang
    {
        public int ID { get; set; }

        public int DonHangID { get; set; }
        public DonHang DonHang { get; set; }

        public int MonAnID { get; set; }
        public MonAn MonAn { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
