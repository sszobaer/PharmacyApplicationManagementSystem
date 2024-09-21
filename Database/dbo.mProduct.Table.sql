USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[mProduct]    Script Date: 21/09/2024 17:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mProduct](
	[pID] [int] NULL,
	[pName] [varchar](50) NULL,
	[Price] [float] NULL
) ON [PRIMARY]
GO
