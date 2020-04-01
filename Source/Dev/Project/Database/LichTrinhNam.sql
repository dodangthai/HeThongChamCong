USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[LichTrinhNam]    Script Date: 01/04/2020 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinhNam](
	[MaLichTrinhNam] [int] IDENTITY(1,1) NOT NULL,
	[MaLichTrinh] [varchar](5) NOT NULL,
	[MaChuKyNam] [varchar](5) NOT NULL,
	[MaCaLamViec] [varchar](5) NOT NULL,
 CONSTRAINT [PK_LichTrinhNam] PRIMARY KEY CLUSTERED 
(
	[MaLichTrinhNam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
ALTER TABLE [dbo].[LichTrinhNam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichTrinhNam_LichTrinh] FOREIGN KEY([MaLichTrinh])
REFERENCES [dbo].[LichTrinh] ([MaLichTrinh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinhNam] CHECK CONSTRAINT [FK_dbo.LichTrinhNam_LichTrinh]
GO
