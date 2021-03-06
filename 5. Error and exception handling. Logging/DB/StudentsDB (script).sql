USE [StudentsDB]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 23.12.2019 16:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[Age] [int] NULL,
	[Gender] [nvarchar](5) NULL,
	[City] [nvarchar](20) NULL,
	[Country] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[InsertStudent]    Script Date: 23.12.2019 16:28:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStudent]
@firstName nchar(50),
@lastName nchar(50),
@age int,
@gender char(10),
@city nchar(10),
@country nchar(50)
AS

INSERT INTO Student (FirstName, LastName, Age, Gender, City, Country)
VALUES (@firstName,@lastName,@age,@gender,@city,@country);
GO
