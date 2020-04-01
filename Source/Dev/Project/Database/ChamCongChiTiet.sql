USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[ChamCongChiTiet]    Script Date: 01/04/2020 7:12:44 PM ******/
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
