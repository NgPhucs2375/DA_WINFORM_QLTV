using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Database.Entities
{
    [Table("THAMSO")]
    public class ThamSo
    {
        [Key]
        [Column("TENTHAMSO")]
        public string TenThamSo { get; set; }

        [Column("GIATRI")]
        public string GiaTri { get; set; }

        [Column("MOTA")]
        public string MoTa { get; set; }
    }
}