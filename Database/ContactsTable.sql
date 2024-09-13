USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[ContactsTable]    Script Date: 13/09/2024 23:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactsTable](
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[message] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
