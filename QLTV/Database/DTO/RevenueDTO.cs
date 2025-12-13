using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Database.DTO
{
    internal class RevenueDTO
    {
        public int MaPhat { get; set; }
        public string DocGia { get; set; } // Tên độc giả (nếu cần hiển thị)
        public string LyDo { get; set; }
        public DateTime NgayPhat { get; set; }
        public decimal SoTien { get; set; }
    }
}
