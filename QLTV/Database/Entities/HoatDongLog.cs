using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Database.Entities
{
    [Table("HOATDONG_LOG")]

    internal class HoatDongLog
    {
        [Column("MAHDLOG"), Key]
        public int IDDHLog { get; set; }
        [Column("MANGUOIDUNG"), ForeignKey("NGUOIDUNGDATA5")]
        public int IDNguoiDung_DHG { get; set; }
        [Column("HANHDONG")]
        public string HangDong_DHG { get; set; }
        [Column("DOITUONG")]
        public string DoiTuong { get; set; }
        [Column("NOIDUNG")]
        public string NoiDung_DHG { get; set; }
        [Column("THOIGIAN")]
        public DateTime ThoiGian_DHG { get; set; }
        public virtual NguoiDung NGUOIDUNGDATA5 { get; set; }
    }
}
