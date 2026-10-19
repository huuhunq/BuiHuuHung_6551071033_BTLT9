CREATE DATABASE QL_TraSua; GO
USE QL_TraSua;
CREATE TABLE DanhMucMon(MaDM int IDENTITY PRIMARY KEY,TenDM nvarchar(50) NOT NULL);
CREATE TABLE MonUong(MaMon int IDENTITY PRIMARY KEY,TenMon nvarchar(100) NOT NULL,GiaBan decimal(18,0) NOT NULL,DangBan bit NOT NULL,MaDM int NOT NULL REFERENCES DanhMucMon(MaDM));
CREATE TABLE HoaDon(MaHD int IDENTITY PRIMARY KEY,NgayLap datetime NOT NULL,TongTien decimal(18,0) NOT NULL,HinhThucTT nvarchar(20) NOT NULL,DaThanhToan bit NOT NULL);
CREATE TABLE ChiTietHoaDon(MaHD int NOT NULL REFERENCES HoaDon(MaHD),MaMon int NOT NULL REFERENCES MonUong(MaMon),SoLy int NOT NULL,DonGia decimal(18,0) NOT NULL,CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY(MaHD,MaMon));
INSERT DanhMucMon(TenDM) VALUES(N'Trà sữa'),(N'Trà trái cây'),(N'Topping'),(N'Đồ ăn vặt');
INSERT MonUong(TenMon,GiaBan,DangBan,MaDM) VALUES(N'Trà sữa truyền thống',30000,1,1),(N'Trà sữa matcha',35000,1,1),(N'Trà sữa khoai môn',35000,1,1),(N'Trà đào',30000,1,2),(N'Trà vải',32000,1,2),(N'Trà chanh',20000,1,2),(N'Trân châu đen',8000,1,3),(N'Thạch rau câu',7000,1,3),(N'Pudding',10000,1,3),(N'Khoai tây chiên',25000,1,4),(N'Xúc xích',18000,1,4),(N'Bánh tráng',20000,1,4);
