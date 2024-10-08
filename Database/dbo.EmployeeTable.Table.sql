USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[EmployeeTable]    Script Date: 13/09/2024 01:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTable](
	[empID] [int] IDENTITY(1,1) NOT NULL,
	[empName] [varchar](50) NOT NULL,
	[empGender] [varchar](50) NOT NULL,
	[empDept] [int] NOT NULL,
	[empDob] [date] NOT NULL,
	[empJDate] [date] NOT NULL,
	[empSal] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[empID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([empDept])
REFERENCES [dbo].[DepartmentTable] ([deptID])
GO
ALTER TABLE [dbo].[EmployeeTable] CHECK CONSTRAINT [FK1]
GO
