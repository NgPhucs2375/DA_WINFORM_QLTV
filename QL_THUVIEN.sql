-- ============================================================
-- 1. KHỞI TẠO DATABASE & XÓA CŨ (NẾU CÓ)
-- ============================================================
USE master;
GO

IF DB_ID('QL_THUVIEN') IS NOT NULL
BEGIN
    ALTER DATABASE QL_THUVIEN SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QL_THUVIEN;
END
GO

CREATE DATABASE QL_THUVIEN;
GO
USE QL_THUVIEN;
GO

-- ============================================================
-- 2. TẠO BẢNG (TABLES) - CẤU TRÚC MỚI NHẤT
-- ============================================================

-- 2.1 Bảng Người Dùng
CREATE TABLE NGUOIDUNG (
    MANGUOIDUNG INT PRIMARY KEY IDENTITY(1,1),
    HOTEN NVARCHAR(100) NOT NULL,
    EMAIL NVARCHAR(100) UNIQUE,
    SDT NVARCHAR(20),
    MATKHAU NVARCHAR(255) NOT NULL, 
    VAITRO NVARCHAR(20) NOT NULL, 
    TRANGTHAI NVARCHAR(20) DEFAULT N'Active', 
    ANHDAIDIEN NVARCHAR(255) NULL, 
    NGAYTAO DATETIME DEFAULT GETDATE()
);
GO

-- 2.2 Bảng Độc Giả
CREATE TABLE DOCGIA (
    MADOCGIA INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT UNIQUE,
    TINHTRANGTHE NVARCHAR(20) DEFAULT N'Active',
    NGAYCAP DATE DEFAULT GETDATE(),
    NGAYHETHAN DATE,
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO

-- 2.3 Bảng Nhân Viên
CREATE TABLE NHANVIEN (
    MANHANVIEN INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT UNIQUE,
    CHUCVU NVARCHAR(50),
    NGAYVAOLAM DATE DEFAULT GETDATE(),
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO

-- 2.4 Bảng Sách
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
    MAQR NVARCHAR(100) NULL,
    MOTA NVARCHAR(MAX) NULL,
    TRANGTHAI NVARCHAR(20) DEFAULT N'Có sẵn'
);
GO

-- 2.5 Bảng Phiếu Mượn (Đã thêm TIENMUON, TONGTIEN)
CREATE TABLE PHIEUMUON (
    MAPHIEUMUON INT PRIMARY KEY IDENTITY(1,1),
    MADOCGIA INT,
    MASACH INT,
    MANHANVIEN INT NULL,
    NGAYMUON DATE DEFAULT GETDATE(),
    HANTRA DATE,
    NGAYTRA DATE NULL,
    TRANGTHAI NVARCHAR(20) DEFAULT N'Đang mượn', 
    SOTIENPHAT DECIMAL(10,2) DEFAULT 0,
    
    -- MỚI: Thêm trực tiếp tại đây, không cần ALTER sau này
    TIENMUON DECIMAL(10,2) NOT NULL DEFAULT 0,
    TONGTIEN DECIMAL(10,2) NOT NULL DEFAULT 0,

    FOREIGN KEY (MADOCGIA) REFERENCES DOCGIA(MADOCGIA),
    FOREIGN KEY (MASACH) REFERENCES SACH(MASACH),
    FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN)
);
GO

-- 2.6 Tiền Phạt
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

-- 2.7 Yêu Cầu Mượn
CREATE TABLE YEUCAUMUON (
    MAYEUCAU INT PRIMARY KEY IDENTITY(1,1),
    MADOCGIA INT,
    MASACH INT,
    NGAYYEUCAU DATETIME DEFAULT GETDATE(),
    TRANGTHAI NVARCHAR(20) DEFAULT N'Chờ duyệt',
    FOREIGN KEY (MADOCGIA) REFERENCES DOCGIA(MADOCGIA),
    FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
);
GO

-- 2.8 Các bảng Log và Tham số
CREATE TABLE THONGBAO (
    MATHONGBAO INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT,
    TIEUDE NVARCHAR(200),
    NOIDUNG NVARCHAR(MAX),
    NGAYGUI DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);

CREATE TABLE LOGIN_LOG (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT,
    THOIGIAN DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);

-- Bảng Hoạt Động Log (Đã thêm DOITUONG, NOIDUNG)
CREATE TABLE HOATDONG_LOG (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT,
    HANHDONG NVARCHAR(200),
    THOIGIAN DATETIME DEFAULT GETDATE(),
    
    -- MỚI: Thêm trực tiếp
    DOITUONG NVARCHAR(200) NULL,
    NOIDUNG NVARCHAR(MAX) NULL,

    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);

CREATE TABLE THAMSO (
    TENTHAMSO NVARCHAR(50) PRIMARY KEY,
    GIATRI NVARCHAR(255) NOT NULL,
    MOTA NVARCHAR(255)
);

-- Các bảng danh mục
CREATE TABLE THELOAI (MA INT IDENTITY(1,1) PRIMARY KEY, TEN NVARCHAR(100));
CREATE TABLE TACGIA (MA INT IDENTITY(1,1) PRIMARY KEY, TEN NVARCHAR(100));
CREATE TABLE NHAXUATBAN (MA INT IDENTITY(1,1) PRIMARY KEY, TEN NVARCHAR(100), DIACHI NVARCHAR(200), SDT NVARCHAR(20));
GO

-- ============================================================
-- 3. STORED PROCEDURE
-- ============================================================
CREATE PROCEDURE sp_MuonSach
    @MaDocGia INT,
    @MaSach INT,
    @MaNhanVien INT,
    @NgayMuon DATE,
    @HanTra DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @SoLuong INT;
        SELECT @SoLuong = SOLUONG FROM SACH WHERE MASACH = @MaSach;

        IF @SoLuong <= 0
        BEGIN
            ROLLBACK TRANSACTION;
            THROW 51000, N'Sách này đã hết, không thể mượn!', 1;
            RETURN;
        END

        INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, TRANGTHAI)
        VALUES (@MaDocGia, @MaSach, @MaNhanVien, @NgayMuon, @HanTra, N'Đang mượn');

        UPDATE SACH SET SOLUONG = SOLUONG - 1 WHERE MASACH = @MaSach;
        UPDATE SACH SET TRANGTHAI = N'Hết hàng' WHERE MASACH = @MaSach AND SOLUONG = 0;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- ============================================================
