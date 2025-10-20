using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Database.Entities
{
    [Table("PHIEUMUON")]
    internal class PhieuMuon
    {
        [Column("MAPHIEUMUON")]
        public int IDPhieuMuon {  get; set; }
        [Column("MADOCGIA"),ForeignKey("DOCGIADATA")]
        public int IDDocGia_PhieuMuon { get; set; }
        [Column("MASACH"), ForeignKey("SACHDATA")]
        public int IDSach_PhieuMuon { get; set; }
        [Column("NGAYMUON")]
        public DateTime NgayMuon_Sach {  get; set; }
        [Column("HANTRA")]
        public DateTime HanTra_PhieuMuon { get; set; }
        [Column("NGAYTRA")]
        public DateTime NgayTra_PhieuMuon { get; set; }
        [Column("TRANGTHAI")]
        public string TrangThai_PhieuMuon { get; set; }
        [Column("SOTIENPHAT")]
        public decimal SoTienPhat_PhieuMuon { get; set; }

        public virtual DocGia DOCGIADATA { get; set; }
        public virtual Sach SACHDATA {  get; set; }

    }
}
