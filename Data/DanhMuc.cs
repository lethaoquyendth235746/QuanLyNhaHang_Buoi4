using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class DanhMuc
    {
        public int ID { get; set; }
        public string TenDanhMuc { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<MonAn> MonAns { get; set; }
    }
}
