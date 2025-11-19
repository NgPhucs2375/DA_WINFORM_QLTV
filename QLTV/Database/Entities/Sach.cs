using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Database.Entities
{
    [Table("SACH")]
    public class Sach
    {
        [Column("MASACH"),Key]
        public int IDSach { get; set; }
        [Column("TENSACH")]
        public string Name_Sach { get; set; }
        [Column("TACGIA")]
        public string TacGia_Sach { get; set; }
        [Column("THELOAI")]
        public string TheLoai_Sach { get; set; }
        [Column("NHAXUATBAN")]
        public string NhaXuatBan_Sach { get; set; }
        [Column("NAMXUATBAN")]
        public int NamXuatBan_Sach { get; set; }
        [Column("SOLUONG")]
        public int SoLuong_Sach { get; set; }
        [Column("VITRISACH")]
        public string ViTriSach { get; set; }
        [Column("ANHBIA")]
        public string AnhBia_Sach { get; set; }
        [Column("MAQR")]
        public string MaQR {  get; set; }
        [Column("TRANGTHAI")]
        public string TrangThai_Sach { get; set; }
    }
}
