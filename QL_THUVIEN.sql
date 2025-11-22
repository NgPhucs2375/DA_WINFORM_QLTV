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
-- 2. TẠO BẢNG (TABLES) VỚI CẤU TRÚC NÂNG CẤP
-- ============================================================

-- 2.1 Bảng Người Dùng (Thêm ANHDAIDIEN)
CREATE TABLE NGUOIDUNG (
    MANGUOIDUNG INT PRIMARY KEY IDENTITY(1,1),
    HOTEN NVARCHAR(100) NOT NULL,
    EMAIL NVARCHAR(100) UNIQUE,
    SDT NVARCHAR(20),
    MATKHAU NVARCHAR(255) NOT NULL, -- Lưu MD5 Hash
    VAITRO NVARCHAR(20) NOT NULL, -- 'DocGia', 'NhanVien', 'Admin'
    TRANGTHAI NVARCHAR(20) DEFAULT N'Active', -- 'Active', 'Locked'
    ANHDAIDIEN NVARCHAR(255) NULL, -- MỚI: Đường dẫn ảnh avatar
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

-- 2.4 Bảng Sách (Thêm MOTA)
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
    MOTA NVARCHAR(MAX) NULL, -- MỚI: Tóm tắt nội dung sách
    TRANGTHAI NVARCHAR(20) DEFAULT N'Có sẵn'
);
GO

-- 2.5 Bảng Phiếu Mượn (Thêm MANHANVIEN)
CREATE TABLE PHIEUMUON (
    MAPHIEUMUON INT PRIMARY KEY IDENTITY(1,1),
    MADOCGIA INT,
    MASACH INT,
    MANHANVIEN INT NULL, -- MỚI: Ai lập phiếu này?
    NGAYMUON DATE DEFAULT GETDATE(),
    HANTRA DATE,
    NGAYTRA DATE NULL,
    TRANGTHAI NVARCHAR(20) DEFAULT N'Đang mượn', 
    SOTIENPHAT DECIMAL(10,2) DEFAULT 0,
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

-- 2.7 Yêu Cầu Mượn (Online)
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

-- 2.8 Các bảng Log và Thông báo (Giữ nguyên để đủ cấu trúc)
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

CREATE TABLE HOATDONG_LOG (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MANGUOIDUNG INT,
    HANHDONG NVARCHAR(200),
    THOIGIAN DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MANGUOIDUNG) REFERENCES NGUOIDUNG(MANGUOIDUNG)
);
GO

-- ============================================================
-- 3. STORED PROCEDURE (XỬ LÝ NGHIỆP VỤ CHẶT CHẼ)
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
        -- 1. Kiểm tra tồn kho
        DECLARE @SoLuong INT;
        SELECT @SoLuong = SOLUONG FROM SACH WHERE MASACH = @MaSach;

        IF @SoLuong <= 0
        BEGIN
            ROLLBACK TRANSACTION;
            THROW 51000, N'Sách này đã hết, không thể mượn!', 1;
            RETURN;
        END

        -- 2. Thêm phiếu mượn
        INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, TRANGTHAI)
        VALUES (@MaDocGia, @MaSach, @MaNhanVien, @NgayMuon, @HanTra, N'Đang mượn');

        -- 3. Trừ kho
        UPDATE SACH SET SOLUONG = SOLUONG - 1 WHERE MASACH = @MaSach;
        
        -- 4. Cập nhật trạng thái nếu hết
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
-- 4. INSERT DỮ LIỆU MẪU (DATA SEEDING)
-- ============================================================

-- Lưu ý: Mật khẩu mặc định là '123456' đã mã hóa MD5
-- Hash MD5 của '123456' = 'E10ADC3949BA59ABBE56E057F20F883E'

-- 4.1 Tạo 1 Admin
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO)
VALUES (N'Administrator', 'admin@library.com', '0900000001', 'E10ADC3949BA59ABBE56E057F20F883E', 'admin');

INSERT INTO NHANVIEN (MANGUOIDUNG, CHUCVU) VALUES (1, 'QuanLy');

-- 4.2 Tạo 2 Thủ thư (NhanVien)
INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO)
VALUES 
(N'Trần Thu Thư', 'thuthu1@library.com', '0900000002', 'E10ADC3949BA59ABBE56E057F20F883E', 'nhanvien'),
(N'Lê Văn Sách', 'thuthu2@library.com', '0900000003', 'E10ADC3949BA59ABBE56E057F20F883E', 'nhanvien');

