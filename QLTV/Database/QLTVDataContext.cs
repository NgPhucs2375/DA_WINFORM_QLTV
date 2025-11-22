using QLTV.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLTV.Database
{
    internal class QLTVDataContext : DbContext
    {
        public QLTVDataContext(): base("Server = MSI;Database = QL_THUVIEN; Integrated Security = true")
        {
            Database.Log = sql => Console.WriteLine(sql);

        }
        // Các DbSet tương ứng với từng bảng
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }
        public DbSet<Phat> Phats { get; set; }
        public DbSet<YeuCauMuon> YeuCauMuons { get; set; }
        public DbSet<ThongBao> ThongBaos { get; set; }
        public DbSet<BaoCao> BaoCaos { get; set; }
        public DbSet<LoginLog> LoginLogs { get; set; }
        public DbSet<HoatDongLog> HoatDongLogs { get; set; }
    }
}
