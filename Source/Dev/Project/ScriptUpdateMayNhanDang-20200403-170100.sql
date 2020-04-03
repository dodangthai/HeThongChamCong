USE [ATINChamCong]
GO

/****** Object:  Table [dbo].[MayNhanDang]    Script Date: 03/04/2020 5:00:20 PM ******/
DROP TABLE [dbo].[MayNhanDang]
GO

/****** Object:  Table [dbo].[MayNhanDang]    Script Date: 03/04/2020 5:00:20 PM ******/
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