INSERT INTO NHANVIEN (MANGUOIDUNG, CHUCVU) VALUES (2, 'ThuThu'), (3, 'ThuThu');

-- 4.3 Tạo 20 Độc giả (Sử dụng vòng lặp)
DECLARE @i INT = 1;
WHILE @i <= 20
BEGIN
    DECLARE @TenDG NVARCHAR(50) = N'Độc Giả ' + CAST(@i AS NVARCHAR(10));
    DECLARE @EmailDG NVARCHAR(50) = 'docgia' + CAST(@i AS NVARCHAR(10)) + '@gmail.com';
    DECLARE @SdtDG NVARCHAR(20) = '098' + RIGHT('0000000' + CAST(@i AS NVARCHAR(10)), 7);
    
    -- Insert User
    INSERT INTO NGUOIDUNG (HOTEN, EMAIL, SDT, MATKHAU, VAITRO)
    VALUES (@TenDG, @EmailDG, @SdtDG, 'E10ADC3949BA59ABBE56E057F20F883E', 'DocGia');
    
    -- Insert DocGia (Lấy ID vừa tạo)
    DECLARE @NewUserID INT = SCOPE_IDENTITY();
    INSERT INTO DOCGIA (MANGUOIDUNG, TINHTRANGTHE, NGAYHETHAN)
    VALUES (@NewUserID, N'Active', DATEADD(YEAR, 1, GETDATE()));

    SET @i = @i + 1;
END
GO

-- 4.4 Tạo 150 Sách
-- A. Tạo 20 sách "xịn" có tên thật để Dashboard đẹp
INSERT INTO SACH (TENSACH, TACGIA, THELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, VITRISACH, MOTA)
VALUES 
(N'Nhà Giả Kim', N'Paulo Coelho', N'Tiểu thuyết', N'NXB Văn Học', 2020, 10, N'Kệ A1', N'Cuốn sách bán chạy nhất mọi thời đại về hành trình theo đuổi ước mơ.'),
(N'Đắc Nhân Tâm', N'Dale Carnegie', N'Kỹ năng sống', N'NXB Trẻ', 2019, 15, N'Kệ B2', N'Nghệ thuật thu phục lòng người.'),
(N'Clean Code', N'Robert C. Martin', N'Công nghệ', N'Prentice Hall', 2008, 5, N'Kệ C1', N'Hướng dẫn viết code sạch, dễ bảo trì cho lập trình viên.'),
(N'Harry Potter và Hòn đá phù thủy', N'J.K. Rowling', N'Viễn tưởng', N'NXB Trẻ', 2015, 8, N'Kệ D1', N'Tập đầu tiên trong series Harry Potter nổi tiếng.'),
(N'Tuổi trẻ đáng giá bao nhiêu', N'Rosie Nguyễn', N'Kỹ năng sống', N'NXB Nhã Nam', 2018, 20, N'Kệ B3', N'Sách self-help dành cho giới trẻ.'),
(N'Lập trình C# căn bản', N'Phạm Văn Ất', N'Giáo trình', N'NXB Bách Khoa', 2021, 50, N'Kệ C2', N'Giáo trình nhập môn C# cho sinh viên.'),
(N'Sherlock Holmes Toàn tập', N'Arthur Conan Doyle', N'Trinh thám', N'NXB Văn Học', 2017, 12, N'Kệ D2', N'Những vụ án ly kỳ của thám tử lừng danh.'),
(N'Mắt Biếc', N'Nguyễn Nhật Ánh', N'Truyện dài', N'NXB Trẻ', 2019, 18, N'Kệ A2', N'Câu chuyện tình đơn phương buồn man mác.'),
(N'Cha Giàu Cha Nghèo', N'Robert Kiyosaki', N'Kinh tế', N'NXB Trẻ', 2020, 25, N'Kệ E1', N'Tư duy tài chính khác biệt.'),
(N'Dế Mèn phiêu lưu ký', N'Tô Hoài', N'Thiếu nhi', N'NXB Kim Đồng', 2016, 30, N'Kệ F1', N'Tác phẩm văn học thiếu nhi kinh điển.'),
(N'Rừng Na Uy', N'Haruki Murakami', N'Tiểu thuyết', N'NXB Hội Nhà Văn', 2018, 7, N'Kệ A3', N'Câu chuyện về tình yêu và sự cô đơn.'),
(N'Sapiens: Lược sử loài người', N'Yuval Noah Harari', N'Lịch sử', N'NXB Tri Thức', 2019, 9, N'Kệ G1', N'Lịch sử tiến hóa của loài người.'),
(N'Design Patterns', N'Erich Gamma', N'Công nghệ', N'Addison-Wesley', 1994, 4, N'Kệ C3', N'Các mẫu thiết kế phần mềm kinh điển.'),
(N'Tôi thấy hoa vàng trên cỏ xanh', N'Nguyễn Nhật Ánh', N'Truyện dài', N'NXB Trẻ', 2015, 22, N'Kệ A2', N'Tuổi thơ trong trẻo.'),
(N'Đại gia Gatsby', N'F. Scott Fitzgerald', N'Tiểu thuyết', N'NXB Văn Học', 2010, 6, N'Kệ A4', N'Giấc mơ Mỹ và bi kịch tình yêu.'),
(N'Introduction to Algorithms', N'Thomas H. Cormen', N'Công nghệ', N'MIT Press', 2009, 3, N'Kệ C4', N'Sách gối đầu giường về giải thuật.'),
(N'Tam Quốc Diễn Nghĩa', N'La Quán Trung', N'Lịch sử', N'NXB Văn Học', 2012, 14, N'Kệ G2', N'Tiểu thuyết lịch sử Trung Quốc.'),
(N'Doraemon Tập 1', N'Fujiko F. Fujio', N'Truyện tranh', N'NXB Kim Đồng', 2022, 100, N'Kệ F2', N'Mèo máy đến từ tương lai.'),
(N'Conan Tập 100', N'Gosho Aoyama', N'Truyện tranh', N'NXB Kim Đồng', 2022, 80, N'Kệ F2', N'Thám tử lừng danh Conan.'),
(N'Cấu trúc dữ liệu và giải thuật', N'Đinh Mạnh Tường', N'Giáo trình', N'NXB ĐHQG', 2020, 40, N'Kệ C2', N'Tài liệu học tập chính quy.');

