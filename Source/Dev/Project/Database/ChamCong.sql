USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 01/04/2020 7:11:58 PM ******/
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
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED 
(
	[MaChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
