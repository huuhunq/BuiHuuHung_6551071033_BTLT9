-- Script tạo cơ sở dữ liệu và dữ liệu mẫu cho bài tập "Sổ chi tiêu cá nhân"
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'QL_ChiTieu')
BEGIN
    CREATE DATABASE QL_ChiTieu;
END
GO

USE QL_ChiTieu;
GO

IF OBJECT_ID(N'dbo.ChiTieu', N'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.ChiTieu;
END
GO

CREATE TABLE dbo.ChiTieu (
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    NgayChi DATE NOT NULL,
    NoiDung NVARCHAR(100) NOT NULL,
    LoaiChi NVARCHAR(30) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    GhiChu NVARCHAR(200) NULL
);
GO

-- Nhập sẵn ít nhất 10 dòng dữ liệu mẫu
INSERT INTO dbo.ChiTieu (NgayChi, NoiDung, LoaiChi, SoTien, GhiChu)
VALUES 
    ('2026-10-01', N'Cơm trưa', N'Ăn uống', 35000, N'Cơm văn phòng'),
    ('2026-10-02', N'Xăng xe', N'Đi lại', 60000, N'Đổ xăng xe máy'),
    ('2026-10-03', N'Photo giáo trình', N'Học tập', 25000, N'Tài liệu môn Lập trình trực quan'),
    ('2026-10-04', N'Xem phim', N'Giải trí', 90000, N'Vé xem phim CGV cuối tuần'),
    ('2026-10-05', N'Trà sữa', N'Ăn uống', 40000, N'Trà sữa ô long'),
    ('2026-10-06', N'Mua áo thun', N'Khác', 150000, N'Mua sắm cá nhân'),
    ('2026-10-07', N'Tiền điện nước', N'Khác', 500000, N'Hóa đơn sinh hoạt tháng 10'),
    ('2026-10-08', N'Ăn sáng', N'Ăn uống', 25000, N'Bánh mì chả'),
    ('2026-10-10', N'Mua sách tham khảo', N'Học tập', 120000, N'Sách C# và EF Core'),
    ('2026-10-12', N'Vé gửi xe tháng', N'Đi lại', 80000, N'Gửi xe trường'),
    ('2026-10-15', N'Cà phê với bạn bè', N'Ăn uống', 45000, N'Highlands Coffee'),
    ('2026-10-17', N'Bowling giải trí', N'Giải trí', 105000, N'Chơi bowling với nhóm bạn');
GO
