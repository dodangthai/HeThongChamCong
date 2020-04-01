USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[LichSuSuaDuLieuChamCong]    Script Date: 01/04/2020 7:15:27 PM ******/
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
