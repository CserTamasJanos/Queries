USE [master]
GO

/****** Object:  Database [FictiveCompany]    Script Date: 2019. 08. 12. 11:13:34 ******/
CREATE DATABASE [FictiveCompany]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FictiveCompany', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FictiveCompany.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FictiveCompany_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FictiveCompany_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [FictiveCompany] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FictiveCompany].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FictiveCompany] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FictiveCompany] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FictiveCompany] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FictiveCompany] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FictiveCompany] SET ARITHABORT OFF 
GO

ALTER DATABASE [FictiveCompany] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [FictiveCompany] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FictiveCompany] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FictiveCompany] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FictiveCompany] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FictiveCompany] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FictiveCompany] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FictiveCompany] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FictiveCompany] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FictiveCompany] SET  DISABLE_BROKER 
GO

ALTER DATABASE [FictiveCompany] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FictiveCompany] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FictiveCompany] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FictiveCompany] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FictiveCompany] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FictiveCompany] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [FictiveCompany] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FictiveCompany] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [FictiveCompany] SET  MULTI_USER 
GO

ALTER DATABASE [FictiveCompany] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FictiveCompany] SET DB_CHAINING OFF 
GO

ALTER DATABASE [FictiveCompany] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [FictiveCompany] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [FictiveCompany] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [FictiveCompany] SET QUERY_STORE = OFF
GO

USE [FictiveCompany]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [FictiveCompany] SET  READ_WRITE 
GO
