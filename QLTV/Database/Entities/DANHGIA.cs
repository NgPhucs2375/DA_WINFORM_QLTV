using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLTV.Database.Entities
{
    [Table("DANHGIA")]

    internal class DANHGIA
    {
        [Column("MADANHGIA"), Key]
        public int IDDanhGia { get; set; }
        [Column("MASACH")]
        public int MaSach { get; set; }
        [Column("MADOCGIA")]
        public int MaDocGia { get; set; }
        [Column("DIEM")]
        public int Diem { get; set; }
        [Column("BINHLUAN")]
        public string BinhLuan { get; set; }
        [Column("NGAYDANHGIA")]
        public DateTime NgayDanhGia { get; set; }

    }
}
