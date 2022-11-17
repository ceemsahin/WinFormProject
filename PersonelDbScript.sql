USE [master]
GO
/****** Object:  Database [DatabasePersonel]    Script Date: 17.11.2022 15:55:20 ******/
CREATE DATABASE [DatabasePersonel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DatabasePersonel', FILENAME = N'D:\Microsoft SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\DatabasePersonel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DatabasePersonel_log', FILENAME = N'D:\Microsoft SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\DatabasePersonel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DatabasePersonel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DatabasePersonel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DatabasePersonel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DatabasePersonel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DatabasePersonel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DatabasePersonel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DatabasePersonel] SET ARITHABORT OFF 
GO
ALTER DATABASE [DatabasePersonel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DatabasePersonel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DatabasePersonel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DatabasePersonel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DatabasePersonel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DatabasePersonel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DatabasePersonel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DatabasePersonel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DatabasePersonel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DatabasePersonel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DatabasePersonel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DatabasePersonel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DatabasePersonel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DatabasePersonel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DatabasePersonel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DatabasePersonel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DatabasePersonel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DatabasePersonel] SET RECOVERY FULL 
GO
ALTER DATABASE [DatabasePersonel] SET  MULTI_USER 
GO
ALTER DATABASE [DatabasePersonel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DatabasePersonel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DatabasePersonel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DatabasePersonel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DatabasePersonel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DatabasePersonel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DatabasePersonel', N'ON'
GO
ALTER DATABASE [DatabasePersonel] SET QUERY_STORE = OFF
GO
USE [DatabasePersonel]
GO
/****** Object:  Table [dbo].[TBLPersonel]    Script Date: 17.11.2022 15:55:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLPersonel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[AdiSoyadi] [nvarchar](50) NULL,
	[Numarasi] [varchar](12) NULL,
 CONSTRAINT [PK_TBLPersonel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBLPersonel] ON 

INSERT [dbo].[TBLPersonel] ([PersonelID], [AdiSoyadi], [Numarasi]) VALUES (1, N'Cem Şahin', N'123456789')
SET IDENTITY_INSERT [dbo].[TBLPersonel] OFF
GO
USE [master]
GO
ALTER DATABASE [DatabasePersonel] SET  READ_WRITE 
GO
