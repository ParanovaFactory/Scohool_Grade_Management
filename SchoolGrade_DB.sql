USE [master]
GO
/****** Object:  Database [School Grade]    Script Date: 9/8/2024 11:32:10 PM ******/
CREATE DATABASE [School Grade]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'School Grade', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\School Grade.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'School Grade_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\School Grade_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [School Grade] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [School Grade].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [School Grade] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [School Grade] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [School Grade] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [School Grade] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [School Grade] SET ARITHABORT OFF 
GO
ALTER DATABASE [School Grade] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [School Grade] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [School Grade] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [School Grade] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [School Grade] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [School Grade] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [School Grade] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [School Grade] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [School Grade] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [School Grade] SET  DISABLE_BROKER 
GO
ALTER DATABASE [School Grade] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [School Grade] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [School Grade] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [School Grade] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [School Grade] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [School Grade] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [School Grade] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [School Grade] SET RECOVERY FULL 
GO
ALTER DATABASE [School Grade] SET  MULTI_USER 
GO
ALTER DATABASE [School Grade] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [School Grade] SET DB_CHAINING OFF 
GO
ALTER DATABASE [School Grade] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [School Grade] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [School Grade] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [School Grade] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'School Grade', N'ON'
GO
ALTER DATABASE [School Grade] SET QUERY_STORE = ON
GO
ALTER DATABASE [School Grade] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [School Grade]
GO
/****** Object:  Table [dbo].[TblCourses]    Script Date: 9/8/2024 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCourses](
	[courseId] [tinyint] IDENTITY(1,1) NOT NULL,
	[courseName] [varchar](30) NULL,
 CONSTRAINT [PK_TblCourses] PRIMARY KEY CLUSTERED 
(
	[courseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblGrades]    Script Date: 9/8/2024 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblGrades](
	[gradeId] [int] IDENTITY(1,1) NOT NULL,
	[crsId] [tinyint] NULL,
	[tchId] [int] NULL,
	[studentId] [int] NULL,
	[exam1] [decimal](5, 2) NULL,
	[exam2] [decimal](5, 2) NULL,
	[exam3] [decimal](5, 2) NULL,
	[assignment] [decimal](5, 2) NULL,
	[average] [decimal](5, 2) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_TblGrades] PRIMARY KEY CLUSTERED 
(
	[gradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSocialClubs]    Script Date: 9/8/2024 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSocialClubs](
	[socialClubId] [tinyint] IDENTITY(1,1) NOT NULL,
	[clubName] [varchar](30) NULL,
 CONSTRAINT [PK_TblSocialClub] PRIMARY KEY CLUSTERED 
(
	[socialClubId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStudents]    Script Date: 9/8/2024 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStudents](
	[stdId] [int] IDENTITY(1,1) NOT NULL,
	[stdName] [varchar](20) NULL,
	[stdSurname] [varchar](20) NULL,
	[stdSocialClub] [tinyint] NULL,
	[stdGender] [varchar](6) NULL,
	[stdUserName] [varchar](20) NULL,
	[stdPassword] [varchar](20) NULL,
 CONSTRAINT [PK_TblStudents] PRIMARY KEY CLUSTERED 
(
	[stdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTeachers]    Script Date: 9/8/2024 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTeachers](
	[teacherId] [int] IDENTITY(1,1) NOT NULL,
	[teacherName] [varchar](20) NULL,
	[teacherSurname] [varchar](20) NULL,
	[teacherDepartment] [tinyint] NULL,
	[teacherUserName] [varchar](20) NULL,
	[teacherPassword] [varchar](20) NULL,
 CONSTRAINT [PK_TblTeacher] PRIMARY KEY CLUSTERED 
(
	[teacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblGrades]  WITH CHECK ADD  CONSTRAINT [FK_TblGrades_TblCourses] FOREIGN KEY([crsId])
REFERENCES [dbo].[TblCourses] ([courseId])
GO
ALTER TABLE [dbo].[TblGrades] CHECK CONSTRAINT [FK_TblGrades_TblCourses]
GO
ALTER TABLE [dbo].[TblGrades]  WITH CHECK ADD  CONSTRAINT [FK_TblGrades_TblStudents] FOREIGN KEY([studentId])
REFERENCES [dbo].[TblStudents] ([stdId])
GO
ALTER TABLE [dbo].[TblGrades] CHECK CONSTRAINT [FK_TblGrades_TblStudents]
GO
ALTER TABLE [dbo].[TblGrades]  WITH CHECK ADD  CONSTRAINT [FK_TblGrades_TblTeacher] FOREIGN KEY([tchId])
REFERENCES [dbo].[TblTeachers] ([teacherId])
GO
ALTER TABLE [dbo].[TblGrades] CHECK CONSTRAINT [FK_TblGrades_TblTeacher]
GO
ALTER TABLE [dbo].[TblStudents]  WITH CHECK ADD  CONSTRAINT [FK_TblStudents_TblSocialClub] FOREIGN KEY([stdSocialClub])
REFERENCES [dbo].[TblSocialClubs] ([socialClubId])
GO
ALTER TABLE [dbo].[TblStudents] CHECK CONSTRAINT [FK_TblStudents_TblSocialClub]
GO
ALTER TABLE [dbo].[TblTeachers]  WITH CHECK ADD  CONSTRAINT [FK_TblTeacher_TblCourses] FOREIGN KEY([teacherDepartment])
REFERENCES [dbo].[TblCourses] ([courseId])
GO
ALTER TABLE [dbo].[TblTeachers] CHECK CONSTRAINT [FK_TblTeacher_TblCourses]
GO
USE [master]
GO
ALTER DATABASE [School Grade] SET  READ_WRITE 
GO
