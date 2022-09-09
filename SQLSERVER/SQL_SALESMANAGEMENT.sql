CREATE DATABASE QUANLY_BEAUTY_HEALTH
ON ( NAME = 'QUANLYBH_DATA', FILENAME = 'C:\Users\Van Nghia\OneDrive\Desktop\Winform c#\DATA\QUANLYBH.MDF')
LOG ON ( NAME = 'QUANLYBH_LOG', FILENAME = 'C:\Users\Van Nghia\OneDrive\Desktop\Winform c#\DATA\QUANLYBH.LDF')
GO

USE QUANLY_BEAUTY_HEALTH
GO

CREATE TABLE LOAITAIKHOAN
(
	MALOAI INT IDENTITY(1,1) PRIMARY KEY,
	TENLOAI NVARCHAR(20)
)
GO
CREATE TABLE TAIKHOAN 
(
	TAIKHOAN NVARCHAR(50) PRIMARY KEY,
	MATKHAU NVARCHAR(50) NOT NULL,
	TENTAIKHOAN NVARCHAR(50) NOT NULL,
	MALOAI INT NOT NULL
	FOREIGN KEY (MALOAI) REFERENCES dbo.LOAITAIKHOAN(MALOAI)
)
GO
CREATE TABLE NHANVIEN
(
	MANV VARCHAR(10) PRIMARY KEY,
	TENNV NVARCHAR(50) NOT NULL,
	SDT VARCHAR(20) CHECK (LEN(SDT) = 10),
	DIACHI NVARCHAR(100)
)

GO
CREATE TABLE KHACHHANG
(
	MAKH VARCHAR(10) PRIMARY KEY,
	TENKH NVARCHAR(50) NOT NULL, 
	SDT VARCHAR(20) CHECK (LEN(SDT) = 10),
	DIACHI NVARCHAR(100)
)
GO
CREATE TABLE NHACUNGCAP
(
	MANCC VARCHAR(10) PRIMARY KEY,
	TENNCC NVARCHAR(50) NOT NULL,
	SDT VARCHAR(20) CHECK (LEN(SDT) = 10),
	DIACHI NVARCHAR(100)
)
GO
CREATE TABLE KHO
(
	MAKHO VARCHAR(10) PRIMARY KEY,
	MANV VARCHAR(10),
	TENKHO NVARCHAR(50), 
	DIACHI NVARCHAR(100),
	FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN(MANV)
)
GO
CREATE TABLE SANPHAM 
(
	MASP VARCHAR(10) PRIMARY KEY, 
	TENSP NVARCHAR(10) NOT NULL,
	GIATIEN MONEY CHECK (GIATIEN > 0 ),
	DONVITINH NVARCHAR(10),
	HANSUDUNG DATETIME,
	MAKHO VARCHAR(10), 
	SOLUONGTON INT CHECK (SOLUONGTON >= 0),
	FOREIGN KEY (MAKHO) REFERENCES dbo.KHO (MAKHO)
)
GO
CREATE TABLE HOADON 
(
	MAHD VARCHAR(10) PRIMARY KEY,
	MANV VARCHAR(10),
	MAKH VARCHAR(10), 
	NGAYLAP DATE CHECK (NGAYLAP < GETDATE()),
	THANHTIEN MONEY,
	TRANGTHAI NVARCHAR(20)
	FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN(MANV),
	FOREIGN KEY (MAKH) REFERENCES dbo.KHACHHANG(MAKH)
)
GO
CREATE TABLE PHIEUGIAOHANG
(
	MAPGH VARCHAR(10) PRIMARY KEY,
	MANCC VARCHAR(10),
	MANV VARCHAR(10), 
	FOREIGN KEY (MANCC) REFERENCES dbo.NHACUNGCAP(MANCC),
	FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN(MANV)
)
GO
CREATE TABLE CTPGH 
(
	MAPGH VARCHAR(10),
	MASP VARCHAR(10),
	PRIMARY KEY(MAPGH,MASP),
	NGAYDAT DATE,
	NGAYNHAN DATE,
	SOLUONG INT,
	TONGTIEN MONEY
	FOREIGN KEY (MAPGH) REFERENCES dbo.PHIEUGIAOHANG (MAPGH),
	FOREIGN KEY (MASP) REFERENCES dbo.SANPHAM (MASP),
)
GO
CREATE TABLE GIOHANG
(
	MAHD VARCHAR(10),
	MASP VARCHAR(10),
	PRIMARY KEY (MAHD, MASP),
	SOLUONG INT CHECK (SOLUONG > 0),
	FOREIGN KEY (MAHD) REFERENCES dbo.HOADON(MAHD),
	FOREIGN KEY (MASP) REFERENCES dbo.SANPHAM(MASP)
	
)
GO


