USE [master]
GO
/****** Object:  Database [ATINChamCong]    Script Date: 02/04/2020 6:19:29 PM ******/
CREATE DATABASE [ATINChamCong]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Timeshare-Developer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ATINChamCong.mdf' , SIZE = 262272KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Timeshare-Developer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ATINChamCong_0.LDF' , SIZE = 22144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ATINChamCong] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ATINChamCong].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ATINChamCong] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ATINChamCong] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ATINChamCong] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ATINChamCong] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ATINChamCong] SET ARITHABORT OFF 
GO
ALTER DATABASE [ATINChamCong] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ATINChamCong] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ATINChamCong] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ATINChamCong] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ATINChamCong] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ATINChamCong] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ATINChamCong] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ATINChamCong] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ATINChamCong] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ATINChamCong] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ATINChamCong] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ATINChamCong] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ATINChamCong] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ATINChamCong] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ATINChamCong] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ATINChamCong] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ATINChamCong] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ATINChamCong] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ATINChamCong] SET  MULTI_USER 
GO
ALTER DATABASE [ATINChamCong] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ATINChamCong] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ATINChamCong] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ATINChamCong] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ATINChamCong] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ATINChamCong] SET QUERY_STORE = OFF
GO
USE [ATINChamCong]
GO
/****** Object:  User [admin]    Script Date: 02/04/2020 6:19:29 PM ******/
CREATE USER [admin] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [admin]
GO
/****** Object:  Table [dbo].[SapXepLichTrinh]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SapXepLichTrinh](
	[MaSapXep] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[MaChamCong] [int] NOT NULL,
	[MaLichTrinh] [varchar](5) NULL,
	[MaLichTrinhTam] [int] NULL,
 CONSTRAINT [PK_SapXepLichTrinh] PRIMARY KEY CLUSTERED 
(
	[MaSapXep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nguoi]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoi](
	[MaNguoi] [int] NOT NULL,
	[MaDinhDanh] [varchar](50) NULL,
	[HoTen] [nvarchar](100) NULL,
	[PhongBan] [int] NULL,
	[ChucVu] [int] NULL,
	[KhuVuc] [int] NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [int] NOT NULL,
	[SoDienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[AnhDaiDien] [varchar](200) NULL,
	[TrinhDo] [int] NULL,
	[SoTheCanCuoc] [varchar](50) NULL,
	[NgayCapTCC] [date] NULL,
	[NoiCapTCC] [nvarchar](150) NULL,
	[DanToc] [int] NULL,
	[TonGiao] [int] NULL,
	[QuocTich] [int] NULL,
	[TinhTrangHonNhan] [int] NULL,
	[SoBangLaiXeMay] [varchar](50) NULL,
	[NgayCapBLXM] [date] NULL,
	[NoiCapBLXM] [nvarchar](150) NULL,
	[SoBangLaiOto] [varchar](50) NULL,
	[NgayCapBLXO] [date] NULL,
	[NoiCapBLXO] [nvarchar](150) NULL,
	[DiaChiThuongTru] [nvarchar](150) NULL,
	[DiaChiTamTru] [varchar](20) NULL,
	[NgayNhanViec] [date] NULL,
	[NgayThoiViec] [date] NULL,
	[SuDungVanTay] [bit] NULL,
	[SuDungTheTu] [bit] NULL,
	[SuDungKhuonMat] [bit] NULL,
	[ThoiGianDangKy] [datetime] NULL,
	[ThoiGianCapNhat] [datetime] NULL,
	[GhiChu] [nvarchar](150) NULL,
	[TrangThaiHoatDong] [int] NULL,
 CONSTRAINT [PK_Nguoi] PRIMARY KEY CLUSTERED 
(
	[MaNguoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinh]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinh](
	[MaLichTrinh] [varchar](5) NOT NULL,
	[TenLichTrinh] [nvarchar](30) NOT NULL,
	[MaLoaiChuKy] [varchar](5) NOT NULL,
 CONSTRAINT [PK_LichTrinh] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewSapXepLichTrinh]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[ViewSapXepLichTrinh]
as

select MaSapXep, Nguoi.MaNguoi, MaChamCong, HoTen, TenLichTrinh 
from SapXepLichTrinh
join Nguoi
on SapXepLichTrinh.MaNguoi = Nguoi.MaNguoi
join LichTrinh
on SapXepLichTrinh.MaLichTrinh = LichTrinh.MaLichTrinh

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[FullName] [nvarchar](256) NULL,
	[AnhDaiDien] [nvarchar](256) NULL,
	[TinhId] [int] NULL,
	[TenTinh] [nvarchar](256) NULL,
	[QuanHuyenId] [int] NULL,
	[TenQuanHuyen] [nvarchar](256) NULL,
	[GioiTinh] [int] NULL,
	[DiaChi] [nvarchar](256) NULL,
	[UserType] [int] NOT NULL,
	[HieuLuc] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[MaBaoCao] [int] NOT NULL,
	[NgayBaoCao] [date] NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[ThoiGianIn] [datetime] NULL,
	[ThoiGianOut] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoCaoChiTiet]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoChiTiet](
	[id] [uniqueidentifier] NOT NULL,
	[reportDate] [datetime] NULL,
	[checkInTime] [date] NULL,
	[checkOutTime] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CacLoaiVang]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CacLoaiVang](
	[MaLoaiVang] [varchar](10) NOT NULL,
	[TenLoaiVang] [nvarchar](100) NOT NULL,
	[TrangThai] [bit] NULL,
	[TinhCong] [bit] NULL,
 CONSTRAINT [PK_CacLoaiVang] PRIMARY KEY CLUSTERED 
(
	[MaLoaiVang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaLamViec]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaLamViec](
	[MaCaLamViec] [varchar](5) NOT NULL,
	[TenCaLamViec] [nvarchar](50) NOT NULL,
	[GioBatDauCa] [time](7) NOT NULL,
	[GioKetThucCa] [time](7) NOT NULL,
	[GioBatDauGiaiLao] [time](7) NULL,
	[GioKetThucGiaiLao] [time](7) NULL,
	[TongGio] [int] NOT NULL,
	[DiemCong] [int] NOT NULL,
	[GioVaoSomNhatDuocTinhCa] [time](7) NOT NULL,
	[GioVaoMuonNhatDuocTinhCa] [time](7) NOT NULL,
	[GioRaSomNhatDuocTinhCa] [time](7) NOT NULL,
	[GioRaMuonNhatDuocTinhCa] [time](7) NOT NULL,
	[KhongCoGioVao] [int] NOT NULL,
	[KhongCoGioRa] [int] NOT NULL,
	[TruGioDiTre] [bit] NULL,
	[ThoiGianDiTreChoPhep] [int] NULL,
	[TruGioVeSom] [bit] NULL,
	[ThoiGianVeSomChoPhep] [int] NULL,
	[SDMucTangCaHienTai] [bit] NULL,
	[MucTangCaHienTai] [int] NULL,
	[SDMucTangCaCuoiTuan] [bit] NULL,
	[MucTangCaCuoiTuan] [int] NULL,
	[SDMucTangCaNgayLe] [bit] NULL,
	[MucTangCaNgayLe] [int] NULL,
	[SDMucTangCaCuaTangCaCuoiTuan] [bit] NULL,
	[MucTangCaCuaTangCaCuoiTuan] [int] NULL,
	[SDMucTangCaCuaTangCaNgayLe] [bit] NULL,
	[MucTangCaCuaTangCaNgayLe] [int] NULL,
	[SDTangCaTruocGLV] [bit] NULL,
	[TangCaTruocGLV] [int] NULL,
	[SDTangCaSauGLV] [bit] NULL,
	[TangCaSauGLV] [int] NULL,
	[TongGLVTinhTangCa] [int] NULL,
	[GioiHanTCMucMot] [int] NULL,
	[GioiHanTCMucHai] [int] NULL,
	[GioiHanTCTruocGLV] [int] NULL,
	[GioiHanTCSauGLV] [int] NULL,
	[CaQuaDem] [bit] NULL,
	[TachGioCaDemTu] [time](7) NULL,
	[TachGioCaDemDen] [time](7) NULL,
	[SDTongGLVTinhTangCa] [bit] NULL,
 CONSTRAINT [PK_CaLamViec] PRIMARY KEY CLUSTERED 
(
	[MaCaLamViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaChamCong] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaDinhDanh] [int] NULL,
	[NgayChamCong] [date] NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
	[GioVaoDauTien] [datetime] NULL,
	[GioRaCuoiCung] [datetime] NULL,
	[SoGioLamViec] [float] NOT NULL,
	[SoCongLamViec] [float] NOT NULL,
	[SoPhutDiTre] [int] NOT NULL,
	[SoPhutVeSom] [int] NOT NULL,
	[SoPhutBuGio] [float] NOT NULL,
	[TangCa1] [int] NOT NULL,
	[TangCa2] [int] NOT NULL,
	[TangCa3] [int] NOT NULL,
	[MaLoaiVang] [varchar](10) NULL,
	[LyDoVang] [nvarchar](100) NULL,
	[TongSoGioLamViec] [float] NOT NULL,
	[TongSoCongLamViec] [float] NOT NULL,
	[MaXepLoaiChamCong] [varchar](10) NULL,
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED 
(
	[MaChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCongChiTiet]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCongChiTiet](
	[MaChamCongChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaChamCong] [int] NOT NULL,
	[NgayChamCong] [date] NOT NULL,
	[GioChamCong] [datetime] NOT NULL,
	[MaLoaiChamCong] [varchar](3) NOT NULL,
	[NguonThucHien] [int] NOT NULL,
	[MaThietBi] [int] NULL,
	[HinhChamCong] [varbinary](max) NULL,
 CONSTRAINT [PK_ChamCongChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaChamCongChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuKyNam]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuKyNam](
	[MaChuKyNam] [varchar](5) NOT NULL,
	[TenChuKyNam] [nvarchar](30) NOT NULL,
	[SapXep] [int] NOT NULL,
 CONSTRAINT [PK_ChuKyNam] PRIMARY KEY CLUSTERED 
(
	[MaChuKyNam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuKyThang]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuKyThang](
	[MaChuKyThang] [varchar](5) NOT NULL,
	[TenChuKyThang] [nvarchar](30) NOT NULL,
	[SapXep] [int] NOT NULL,
 CONSTRAINT [PK_ChuKyThang] PRIMARY KEY CLUSTERED 
(
	[MaChuKyThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuKyTuan]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuKyTuan](
	[MaChuKyTuan] [varchar](5) NOT NULL,
	[TenChuKyTuan] [nvarchar](30) NOT NULL,
	[SapXep] [int] NOT NULL,
 CONSTRAINT [PK_ChuKyTuan] PRIMARY KEY CLUSTERED 
(
	[MaChuKyTuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongTyKhuVuc]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTyKhuVuc](
	[MaKhuVuc] [int] IDENTITY(1,1) NOT NULL,
	[KhuVuc] [nvarchar](200) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_CongTyKhuVuc] PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangKyNghiPhep]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKyNghiPhep](
	[Id] [int] NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaDinhDanh] [varchar](50) NULL,
	[MaLoaiNghiPhep] [int] NOT NULL,
	[NgayDangKy] [date] NOT NULL,
	[LyDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangKyNghiPhep] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[MaNhanVien] ASC,
	[MaLoaiNghiPhep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangKyTangCa]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKyTangCa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaDinhDanh] [varchar](50) NULL,
	[NgayDangKy] [date] NOT NULL,
	[GioBD] [int] NOT NULL,
	[PhutBD] [int] NOT NULL,
	[GioKT] [int] NOT NULL,
	[PhutKT] [int] NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
	[DK] [bit] NOT NULL,
 CONSTRAINT [PK_DangKyTangCa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanToc]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanToc](
	[MaDanToc] [int] IDENTITY(1,1) NOT NULL,
	[DanToc] [nvarchar](50) NULL,
 CONSTRAINT [PK_DanToc] PRIMARY KEY CLUSTERED 
(
	[MaDanToc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDongLaoDong]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDongLaoDong](
	[MaHopDong] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[SoHopDong] [varchar](50) NULL,
	[LoaiHopDong] [varchar](10) NULL,
	[NgayKyHopDong] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_HopDongLaoDong] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhaiBaoThoiGian]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhaiBaoThoiGian](
	[MaThoiGian] [varchar](30) NOT NULL,
	[ThoiGian] [nvarchar](30) NOT NULL,
	[NhomThoiGian] [varchar](30) NOT NULL,
	[SapXep] [int] NULL,
 CONSTRAINT [PK_KhaiBaoThoiGian] PRIMARY KEY CLUSTERED 
(
	[MaThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuonMat]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuonMat](
	[MaKhuonMat] [int] NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[AnhKhuonMat] [nvarchar](200) NOT NULL,
	[ThuocTinhKhuonMat] [varbinary](max) NULL,
	[ThoiGianDangKy] [datetime] NOT NULL,
	[TrangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhuonMat] ASC,
	[MaNguoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuSuaDuLieuChamCong]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuSuaDuLieuChamCong](
	[MaLichSuSuaDLCC] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGianThucHien] [datetime] NOT NULL,
	[GioCu] [datetime] NULL,
	[GioMoi] [datetime] NULL,
	[MaLoaiChamCongCu] [varchar](3) NULL,
	[MaLoaiChamCongMoi] [varchar](3) NULL,
	[NguoiThucHien] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LichSuSuaDuLieuChamCong] PRIMARY KEY CLUSTERED 
(
	[MaLichSuSuaDLCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhNam]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhNam](
	[MaLichTrinhNam] [int] IDENTITY(1,1) NOT NULL,
	[MaChuKyNam] [varchar](5) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
 CONSTRAINT [PK_LichTrinhNam] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhNam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhNangCao]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhNangCao](
	[MaLichTrinhNangCao] [varchar](5) NOT NULL,
	[TenLichTrinhNangCao] [nvarchar](150) NOT NULL,
	[SuDung] [bit] NOT NULL,
 CONSTRAINT [PK_LichTrinhNangCao] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhNangCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhThang]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhThang](
	[MaLichTrinhThang] [int] IDENTITY(1,1) NOT NULL,
	[MaChuKyThang] [varchar](5) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
 CONSTRAINT [PK_LichTrinhThang] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhTuan]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhTuan](
	[MaLichTrinhTuan] [int] IDENTITY(1,1) NOT NULL,
	[MaChuKyTuan] [varchar](5) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
 CONSTRAINT [PK_LichTrinhTuan] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhTuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiChamCong]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiChamCong](
	[MaLoaiChamCong] [varchar](3) NOT NULL,
	[TenLoaiChamCong] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_LoaiChamCong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiChuKy]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiChuKy](
	[MaLoaiChuKy] [varchar](5) NOT NULL,
	[TenLoaiChuKy] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_LoaiChuKy] PRIMARY KEY CLUSTERED 
(
	[MaLoaiChuKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHopDong](
	[MaLoaiHopDong] [int] IDENTITY(1,1) NOT NULL,
	[LoaiHopDong] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHopDong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNghiPhep]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNghiPhep](
	[MaLoaiNghiPhep] [int] IDENTITY(1,1) NOT NULL,
	[LoaiNghiPhep] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiNghiPhep] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNghiPhep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThamSo]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThamSo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiThamSo] [varchar](100) NOT NULL,
	[TenLoaiThamSo] [nvarchar](150) NOT NULL,
	[MoTa] [nvarchar](250) NULL,
 CONSTRAINT [PK_LoaiThamSo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MapLichTrinhNangCao]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MapLichTrinhNangCao](
	[MaLichTrinh] [varchar](5) NOT NULL,
	[MaLichTrinhNangCao] [varchar](5) NOT NULL,
 CONSTRAINT [PK_MapLichTrinhNangCao] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinh] ASC,
	[MaLichTrinhNangCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayNhanDang]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayNhanDang](
	[MaMay] [int] NOT NULL,
	[TenMay] [nvarchar](150) NOT NULL,
	[SoSerial] [nvarchar](100) NOT NULL,
	[LoaiMay] [int] NOT NULL,
	[DiaChiIP] [nvarchar](50) NULL,
	[DiaChiMac] [nvarchar](50) NULL,
	[NhaSanXuat] [nvarchar](100) NULL,
	[AnhThietBi] [nvarchar](200) NULL,
	[TongBoNho] [float] NULL,
	[BoNhoHienTai] [float] NULL,
	[SoLuongDangKy] [int] NULL,
	[ThoiGianKichHoat] [datetime] NULL,
	[ThoiGianCapNhat] [datetime] NULL,
	[TuDongDongBo] [int] NULL,
	[ThoiGianDongBo] [int] NULL,
	[LuuAnhNhanDang] [int] NULL,
	[TaiKhoanDangNhap] [varchar](50) NOT NULL,
	[MatKhauDangNhap] [varchar](50) NOT NULL,
	[MaKichHoat] [varchar](150) NOT NULL,
	[TrangThaiKetNoi] [int] NULL,
	[TrangThaiHoatDong] [int] NOT NULL,
 CONSTRAINT [PK_Camera] PRIMARY KEY CLUSTERED 
(
	[MaMay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgayNghiLe]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgayNghiLe](
	[MaNgayNghiLe] [int] IDENTITY(1,1) NOT NULL,
	[NgayNghiLe] [date] NOT NULL,
	[MoTa] [nvarchar](150) NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_NgayNghiLe] PRIMARY KEY CLUSTERED 
(
	[MaNgayNghiLe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgayPhepNhanVien]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgayPhepNhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NULL,
	[SoNgayPhep] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NgayPhepNhanVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhatKy]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKy](
	[MaNhatKy] [int] NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[MaKhuonMat] [int] NOT NULL,
	[MaTheTu] [int] NOT NULL,
	[MaVanTay] [int] NOT NULL,
	[AnhKhuonMat] [nvarchar](200) NULL,
	[ThuocTinhKhuonMat] [varbinary](max) NULL,
	[DiemSoSanh] [float] NULL,
	[Tuoi] [int] NULL,
	[GioiTinh] [int] NULL,
	[ThoiGianDienRa] [datetime] NULL,
	[MaThietBi] [varchar](50) NOT NULL,
	[ThongBao] [nvarchar](250) NULL,
	[LoaiHoatDong] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_NhatKy] PRIMARY KEY CLUSTERED 
(
	[MaNhatKy] ASC,
	[MaNguoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyenNhanDang]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyenNhanDang](
	[MaPhanQuyenNhanDang] [int] IDENTITY(1,1) NOT NULL,
	[KhuVuc] [int] NULL,
	[PhongBan] [int] NULL,
	[ChucVu] [int] NULL,
	[Nguoi] [int] NULL,
	[MaThietBiNhanDang] [int] NULL,
 CONSTRAINT [PK_PhanQuyenNhanDang] PRIMARY KEY CLUSTERED 
(
	[MaPhanQuyenNhanDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [int] IDENTITY(1,1) NOT NULL,
	[PhongBan] [nvarchar](100) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuCap]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuCap](
	[MaPhuCap] [int] IDENTITY(1,1) NOT NULL,
	[PhuCap] [float] NULL,
 CONSTRAINT [PK_PhuCap] PRIMARY KEY CLUSTERED 
(
	[MaPhuCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SapXepLichTrinhTam]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SapXepLichTrinhTam](
	[MaLichTrinhTam] [int] IDENTITY(1,1) NOT NULL,
	[TuNgay] [date] NOT NULL,
	[DenNgay] [date] NOT NULL,
	[MaLichTrinh] [varchar](5) NULL,
 CONSTRAINT [PK_SapXepLichTrinhTam] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhTam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[MaThamSo] [int] IDENTITY(1,1) NOT NULL,
	[LoaiThamSo] [varchar](100) NOT NULL,
	[TenThamSo] [nvarchar](150) NOT NULL,
	[GiaTriThamSo] [nvarchar](150) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_ThamSo] PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheTu]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheTu](
	[MaTheTu] [int] NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[LoaiTheTu] [int] NULL,
	[ThuocTinhThe] [varbinary](max) NULL,
	[ThoiGianDangKy] [datetime] NOT NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_TheTu] PRIMARY KEY CLUSTERED 
(
	[MaTheTu] ASC,
	[MaNguoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TonGiao]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TonGiao](
	[MaTonGiao] [int] IDENTITY(1,1) NOT NULL,
	[TenTonGiao] [nvarchar](100) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_TonGiao] PRIMARY KEY CLUSTERED 
(
	[MaTonGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDoHocVan]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDoHocVan](
	[MaTrinhDoHocVan] [int] IDENTITY(1,1) NOT NULL,
	[TrinhDoHocVan] [nvarchar](100) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_TrinhDoHocVan] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDoHocVan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VanTay]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VanTay](
	[MaVanTay] [int] NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[NgonTay] [int] NULL,
	[ThuocTinhVanTay] [varbinary](max) NULL,
	[ThoiGianDangKy] [datetime] NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_FingerPrint] PRIMARY KEY CLUSTERED 
(
	[MaVanTay] ASC,
	[MaNguoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XepLoaiChamCong]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XepLoaiChamCong](
	[MaXepLoaiChamCong] [varchar](10) NOT NULL,
	[TenKyHieuChamCong] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_XepLoaiChamCong] PRIMARY KEY CLUSTERED 
(
	[MaXepLoaiChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0BDE11AA-D2DE-42ED-B9B6-E3CD759E6D64', N'QuanLy')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'29C3E5A0-61A7-4A19-96C2-127A20AB48E3', N'Admin')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'60D211B6-4C4F-4D4B-B4AD-1C0EDA3F8BB9', N'GiamSat')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'CFDA8F7E-0B5E-408F-981D-DBFF34191BFA', N'BaoCao')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'343c6d31-7e4a-4b7b-a62c-7d9765caf25a', N'29C3E5A0-61A7-4A19-96C2-127A20AB48E3')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FullName], [AnhDaiDien], [TinhId], [TenTinh], [QuanHuyenId], [TenQuanHuyen], [GioiTinh], [DiaChi], [UserType], [HieuLuc]) VALUES (N'343c6d31-7e4a-4b7b-a62c-7d9765caf25a', N'admin@remaxvietnam.vn', 0, N'AOm/rw/Wv4li3parNjf/FQFlGzWbSbDxSQzuP7bjBq0Ss/sM8cdehXq9yfuurvCQ4g==', N'83a1acc1-e823-441e-b3b4-7ad0f6aaa322', N'XXXXXXXXXX', 0, 0, NULL, 1, 0, N'admin@remaxvietnam.vn', N'admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 10, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'CD', N'Cúp điện', 1, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'CO', N'Nghỉ con ốm', 1, 0)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'CT', N'Nghỉ công tác', 1, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'F', N'Nghỉ phép nắm', 1, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'H', N'Nghỉ hội họp, học tập', 1, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'NL', N'Nghỉ lễ', 1, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'OM', N'Nghỉ ốm', 1, 0)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'P', N'Nghỉ phép', 1, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'R', N'Nghỉ việc riêng có lương', 1, 1)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'RO', N'Nghỉ việc riêng không lương', 1, 0)
INSERT [dbo].[CacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [TrangThai], [TinhCong]) VALUES (N'TS', N'Nghỉ thai sản', 1, 0)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'APR', N'Tháng 04', 4)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'AUG', N'Tháng 08', 8)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'DEC', N'Tháng 12', 12)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'FEB', N'Tháng 02', 2)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'JAN', N'Tháng 01', 1)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'JUL', N'Tháng 07', 7)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'JUN', N'Tháng 06', 6)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'MAR', N'Tháng 03', 3)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'MAY', N'Tháng 05', 5)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'NOV', N'Tháng 11', 11)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'OCT', N'Tháng 10', 10)
INSERT [dbo].[ChuKyNam] ([MaChuKyNam], [TenChuKyNam], [SapXep]) VALUES (N'SEP', N'Tháng 09', 9)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D01', N'Ngày 01', 1)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D02', N'Ngày 02', 2)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D03', N'Ngày 03', 3)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D04', N'Ngày 04', 4)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D05', N'Ngày 05', 5)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D06', N'Ngày 06', 6)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D07', N'Ngày 07', 7)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D08', N'Ngày 08', 8)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D09', N'Ngày 09', 9)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D10', N'Ngày 10', 10)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D11', N'Ngày 11', 11)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D12', N'Ngày 12', 12)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D13', N'Ngày 13', 13)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D14', N'Ngày 14', 14)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D15', N'Ngày 15', 15)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D16', N'Ngày 16', 16)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D17', N'Ngày 17', 17)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D18', N'Ngày 18', 18)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D19', N'Ngày 19', 19)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D20', N'Ngày 20', 20)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D21', N'Ngày 21', 21)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D22', N'Ngày 22', 22)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D23', N'Ngày 23', 23)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D24', N'Ngày 24', 24)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D25', N'Ngày 25', 25)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D26', N'Ngày 26', 26)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D27', N'Ngày 27', 27)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D28', N'Ngày 28', 28)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D29', N'Ngày 29', 29)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D30', N'Ngày 30', 30)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'D31', N'Ngày 31', 31)
INSERT [dbo].[ChuKyThang] ([MaChuKyThang], [TenChuKyThang], [SapXep]) VALUES (N'HOL', N'Ngày lễ', 32)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'FRI', N'Thứ sáu', 5)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'HOL', N'Ngày lễ', 8)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'MON', N'Thứ hai', 1)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'SAT', N'Thứ bẩy', 6)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'SUN', N'Chủ nhật', 7)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'THU', N'Thứ năm', 4)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'TUE', N'Thứ ba', 2)
INSERT [dbo].[ChuKyTuan] ([MaChuKyTuan], [TenChuKyTuan], [SapXep]) VALUES (N'WED', N'Thứ tư', 3)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC1', N'Không xét vắng cho ngày Thứ Bẩy khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC2', N'Không xét vắng cho ngày Chủ Nhật khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC3', N'Không xét vắng cho ngày Ngày Lễ khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC4', N'Ngày Lễ được tính 1 công cho trường hợp không đi làm ', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC5', N'Ngày là ngày của giờ ra', 0)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC6', N'Khi không xếp ca vào các ngày trong tuần hoặc ngày lễ nếu có đi làm tính tăng ca mức 1', 1)
INSERT [dbo].[LoaiChamCong] ([MaLoaiChamCong], [TenLoaiChamCong]) VALUES (N'IN', N'Check in')
INSERT [dbo].[LoaiChamCong] ([MaLoaiChamCong], [TenLoaiChamCong]) VALUES (N'OUT', N'Check out')
INSERT [dbo].[LoaiChuKy] ([MaLoaiChuKy], [TenLoaiChuKy]) VALUES (N'MD', N'Chu kỳ tháng')
INSERT [dbo].[LoaiChuKy] ([MaLoaiChuKy], [TenLoaiChuKy]) VALUES (N'WD', N'Chu kỳ tuần')
INSERT [dbo].[LoaiChuKy] ([MaLoaiChuKy], [TenLoaiChuKy]) VALUES (N'YD', N'Chu kỳ năm')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'+', N'Ký hiệu tăng ca')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'Kr', N'Ký hiệu thiếu giờ ra')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'Kv', N'Ký hiệu thiếu giờ vào')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'Off', N'Ký hiệu không xếp ca')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'Qd', N'Ký hiệu đúng giờ và làm qua đêm')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'Sm', N'Ký hiệu về sớm')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'Tr', N'Ký hiệu đi trễ')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'V', N'Ký hiệu vắng')
INSERT [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong], [TenKyHieuChamCong]) VALUES (N'X', N'Ký hiệu đúng giờ')
ALTER TABLE [dbo].[AspNetUsers] ADD  CONSTRAINT [DF_AspNetUsers_PhoneNumber]  DEFAULT (newid()) FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  CONSTRAINT [DF__AspNetUse__UserT__4BF72343]  DEFAULT ((1)) FOR [UserType]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  CONSTRAINT [DF_AspNetUsers_HieuLuc]  DEFAULT ((1)) FOR [HieuLuc]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChamCong_CacLoaiVang] FOREIGN KEY([MaLoaiVang])
REFERENCES [dbo].[CacLoaiVang] ([MaLoaiVang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_dbo.ChamCong_CacLoaiVang]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChamCong_CaLamViec] FOREIGN KEY([MaCaLamViec])
REFERENCES [dbo].[CaLamViec] ([MaCaLamViec])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_dbo.ChamCong_CaLamViec]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChamCong_Nguoi] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_dbo.ChamCong_Nguoi]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChamCong_XepLoaiChamCong] FOREIGN KEY([MaXepLoaiChamCong])
REFERENCES [dbo].[XepLoaiChamCong] ([MaXepLoaiChamCong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_dbo.ChamCong_XepLoaiChamCong]
GO
ALTER TABLE [dbo].[ChamCongChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChamCongChiTiet_ChamCong] FOREIGN KEY([MaChamCong])
REFERENCES [dbo].[ChamCong] ([MaChamCong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChamCongChiTiet] CHECK CONSTRAINT [FK_dbo.ChamCongChiTiet_ChamCong]
GO
ALTER TABLE [dbo].[ChamCongChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChamCongChiTiet_LoaiChamCong] FOREIGN KEY([MaLoaiChamCong])
REFERENCES [dbo].[LoaiChamCong] ([MaLoaiChamCong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChamCongChiTiet] CHECK CONSTRAINT [FK_dbo.ChamCongChiTiet_LoaiChamCong]
GO
ALTER TABLE [dbo].[DangKyNghiPhep]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DangKyNghiPhep_LoaiNghiPhep] FOREIGN KEY([MaLoaiNghiPhep])
REFERENCES [dbo].[LoaiNghiPhep] ([MaLoaiNghiPhep])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKyNghiPhep] CHECK CONSTRAINT [FK_dbo.DangKyNghiPhep_LoaiNghiPhep]
GO
ALTER TABLE [dbo].[DangKyNghiPhep]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DangKyNghiPhep_Nguoi] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKyNghiPhep] CHECK CONSTRAINT [FK_dbo.DangKyNghiPhep_Nguoi]
GO
ALTER TABLE [dbo].[DangKyTangCa]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DangKyTangCa_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKyTangCa] CHECK CONSTRAINT [FK_dbo.DangKyTangCa_MaNhanVien]
GO
ALTER TABLE [dbo].[KhuonMat]  WITH CHECK ADD  CONSTRAINT [FK_dbo.KhuonMat_MaNguoi] FOREIGN KEY([MaNguoi])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhuonMat] CHECK CONSTRAINT [FK_dbo.KhuonMat_MaNguoi]
GO
ALTER TABLE [dbo].[LichTrinh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinh_LoaiChuKy] FOREIGN KEY([MaLoaiChuKy])
REFERENCES [dbo].[LoaiChuKy] ([MaLoaiChuKy])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinh] CHECK CONSTRAINT [FK_dbo.LichTrinh_LoaiChuKy]
GO
ALTER TABLE [dbo].[LichTrinhNam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhNam_CaLamViec] FOREIGN KEY([MaCaLamViec])
REFERENCES [dbo].[CaLamViec] ([MaCaLamViec])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhNam] CHECK CONSTRAINT [FK_dbo.LichTrinhNam_CaLamViec]
GO
ALTER TABLE [dbo].[LichTrinhNam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhNam_ChuKyNam] FOREIGN KEY([MaChuKyNam])
REFERENCES [dbo].[ChuKyNam] ([MaChuKyNam])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhNam] CHECK CONSTRAINT [FK_dbo.LichTrinhNam_ChuKyNam]
GO
ALTER TABLE [dbo].[LichTrinhThang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhThang_CaLamViec] FOREIGN KEY([MaCaLamViec])
REFERENCES [dbo].[CaLamViec] ([MaCaLamViec])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhThang] CHECK CONSTRAINT [FK_dbo.LichTrinhThang_CaLamViec]
GO
ALTER TABLE [dbo].[LichTrinhThang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhThang_ChuKyThang] FOREIGN KEY([MaChuKyThang])
REFERENCES [dbo].[ChuKyThang] ([MaChuKyThang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhThang] CHECK CONSTRAINT [FK_dbo.LichTrinhThang_ChuKyThang]
GO
ALTER TABLE [dbo].[LichTrinhTuan]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhTuan_CaLamViec] FOREIGN KEY([MaCaLamViec])
REFERENCES [dbo].[CaLamViec] ([MaCaLamViec])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhTuan] CHECK CONSTRAINT [FK_dbo.LichTrinhTuan_CaLamViec]
GO
ALTER TABLE [dbo].[LichTrinhTuan]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhTuan_ChuKyTuan] FOREIGN KEY([MaChuKyTuan])
REFERENCES [dbo].[ChuKyTuan] ([MaChuKyTuan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhTuan] CHECK CONSTRAINT [FK_dbo.LichTrinhTuan_ChuKyTuan]
GO
ALTER TABLE [dbo].[MapLichTrinhNangCao]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MapLichTrinhNangCao_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MapLichTrinhNangCao] CHECK CONSTRAINT [FK_dbo.MapLichTrinhNangCao_LichTrinh]
GO
ALTER TABLE [dbo].[MapLichTrinhNangCao]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MapLichTrinhNangCao_LichTrinhNangCao] FOREIGN KEY([MaLichTrinhNangCao])
REFERENCES [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MapLichTrinhNangCao] CHECK CONSTRAINT [FK_dbo.MapLichTrinhNangCao_LichTrinhNangCao]
GO
ALTER TABLE [dbo].[Nguoi]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Nguoi_ChucVu] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nguoi] CHECK CONSTRAINT [FK_dbo.Nguoi_ChucVu]
GO
ALTER TABLE [dbo].[Nguoi]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Nguoi_PhongBan] FOREIGN KEY([PhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nguoi] CHECK CONSTRAINT [FK_dbo.Nguoi_PhongBan]
GO
ALTER TABLE [dbo].[NhatKy]  WITH CHECK ADD  CONSTRAINT [FK_dbo.NhatKy_MaNguoi] FOREIGN KEY([MaNguoi])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhatKy] CHECK CONSTRAINT [FK_dbo.NhatKy_MaNguoi]
GO
ALTER TABLE [dbo].[SapXepLichTrinh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SapXepLichTrinh_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SapXepLichTrinh] CHECK CONSTRAINT [FK_dbo.SapXepLichTrinh_LichTrinh]
GO
ALTER TABLE [dbo].[SapXepLichTrinh]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SapXepLichTrinh_Nguoi] FOREIGN KEY([MaNguoi])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SapXepLichTrinh] CHECK CONSTRAINT [FK_dbo.SapXepLichTrinh_Nguoi]
GO
ALTER TABLE [dbo].[SapXepLichTrinhTam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SapXepLichTrinhTam_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SapXepLichTrinhTam] CHECK CONSTRAINT [FK_dbo.SapXepLichTrinhTam_LichTrinh]
GO
ALTER TABLE [dbo].[TheTu]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TheTu_MaNguoi] FOREIGN KEY([MaNguoi])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TheTu] CHECK CONSTRAINT [FK_dbo.TheTu_MaNguoi]
GO
ALTER TABLE [dbo].[VanTay]  WITH CHECK ADD  CONSTRAINT [FK_dbo.VanTay_MaNguoi] FOREIGN KEY([MaNguoi])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VanTay] CHECK CONSTRAINT [FK_dbo.VanTay_MaNguoi]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCaLamViec]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[spDeleteCaLamViec]
@MaCaLamViec varchar(5)
as
begin
delete from CaLamViec
where MaCaLamViec = @MaCaLamViec;
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllCaLamViec]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[spGetAllCaLamViec]
as
Select * 
From CaLamViec
GO
/****** Object:  StoredProcedure [dbo].[spGetCaLamViec]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[spGetCaLamViec]
@MaCaLamViec varchar(5)
as
begin
Select *
From CaLamViec
Where MaCaLamViec = @MaCaLamViec
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertCaLamViec]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[spInsertCaLamViec]
@MaCaLamViec varchar(5),
@TenCaLamViec nvarchar(50), 
@GioBatDauCa time(7), 
@GioKetThucCa time(7), 
@GioBatDauGiaiLao time(7), 
@GioKetThucGiaiLao time(7),
@TongGio int,  
@DiemCong int, 
@GioVaoSomNhatDuocTinhCa time(7), 
@GioVaoMuonNhatDuocTinhCa time(7), 
@GioRaMuonNhatDuocTinhCa time(7), 
@GioRaSomNhatDuocTinhCa time(7),
@KhongCoGioRa int,
@KhongCoGioVao int, 
@TruGioDiTre bit, 
@ThoiGianDiTreChoPhep int, 
@TruGioVeSom bit, 
@ThoiGianVeSomChoPhep int,

@SDMucTangCaHienTai bit,
@MucTangCaHienTai int,
@SDMucTangCaCuoiTuan bit,
@MucTangCaCuoiTuan int,
@SDMucTangCaNgayLe bit,
@MucTangCaNgayLe int,
@SDTangCaTruocGLV bit,
@TangCaTruocGLV int,
@SDTangCaSauGLV bit,
@TangCaSauGLV int,
@SDTongGLVTinhTangCa bit,
@TongGLVTinhTangCa int,

@GioiHanTCMucMot int,
@GioiHanTCMucHai int,
@SDMucTangCaCuaTangCaCuoiTuan bit, 
@MucTangCaCuaTangCaCuoiTuan int, 
@SDMucTangCaCuaTangCaNgayLe bit, 
@MucTangCaCuaTangCaNgayLe int, 
@GioiHanTCTruocGLV int,
@GioiHanTCSauGLV int, 
@CaQuaDem bit, 
@TachGioCaDemTu time(7), 
@TachGioCaDemDen time(7)
as
begin
insert into CaLamViec(
MaCaLamViec,
TenCaLamViec, 
GioBatDauCa, 
GioKetThucCa, 
GioBatDauGiaiLao, 
GioKetThucGiaiLao , 
TongGio, 
DiemCong, 
GioVaoSomNhatDuocTinhCa, 
GioVaoMuonNhatDuocTinhCa, 
GioRaMuonNhatDuocTinhCa, 
GioRaSomNhatDuocTinhCa, 
KhongCoGioRa, 
KhongCoGioVao, 
TruGioDiTre, 
ThoiGianDiTreChoPhep, 
TruGioVeSom, 
ThoiGianVeSomChoPhep, 

SDMucTangCaHienTai,
MucTangCaHienTai,
SDMucTangCaCuoiTuan,
MucTangCaCuoiTuan,
SDMucTangCaNgayLe,
MucTangCaNgayLe,
SDTangCaTruocGLV,
TangCaTruocGLV,
SDTangCaSauGLV,
TangCaSauGLV,
SDTongGLVTinhTangCa,
TongGLVTinhTangCa,

GioiHanTCMucMot, 
GioiHanTCMucHai,
SDMucTangCaCuaTangCaCuoiTuan, 
MucTangCaCuaTangCaCuoiTuan, 
SDMucTangCaCuaTangCaNgayLe, 
MucTangCaCuaTangCaNgayLe, 
GioiHanTCTruocGLV,
GioiHanTCSauGLV, 
CaQuaDem, 
TachGioCaDemTu, 
TachGioCaDemDen)
values (
@MaCaLamViec,
@TenCaLamViec, 
@GioBatDauCa, 
@GioKetThucCa, 
@GioBatDauGiaiLao, 
@GioKetThucGiaiLao, 
@TongGio, 
@DiemCong, 
@GioVaoSomNhatDuocTinhCa,
@GioVaoMuonNhatDuocTinhCa,
@GioRaMuonNhatDuocTinhCa, 
@GioRaSomNhatDuocTinhCa,
@KhongCoGioRa,
@KhongCoGioVao,
@TruGioDiTre,
@ThoiGianDiTreChoPhep, 
@TruGioVeSom, 
@ThoiGianVeSomChoPhep,

@SDMucTangCaHienTai,
@MucTangCaHienTai,
@SDMucTangCaCuoiTuan,
@MucTangCaCuoiTuan,
@SDMucTangCaNgayLe,
@MucTangCaNgayLe,
@SDTangCaTruocGLV,
@TangCaTruocGLV,
@SDTangCaSauGLV,
@TangCaSauGLV,
@SDTongGLVTinhTangCa,
@TongGLVTinhTangCa,

@GioiHanTCMucMot,
@GioiHanTCMucHai,
@SDMucTangCaCuaTangCaCuoiTuan, 
@MucTangCaCuaTangCaCuoiTuan, 
@SDMucTangCaCuaTangCaNgayLe, 
@MucTangCaCuaTangCaNgayLe, 
@GioiHanTCTruocGLV,
@GioiHanTCSauGLV, 
@CaQuaDem, 
@TachGioCaDemTu,
@TachGioCaDemDen);
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCaLamViec]    Script Date: 02/04/2020 6:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[spUpdateCaLamViec]
@MaCaLamViecChon varchar(5),
@MaCaLamViec varchar(5),
@TenCaLamViec nvarchar(50), 
@GioBatDauCa time(7), 
@GioKetThucCa time(7), 
@GioBatDauGiaiLao time(7), 
@GioKetThucGiaiLao time(7),
@TongGio int,  
@DiemCong int, 
@GioVaoSomNhatDuocTinhCa time(7), 
@GioVaoMuonNhatDuocTinhCa time(7), 
@GioRaMuonNhatDuocTinhCa time(7), 
@GioRaSomNhatDuocTinhCa time(7), 
@KhongCoGioRa int, 
@KhongCoGioVao int, 
@TruGioDiTre bit, 
@ThoiGianDiTreChoPhep int, 
@TruGioVeSom bit, 
@ThoiGianVeSomChoPhep int,

@SDMucTangCaHienTai bit,
@MucTangCaHienTai int,
@SDMucTangCaCuoiTuan bit,
@MucTangCaCuoiTuan int,
@SDMucTangCaNgayLe bit,
@MucTangCaNgayLe int,
@SDTangCaTruocGLV bit,
@TangCaTruocGLV int,
@SDTangCaSauGLV bit,
@TangCaSauGLV int,
@SDTongGLVTinhTangCa bit,
@TongGLVTinhTangCa int,


@GioiHanTCMucMot int,
@GioiHanTCMucHai int,
@SDMucTangCaCuaTangCaCuoiTuan bit, 
@MucTangCaCuaTangCaCuoiTuan int,
@SDMucTangCaCuaTangCaNgayLe bit, 
@MucTangCaCuaTangCaNgayLe int, 
@GioiHanTCTruocGLV int,
@GioiHanTCSauGLV int, 
@CaQuaDem bit, 
@TachGioCaDemTu time(7), 
@TachGioCaDemDen time(7)
as
begin
update CaLamViec
set 
MaCaLamViec = @MaCaLamViec,
TenCaLamViec = @TenCaLamViec, 
GioBatDauCa=@GioBatDauCa, 
GioKetThucCa=@GioKetThucCa, 
GioBatDauGiaiLao=@GioBatDauGiaiLao, 
GioKetThucGiaiLao= @GioKetThucGiaiLao, 
TongGio=@TongGio, 
DiemCong=@DiemCong, 
GioVaoSomNhatDuocTinhCa=@GioVaoSomNhatDuocTinhCa, 
GioVaoMuonNhatDuocTinhCa=@GioVaoMuonNhatDuocTinhCa, 
GioRaMuonNhatDuocTinhCa=@GioRaMuonNhatDuocTinhCa, 
GioRaSomNhatDuocTinhCa=@GioRaSomNhatDuocTinhCa,
KhongCoGioRa=@KhongCoGioRa, 
KhongCoGioVao= @KhongCoGioVao,
TruGioDiTre=@TruGioDiTre, 
ThoiGianDiTreChoPhep=@ThoiGianDiTreChoPhep, 
TruGioVeSom=@TruGioVeSom, 
ThoiGianVeSomChoPhep=@ThoiGianVeSomChoPhep, 


SDMucTangCaHienTai = @SDMucTangCaHienTai,
MucTangCaHienTai = @MucTangCaHienTai,
SDMucTangCaCuoiTuan = @SDMucTangCaCuoiTuan,
MucTangCaCuoiTuan = @MucTangCaCuoiTuan,
SDMucTangCaNgayLe = @SDMucTangCaNgayLe,
MucTangCaNgayLe = @MucTangCaNgayLe,
SDTangCaTruocGLV = @SDTangCaTruocGLV,
TangCaTruocGLV = @TangCaTruocGLV,
SDTangCaSauGLV = @SDTangCaSauGLV,
TangCaSauGLV = @TangCaSauGLV,
SDTongGLVTinhTangCa = @SDTongGLVTinhTangCa,
TongGLVTinhTangCa = @TongGLVTinhTangCa,



GioiHanTCMucMot=@GioiHanTCMucMot, 
GioiHanTCMucHai=@GioiHanTCMucHai,
SDMucTangCaCuaTangCaCuoiTuan=@SDMucTangCaCuaTangCaCuoiTuan, 
MucTangCaCuaTangCaCuoiTuan=@MucTangCaCuaTangCaCuoiTuan, 
SDMucTangCaCuaTangCaNgayLe=@SDMucTangCaCuaTangCaNgayLe, 
MucTangCaCuaTangCaNgayLe=@MucTangCaCuaTangCaNgayLe, 
GioiHanTCTruocGLV=@GioiHanTCTruocGLV, 
GioiHanTCSauGLV=@GioiHanTCSauGLV, 
CaQuaDem=@CaQuaDem, 
TachGioCaDemTu=@TachGioCaDemTu, 
TachGioCaDemDen=@TachGioCaDemDen
where MaCaLamViec = @MaCaLamViecChon;
end
GO
USE [master]
GO
ALTER DATABASE [ATINChamCong] SET  READ_WRITE 
GO