-- 4. INSERT DỮ LIỆU MẪU
-- ============================================================
-- 4.0 Thêm Tham Số (Đã gộp đủ 3 tham số)
INSERT INTO THAMSO (TENTHAMSO, GIATRI, MOTA) VALUES (N'TIEN_PHAT_MOI_NGAY', N'5000', N'Số tiền phạt trễ hạn 1 ngày');
INSERT INTO THAMSO (TENTHAMSO, GIATRI, MOTA) VALUES (N'SO_NGAY_GIA_HAN', N'7', N'Số ngày được cộng thêm khi gia hạn');
INSERT INTO THAMSO (TENTHAMSO, GIATRI, MOTA) VALUES (N'SO_TIEN_MUON_MOI_NGAY', N'5000', N'Số tiền mượn trên mỗi ngày'); 

-- 4.1 Danh mục
INSERT INTO THELOAI (TEN) VALUES (N'Công nghệ'), (N'Văn học'), (N'Kinh tế');
INSERT INTO TACGIA (TEN) VALUES (N'Nguyễn Nhật Ánh'), (N'J.K. Rowling');
INSERT INTO NHAXUATBAN (TEN) VALUES (N'NXB Trẻ'), (N'NXB Kim Đồng');

-- 4.2 Người dùng & Nhân viên
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO) VALUES (N'Administrator', 'admin@library.com', '0900000001', 'E10ADC3949BA59ABBE56E057F20F883E', 'admin');
INSERT INTO NHANVIEN (MANGUOIDUNG, CHUCVU) VALUES (1, 'QuanLy');

INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO) VALUES (N'Trần Thu Thư', 'thuthu1@library.com', '0900000002', 'E10ADC3949BA59ABBE56E057F20F883E', 'nhanvien');
INSERT INTO NHANVIEN (MANGUOIDUNG, CHUCVU) VALUES (2, 'ThuThu');

-- 4.3 Độc giả
DECLARE @i INT = 1;
WHILE @i <= 20
BEGIN
    INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO)
    VALUES (N'Độc Giả ' + CAST(@i AS NVARCHAR), 'docgia' + CAST(@i AS NVARCHAR) + '@gmail.com', '098' + CAST(@i AS NVARCHAR), 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia');
    INSERT INTO DOCGIA (MANGUOIDUNG, NGAYHETHAN) VALUES (SCOPE_IDENTITY(), DATEADD(YEAR, 1, GETDATE()));
    SET @i = @i + 1;
END
GO

-- 4.4 Sách (Tạo 150 cuốn)
-- 20 cuốn đầu
INSERT INTO SACH (TENSACH, TACGIA, THELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, VITRISACH, MOTA)
VALUES 
(N'Nhà Giả Kim', N'Paulo Coelho', N'Tiểu thuyết', N'NXB Văn Học', 2020, 10, N'Kệ A1', N'Cuốn sách bán chạy nhất.'),
(N'Đắc Nhân Tâm', N'Dale Carnegie', N'Kỹ năng', N'NXB Trẻ', 2019, 15, N'Kệ B2', N'Nghệ thuật thu phục lòng người.'),
(N'Clean Code', N'Robert C. Martin', N'Công nghệ', N'Prentice Hall', 2008, 5, N'Kệ C1', N'Viết code sạch.');

-- Vòng lặp tạo sách mẫu
DECLARE @j INT = 4;
WHILE @j <= 150
BEGIN
    INSERT INTO SACH (TENSACH, TACGIA, THELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, VITRISACH, MOTA)
    VALUES (
        N'Sách tham khảo số ' + CAST(@j AS NVARCHAR),
        N'Tác giả AI',
        N'Khoa học',
        N'NXB Tổng hợp',
        2022, 10, N'Kho A', N'Mô tả sách...'
    );
    SET @j = @j + 1;
END
GO

-- 4.5 Phiếu Mượn (Dữ liệu mẫu - Đã có TIENMUON, TONGTIEN)
INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, TRANGTHAI, TIENMUON, TONGTIEN)
VALUES 
(1, 1, 1, GETDATE(), DATEADD(DAY, 7, GETDATE()), N'Đang mượn', 35000, 35000),
(2, 2, 1, GETDATE(), DATEADD(DAY, 7, GETDATE()), N'Đang mượn', 35000, 35000),
(3, 3, 1, DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -3, GETDATE()), N'Đang mượn', 35000, 35000);

-- Một phiếu đã trả và bị phạt
INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, NGAYTRA, TRANGTHAI, SOTIENPHAT, TIENMUON, TONGTIEN)
VALUES 
(1, 4, 1, DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -3, GETDATE()), GETDATE(), N'Đã trả', 15000, 35000, 50000); 

INSERT INTO PHAT (MAPHIEUMUON, SOTIEN, LYDO, DATHANHTOAN, NGAYPHAT)
VALUES (SCOPE_IDENTITY(), 15000, N'Quá hạn 3 ngày', 1, GETDATE());

PRINT N'Cài đặt Database QL_THUVIEN thành công!';
GO

USE QL_THUVIEN;
GO

-- =============================================
-- 1. THÊM THAM SỐ CẤU HÌNH (QUAN TRỌNG)
-- Để tính năng giới hạn 5 cuốn sách hoạt động
-- =============================================
DELETE FROM THAMSO WHERE TENTHAMSO = 'GIOI_HAN_SACH_MUON'; -- Xóa cũ nếu có tránh lỗi
INSERT INTO THAMSO (TENTHAMSO, GIATRI, MOTA) 
VALUES ('GIOI_HAN_SACH_MUON', '5', N'Số lượng sách tối đa một độc giả được mượn');

-- Cập nhật lại các tham số khác nếu chưa đúng ý
UPDATE THAMSO SET GIATRI = '5000' WHERE TENTHAMSO = 'TIEN_PHAT_MOI_NGAY';
UPDATE THAMSO SET GIATRI = '7' WHERE TENTHAMSO = 'SO_NGAY_GIA_HAN';
UPDATE THAMSO SET GIATRI = '2000' WHERE TENTHAMSO = 'SO_TIEN_MUON_MOI_NGAY';

-- =============================================
-- 2. THÊM DANH MỤC (Thể loại, Tác giả, NXB)
-- =============================================
INSERT INTO THELOAI (TEN) VALUES 
(N'Tiểu thuyết'), (N'Khoa học viễn tưởng'), (N'Kỹ năng sống'), 
(N'Lịch sử'), (N'Công nghệ thông tin'), (N'Truyện tranh');

