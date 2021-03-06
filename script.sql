USE [master]
GO
/****** Object:  Database [DB_SinavOgrenci]    Script Date: 5.1.2020 00:53:13 ******/
CREATE DATABASE [DB_SinavOgrenci]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_SinavOgrenci', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_SinavOgrenci.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_SinavOgrenci_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_SinavOgrenci_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_SinavOgrenci] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_SinavOgrenci].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_SinavOgrenci] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_SinavOgrenci] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_SinavOgrenci] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_SinavOgrenci] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_SinavOgrenci] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_SinavOgrenci] SET  MULTI_USER 
GO
ALTER DATABASE [DB_SinavOgrenci] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_SinavOgrenci] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_SinavOgrenci] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_SinavOgrenci] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_SinavOgrenci] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DB_SinavOgrenci]
GO
/****** Object:  Table [tbl_dersler]    Script Date: 5.1.2020 00:53:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tbl_dersler](
	[DersId] [int] IDENTITY(1,1) NOT NULL,
	[DersAd] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_dersler] PRIMARY KEY CLUSTERED 
(
	[DersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tbl_kulupler]    Script Date: 5.1.2020 00:53:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tbl_kulupler](
	[KULUPID] [tinyint] IDENTITY(1,1) NOT NULL,
	[KULUPAD] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_kulupler] PRIMARY KEY CLUSTERED 
(
	[KULUPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tbl_notlar]    Script Date: 5.1.2020 00:53:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tbl_notlar](
	[NotId] [int] IDENTITY(1,1) NOT NULL,
	[Ogr] [int] NULL,
	[Ders] [int] NULL,
	[Sinav1] [smallint] NULL,
	[Sinav2] [smallint] NULL,
	[Sinav3] [smallint] NULL,
	[Ortalama] [decimal](5, 2) NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_tbl_notlar] PRIMARY KEY CLUSTERED 
(
	[NotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [tbl_ogrenci]    Script Date: 5.1.2020 00:53:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tbl_ogrenci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Fotograf] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_ogrenci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [tbl_dersler] ON 

INSERT [tbl_dersler] ([DersId], [DersAd]) VALUES (1, N'ALGORİTMA VE PROGRAMLAMA')
INSERT [tbl_dersler] ([DersId], [DersAd]) VALUES (2, N'VERİ MADENCİLİĞİ')
INSERT [tbl_dersler] ([DersId], [DersAd]) VALUES (3, N'YAZILIM TEST')
SET IDENTITY_INSERT [tbl_dersler] OFF
SET IDENTITY_INSERT [tbl_notlar] ON 

INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (1, 1, 1, 30, NULL, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (2, 2, 1, 27, NULL, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (3, 3, 1, 69, NULL, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (4, 4, 1, 96, NULL, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (5, 5, 1, 45, NULL, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (6, 1, 2, 32, 45, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (7, 2, 2, 85, 96, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (8, 3, 2, 67, 25, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (9, 4, 2, 49, 28, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (10, 5, 2, 73, 97, NULL, NULL, NULL)
INSERT [tbl_notlar] ([NotId], [Ogr], [Ders], [Sinav1], [Sinav2], [Sinav3], [Ortalama], [Durum]) VALUES (11, 5, 1, 19, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [tbl_notlar] OFF
SET IDENTITY_INSERT [tbl_ogrenci] ON 

INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (1, N'ALİ', N'YILDIZ', NULL)
INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (2, N'MEHMET', N'ÖZTÜRK', NULL)
INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (3, N'HAVVA', N'ARSLAN', NULL)
INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (4, N'AYŞE', N'KARA', NULL)
INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (5, N'VEYSEL', N'YILMAZ', NULL)
INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (13, N'FEYZA', N'KIR', NULL)
INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (16, N'BURAK', N'İNCE', NULL)
INSERT [tbl_ogrenci] ([Id], [Ad], [Soyad], [Fotograf]) VALUES (19, N'MUSTAFA', N'KAYA', NULL)
SET IDENTITY_INSERT [tbl_ogrenci] OFF
ALTER TABLE [tbl_notlar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_notlar_Tbl_dersler] FOREIGN KEY([Ders])
REFERENCES [tbl_dersler] ([DersId])
GO
ALTER TABLE [tbl_notlar] CHECK CONSTRAINT [FK_tbl_notlar_Tbl_dersler]
GO
ALTER TABLE [tbl_notlar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_notlar_tbl_ogrenci] FOREIGN KEY([Ogr])
REFERENCES [tbl_ogrenci] ([Id])
GO
ALTER TABLE [tbl_notlar] CHECK CONSTRAINT [FK_tbl_notlar_tbl_ogrenci]
GO
/****** Object:  StoredProcedure [NOTLISTESI]    Script Date: 5.1.2020 00:53:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [NOTLISTESI]
AS
SELECT NotId,Ad+' '+Soyad AS 'AD SOYAD',Sinav1,Sinav2,Sinav3,DersAd,Ortalama,Durum FROM tbl_notlar
INNER JOIN tbl_ogrenci ON tbl_notlar.Ogr=tbl_ogrenci.Id
INNER JOIN tbl_dersler ON tbl_dersler.DersId=tbl_notlar.Ders
GO
USE [master]
GO
ALTER DATABASE [DB_SinavOgrenci] SET  READ_WRITE 
GO
