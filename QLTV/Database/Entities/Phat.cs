using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Database.Entities
{
    [Table("PHAT")]
    internal class Phat
    {
        [Column("MAPHAT"),Key]
        public int IDPhat { get; set; }
        [Column("MAPHIEUMUON"),ForeignKey("PHIEUMUONDATA")]
        public int IDPhieuMuon_Phat { get; set; }
        [Column("SOTIEN")]
        public decimal SoTien_Phat { get; set; }
        [Column("LYDO")]
        public string LyDo_Phat { get; set; }
        [Column("DATHANHTOAN")]
        public bool DaThanhToan {  get; set; }
        [Column("NGAYPHAT")]
        public DateTime NgayPhat { get; set; }
        public virtual PhieuMuon PHIEUMUONDATA { get; set; }

        
    }
}
