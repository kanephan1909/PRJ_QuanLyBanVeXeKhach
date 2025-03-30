CREATE DATABASE DB_QLBanVeXe
USE DB_QLBanVeXe

CREATE TABLE NhanVien(
    soDienThoai VARCHAR(12) PRIMARY KEY, 
    hoTen NVARCHAR(50) NOT NULL, 
    cccd VARCHAR(30) UNIQUE, 
    gioiTinh VARCHAR(10),    
    diaChi NVARCHAR(100)    
);

CREATE TABLE BenXe (
    maBenXe		INT				PRIMARY KEY, 
    tenBenXe	NVARCHAR(50)	NOT NULL, 
    diaChi		NVARCHAR(100) 
);
CREATE TABLE ChuyenDi(
	maCD	INT		PRIMARY KEY,
	gioDi	TIME,
	ngayDi	DATE,
	diemDi	NVARCHAR(50),
	diemDen	NVARCHAR(50),
	giaVe	NVARCHAR(20)
);
CREATE TABLE KhachHang(
	soDienThoai		VARCHAR(12)		PRIMARY KEY,
	hoTen			NVARCHAR(50)	NOT NULL,
	cccd			VARCHAR(30)		UNIQUE,
	gioiTinh		VARCHAR(10),
	gmail			VARCHAR(50)		UNIQUE,
	diaChi			NVARCHAR(50)
);
CREATE TABLE DatVeXe (
    maDatVe			INT			PRIMARY KEY, 
    soDienThoai		VARCHAR(12) NOT NULL,
    maChuyenDi		INT			NOT NULL, 
    soGhe			VARCHAR(5)	NOT NULL,
    FOREIGN KEY (soDienThoai) REFERENCES KhachHang(soDienThoai),
    FOREIGN KEY (maChuyenDi) REFERENCES ChuyenDi(maCD)
);
CREATE TABLE HopDongNV(
	maHopDong	INT		PRIMARY KEY, 
    maNV		INT		NOT NULL, 
    ngayKy		DATE	NOT NULL, 
    ngayHetHan	DATE, 
    luong		DECIMAL(15, 2), 
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
);
CREATE TABLE TaiKhoan (
    tenDangNhap VARCHAR(20) PRIMARY KEY,
    matKhau VARCHAR(20) NOT NULL,
    loaiTaiKhoan INT NOT NULL, 
    maNV INT,
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
);

CREATE TABLE ThoiGianHoatDong(
	maThoiGian			INT			PRIMARY KEY, 
    maNV				INT			NOT NULL, 
    thoiGianDangNhap	DATETIME,	
    thoiGianDangXuat	DATETIME,	
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV) 
);
CREATE TABLE Xe (
    bienSo		VARCHAR(20) PRIMARY KEY,
    tenXe		NVARCHAR(50) NOT NULL,
    taiXe		NVARCHAR(50),
    soDienThoai VARCHAR(12)
);
CREATE TABLE ThongTinVeXe(
	maVe		INT			PRIMARY KEY, 
    maChuyen	INT			NOT NULL, 
    bienSo		VARCHAR(20) NOT NULL, 
    soLuong		INT			NOT NULL, 
    FOREIGN KEY (maChuyen) REFERENCES ChuyenDi(maCD), 
    FOREIGN KEY (bienSo) REFERENCES Xe(bienSo)
);