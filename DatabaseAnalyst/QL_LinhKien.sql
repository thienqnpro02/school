USE [master]
GO
/****** Object:  Database [QL_LINHKIEN]    Script Date: 10/16/2019 7:14:59 PM ******/
CREATE DATABASE [QL_LINHKIEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_LINHKIEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_LINHKIEN.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_LINHKIEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_LINHKIEN_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_LINHKIEN] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_LINHKIEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_LINHKIEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_LINHKIEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_LINHKIEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_LINHKIEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_LINHKIEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_LINHKIEN] SET  MULTI_USER 
GO
ALTER DATABASE [QL_LINHKIEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_LINHKIEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_LINHKIEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_LINHKIEN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_LINHKIEN] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_LINHKIEN', N'ON'
GO
USE [QL_LINHKIEN]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MAPHIEUNHAP] [int] NOT NULL,
	[MAHANG] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[GIANHAP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUNHAP] ASC,
	[MAHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUAT]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUAT](
	[MAPHIEUXUAT] [int] NOT NULL,
	[MAHANG] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[GIAXUAT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUXUAT] ASC,
	[MAHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[MADM] [int] IDENTITY(1,1) NOT NULL,
	[TENDANHMUC] [nvarchar](50) NULL,
	[NGAYTAO] [date] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[MADM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANG]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANG](
	[MAHANG] [int] IDENTITY(1,1) NOT NULL,
	[TENHANG] [varchar](200) NULL,
	[THONGSO] [nvarchar](max) NULL,
	[BAOHANH] [int] NULL,
	[SOLUONG] [int] NULL,
	[GIA] [int] NULL,
	[HINH] [varchar](100) NULL DEFAULT ('default.png'),
	[NHASANXUAT] [varchar](50) NULL,
	[NGAYTAO] [date] NULL DEFAULT (getdate()),
	[MADANHMUC] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[NAMSINH] [date] NULL,
	[NGAYTAO] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [int] IDENTITY(1,1) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](80) NULL,
	[FAX] [char](10) NULL,
	[EMAIL] [varchar](50) NULL,
	[NGAYTAO] [date] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME] [varchar](50) NULL,
	[PASSWORD] [varchar](80) NULL,
	[HOTEN] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[DIACHI] [nvarchar](80) NULL,
	[NAMSINH] [date] NULL,
	[LOAINHANVIEN] [tinyint] NULL,
	[GIOITINH] [bit] NULL,
	[NGAYTAO] [date] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPHIEUNHAP] [int] IDENTITY(1,1) NOT NULL,
	[NGAYTAO] [date] NULL,
	[MANCC] [int] NULL,
	[MANV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 10/16/2019 7:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MAPHIEUXUAT] [int] IDENTITY(1,1) NOT NULL,
	[MAKH] [int] NULL,
	[NGAYTAO] [date] NULL,
	[MANV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUXUAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[KHACHHANG] ADD  DEFAULT (getdate()) FOR [NGAYTAO]
GO
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT (getdate()) FOR [NGAYTAO]
GO
ALTER TABLE [dbo].[PHIEUXUAT] ADD  DEFAULT (getdate()) FOR [NGAYTAO]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MAHANG])
REFERENCES [dbo].[HANG] ([MAHANG])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MAPHIEUNHAP])
REFERENCES [dbo].[PHIEUNHAP] ([MAPHIEUNHAP])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MAHANG])
REFERENCES [dbo].[HANG] ([MAHANG])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MAPHIEUXUAT])
REFERENCES [dbo].[PHIEUXUAT] ([MAPHIEUXUAT])
GO
ALTER TABLE [dbo].[HANG]  WITH CHECK ADD FOREIGN KEY([MADANHMUC])
REFERENCES [dbo].[DANHMUC] ([MADM])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
USE [master]
GO
ALTER DATABASE [QL_LINHKIEN] SET  READ_WRITE 
GO
