using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLTV.Database.Entities
{
    [Table("NGUOIDUNG")]
    internal class NguoiDung
    {
        [Column("MANGUOIDUNG"),Key]
        public int IDNguoiDung { get; set; }
        [Column("HOTEN")]
        public string HoTen_NguoiDung { get; set; }
        [Column("EMAIL")]
        public string Email_NguoiDung { get; set; }
        [Column("SDT")]
        public string SDT_NguoiDung { get; set; }
        [Column("MATKHAU")]
        public string MatKhau_NguoiDung { get; set; }
        [Column("VAITRO")]
        public string VaiTro_NguoiDung { get; set; }
        [Column("TRANGTHAI")]
        public string TrangThai_NguoiDung { get; set; }
        [Column("NGAYTAO")]
        public DateTime? NgayTao_NguoiDung { get; set; }
    }
}
