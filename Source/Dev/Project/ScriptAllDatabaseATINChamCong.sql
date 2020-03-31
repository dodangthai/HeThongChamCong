USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[SapXepLichTrinh]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[Nguoi]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[LichTrinh]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  View [dbo].[ViewSapXepLichTrinh]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[BaoCao]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[BaoCaoChiTiet]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[CaLamViec]    Script Date: 31/03/2020 4:51:55 PM ******/
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
 CONSTRAINT [PK_CaLamViec] PRIMARY KEY CLUSTERED 
(
	[MaCaLamViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 31/03/2020 4:51:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaChamCong] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaDinhDanh] [int] NULL,
	[NgayChamCong] [date] NOT NULL,
	[MaCaLamViec] [int] NOT NULL,
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
	[TongSoGioLamViec] [float] NOT NULL,
	[TongSoCongLamViec] [float] NOT NULL,
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED 
(
	[MaChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCongChiTiet]    Script Date: 31/03/2020 4:51:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCongChiTiet](
	[MaChamCongChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaChamCong] [int] NOT NULL,
	[NgayChamCong] [date] NOT NULL,
	[GioChamCong] [datetime] NOT NULL,
	[LoaiChamCong] [int] NOT NULL,
	[NguonThucHien] [int] NOT NULL,
	[MaThietBi] [int] NULL,
 CONSTRAINT [PK_ChamCongChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaChamCongChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[ChuKyNam]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[ChuKyThang]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[ChuKyTuan]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[CongTyKhuVuc]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[DangKyNghiPhep]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[DangKyTangCa]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[DanToc]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[HopDongLaoDong]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[KhaiBaoThoiGian]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[KhuonMat]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[KyHieuCacLoaiVang]    Script Date: 31/03/2020 4:51:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyHieuCacLoaiVang](
	[MaLoaiVang] [varchar](10) NOT NULL,
	[TenLoaiVang] [nvarchar](100) NOT NULL,
	[KyHieu] [varchar](20) NOT NULL,
	[TrangThai] [bit] NULL,
	[TinhCong] [bit] NULL,
 CONSTRAINT [PK_KyHieuCacLoaiVang] PRIMARY KEY CLUSTERED 
(
	[MaLoaiVang] ASC,
	[KyHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyHieuChamCong]    Script Date: 31/03/2020 4:51:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyHieuChamCong](
	[MaKyHieuChamCong] [varchar](10) NOT NULL,
	[TenKyHieuChamCong] [nvarchar](100) NOT NULL,
	[KyHieu] [varchar](20) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_KyHieuChamCong] PRIMARY KEY CLUSTERED 
(
	[MaKyHieuChamCong] ASC,
	[KyHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhNam]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[LichTrinhNangCao]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[LichTrinhThang]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[LichTrinhTuan]    Script Date: 31/03/2020 4:51:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhTuan](
	[MaLichTrinhTuan] [int] IDENTITY(1,1) NOT NULL,
	[MaLichTrinh] [varchar](5) NOT NULL,
	[MaChuKyTuan] [varchar](5) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
 CONSTRAINT [PK_LichTrinhTuan] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhTuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiChuKy]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[LoaiNghiPhep]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[LoaiThamSo]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[MayNhanDang]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[NgayNghiLe]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[NgayPhepNhanVien]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[NhatKy]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[PhanQuyenNhanDang]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[PhongBan]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[PhuCap]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[SapXepLichTrinhTam]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[ThamSo]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[TheTu]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[TonGiao]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[TrinhDoHocVan]    Script Date: 31/03/2020 4:51:55 PM ******/
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
/****** Object:  Table [dbo].[VanTay]    Script Date: 31/03/2020 4:51:55 PM ******/
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
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0BDE11AA-D2DE-42ED-B9B6-E3CD759E6D64', N'QuanLy')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'29C3E5A0-61A7-4A19-96C2-127A20AB48E3', N'Admin')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'60D211B6-4C4F-4D4B-B4AD-1C0EDA3F8BB9', N'GiamSat')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'CFDA8F7E-0B5E-408F-981D-DBFF34191BFA', N'BaoCao')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'343c6d31-7e4a-4b7b-a62c-7d9765caf25a', N'29C3E5A0-61A7-4A19-96C2-127A20AB48E3')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FullName], [AnhDaiDien], [TinhId], [TenTinh], [QuanHuyenId], [TenQuanHuyen], [GioiTinh], [DiaChi], [UserType], [HieuLuc]) VALUES (N'343c6d31-7e4a-4b7b-a62c-7d9765caf25a', N'admin@remaxvietnam.vn', 0, N'AOm/rw/Wv4li3parNjf/FQFlGzWbSbDxSQzuP7bjBq0Ss/sM8cdehXq9yfuurvCQ4g==', N'83a1acc1-e823-441e-b3b4-7ad0f6aaa322', N'XXXXXXXXXX', 0, 0, NULL, 1, 0, N'admin@remaxvietnam.vn', N'admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 10, 1)
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
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V01', N'Nghỉ ốm', N'OM', 1, 0)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V02', N'Nghỉ thai sản', N'TS', 1, 0)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V03', N'Nghỉ việc riêng có lương', N'R', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V04', N'Nghỉ việc riêng không lương', N'RO', 1, 0)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V05', N'Nghỉ phép', N'P', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V06', N'Nghỉ phép nắm', N'F', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V07', N'Nghỉ con ốm', N'CO', 1, 0)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V08', N'Cúp điện', N'CD', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V09', N'Nghỉ hội họp, học tập', N'H', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V10', N'Nghỉ công tác', N'CT', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaLoaiVang], [TenLoaiVang], [KyHieu], [TrangThai], [TinhCong]) VALUES (N'V11', N'Nghỉ lễ', N'CT', 1, 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C01', N'Ký hiệu đi trễ', N'Tr', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C02', N'Ký hiệu về sớm', N'Sm', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C03', N'Ký hiệu đúng giờ', N'X', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C04', N'Ký hiệu tăng ca', N'+', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C05', N'Ký hiệu thiếu giờ ra', N'Kr', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C06', N'Ký hiệu thiếu giờ vào', N'Kv', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C07', N'Ký hiệu vắng', N'V', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C08', N'Ký hiệu đúng giờ và làm qua đêm', N'Qd', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieuChamCong], [TenKyHieuChamCong], [KyHieu], [TrangThai]) VALUES (N'C09', N'Ký hiệu không xếp ca', N'Off', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC1', N'Không xét vắng cho ngày Thứ Bẩy khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC2', N'Không xét vắng cho ngày Chủ Nhật khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC3', N'Không xét vắng cho ngày Ngày Lễ khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC4', N'Ngày Lễ được tính 1 công cho trường hợp không đi làm ', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC5', N'Ngày là ngày của giờ ra', 0)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC6', N'Khi không xếp ca vào các ngày trong tuần hoặc ngày lễ nếu có đi làm tính tăng ca mức 1', 1)
INSERT [dbo].[LoaiChuKy] ([MaLoaiChuKy], [TenLoaiChuKy]) VALUES (N'MD', N'Chu kỳ tháng')
INSERT [dbo].[LoaiChuKy] ([MaLoaiChuKy], [TenLoaiChuKy]) VALUES (N'WD', N'Chu kỳ tuần')
INSERT [dbo].[LoaiChuKy] ([MaLoaiChuKy], [TenLoaiChuKy]) VALUES (N'YD', N'Chu kỳ năm')
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
ALTER TABLE [dbo].[DangKyNghiPhep]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DangKyNghiPhep_MaLoaiNghiPhep] FOREIGN KEY([MaLoaiNghiPhep])
REFERENCES [dbo].[LoaiNghiPhep] ([MaLoaiNghiPhep])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKyNghiPhep] CHECK CONSTRAINT [FK_dbo.DangKyNghiPhep_MaLoaiNghiPhep]
GO
ALTER TABLE [dbo].[DangKyNghiPhep]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DangKyNghiPhep_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKyNghiPhep] CHECK CONSTRAINT [FK_dbo.DangKyNghiPhep_MaNhanVien]
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
ALTER TABLE [dbo].[LichTrinhTuan]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhTuan_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhTuan] CHECK CONSTRAINT [FK_dbo.LichTrinhTuan_LichTrinh]
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
