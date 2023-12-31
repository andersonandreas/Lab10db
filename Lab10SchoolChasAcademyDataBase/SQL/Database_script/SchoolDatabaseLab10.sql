USE [master]
GO
/****** Object:  Database [SchoolChasAcademyDb]    Script Date: 11/7/2023 10:29:48 AM ******/
CREATE DATABASE [SchoolChasAcademyDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolChasAcademy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SchoolChasAcademy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolChasAcademy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SchoolChasAcademy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SchoolChasAcademyDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolChasAcademyDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolChasAcademyDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET RECOVERY FULL 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolChasAcademyDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolChasAcademyDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SchoolChasAcademyDb', N'ON'
GO
ALTER DATABASE [SchoolChasAcademyDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [SchoolChasAcademyDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SchoolChasAcademyDb]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 11/7/2023 10:29:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](128) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/7/2023 10:29:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[EmployeeRole] [nvarchar](128) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grades]    Script Date: 11/7/2023 10:29:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[GradeID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[CourseID] [int] NULL,
	[Grade] [int] NULL,
	[DateGrade] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 11/7/2023 10:29:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[PersonNumber] [varchar](15) NULL,
	[FirstName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[Class] [nvarchar](128) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (1, N'Databases and SQL')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (2, N'Front-End with React')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (3, N'JavaScript Vanilla')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (4, N'HTML and CSS')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (5, N'Authentication and Authorization ')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (6, N'Web Performance Optimization')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (7, N'API Development and Integration')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (8, N'Responsive Web Design')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (9, N'Web Accessibility')
INSERT [dbo].[Courses] ([CourseID], [CourseName]) VALUES (10, N'Microsoft Azure Networking')
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (1, N'Cristoffer', N'Eriksson', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (2, N'Anna', N'Malmborg', N'Librarian')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (3, N'Fredrik', N'Andersson', N'Administrative Staff')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (4, N'Cleas', N'Johansson', N'Counselor')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (5, N'Daniel', N'Timell', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (6, N'Lars', N'Blomberg', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (7, N'Camilla', N'Olsson', N'Counselor')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (8, N'Erik', N'Andersson', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (9, N'Andreas', N'Anderson', N'Boss')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (10, N'Daniel ', N'Olsson', N'Hour gardner')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (11, N'Malin', N'Liseberg', N'Assistent')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (3012, N'Andreas ', N'Anderson', N'')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (3013, N'Daniel', N'Jonsson', N'Gardner')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [EmployeeRole]) VALUES (5025, N'Andreas', N'Anderson', N'ChasAcademy')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Grades] ON 

INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (1, 1, 1, 2, CAST(N'2023-10-04' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (2, 1, 2, 1, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (3, 2, 1, 2, CAST(N'2023-10-04' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (4, 2, 2, 1, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (5, 3, 1, 1, CAST(N'2023-10-04' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (6, 3, 2, 2, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (7, 4, 1, 0, CAST(N'2023-10-04' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (8, 4, 2, 0, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (9, 5, 1, 1, CAST(N'2023-10-04' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (10, 5, 2, 1, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (11, 6, 1, 1, CAST(N'2022-10-01' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (12, 6, 2, 2, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (13, 7, 1, 1, CAST(N'2022-10-01' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (14, 7, 2, 2, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (15, 8, 1, 2, CAST(N'2022-10-01' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (16, 8, 2, 1, CAST(N'2022-06-15' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (17, 9, 1, 1, CAST(N'2022-10-01' AS Date))
INSERT [dbo].[Grades] ([GradeID], [StudentID], [CourseID], [Grade], [DateGrade]) VALUES (18, 9, 2, 1, CAST(N'2022-06-15' AS Date))
SET IDENTITY_INSERT [dbo].[Grades] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (1, N'19720224-8044', N'Patric', N'Eriksson', N'UX Designer')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (2, N'19830611-9031', N'Lars', N'Malmborg', N'Fullstack JavaScript')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (3, N'19850511-5831', N'Adrian', N'Blomberg', N'Fullstack .NET')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (4, N'19900511-3488', N'Dennis', N'Eriksson', N'UX Designer')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (5, N'19910912-3014', N'Niklas', N'Olsson', N'Devops Engineer')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (6, N'19991120-1144', N'Andreas', N'Lindholm', N'Systemutvecklare C/C++')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (7, N'20020511-1651', N'Sandra', N'Dahl', N'Fullstack JavaScript')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (8, N'20041211-5483', N'Malin', N'Malmquist', N'Fullstack .NET')
INSERT [dbo].[Students] ([StudentID], [PersonNumber], [FirstName], [LastName], [Class]) VALUES (9, N'19950511-3555', N'Stina', N'Johnsson', N'Systemutvecklare C/C++')
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
USE [master]
GO
ALTER DATABASE [SchoolChasAcademyDb] SET  READ_WRITE 
GO
