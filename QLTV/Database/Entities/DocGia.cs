using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLTV.Database.Entities
{
    [Table("DOCGIA")]
    internal class DocGia
    {
        [Column("MADOCGIA"),Key]
        public int IDDocGia { get; set; }

        [Column("MANGUOIDUNG"), ForeignKey("NGUOIDUNGDATA")]
        public int IDNguoiDung_DocGia { get; set; }

        [Column("TINHTRANGTHE")]
        public string TinhTrangThe {  get; set; }

        [Column("NGAYCAP")]
        public DateTime NgayCap {  get; set; }

        [Column("NGAYHETHAN")]
        public DateTime NgayHetHan { get; set; }

        public virtual NguoiDung NGUOIDUNGDATA { get; set; }

    }
}
