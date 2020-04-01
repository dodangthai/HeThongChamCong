USE [ATINChamCong]
GO

ALTER TABLE [dbo].[LichTrinhThang] DROP CONSTRAINT [FK_dbo.LichTrinhThang_ChuKyThang]
GO

ALTER TABLE [dbo].[LichTrinhThang] DROP CONSTRAINT [FK_dbo.LichTrinhThang_CaLamViec]
GO

/****** Object:  Table [dbo].[LichTrinhThang]    Script Date: 01/04/2020 2:55:43 PM ******/
DROP TABLE [dbo].[LichTrinhThang]
GO

/****** Object:  Table [dbo].[LichTrinhThang]    Script Date: 01/04/2020 2:55:43 PM ******/
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


