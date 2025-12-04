using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLTV.Database.Entities
{
    [Table("THELOAI")]
    public class TheLoai
    {
        [Key][Column("MA")] public int Ma { get; set; }
        [Column("TEN")] public string Ten { get; set; }
    }
}
