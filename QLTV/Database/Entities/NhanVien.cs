using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLTV.Database.Entities
{
    [Table("NHANVIEN")]
    internal class NhanVien
    {
        [Column("MANHANVIEN"),Key]
        public int IDNhanVien { get; set; }
        [Column("MANGUOIDUNG"),ForeignKey("NGUOIDUNGDATA2")]
        public int IDNguoiDung_NhanVien { get; set; }
        [Column("CHUCVU")]
        public string ChucVu {  get; set; }
        [Column("NGAYVAOLAM")]
        public DateTime NgayVaoLam {  get; set; }
        public virtual NguoiDung NGUOIDUNGDATA2 { get; set; }

    }
}
