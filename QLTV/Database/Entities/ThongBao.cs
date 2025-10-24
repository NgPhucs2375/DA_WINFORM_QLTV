using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Database.Entities
{
    [Table("THONGBAO")]
    internal class ThongBao
    {
        [Column("MATHONGBAO"),Key]
        public int IDThongBao { get; set; }
        [Column("MANGUOIDUNG"),ForeignKey("NGUOIDUNGDATA3")]
        public int IDNguoiDung_ThongBao { get; set; }
        [Column("LOAI")]
        public string Loai_ThongBao { get; set; }
        [Column("TIEUDE")]
        public string TieuDe_ThongBao { get; set; }
        [Column("NOIDUNG")]
        public string NoiDung_ThongBao { get; set; }
        [Column("NGAYGUI")]
        public DateTime NgayGui_ThongBao { get; set; }
        [Column("TRANGTHAI")]
        public string TrangThai_ThongBao { get; set; }
        public virtual NguoiDung NGUOIDUNGDATA3 { get; set; }

        }
}
