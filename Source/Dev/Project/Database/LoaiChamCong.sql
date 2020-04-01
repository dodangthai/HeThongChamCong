USE [ATINChamCong]
GO
/****** Object:  Table [dbo].[LoaiChamCong]    Script Date: 01/04/2020 7:14:39 PM ******/
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
INSERT [dbo].[LoaiChamCong] ([MaLoaiChamCong], [TenLoaiChamCong]) VALUES (N'IN', N'Check in')
INSERT [dbo].[LoaiChamCong] ([MaLoaiChamCong], [TenLoaiChamCong]) VALUES (N'OUT', N'Check out')