-- B. Tạo thêm 130 sách tự động (Loop) để đủ 150 cuốn
DECLARE @j INT = 21;
WHILE @j <= 150
BEGIN
    INSERT INTO SACH (TENSACH, TACGIA, THELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, VITRISACH, MOTA)
    VALUES (
        N'Sách tham khảo số ' + CAST(@j AS NVARCHAR(10)),
        N'Tác giả AI',
        N'Khoa học',
        N'NXB Tổng hợp',
        2020 + (@j % 5), -- Năm ngẫu nhiên từ 2020-2024
        10 + (@j % 20),  -- Số lượng ngẫu nhiên
        N'Kho ' + CAST((@j % 5) + 1 AS NVARCHAR(10)),
        N'Mô tả nội dung cho sách số ' + CAST(@j AS NVARCHAR(10))
    );
    SET @j = @j + 1;
END
GO

-- ============================================================
-- 5. TẠO DỮ LIỆU MƯỢN/TRẢ (ĐỂ TEST BÁO CÁO)
-- ============================================================

-- Mượn 5 cuốn (Trạng thái: Đang mượn)
-- Giả định: Độc giả 1 mượn Sách 1, Độc giả 2 mượn Sách 2... do Nhân viên 1 (Thủ thư) lập
INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, TRANGTHAI)
VALUES 
(1, 1, 1, GETDATE(), DATEADD(DAY, 7, GETDATE()), N'Đang mượn'),
(2, 2, 1, GETDATE(), DATEADD(DAY, 7, GETDATE()), N'Đang mượn'),
(3, 3, 1, DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -3, GETDATE()), N'Đang mượn'), -- Quá hạn 3 ngày
(4, 4, 1, GETDATE(), DATEADD(DAY, 7, GETDATE()), N'Đang mượn'),
(5, 5, 1, GETDATE(), DATEADD(DAY, 7, GETDATE()), N'Đang mượn');

-- Trả 2 cuốn (Có 1 cuốn bị phạt)
INSERT INTO PHIEUMUON (MADOCGIA, MASACH, MANHANVIEN, NGAYMUON, HANTRA, NGAYTRA, TRANGTHAI, SOTIENPHAT)
VALUES 
(1, 6, 1, DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -3, GETDATE()), GETDATE(), N'Đã trả', 15000); -- Phạt 15k

-- Ghi nhận tiền phạt
INSERT INTO PHAT (MAPHIEUMUON, SOTIEN, LYDO, DATHANHTOAN, NGAYPHAT)
VALUES (SCOPE_IDENTITY(), 15000, N'Quá hạn 3 ngày', 1, GETDATE());

GO

PRINT N'Cài đặt Database QL_THUVIEN thành công! Đã thêm 150 sách và 20 độc giả.';