INSERT INTO TACGIA (TEN) VALUES 
(N'Nguyễn Nhật Ánh'), (N'Tô Hoài'), (N'J.K. Rowling'), 
(N'Haruki Murakami'), (N'Robert C. Martin');

INSERT INTO NHAXUATBAN (TEN, DIACHI, SDT) VALUES 
(N'NXB Kim Đồng', N'Hà Nội', '02439434730'),
(N'NXB Trẻ', N'TP.HCM', '02839316289'),
(N'NXB Văn Học', N'Hà Nội', '02438437300');

-- =============================================
-- 3. THÊM NGƯỜI DÙNG (Mật khẩu mặc định: 123456)
-- Hash MD5 của 123456 = E10ADC3949BA59ABBE56E057F20F883E
-- =============================================

-- 3.1 Tạo Admin
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO, TRANGTHAI)
VALUES (N'Quản Trị Viên', 'admin@library.com', '0901111111', 'E10ADC3949BA59ABBE56E057F20F883E', 'admin', 'Active');
-- Lấy ID vừa tạo để thêm vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANGUOIDUNG, CHUCVU) VALUES ((SELECT TOP 1 MANGUOIDUNG FROM NGUOIDUNG WHERE EMAIL='admin@library.com'), 'QuanLy');

-- 3.2 Tạo Thủ thư (Nhân viên)
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO, TRANGTHAI)
VALUES (N'Nguyễn Văn Thủ Thư', 'staff@library.com', '0902222222', 'E10ADC3949BA59ABBE56E057F20F883E', 'nhanvien', 'Active');
INSERT INTO NHANVIEN (MANGUOIDUNG, CHUCVU) VALUES ((SELECT TOP 1 MANGUOIDUNG FROM NGUOIDUNG WHERE EMAIL='staff@library.com'), 'ThuThu');

-- 3.3 Tạo Độc giả 1
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO, TRANGTHAI)
VALUES (N'Trần Văn Đọc Giả', 'docgia1@gmail.com', '0903333333', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia', 'Active');
INSERT INTO DOCGIA (MANGUOIDUNG, TINHTRANGTHE, NGAYCAP, NGAYHETHAN) 
VALUES ((SELECT TOP 1 MANGUOIDUNG FROM NGUOIDUNG WHERE EMAIL='docgia1@gmail.com'), 'Active', GETDATE(), DATEADD(YEAR, 1, GETDATE()));

-- 3.4 Tạo Độc giả 2
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO, TRANGTHAI)
VALUES (N'Lê Thị Mọt Sách', 'docgia2@gmail.com', '0904444444', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia', 'Active');
INSERT INTO DOCGIA (MANGUOIDUNG, TINHTRANGTHE, NGAYCAP, NGAYHETHAN) 
VALUES ((SELECT TOP 1 MANGUOIDUNG FROM NGUOIDUNG WHERE EMAIL='docgia2@gmail.com'), 'Active', GETDATE(), DATEADD(YEAR, 1, GETDATE()));

-- =============================================
-- 4. THÊM SÁCH
-- =============================================
INSERT INTO SACH (TENSACH, TACGIA, THELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, VITRISACH, TRANGTHAI) VALUES
(N'Harry Potter và Hòn đá Phù thủy', N'J.K. Rowling', N'Tiểu thuyết', N'NXB Trẻ', 2020, 10, N'Kệ A1', N'Có sẵn'),
(N'Clean Code', N'Robert C. Martin', N'Công nghệ thông tin', N'NXB Khoa Học', 2018, 5, N'Kệ B3', N'Có sẵn'),
(N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', N'Truyện tranh', N'NXB Kim Đồng', 2022, 20, N'Kệ C1', N'Có sẵn'),
(N'Rừng Na Uy', N'Haruki Murakami', N'Tiểu thuyết', N'NXB Văn Học', 2019, 0, N'Kệ A2', N'Hết hàng'), -- Sách hết để test
(N'Mắt Biếc', N'Nguyễn Nhật Ánh', N'Tiểu thuyết', N'NXB Trẻ', 2021, 8, N'Kệ A1', N'Có sẵn'),
(N'Design Patterns', N'Gang of Four', N'Công nghệ thông tin', N'NXB Khoa Học', 2015, 3, N'Kệ B3', N'Có sẵn');

-- =============================================
-- 5. THÊM DỮ LIỆU MƯỢN TRẢ (Để test thống kê)
-- =============================================

-- Phiếu 1: Đang mượn (Đúng hạn)
INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, TRANGTHAI, TIENMUON, TONGTIEN)
VALUES (
    (SELECT TOP 1 MADOCGIA FROM DOCGIA), -- Lấy độc giả đầu tiên
    (SELECT TOP 1 MASACH FROM SACH WHERE TENSACH LIKE N'%Harry%'), 
    (SELECT TOP 1 MANHANVIEN FROM NHANVIEN), 
    GETDATE(), 
    DATEADD(DAY, 7, GETDATE()), 
    N'Đang mượn', 
    20000, 20000
);

-- Phiếu 2: Đang mượn (Quá hạn - để test tính phạt)
INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, TRANGTHAI, TIENMUON, TONGTIEN)
VALUES (
    (SELECT TOP 1 MADOCGIA FROM DOCGIA), 
    (SELECT TOP 1 MASACH FROM SACH WHERE TENSACH LIKE N'%Clean Code%'), 
    (SELECT TOP 1 MANHANVIEN FROM NHANVIEN), 
    DATEADD(DAY, -10, GETDATE()), -- Mượn 10 ngày trước
    DATEADD(DAY, -3, GETDATE()),  -- Hết hạn 3 ngày trước
    N'Đang mượn', 
    20000, 20000
);

-- Phiếu 3: Đã trả (Có đóng tiền phạt)
INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, NGAYTRA, TRANGTHAI, SOTIENPHAT, TIENMUON, TONGTIEN)
VALUES (
    (SELECT TOP 1 MADOCGIA FROM DOCGIA ORDER BY MADOCGIA DESC), -- Lấy độc giả thứ 2
    (SELECT TOP 1 MASACH FROM SACH WHERE TENSACH LIKE N'%Mắt Biếc%'), 
    (SELECT TOP 1 MANHANVIEN FROM NHANVIEN), 
    DATEADD(MONTH, -1, GETDATE()), 
    DATEADD(MONTH, -1, GETDATE()) + 7, 
    DATEADD(MONTH, -1, GETDATE()) + 10, -- Trả trễ 3 ngày
    N'Đã trả', 
    15000, 20000, 35000
);

