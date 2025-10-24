using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Database.Entities
{
    [Table("LOGIN_LOG")]

    internal class LoginLog
    {

        [Column("MABANGLHI"), Key]
        public int IDBangLHI { get; set; }
        [Column("MANGUOIDUNG"),ForeignKey("NGUOIDUNGDATA4")]
        public int IDNguoiDung_LHI { get; set; }
        [Column("DIA_CHI_IP")]
        public string DiaChi_IP { get; set; }
        [Column("THIETBI")]
        public string ThietBi { get; set; }
        [Column("TRANGTHAI")]
        public string TrangThai_LHI { get; set; }
        [Column("THOIGIAN")]
        public DateTime ThoiGian_LHI { get; set; }
        public virtual NguoiDung NGUOIDUNGDATA4 { get; set; }

    }
}
