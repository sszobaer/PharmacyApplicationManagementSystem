USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[DepartmentTable]    Script Date: 13/09/2024 01:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentTable](
	[deptID] [int] IDENTITY(1,1) NOT NULL,
	[deptName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[deptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