-- Thêm vào bảng PHAT cho phiếu số 3
INSERT INTO PHAT (MAPHIEUMUON, SOTIEN, LYDO, DATHANHTOAN, NGAYPHAT)
VALUES (
    (SELECT TOP 1 MAPHIEUMUON FROM PHIEUMUON WHERE TRANGTHAI = N'Đã trả'),
    15000, 
    N'Quá hạn trả sách', 
    1, 
    DATEADD(MONTH, -1, GETDATE()) + 10
);

PRINT N'Đã thêm dữ liệu mẫu thành công!';
GO



USE QL_THUVIEN;
GO

-- ============================================================
-- 1. XÓA DỮ LIỆU CŨ (Để reset lại từ đầu cho sạch)
-- ============================================================
-- Tắt check khóa ngoại tạm thời để xóa nhanh
EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"
DELETE FROM PHAT;
DELETE FROM PHIEUMUON;
DELETE FROM YEUCAUMUON;
DELETE FROM SACH;
DELETE FROM DOCGIA;
DELETE FROM NHANVIEN;
DELETE FROM NGUOIDUNG;
DELETE FROM THAMSO;
DELETE FROM THELOAI;
DELETE FROM TACGIA;
DELETE FROM NHAXUATBAN;
-- Bật lại check khóa ngoại
EXEC sp_MSforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"
DBCC CHECKIDENT ('SACH', RESEED, 0);
DBCC CHECKIDENT ('NGUOIDUNG', RESEED, 0);
DBCC CHECKIDENT ('DOCGIA', RESEED, 0);
DBCC CHECKIDENT ('NHANVIEN', RESEED, 0);
DBCC CHECKIDENT ('PHIEUMUON', RESEED, 0);
DBCC CHECKIDENT ('PHAT', RESEED, 0);
GO

-- ============================================================
-- 2. CẤU HÌNH HỆ THỐNG
-- ============================================================
INSERT INTO THAMSO (TENTHAMSO, GIATRI, MOTA) VALUES 
('GIOI_HAN_SACH_MUON', '5', N'Số lượng sách tối đa một độc giả được mượn'),
('TIEN_PHAT_MOI_NGAY', '5000', N'Số tiền phạt trễ hạn 1 ngày'),
('SO_NGAY_GIA_HAN', '7', N'Số ngày được cộng thêm khi gia hạn'),
('SO_TIEN_MUON_MOI_NGAY', '2000', N'Số tiền mượn trên mỗi ngày');

-- ============================================================
-- 3. DANH MỤC
-- ============================================================
INSERT INTO THELOAI (TEN) VALUES 
(N'Tiểu thuyết'), (N'Kinh tế - Quản trị'), (N'Tâm lý - Kỹ năng'), 
(N'Công nghệ thông tin'), (N'Truyện tranh'), (N'Văn học kinh điển'), 
(N'Lịch sử'), (N'Khoa học viễn tưởng'), (N'Trinh thám');

INSERT INTO TACGIA (TEN) VALUES 
(N'Nguyễn Nhật Ánh'), (N'Tô Hoài'), (N'J.K. Rowling'), (N'Haruki Murakami'), 
(N'Paulo Coelho'), (N'Dale Carnegie'), (N'Robert C. Martin'), (N'Rosie Nguyễn'),
(N'Dan Brown'), (N'Thạch Lam'), (N'Nam Cao'), (N'Vũ Trọng Phụng'), 
(N'Fujiko F. Fujio'), (N'Stephen Hawking'), (N'Yuval Noah Harari');

INSERT INTO NHAXUATBAN (TEN, DIACHI, SDT) VALUES 
(N'NXB Trẻ', N'TP.HCM', '02839316289'),
(N'NXB Kim Đồng', N'Hà Nội', '02439434730'),
(N'NXB Hội Nhà Văn', N'Hà Nội', '02438222135'),
(N'NXB Lao Động', N'Hà Nội', '02438515380'),
(N'NXB Thế Giới', N'Hà Nội', '02438253841'),
(N'NXB Tổng hợp TP.HCM', N'TP.HCM', '02838225009');

-- ============================================================
-- 4. NGƯỜI DÙNG & NHÂN VIÊN
-- ============================================================
-- Admin & Thủ thư
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO) VALUES 
(N'Quản Trị Viên', 'admin@library.com', '0909000001', 'E10ADC3949BA59ABBE56E057F20F883E', 'admin'),
(N'Trần Thị Thủ Thư', 'thuthu@library.com', '0909000002', 'E10ADC3949BA59ABBE56E057F20F883E', 'nhanvien');

INSERT INTO NHANVIEN (MANGUOIDUNG, CHUCVU) VALUES 
((SELECT MANGUOIDUNG FROM NGUOIDUNG WHERE EMAIL='admin@library.com'), 'QuanLy'),
((SELECT MANGUOIDUNG FROM NGUOIDUNG WHERE EMAIL='thuthu@library.com'), 'ThuThu');

