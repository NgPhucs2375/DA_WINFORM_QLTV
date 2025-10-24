using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Database.Entities
{
    [Table("YEUCAUMUON")]
    internal class YeuCauMuon
    {
        [Column("MAYEUCAU"),Key]
        public int IDYeuCau {  get; set; }
        [Column("MADOCGIA"),ForeignKey("DOCGIADATA")]
        public int IDDocGia_YCM { get; set;}
        [Column("MASACH"),ForeignKey("SACHDATA")]
        public int IDSACH_YCM { get; set;}
        [Column("NGAYYEUCAU")]
        public DateTime Ngayyeucau_YCM { get; set; }
        [Column("TRANGTHAI")]
        public string TrangThai_YCM { get; set; }
        public virtual DocGia DOCGIADATA { get; set; }
        public virtual Sach SACHDATA { get; set; }

    }
}
