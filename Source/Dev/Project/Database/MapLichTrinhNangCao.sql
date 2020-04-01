USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[MapLichTrinhNangCao]    Script Date: 01/04/2020 11:55:06 AM ******/
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