-- 20 Độc giả "người thật"
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO) VALUES
(N'Nguyễn Văn An', 'an.nguyen@gmail.com', '0912345678', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Trần Thị Bích', 'bich.tran@gmail.com', '0912345679', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Lê Hoàng Cường', 'cuong.le@gmail.com', '0912345680', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Phạm Minh Duy', 'duy.pham@gmail.com', '0912345681', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Hoàng Thị Em', 'em.hoang@gmail.com', '0912345682', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Vũ Văn Dũng', 'dung.vu@gmail.com', '0912345683', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Đặng Thu Hà', 'ha.dang@gmail.com', '0912345684', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Bùi Văn Hùng', 'hung.bui@gmail.com', '0912345685', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Đỗ Thị Khanh', 'khanh.do@gmail.com', '0912345686', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Ngô Văn Long', 'long.ngo@gmail.com', '0912345687', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Dương Thị Mai', 'mai.duong@gmail.com', '0912345688', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Lý Văn Nam', 'nam.ly@gmail.com', '0912345689', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Trương Thị Oanh', 'oanh.truong@gmail.com', '0912345690', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Đinh Văn Phúc', 'phuc.dinh@gmail.com', '0912345691', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Lâm Thị Quyên', 'quyen.lam@gmail.com', '0912345692', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Mai Văn Sang', 'sang.mai@gmail.com', '0912345693', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Cao Thị Thảo', 'thao.cao@gmail.com', '0912345694', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Phan Văn Uy', 'uy.phan@gmail.com', '0912345695', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Hà Thị Vân', 'van.ha@gmail.com', '0912345696', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia'),
(N'Võ Văn Xuyên', 'xuyen.vo@gmail.com', '0912345697', 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia');

-- Thêm vào bảng Độc Giả
INSERT INTO DOCGIA (MANGUOIDUNG, NGAYCAP, NGAYHETHAN)
SELECT MANGUOIDUNG, '2024-01-01', '2025-12-31' FROM NGUOIDUNG WHERE VAITRO = 'DocGia';

-- ============================================================
-- 5. SÁCH (100 CUỐN - DỮ LIỆU THẬT)
-- ============================================================
-- Dữ liệu sách được chọn lọc kỹ: Tên sách, Tác giả, Thể loại, NXB, Năm XB
INSERT INTO SACH (TENSACH, TACGIA, THELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, VITRISACH, ANHBIA) VALUES
(N'Mắt Biếc', N'Nguyễn Nhật Ánh', N'Tiểu thuyết', N'NXB Trẻ', 2019, 10, N'Kệ A1', N'matbiec.jpg'),
(N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'Nguyễn Nhật Ánh', N'Tiểu thuyết', N'NXB Trẻ', 2018, 15, N'Kệ A1', N'hoavang.jpg'),
(N'Cho Tôi Xin Một Vé Đi Tuổi Thơ', N'Nguyễn Nhật Ánh', N'Tiểu thuyết', N'NXB Trẻ', 2020, 12, N'Kệ A1', N'vevetuoitho.jpg'),
(N'Cô Gái Đến Từ Hôm Qua', N'Nguyễn Nhật Ánh', N'Tiểu thuyết', N'NXB Trẻ', 2017, 8, N'Kệ A1', N'cogai.jpg'),
(N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', N'Truyện tranh', N'NXB Kim Đồng', 2021, 20, N'Kệ C1', N'demen.jpg'),
(N'Số Đỏ', N'Vũ Trọng Phụng', N'Văn học kinh điển', N'NXB Văn Học', 2015, 5, N'Kệ B2', N'sodo.jpg'),
(N'Chí Phèo', N'Nam Cao', N'Văn học kinh điển', N'NXB Văn Học', 2016, 7, N'Kệ B2', N'chipheo.jpg'),
(N'Tắt Đèn', N'Ngô Tất Tố', N'Văn học kinh điển', N'NXB Văn Học', 2014, 6, N'Kệ B2', N'tatden.jpg'),
(N'Harry Potter và Hòn Đá Phù Thủy', N'J.K. Rowling', N'Tiểu thuyết', N'NXB Trẻ', 2020, 10, N'Kệ A2', N'harry1.jpg'),
(N'Harry Potter và Phòng Chứa Bí Mật', N'J.K. Rowling', N'Tiểu thuyết', N'NXB Trẻ', 2020, 9, N'Kệ A2', N'harry2.jpg'),
(N'Harry Potter và Tên Tù Nhân Ngục Azkaban', N'J.K. Rowling', N'Tiểu thuyết', N'NXB Trẻ', 2020, 11, N'Kệ A2', N'harry3.jpg'),
(N'Rừng Na Uy', N'Haruki Murakami', N'Tiểu thuyết', N'NXB Hội Nhà Văn', 2019, 8, N'Kệ A3', N'rungnauy.jpg'),
(N'Kafka Bên Bờ Biển', N'Haruki Murakami', N'Tiểu thuyết', N'NXB Hội Nhà Văn', 2018, 6, N'Kệ A3', N'kafka.jpg'),
(N'Nhà Giả Kim', N'Paulo Coelho', N'Tiểu thuyết', N'NXB Hội Nhà Văn', 2021, 25, N'Kệ A4', N'nhagiakim.jpg'),
(N'Đắc Nhân Tâm', N'Dale Carnegie', N'Tâm lý - Kỹ năng', N'NXB Tổng hợp TP.HCM', 2022, 30, N'Kệ D1', N'dacnhantam.jpg'),
(N'Quẳng Gánh Lo Đi Và Vui Sống', N'Dale Carnegie', N'Tâm lý - Kỹ năng', N'NXB Tổng hợp TP.HCM', 2021, 20, N'Kệ D1', N'quangganh.jpg'),
(N'Tuổi Trẻ Đáng Giá Bao Nhiêu', N'Rosie Nguyễn', N'Tâm lý - Kỹ năng', N'NXB Hội Nhà Văn', 2018, 18, N'Kệ D2', N'tuoitre.jpg'),
(N'Clean Code', N'Robert C. Martin', N'Công nghệ thông tin', N'NXB Lao Động', 2019, 5, N'Kệ E1', N'cleancode.jpg'),
(N'The Pragmatic Programmer', N'Andy Hunt', N'Công nghệ thông tin', N'NXB Lao Động', 2020, 4, N'Kệ E1', N'pragmatic.jpg'),
(N'Design Patterns', N'Gang of Four', N'Công nghệ thông tin', N'NXB Lao Động', 2015, 3, N'Kệ E1', N'designpattern.jpg'),
(N'Introduction to Algorithms', N'Thomas H. Cormen', N'Công nghệ thông tin', N'NXB Thế Giới', 2018, 2, N'Kệ E2', N'algo.jpg'),
(N'Sapiens: Lược Sử Loài Người', N'Yuval Noah Harari', N'Lịch sử', N'NXB Thế Giới', 2021, 15, N'Kệ F1', N'sapiens.jpg'),
(N'Homo Deus: Lược Sử Tương Lai', N'Yuval Noah Harari', N'Lịch sử', N'NXB Thế Giới', 2022, 12, N'Kệ F1', N'homodeus.jpg'),
(N'Lược Sử Thời Gian', N'Stephen Hawking', N'Khoa học viễn tưởng', N'NXB Trẻ', 2019, 10, N'Kệ F2', N'luocsu.jpg'),
(N'Vũ Trụ Trong Vỏ Hạt Dẻ', N'Stephen Hawking', N'Khoa học viễn tưởng', N'NXB Trẻ', 2018, 8, N'Kệ F2', N'vutru.jpg'),
(N'Mật Mã Da Vinci', N'Dan Brown', N'Trinh thám', N'NXB Lao Động', 2017, 10, N'Kệ G1', N'davinci.jpg'),
(N'Thiên Thần Và Ác Quỷ', N'Dan Brown', N'Trinh thám', N'NXB Lao Động', 2016, 9, N'Kệ G1', N'angel.jpg'),
(N'Hỏa Ngục', N'Dan Brown', N'Trinh thám', N'NXB Lao Động', 2018, 7, N'Kệ G1', N'inferno.jpg'),
(N'Doraemon Tập 1', N'Fujiko F. Fujio', N'Truyện tranh', N'NXB Kim Đồng', 2023, 20, N'Kệ C2', N'doraemon1.jpg'),
(N'Doraemon Tập 2', N'Fujiko F. Fujio', N'Truyện tranh', N'NXB Kim Đồng', 2023, 20, N'Kệ C2', N'doraemon2.jpg'),
(N'Thám Tử Lừng Danh Conan Tập 1', N'Gosho Aoyama', N'Truyện tranh', N'NXB Kim Đồng', 2023, 15, N'Kệ C3', N'conan1.jpg'),
(N'One Piece Tập 1', N'Eiichiro Oda', N'Truyện tranh', N'NXB Kim Đồng', 2023, 15, N'Kệ C3', N'onepiece1.jpg'),
(N'Naruto Tập 1', N'Masashi Kishimoto', N'Truyện tranh', N'NXB Kim Đồng', 2022, 10, N'Kệ C3', N'naruto1.jpg'),
(N'Dragon Ball Tập 1', N'Akira Toriyama', N'Truyện tranh', N'NXB Kim Đồng', 2022, 12, N'Kệ C3', N'dragonball1.jpg'),
(N'Bố Già', N'Mario Puzo', N'Tiểu thuyết', N'NXB Văn Học', 2015, 8, N'Kệ A5', N'godfather.jpg'),
(N'Cuốn Theo Chiều Gió', N'Margaret Mitchell', N'Tiểu thuyết', N'NXB Văn Học', 2016, 7, N'Kệ A5', N'gone.jpg'),
(N'Không Gia Đình', N'Hector Malot', N'Tiểu thuyết', N'NXB Kim Đồng', 2018, 10, N'Kệ A5', N'khonggiadinh.jpg'),
(N'Những Người Khốn Khổ', N'Victor Hugo', N'Văn học kinh điển', N'NXB Văn Học', 2014, 5, N'Kệ B1', N'lesmi.jpg'),
(N'Chiến Tranh Và Hòa Bình', N'Leo Tolstoy', N'Văn học kinh điển', N'NXB Văn Học', 2013, 4, N'Kệ B1', N'warpeace.jpg'),
(N'Ông Già Và Biển Cả', N'Ernest Hemingway', N'Văn học kinh điển', N'NXB Văn Học', 2019, 9, N'Kệ B1', N'oldman.jpg'),
(N'Tội Ác Và Trừng Phạt', N'Fyodor Dostoevsky', N'Văn học kinh điển', N'NXB Văn Học', 2018, 6, N'Kệ B1', N'crime.jpg'),
(N'Đồi Gió Hú', N'Emily Brontë', N'Tiểu thuyết', N'NXB Văn Học', 2020, 8, N'Kệ A6', N'wuthering.jpg'),
(N'Kiêu Hãnh Và Định Kiến', N'Jane Austen', N'Tiểu thuyết', N'NXB Văn Học', 2021, 10, N'Kệ A6', N'pride.jpg'),
(N'Gatsby Vĩ Đại', N'F. Scott Fitzgerald', N'Tiểu thuyết', N'NXB Hội Nhà Văn', 2019, 9, N'Kệ A6', N'gatsby.jpg'),
(N'Hoàng Tử Bé', N'Antoine de Saint-Exupéry', N'Truyện tranh', N'NXB Kim Đồng', 2022, 15, N'Kệ C4', N'hoangtube.jpg'),
(N'Cây Cam Ngọt Của Tôi', N'José Mauro de Vasconcelos', N'Tiểu thuyết', N'NXB Hội Nhà Văn', 2020, 12, N'Kệ A7', N'caycamngot.jpg'),
(N'Hai Số Phận', N'Jeffrey Archer', N'Tiểu thuyết', N'NXB Văn Học', 2018, 8, N'Kệ A7', N'haisophan.jpg'),
(N'Suối Nguồn', N'Ayn Rand', N'Tiểu thuyết', N'NXB Trẻ', 2017, 5, N'Kệ A8', N'suoinguon.jpg'),
(N'Trăm Năm Cô Đơn', N'Gabriel García Márquez', N'Tiểu thuyết', N'NXB Văn Học', 2019, 6, N'Kệ A8', N'tramnam.jpg'),
(N'Giết Con Chim Nhại', N'Harper Lee', N'Tiểu thuyết', N'NXB Văn Học', 2020, 10, N'Kệ A8', N'mockingbird.jpg');

-- (Thêm 50 cuốn nữa để đủ 100 - Dùng vòng lặp tạo sách chuyên ngành)
DECLARE @k INT = 51;
WHILE @k <= 100
BEGIN
    INSERT INTO SACH (TENSACH, TACGIA, THELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, VITRISACH, ANHBIA)
    VALUES (
        N'Giáo trình Đại học số ' + CAST(@k AS NVARCHAR),
        N'Nhiều tác giả',
        N'Kinh tế - Quản trị',
        N'NXB Thế Giới',
        2023, 20, N'Kệ H' + CAST((@k/10) AS NVARCHAR), N'giaotrinh.jpg'
    );
    SET @k = @k + 1;
END
GO

-- ============================================================
-- 6. DỮ LIỆU HOẠT ĐỘNG (1 NĂM QUA)
-- ============================================================
-- Tạo dữ liệu mượn trả từ tháng 1/2024 đến nay (Giả sử hiện tại là tháng 12/2024)
DECLARE @CurrentDate DATE = GETDATE();
DECLARE @StartDate DATE = DATEADD(YEAR, -1, @CurrentDate);
DECLARE @LoopDate DATE = @StartDate;

-- Vòng lặp từng ngày trong 365 ngày qua
WHILE @LoopDate <= @CurrentDate
BEGIN
    -- Mỗi ngày có 30% cơ hội có người mượn sách
    IF (RAND() > 0.7)
    BEGIN
        -- Random 1-3 phiếu mượn mỗi ngày có giao dịch
        DECLARE @NumTrans INT = FLOOR(RAND() * 3) + 1;
        DECLARE @t INT = 1;
        
        WHILE @t <= @NumTrans
        BEGIN
            -- Random Độc giả (1-20), Sách (1-100), Nhân viên (1-2)
            DECLARE @RandDG INT = FLOOR(RAND() * 20) + 1;
            DECLARE @RandSach INT = FLOOR(RAND() * 50) + 1; -- Chỉ lấy 50 cuốn đầu cho phổ biến
            DECLARE @RandNV INT = FLOOR(RAND() * 2) + 1;
            
            -- Tính ngày trả: Mượn 7 ngày, có thể trả sớm hoặc trễ
            -- 80% trả đúng hạn/sớm, 15% trả trễ, 5% chưa trả (nếu gần ngày hiện tại)
            DECLARE @RandStatus FLOAT = RAND();
            DECLARE @NgayMuon DATE = @LoopDate;
            DECLARE @HanTra DATE = DATEADD(DAY, 7, @NgayMuon);
            DECLARE @NgayTra DATE = NULL;
            DECLARE @TrangThai NVARCHAR(20) = N'Đang mượn';
            DECLARE @TienPhat DECIMAL(10,2) = 0;
            DECLARE @TienMuon DECIMAL(10,2) = 14000; -- 2000 * 7 ngày (ước lượng)
            DECLARE @TongTien DECIMAL(10,2) = 14000;

            IF @RandStatus < 0.8 -- Trả đúng hạn/sớm
            BEGIN
                SET @NgayTra = DATEADD(DAY, FLOOR(RAND() * 7), @NgayMuon);
                SET @TrangThai = N'Đã trả';
            END
            ELSE IF @RandStatus < 0.95 -- Trả trễ
            BEGIN
                DECLARE @Tre INT = FLOOR(RAND() * 10) + 1; -- Trễ 1-10 ngày
                SET @NgayTra = DATEADD(DAY, 7 + @Tre, @NgayMuon);
                SET @TrangThai = N'Đã trả';
                SET @TienPhat = @Tre * 5000;
                SET @TongTien = @TienMuon + @TienPhat;
            END
            ELSE -- Chưa trả (Quá hạn hoặc đang mượn)
            BEGIN
                SET @TrangThai = N'Đang mượn';
                IF @HanTra < @CurrentDate SET @TrangThai = N'Đang mượn'; -- Logic App sẽ hiển thị Quá hạn
            END

            -- Insert Phiếu Mượn
            INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, NGAYTRA, TRANGTHAI, SOTIENPHAT, TIENMUON, TONGTIEN)
            VALUES (
                (SELECT MADOCGIA FROM DOCGIA WHERE MADOCGIA = @RandDG),
                @RandSach,
                @RandNV,
                @NgayMuon, @HanTra, @NgayTra, @TrangThai, @TienPhat, @TienMuon, @TongTien
            );

            -- Insert Phạt nếu có
            IF @TienPhat > 0
            BEGIN
                INSERT INTO PHAT (MAPHIEUMUON, SOTIEN, LYDO, DATHANHTOAN, NGAYPHAT)
                VALUES (SCOPE_IDENTITY(), @TienPhat, N'Quá hạn trả sách', 1, @NgayTra);
            END

            SET @t = @t + 1;
        END
    END
    SET @LoopDate = DATEADD(DAY, 1, @LoopDate);
END
GO

PRINT N'Hoàn tất tạo dữ liệu giả lập 1 năm!';


USE QL_THUVIEN;
GO

-- 1. Create Review Table if not exists
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DANHGIA]') AND type in (N'U'))
BEGIN
    CREATE TABLE DANHGIA (
        MADANHGIA INT PRIMARY KEY IDENTITY(1,1),
        MASACH INT,
        MADOCGIA INT,
        DIEM INT CHECK (DIEM BETWEEN 1 AND 5), -- Rating 1-5 stars
        BINHLUAN NVARCHAR(MAX),
        NGAYDANHGIA DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (MASACH) REFERENCES SACH(MASACH),
        FOREIGN KEY (MADOCGIA) REFERENCES DOCGIA(MADOCGIA)
    );
END
GO

-- 2. Add some dummy reviews
INSERT INTO DANHGIA (MASACH, MADOCGIA, DIEM, BINHLUAN)
VALUES 
((SELECT TOP 1 MASACH FROM SACH), (SELECT TOP 1 MADOCGIA FROM DOCGIA), 5, N'Sách rất hay, đáng đọc!'),
((SELECT TOP 1 MASACH FROM SACH), (SELECT TOP 1 MADOCGIA FROM DOCGIA ORDER BY MADOCGIA DESC), 4, N'Nội dung tốt nhưng bìa hơi cũ.');
GO


USE QL_THUVIEN;
GO

-- ============================================================
-- CẬP NHẬT ẢNH BÌA CHO 50 CUỐN SÁCH CỤ THỂ (DỮ LIỆU THẬT)
-- ============================================================

-- 1. Nguyễn Nhật Ánh
UPDATE SACH SET ANHBIA = 'matbiec.jpg' WHERE TENSACH = N'Mắt Biếc';
UPDATE SACH SET ANHBIA = 'hoavangtrencoxanh.jpg' WHERE TENSACH = N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh';
UPDATE SACH SET ANHBIA = 'chotoixinmotve.jpg' WHERE TENSACH = N'Cho Tôi Xin Một Vé Đi Tuổi Thơ';
UPDATE SACH SET ANHBIA = 'cogaidentuhomqua.jpg' WHERE TENSACH = N'Cô Gái Đến Từ Hôm Qua';

-- 2. Truyện tranh & Thiếu nhi
UPDATE SACH SET ANHBIA = 'demen.jpg' WHERE TENSACH = N'Dế Mèn Phiêu Lưu Ký';
UPDATE SACH SET ANHBIA = 'hoangtube.jpg' WHERE TENSACH = N'Hoàng Tử Bé';
UPDATE SACH SET ANHBIA = 'khonggiadinh.jpg' WHERE TENSACH = N'Không Gia Đình';
UPDATE SACH SET ANHBIA = 'doraemon1.jpg' WHERE TENSACH LIKE N'Doraemon Tập 1%';
UPDATE SACH SET ANHBIA = 'doraemon2.jpg' WHERE TENSACH LIKE N'Doraemon Tập 2%';
UPDATE SACH SET ANHBIA = 'conan1.jpg' WHERE TENSACH LIKE N'Thám Tử Lừng Danh Conan%';
UPDATE SACH SET ANHBIA = 'onepiece1.jpg' WHERE TENSACH LIKE N'One Piece%';
UPDATE SACH SET ANHBIA = 'naruto1.jpg' WHERE TENSACH LIKE N'Naruto%';
UPDATE SACH SET ANHBIA = 'dragonball1.jpg' WHERE TENSACH LIKE N'Dragon Ball%';

-- 3. Harry Potter
UPDATE SACH SET ANHBIA = 'harry1.jpg' WHERE TENSACH LIKE N'%Hòn Đá Phù Thủy%';
UPDATE SACH SET ANHBIA = 'harry2.jpg' WHERE TENSACH LIKE N'%Phòng Chứa Bí Mật%';
UPDATE SACH SET ANHBIA = 'harry3.jpg' WHERE TENSACH LIKE N'%Tù Nhân Ngục Azkaban%';

-- 4. Văn học kinh điển VN & TG
UPDATE SACH SET ANHBIA = 'sodo.jpg' WHERE TENSACH = N'Số Đỏ';
UPDATE SACH SET ANHBIA = 'chipheo.jpg' WHERE TENSACH = N'Chí Phèo';
UPDATE SACH SET ANHBIA = 'tatden.jpg' WHERE TENSACH = N'Tắt Đèn';
UPDATE SACH SET ANHBIA = 'bogia.jpg' WHERE TENSACH = N'Bố Già';
UPDATE SACH SET ANHBIA = 'cuontheochieugio.jpg' WHERE TENSACH = N'Cuốn Theo Chiều Gió';
UPDATE SACH SET ANHBIA = 'nhungnguoikhonkho.jpg' WHERE TENSACH = N'Những Người Khốn Khổ';
UPDATE SACH SET ANHBIA = 'chientranhvahoabinh.jpg' WHERE TENSACH = N'Chiến Tranh Và Hòa Bình';
UPDATE SACH SET ANHBIA = 'onggiavabienca.jpg' WHERE TENSACH = N'Ông Già Và Biển Cả';
UPDATE SACH SET ANHBIA = 'toiacvatrungphat.jpg' WHERE TENSACH = N'Tội Ác Và Trừng Phạt';
UPDATE SACH SET ANHBIA = 'doigiohu.jpg' WHERE TENSACH = N'Đồi Gió Hú';
UPDATE SACH SET ANHBIA = 'kieuhanhvadinhkien.jpg' WHERE TENSACH = N'Kiêu Hãnh Và Định Kiến';
UPDATE SACH SET ANHBIA = 'gatsby.jpg' WHERE TENSACH = N'Gatsby Vĩ Đại';
UPDATE SACH SET ANHBIA = 'caycamngot.jpg' WHERE TENSACH = N'Cây Cam Ngọt Của Tôi';
UPDATE SACH SET ANHBIA = 'haisophan.jpg' WHERE TENSACH = N'Hai Số Phận';
UPDATE SACH SET ANHBIA = 'suoinguon.jpg' WHERE TENSACH = N'Suối Nguồn';
UPDATE SACH SET ANHBIA = 'tramnamcodon.jpg' WHERE TENSACH = N'Trăm Năm Cô Đơn';
UPDATE SACH SET ANHBIA = 'gietconchimnhai.jpg' WHERE TENSACH = N'Giết Con Chim Nhại';

-- 5. Văn học hiện đại (Murakami, Coelho)
UPDATE SACH SET ANHBIA = 'rungnauy.jpg' WHERE TENSACH = N'Rừng Na Uy';
UPDATE SACH SET ANHBIA = 'kafka.jpg' WHERE TENSACH = N'Kafka Bên Bờ Biển';
UPDATE SACH SET ANHBIA = 'nhagiakim.jpg' WHERE TENSACH = N'Nhà Giả Kim';

-- 6. Kỹ năng & Tâm lý
UPDATE SACH SET ANHBIA = 'dacnhantam.jpg' WHERE TENSACH = N'Đắc Nhân Tâm';
UPDATE SACH SET ANHBIA = 'quangganhlo.jpg' WHERE TENSACH = N'Quẳng Gánh Lo Đi Và Vui Sống';
UPDATE SACH SET ANHBIA = 'tuoitredanggia.jpg' WHERE TENSACH = N'Tuổi Trẻ Đáng Giá Bao Nhiêu';

-- 7. Công nghệ thông tin
UPDATE SACH SET ANHBIA = 'cleancode.jpg' WHERE TENSACH = N'Clean Code';
UPDATE SACH SET ANHBIA = 'pragmatic.jpg' WHERE TENSACH = N'The Pragmatic Programmer';
UPDATE SACH SET ANHBIA = 'designpatterns.jpg' WHERE TENSACH = N'Design Patterns';
UPDATE SACH SET ANHBIA = 'algorithms.jpg' WHERE TENSACH = N'Introduction to Algorithms';

-- 8. Khoa học & Lịch sử
UPDATE SACH SET ANHBIA = 'sapiens.jpg' WHERE TENSACH = N'Sapiens: Lược Sử Loài Người';
UPDATE SACH SET ANHBIA = 'homodeus.jpg' WHERE TENSACH = N'Homo Deus: Lược Sử Tương Lai';
UPDATE SACH SET ANHBIA = 'luocsuthoigian.jpg' WHERE TENSACH = N'Lược Sử Thời Gian';
UPDATE SACH SET ANHBIA = 'vutruhatde.jpg' WHERE TENSACH = N'Vũ Trụ Trong Vỏ Hạt Dẻ';

-- 9. Trinh thám Dan Brown
UPDATE SACH SET ANHBIA = 'davinci.jpg' WHERE TENSACH = N'Mật Mã Da Vinci';
UPDATE SACH SET ANHBIA = 'thienthanacquy.jpg' WHERE TENSACH = N'Thiên Thần Và Ác Quỷ';
UPDATE SACH SET ANHBIA = 'hoanguc.jpg' WHERE TENSACH = N'Hỏa Ngục';

-- ============================================================
-- CẬP NHẬT ẢNH BÌA CHO 50 CUỐN GIÁO TRÌNH (Batch Update)
-- ============================================================
-- Dùng chung 3 ảnh đại diện cho giáo trình để đỡ phải tìm 50 ảnh
UPDATE SACH SET ANHBIA = 'giaotrinh1.jpg' WHERE TENSACH LIKE N'Giáo trình%' AND MASACH % 3 = 0;
UPDATE SACH SET ANHBIA = 'giaotrinh2.jpg' WHERE TENSACH LIKE N'Giáo trình%' AND MASACH % 3 = 1;
UPDATE SACH SET ANHBIA = 'giaotrinh3.jpg' WHERE TENSACH LIKE N'Giáo trình%' AND MASACH % 3 = 2;

GO
PRINT N'Đã cập nhật tên file ảnh thành công!';