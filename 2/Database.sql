CREATE DATABASE QL_NhaTro; GO
USE QL_NhaTro;
CREATE TABLE PhongTro(MaPhong int IDENTITY PRIMARY KEY,TenPhong nvarchar(20) NOT NULL,GiaThue decimal(18,0) NOT NULL,TinhTrang nvarchar(20) NOT NULL);
CREATE TABLE KhachThue(MaKhach int IDENTITY PRIMARY KEY,HoTen nvarchar(100) NOT NULL,GioiTinh nvarchar(5) NOT NULL,NgaySinh date NOT NULL,SoDienThoai varchar(15) NOT NULL,MaTinh int NOT NULL DEFAULT 0,TenTinh nvarchar(100) NOT NULL DEFAULT N'',MaPhuongXa int NOT NULL DEFAULT 0,TenPhuongXa nvarchar(100) NOT NULL DEFAULT N'',DaDangKyTamTru bit NOT NULL,MaPhong int NOT NULL REFERENCES PhongTro(MaPhong));
INSERT PhongTro(TenPhong,GiaThue,TinhTrang) VALUES(N'P101',2500000,N'Trống'),(N'P102',2500000,N'Đang thuê'),(N'P103',2700000,N'Trống'),(N'P201',3000000,N'Trống'),(N'P202',3000000,N'Trống'),(N'P203',3200000,N'Trống');
INSERT KhachThue(HoTen,GioiTinh,NgaySinh,SoDienThoai,TenTinh,TenPhuongXa,DaDangKyTamTru,MaPhong) VALUES(N'Nguyễn An',N'Nam','2000-04-02','0900000001',N'Hà Nội',N'Ba Đình',1,2),(N'Trần Bình',N'Nữ','1999-08-12','0900000002',N'Hà Nội',N'Cầu Giấy',0,2);
