using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Database.Entities
{
    [Table("TACGIA")]
    public class TacGia
    {
        [Key][Column("MA")] public int Ma { get; set; }
        [Column("TEN")] public string Ten { get; set; }
    }
}
