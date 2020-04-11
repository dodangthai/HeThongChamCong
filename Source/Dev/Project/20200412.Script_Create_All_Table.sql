USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[Nguoi]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoi](
	[MaNguoi] [int] IDENTITY(1,1) NOT NULL,
	[MaDinhDanh] [varchar](50) NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[MaPhongBan] [int] NULL,
	[MaChucVu] [int] NULL,
	[MaKhuVuc] [int] NULL,
	[NgaySinh] [date] NULL,
	[MaGioiTinh] [int] NOT NULL,
	[SoDienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[AnhDaiDien] [varbinary](max) NULL,
	[MaTrinhDo] [int] NULL,
	[SoTheCanCuoc] [varchar](50) NULL,
	[NgayCapTCC] [date] NULL,
	[NoiCapTCC] [nvarchar](150) NULL,
	[MaDanToc] [int] NULL,
	[MaTonGiao] [int] NULL,
	[MaQuocTich] [int] NULL,
	[TinhTrangHonNhan] [int] NULL,
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
	[TrangThaiHoatDong] [int] NOT NULL,
 CONSTRAINT [PK_Nguoi] PRIMARY KEY CLUSTERED 
(
	[MaNguoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SapXepLichTrinh]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SapXepLichTrinh](
	[MaSapXep] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[MaChamCong] [int] NOT NULL,
	[MaLichTrinh] [varchar](5) NULL,
 CONSTRAINT [PK_SapXepLichTrinh] PRIMARY KEY CLUSTERED 
(
	[MaSapXep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  View [dbo].[ViewSapXepLichTrinh]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   VIEW [dbo].[ViewSapXepLichTrinh] as
SELECT N.MaNguoi, N.HoTen, C.MaChamCong, SX.MaLichTrinh, SX.MaSapXep
FROM 
(Nguoi as N
left join ChamCong as C On  N.MaNguoi = c.MaNhanVien)
left join SapXepLichTrinh as SX on N.MaNguoi = SX.MaNguoi


GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[CacLoaiVang]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[CaLamViec]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[CauHinhRabbitMQ]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHinhRabbitMQ](
	[DiaChiIp] [varchar](30) NOT NULL,
	[Port] [varchar](5) NOT NULL,
	[TenDangNhap] [varchar](10) NOT NULL,
	[MatKhauDangNhap] [varchar](10) NOT NULL,
	[ThongBaoLoi] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCongChiTiet]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongTyKhuVuc]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[DangKyNghiPhep]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKyNghiPhep](
	[MaDangKyNghiPhep] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaDinhDanh] [varchar](50) NULL,
	[MaLoaiNghiPhep] [int] NOT NULL,
	[NgayDangKy] [date] NOT NULL,
	[LyDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangKyNghiPhep] PRIMARY KEY CLUSTERED 
(
	[MaDangKyNghiPhep] ASC,
	[MaNhanVien] ASC,
	[MaLoaiNghiPhep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangKyTangCa]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKyTangCa](
	[MaDangKyTangCa] [int] IDENTITY(1,1) NOT NULL,
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
	[MaDangKyTangCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanToc]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanToc](
	[MaDanToc] [int] IDENTITY(1,1) NOT NULL,
	[TenDanToc] [nvarchar](50) NULL,
 CONSTRAINT [PK_DanToc] PRIMARY KEY CLUSTERED 
(
	[MaDanToc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioiTinh]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioiTinh](
	[MaGioiTinh] [int] IDENTITY(1,1) NOT NULL,
	[TenGioiTinh] [nvarchar](10) NULL,
 CONSTRAINT [PK_GioiTinh] PRIMARY KEY CLUSTERED 
(
	[MaGioiTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuonMat]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuonMat](
	[MaKhuonMat] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[AnhKhuonMat] [varbinary](max) NULL,
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
/****** Object:  Table [dbo].[KyHieuCacLoaiVang]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyHieuCacLoaiVang](
	[MaKyHieu] [varchar](5) NOT NULL,
	[TenKyHieu] [varchar](5) NOT NULL,
	[MoTa] [nvarchar](255) NULL,
	[SuDung] [bit] NOT NULL,
	[TinhCong] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKyHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyHieuChamCong]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyHieuChamCong](
	[MaKyHieu] [int] IDENTITY(1,1) NOT NULL,
	[TenKyHieu] [varchar](5) NOT NULL,
	[MoTa] [nvarchar](255) NULL,
	[SuDung] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKyHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuSuaDuLieuChamCong]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[LichTrinh]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinh](
	[MaLichTrinh] [varchar](5) NOT NULL,
	[TenLichTrinh] [nvarchar](30) NOT NULL,
	[LoaiChuKy] [varchar](5) NOT NULL,
 CONSTRAINT [PK_LichTrinh] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhNam]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhNam](
	[MaLichTrinhNam] [int] IDENTITY(1,1) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
	[MaLichTrinh] [varchar](5) NOT NULL,
	[Date] [int] NOT NULL,
	[Month] [int] NOT NULL,
 CONSTRAINT [PK_LichTrinhNam] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhNam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhNangCao]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[LichTrinhThang]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhThang](
	[MaLichTrinhThang] [int] IDENTITY(1,1) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
	[MaLichTrinh] [varchar](5) NOT NULL,
	[Date] [int] NOT NULL,
 CONSTRAINT [PK_LichTrinhThang] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinhTuan]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhTuan](
	[MaLichTrinhTuan] [int] IDENTITY(1,1) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
	[MaLichTrinh] [varchar](5) NOT NULL,
	[DateInWeek] [int] NOT NULL,
 CONSTRAINT [PK_LichTrinhTuan] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhTuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiChamCong]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[LoaiNghiPhep]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[MapLichTrinhNangCao]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MapLichTrinhNangCao](
	[MaLichTrinh] [varchar](5) NOT NULL,
	[MaLichTrinhNangCao] [varchar](5) NOT NULL,
	[EmptyColumn] [varchar](1) NULL,
 CONSTRAINT [PK_MapLichTrinhNangCao] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinh] ASC,
	[MaLichTrinhNangCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayNhanDang]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayNhanDang](
	[MaMay] [int] NOT NULL,
	[TenMay] [nvarchar](150) NOT NULL,
	[SoSerial] [nvarchar](100) NOT NULL,
	[DiaChiMac] [nvarchar](50) NULL,
	[TongBoNho] [float] NULL,
	[BoNhoTrong] [float] NULL,
	[SoLuongKhuonMat] [int] NULL,
	[SoLuongTheTu] [int] NULL,
	[SoLuongVanTay] [int] NULL,
	[NgayKichHoat] [datetime] NULL,
	[ThoiGianCapNhat] [datetime] NULL,
	[ChuKyDongBo] [int] NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhauDangNhap] [varchar](50) NULL,
	[MaKichHoat] [varchar](150) NULL,
	[KichHoatOnline] [bit] NULL,
	[TrangThaiKichHoat] [bit] NULL,
	[TrangThaiKetNoi] [bit] NULL,
 CONSTRAINT [PK_Camera] PRIMARY KEY CLUSTERED 
(
	[MaMay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgayNghiLe]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgayNghiLe](
	[MaNgayNghiLe] [int] IDENTITY(1,1) NOT NULL,
	[TenNgayNghiLe] [nvarchar](100) NOT NULL,
	[NgayLe] [date] NOT NULL,
	[MoTa] [nvarchar](250) NULL,
 CONSTRAINT [PK_NgayNghiLe] PRIMARY KEY CLUSTERED 
(
	[MaNgayNghiLe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgayPhepNhanVien]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[NhatKy]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKy](
	[MaNhatKy] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[MaKhuonMat] [int] NOT NULL,
	[MaTheTu] [int] NOT NULL,
	[MaVanTay] [int] NOT NULL,
	[DuongDanAnhKhuonMat] [nvarchar](200) NULL,
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
/****** Object:  Table [dbo].[PhanQuyenNhanDang]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[PhongBan]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [int] IDENTITY(1,1) NOT NULL,
	[TenPhongBan] [nvarchar](100) NOT NULL,
	[Cha] [int] NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuocTich]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuocTich](
	[MaQuocTich] [int] IDENTITY(1,1) NOT NULL,
	[TenQuocTich] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuocTich] PRIMARY KEY CLUSTERED 
(
	[MaQuocTich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SapXepLichTrinhTam]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SapXepLichTrinhTam](
	[MaLichTrinhTam] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoi] [int] NOT NULL,
	[TuNgay] [date] NOT NULL,
	[DenNgay] [date] NOT NULL,
	[MaLichTrinh] [varchar](5) NULL,
 CONSTRAINT [PK_SapXepLichTrinhTam] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhTam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheTu]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheTu](
	[MaTheTu] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[TonGiao]    Script Date: 12/04/2020 3:39:54 AM ******/
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
/****** Object:  Table [dbo].[TrangThai]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenTrangThai] [nvarchar](30) NULL,
	[GiaTri] [int] NOT NULL,
	[TenNhom] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TrangThai] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[GiaTri] ASC,
	[TenNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDoHocVan]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDoHocVan](
	[MaTrinhDoHocVan] [int] IDENTITY(1,1) NOT NULL,
	[TenTrinhDoHocVan] [nvarchar](100) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_TrinhDoHocVan] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDoHocVan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VanTay]    Script Date: 12/04/2020 3:39:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VanTay](
	[MaVanTay] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[XepLoaiChamCong]    Script Date: 12/04/2020 3:39:54 AM ******/
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
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (2, N'Nhân viên')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (3, N'Bảo vệ')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[GioiTinh] ON 

INSERT [dbo].[GioiTinh] ([MaGioiTinh], [TenGioiTinh]) VALUES (1, N'Nam')
INSERT [dbo].[GioiTinh] ([MaGioiTinh], [TenGioiTinh]) VALUES (2, N'Nữ')
SET IDENTITY_INSERT [dbo].[GioiTinh] OFF
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A01', N'OM', N'Nghỉ ốm', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A010', N'CT', N'Nghỉ công tác', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A011', N'LE', N'Nghỉ lễ', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A02', N'TS', N'Nghỉ thai sản', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A03', N'R', N'Nghỉ việc riêng có lương', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A04', N'Ro', N'Nghỉ việc riêng không lương', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A05', N'P', N'Nghỉ phép', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A06', N'F', N'Nghỉ phép năm', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A07', N'CO', N'Nghỉ con ốm', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A08', N'MD', N'Nghỉ mất điện', 1, 1)
INSERT [dbo].[KyHieuCacLoaiVang] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung], [TinhCong]) VALUES (N'A09', N'H', N'Nghỉ đi họp, đi học', 1, 1)
SET IDENTITY_INSERT [dbo].[KyHieuChamCong] ON 

INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (1, N'DT', N'Ký Hiệu đi trễ', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (2, N'vs', N'Ký Hiệu về sớm', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (3, N'dg', N'Ký Hiệu đúng giờ', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (4, N'tc', N'Ký Hiệu tăng ca', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (5, N'tgr', N'Ký Hiệu thiếu giờ ra', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (6, N'tgv', N'Ký Hiệu thiếu giờ vào', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (7, N'v', N'Ký Hiệu vắng', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (8, N'qd', N'Ký Hiệu đúng giờ ca có qua đêm', 1)
INSERT [dbo].[KyHieuChamCong] ([MaKyHieu], [TenKyHieu], [MoTa], [SuDung]) VALUES (9, N'kx', N'Ký Hiệu ngày không xếp ca', 1)
SET IDENTITY_INSERT [dbo].[KyHieuChamCong] OFF
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC1', N'Không xét vắng cho ngày Thứ Bẩy khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC2', N'Không xét vắng cho ngày Chủ Nhật khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC3', N'Không xét vắng cho ngày Ngày Lễ khi có xếp ca', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC4', N'Ngày Lễ được tính 1 công cho trường hợp không đi làm ', 1)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC5', N'Ngày là ngày của giờ ra', 0)
INSERT [dbo].[LichTrinhNangCao] ([MaLichTrinhNangCao], [TenLichTrinhNangCao], [SuDung]) VALUES (N'NC6', N'Khi không xếp ca vào các ngày trong tuần hoặc ngày lễ nếu có đi làm tính tăng ca mức 1', 1)
INSERT [dbo].[LoaiChamCong] ([MaLoaiChamCong], [TenLoaiChamCong]) VALUES (N'IN', N'Check in')
INSERT [dbo].[LoaiChamCong] ([MaLoaiChamCong], [TenLoaiChamCong]) VALUES (N'OUT', N'Check out')
SET IDENTITY_INSERT [dbo].[NgayNghiLe] ON 

INSERT [dbo].[NgayNghiLe] ([MaNgayNghiLe], [TenNgayNghiLe], [NgayLe], [MoTa]) VALUES (1, N'Giải phóng miền Nam thống nhất đất nước', CAST(N'2020-04-30' AS Date), NULL)
INSERT [dbo].[NgayNghiLe] ([MaNgayNghiLe], [TenNgayNghiLe], [NgayLe], [MoTa]) VALUES (5, N'Quốc tế lao động', CAST(N'2020-05-01' AS Date), NULL)
INSERT [dbo].[NgayNghiLe] ([MaNgayNghiLe], [TenNgayNghiLe], [NgayLe], [MoTa]) VALUES (6, N'Ngày hôm nay', CAST(N'2020-04-09' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[NgayNghiLe] OFF
SET IDENTITY_INSERT [dbo].[Nguoi] ON 

INSERT [dbo].[Nguoi] ([MaNguoi], [MaDinhDanh], [HoTen], [MaPhongBan], [MaChucVu], [MaKhuVuc], [NgaySinh], [MaGioiTinh], [SoDienThoai], [Email], [AnhDaiDien], [MaTrinhDo], [SoTheCanCuoc], [NgayCapTCC], [NoiCapTCC], [MaDanToc], [MaTonGiao], [MaQuocTich], [TinhTrangHonNhan], [DiaChiThuongTru], [DiaChiTamTru], [NgayNhanViec], [NgayThoiViec], [SuDungVanTay], [SuDungTheTu], [SuDungKhuonMat], [ThoiGianDangKy], [ThoiGianCapNhat], [GhiChu], [TrangThaiHoatDong]) VALUES (43, N'', N'Đỗ Đăng Thái', 1, 2, NULL, CAST(N'2020-04-08' AS Date), 1, N'', N'', NULL, 0, N'', CAST(N'2020-04-08' AS Date), N'', 0, 0, 0, 1, N'', N'', CAST(N'2020-04-08' AS Date), CAST(N'2020-04-08' AS Date), 0, 0, 1, NULL, NULL, N'', 3)
SET IDENTITY_INSERT [dbo].[Nguoi] OFF
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (1, N'Phòng ban làm việc', 0)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (3, N'Hành chính', 1)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (7, N'Bảo vệ', 1)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (9, N'Sản xuất', 1)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (10, N'Phần mềm', 9)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (11, N'Phần cứng', 9)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (12, N'Hệ thống', 9)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (13, N'Quản lý', 1)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (14, N'Bảo vệ cổng', 7)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (15, N'Bảo vệ nhà kho', 7)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [Cha]) VALUES (16, N'Bảo vệ văn phòng', 7)
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
SET IDENTITY_INSERT [dbo].[TrangThai] ON 

INSERT [dbo].[TrangThai] ([Id], [TenTrangThai], [GiaTri], [TenNhom]) VALUES (1, N'Ngừng hoạt động', 3, N'PERSON_AVAILABLE_STATUS')
INSERT [dbo].[TrangThai] ([Id], [TenTrangThai], [GiaTri], [TenNhom]) VALUES (3, N'Hoạt động', 1, N'PERSON_AVAILABLE_STATUS')
INSERT [dbo].[TrangThai] ([Id], [TenTrangThai], [GiaTri], [TenNhom]) VALUES (4, N'Nhân viên mới', 2, N'PERSON_AVAILABLE_STATUS')
INSERT [dbo].[TrangThai] ([Id], [TenTrangThai], [GiaTri], [TenNhom]) VALUES (5, N'Độc thân', 1, N'PERSON_MARITAL_STATUS')
INSERT [dbo].[TrangThai] ([Id], [TenTrangThai], [GiaTri], [TenNhom]) VALUES (6, N'Kết hôn', 2, N'PERSON_MARITAL_STATUS')
SET IDENTITY_INSERT [dbo].[TrangThai] OFF
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
ALTER TABLE [dbo].[LichTrinhNam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhNam_CaLamViec] FOREIGN KEY([MaCaLamViec])
REFERENCES [dbo].[CaLamViec] ([MaCaLamViec])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhNam] CHECK CONSTRAINT [FK_dbo.LichTrinhNam_CaLamViec]
GO
ALTER TABLE [dbo].[LichTrinhNam]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinhNam_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
GO
ALTER TABLE [dbo].[LichTrinhNam] CHECK CONSTRAINT [FK_LichTrinhNam_LichTrinh]
GO
ALTER TABLE [dbo].[LichTrinhThang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhThang_CaLamViec] FOREIGN KEY([MaCaLamViec])
REFERENCES [dbo].[CaLamViec] ([MaCaLamViec])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhThang] CHECK CONSTRAINT [FK_dbo.LichTrinhThang_CaLamViec]
GO
ALTER TABLE [dbo].[LichTrinhThang]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinhThang_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
GO
ALTER TABLE [dbo].[LichTrinhThang] CHECK CONSTRAINT [FK_LichTrinhThang_LichTrinh]
GO
ALTER TABLE [dbo].[LichTrinhTuan]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhTuan_CaLamViec] FOREIGN KEY([MaCaLamViec])
REFERENCES [dbo].[CaLamViec] ([MaCaLamViec])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhTuan] CHECK CONSTRAINT [FK_dbo.LichTrinhTuan_CaLamViec]
GO
ALTER TABLE [dbo].[LichTrinhTuan]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinhTuan_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
GO
ALTER TABLE [dbo].[LichTrinhTuan] CHECK CONSTRAINT [FK_LichTrinhTuan_LichTrinh]
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
ALTER TABLE [dbo].[Nguoi]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Nguoi_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nguoi] CHECK CONSTRAINT [FK_dbo.Nguoi_ChucVu]
GO
ALTER TABLE [dbo].[Nguoi]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Nguoi_PhongBan] FOREIGN KEY([MaPhongBan])
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
ALTER TABLE [dbo].[SapXepLichTrinhTam]  WITH CHECK ADD  CONSTRAINT [FK_SapXepLichTrinhTam_Nguoi] FOREIGN KEY([MaNguoi])
REFERENCES [dbo].[Nguoi] ([MaNguoi])
GO
ALTER TABLE [dbo].[SapXepLichTrinhTam] CHECK CONSTRAINT [FK_SapXepLichTrinhTam_Nguoi]
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
