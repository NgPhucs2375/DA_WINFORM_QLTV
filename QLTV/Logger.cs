using QLTV.Database;
using QLTV.Database.Entities;
using System;

namespace QLTV
{
    public static class Logger
    {
        public static void Record(string hanhDong, string doiTuong, string noiDung)
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    var log = new HoatDongLog
                    {
                        IDNguoiDung_DHG = Program.CurrentUserId, // Lấy ID người đang đăng nhập
                        HangDong_DHG = hanhDong,
                        DoiTuong = doiTuong,
                        NoiDung_DHG = noiDung,
                        ThoiGian_DHG = DateTime.Now
                    };

                    db.HoatDongLogs.Add(log);
                    db.SaveChanges();
                }
            }
            catch
            {
                // Ghi log thất bại thì bỏ qua, không làm crash phần mềm
            }
        }
    }
}