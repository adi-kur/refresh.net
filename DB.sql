USE [master]
GO
/****** Object:  Database [applicant_db]    Script Date: 7/8/2020 8:20:04 PM ******/
CREATE DATABASE [applicant_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'applicant_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\applicant_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'applicant_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\applicant_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [applicant_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [applicant_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [applicant_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [applicant_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [applicant_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [applicant_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [applicant_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [applicant_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [applicant_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [applicant_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [applicant_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [applicant_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [applicant_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [applicant_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [applicant_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [applicant_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [applicant_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [applicant_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [applicant_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [applicant_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [applicant_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [applicant_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [applicant_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [applicant_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [applicant_db] SET RECOVERY FULL 
GO
ALTER DATABASE [applicant_db] SET  MULTI_USER 
GO
ALTER DATABASE [applicant_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [applicant_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [applicant_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [applicant_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [applicant_db] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'applicant_db', N'ON'
GO
ALTER DATABASE [applicant_db] SET QUERY_STORE = OFF
GO
USE [applicant_db]
GO
/****** Object:  Table [dbo].[TB_Applicant]    Script Date: 7/8/2020 8:20:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Applicant](
	[ID] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Contact_Number] [varchar](13) NOT NULL,
	[Email] [varchar](50) NULL,
	[Date_Of_Birth] [datetime] NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Major] [bit] NULL,
	[Question] [varchar](100) NULL,
	[Is_Delete] [bit] NOT NULL,
	[Created_By] [varchar](50) NULL,
	[Created_On] [datetime] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_On] [datetime] NULL,
 CONSTRAINT [PK_TB_Applicant] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [applicant_db] SET  READ_WRITE 
GO
