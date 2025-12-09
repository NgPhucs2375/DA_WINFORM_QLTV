using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public static class SessionHelper
    {
        public static int UserID { get; set; } // ID của NguoiDung
        public static int DocGiaID { get; set; } // ID của DocGia (quan trọng để mượn sách)
        public static string HoTen { get; set; }
        public static string VaiTro { get; set; }
    }
}
