USE [ATINChamCong]
GO

ALTER TABLE [dbo].[LichTrinhTuan] DROP CONSTRAINT [FK_dbo.LichTrinhTuan_ChuKyTuan]
GO

ALTER TABLE [dbo].[LichTrinhTuan] DROP CONSTRAINT [FK_dbo.LichTrinhTuan_CaLamViec]
GO

/****** Object:  Table [dbo].[LichTrinhTuan]    Script Date: 01/04/2020 2:54:11 PM ******/
DROP TABLE [dbo].[LichTrinhTuan]
GO

/****** Object:  Table [dbo].[LichTrinhTuan]    Script Date: 01/04/2020 2:54:11 PM ******/
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