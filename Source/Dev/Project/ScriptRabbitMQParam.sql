USE [ATINChamCong]
GO

/****** Object:  Table [dbo].[CauHinhRabbitMQ]    Script Date: 06/04/2020 4:13:36 PM ******/
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
