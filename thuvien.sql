-- ============================
-- 1. Tạo Database
-- ============================
IF DB_ID('QL_THUVIEN') IS NOT NULL
    DROP DATABASE QL_THUVIEN;
GO

CREATE DATABASE QL_THUVIEN;
GO
USE QL_THUVIEN;
GO

-- ============================
-- 2. Người dùng (Users)
-- ============================
CREATE TABLE NGUOIDUNG (
    MANGUOIDUNG INT PRIMARY KEY IDENTITY(1,1),
    HOTEN NVARCHAR(100) NOT NULL,
    EMAIL NVARCHAR(100) UNIQUE,
    SDT NVARCHAR(20),
    MATKHAU NVARCHAR(255) NOT NULL,
    VAITRO NVARCHAR(20) NOT NULL, -- 'DocGia', 'NhanVien', 'Admin'
    TRANGTHAI NVARCHAR(20) DEFAULT N'Hoạt động', -- 'Hoạt động', 'Bị khóa', 'Chờ duyệt'
    NGAYTAO DATETIME DEFAULT GETDATE()
);
GO

-- ============================
-- 3. Độc giả (Readers)
-- ============================
CREATE TABLE DOCGIA (
    MADOCGIA INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT UNIQUE,
    TINHTRANGTHE NVARCHAR(20) DEFAULT N'Còn hạn', -- 'Còn hạn', 'Hết hạn'
    NGAYCAP DATE DEFAULT GETDATE(),
    NGAYHETHAN DATE,
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO

-- ============================
-- 4. Nhân viên (Staff)
-- ============================
CREATE TABLE NHANVIEN (
    MANHANVIEN INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT UNIQUE,
    CHUCVU NVARCHAR(50),
    NGAYVAOLAM DATE DEFAULT GETDATE(),
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO

-- ============================
-- 5. Sách (Books)
-- ============================
CREATE TABLE SACH (
    MASACH INT PRIMARY KEY IDENTITY(1,1),
    TENSACH NVARCHAR(200) NOT NULL,
    TACGIA NVARCHAR(100),
    THELOAI NVARCHAR(100),
    NHAXUATBAN NVARCHAR(100),
    NAMXUATBAN INT,
    SOLUONG INT DEFAULT 0,
    VITRISACH NVARCHAR(50),
    ANHBIA NVARCHAR(255),
    MAQR NVARCHAR(100) NULL, -- mã QR/Barcode
    TRANGTHAI NVARCHAR(20) DEFAULT N'Có sẵn' -- 'Có sẵn', 'Đang mượn', 'Ngừng lưu hành'
);
GO

-- ============================
-- 6. Phiếu mượn (Loan Slips)
-- ============================
CREATE TABLE PHIEUMUON (
    MAPHIEUMUON INT PRIMARY KEY IDENTITY(1,1),
    MADOCGIA INT,
    MASACH INT,
    NGAYMUON DATE DEFAULT GETDATE(),
    HANTRA DATE,
    NGAYTRA DATE NULL,
    TRANGTHAI NVARCHAR(20) DEFAULT N'Đang mượn', -- 'Đang mượn', 'Đã trả', 'Quá hạn', 'Mất/Hỏng'
    SOTIENPHAT DECIMAL(10,2) DEFAULT 0,
    FOREIGN KEY (MADOCGIA) REFERENCES DOCGIA(MADOCGIA),
    FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
);
GO

-- ============================
-- 7. Yêu cầu mượn (Borrow Requests - Online)
-- ============================
CREATE TABLE YEUCAUMUON (
    MAYEUCAU INT PRIMARY KEY IDENTITY(1,1),
    MADOCGIA INT,
    MASACH INT,
    NGAYYEUCAU DATETIME DEFAULT GETDATE(),
    TRANGTHAI NVARCHAR(20) DEFAULT N'Chờ duyệt', -- 'Chờ duyệt', 'Đã duyệt', 'Từ chối'
    FOREIGN KEY (MADOCGIA) REFERENCES DOCGIA(MADOCGIA),
    FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
);
GO

-- ============================
-- 8. Tiền phạt (Fines)
-- ============================
CREATE TABLE PHAT (
    MAPHAT INT PRIMARY KEY IDENTITY(1,1),
    MAPHIEUMUON INT,
    SOTIEN DECIMAL(10,2),
    LYDO NVARCHAR(255),
    DATHANHTOAN BIT DEFAULT 0,
    NGAYPHAT DATE DEFAULT GETDATE(),
    FOREIGN KEY (MAPHIEUMUON) REFERENCES PHIEUMUON(MAPHIEUMUON)
);
GO

-- ============================
-- 9. Thông báo (Notifications)
-- ============================
CREATE TABLE THONGBAO (
    MATHONGBAO INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT,
    LOAI NVARCHAR(20), -- 'Email', 'SMS', 'Web'
    TIEUDE NVARCHAR(200),
    NOIDUNG NVARCHAR(MAX),
    NGAYGUI DATETIME DEFAULT GETDATE(),
    TRANGTHAI NVARCHAR(20) DEFAULT N'Chờ gửi',
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO

-- ============================
-- 10. Báo cáo thống kê (Reports)
-- ============================
CREATE TABLE BAOCAO (
    MABAOCAO INT PRIMARY KEY IDENTITY(1,1),
    LOAIBAOCAO NVARCHAR(100), -- 'Sách mượn nhiều', 'Độc giả vi phạm', ...
    NOIDUNG NVARCHAR(MAX),
    NGAYTAO DATETIME DEFAULT GETDATE()
);
GO

-- ============================
-- 11. Nhật ký đăng nhập (Login Logs)
-- ============================
CREATE TABLE LOGIN_LOG (
    MABANGLHI INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT,
    THOIGIAN DATETIME DEFAULT GETDATE(),
    DIA_CHI_IP NVARCHAR(50),
    THIETBI NVARCHAR(100),
    TRANGTHAI NVARCHAR(20), -- 'Thành công', 'Thất bại'
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO

-- ============================
-- 12. Nhật ký hoạt động (Activity Logs)
-- ============================
CREATE TABLE HOATDONG_LOG (
    MAHDLOG INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT,
    HANHDONG NVARCHAR(100), -- 'Thêm sách', 'Sửa sách', 'Xóa sách', 'Duyệt mượn', ...
    DOITUONG NVARCHAR(50), -- 'DocGia', 'Sach', 'PhieuMuon', 'HeThong'
    NOIDUNG NVARCHAR(MAX), -- chi tiết (vd: "Thêm sách MASACH=10, SL=5")
    THOIGIAN DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO
