using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Database.Entities
{
    [Table("BAOCAO")]
    internal class BaoCao
    {
        [Column("MABAOCAO"), Key]
        public int IDBaoCao{ get; set; }
        [Column("LOAIBAOCAO")]
        public string Loai_BaoCao { get; set; }
        [Column("NOIDUNG")]
        public string NoiDung_BaoCao { get; set; }
        [Column("NGAYTAO")]
        public DateTime NgayTao_BaoCao { get; set; }

    }
}
