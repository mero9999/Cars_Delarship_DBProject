USE [master]
GO
/****** Object:  Database [Cars_Dealership]    Script Date: 12/7/2022 7:26:53 PM ******/
CREATE DATABASE [Cars_Dealership]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cars_Dealership', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cars_Dealership.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cars_Dealership_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cars_Dealership_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Cars_Dealership] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cars_Dealership].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cars_Dealership] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cars_Dealership] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cars_Dealership] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cars_Dealership] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cars_Dealership] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cars_Dealership] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Cars_Dealership] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cars_Dealership] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cars_Dealership] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cars_Dealership] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cars_Dealership] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cars_Dealership] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cars_Dealership] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cars_Dealership] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cars_Dealership] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Cars_Dealership] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cars_Dealership] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cars_Dealership] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cars_Dealership] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cars_Dealership] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cars_Dealership] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cars_Dealership] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cars_Dealership] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cars_Dealership] SET  MULTI_USER 
GO
ALTER DATABASE [Cars_Dealership] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cars_Dealership] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cars_Dealership] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cars_Dealership] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cars_Dealership] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cars_Dealership] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Cars_Dealership] SET QUERY_STORE = OFF
GO
USE [Cars_Dealership]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[F_Name] [varchar](50) NULL,
	[L_Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC,
	[Password] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buyer]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buyer](
	[F_Name] [varchar](50) NULL,
	[L_Name] [varchar](50) NULL,
	[Vin] [varchar](50) NULL,
	[Ssn] [int] NOT NULL,
	[Driver_License] [varchar](50) NULL,
	[Price] [int] NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Card_Details]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card_Details](
	[Card_Number] [int] NOT NULL,
	[Exp_Date] [date] NULL,
	[Cvv] [int] NULL,
	[Ssn_Holder] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Card_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Price] [int] NULL,
	[Vin] [varchar](50) NOT NULL,
	[Company] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Year] [int] NULL,
	[Colour] [varchar](50) NULL,
	[Distance_Travelled] [int] NULL,
	[Type] [varchar](50) NULL,
	[Flag] [varchar](50) NULL,
	[Ssn_Seller] [int] NULL,
	[M_Id] [int] NULL,
	[W_Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Vin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars_Out_Rent]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars_Out_Rent](
	[Ssn] [int] NOT NULL,
	[Vin] [varchar](50) NULL,
	[Start_Date] [date] NULL,
	[End_Date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ssn] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maintenance_Center]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maintenance_Center](
	[M_Id] [int] NOT NULL,
	[Capacity] [int] NULL,
	[Postal_Code] [varchar](50) NULL,
	[District] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[M_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seller]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller](
	[F_Name] [varchar](50) NULL,
	[L_Name] [varchar](50) NULL,
	[Price] [int] NULL,
	[Ssn] [int] NOT NULL,
	[Vin] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 12/7/2022 7:26:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[W_Id] [int] NOT NULL,
	[Capacity] [int] NULL,
	[Postal_Code] [varchar](50) NULL,
	[District] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[W_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Maintenance_Center] ([M_Id], [Capacity], [Postal_Code], [District]) VALUES (0, 50, N'12051', N'Sheikh_Zayed')
GO
INSERT [dbo].[Warehouse] ([W_Id], [Capacity], [Postal_Code], [District]) VALUES (0, 30, N'12061', N'Sheikh_Zayed')
INSERT [dbo].[Warehouse] ([W_Id], [Capacity], [Postal_Code], [District]) VALUES (1, NULL, NULL, N'Dokki')
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ('0') FOR [M_Id]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ('0') FOR [W_Id]
GO
ALTER TABLE [dbo].[buyer]  WITH CHECK ADD FOREIGN KEY([Vin])
REFERENCES [dbo].[Cars] ([Vin])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Card_Details]  WITH CHECK ADD FOREIGN KEY([Ssn_Holder])
REFERENCES [dbo].[buyer] ([Ssn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([M_Id])
REFERENCES [dbo].[Maintenance_Center] ([M_Id])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([Ssn_Seller])
REFERENCES [dbo].[Seller] ([Ssn])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([W_Id])
REFERENCES [dbo].[Warehouse] ([W_Id])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Cars_Out_Rent]  WITH CHECK ADD FOREIGN KEY([Vin])
REFERENCES [dbo].[Cars] ([Vin])
ON UPDATE CASCADE
GO
USE [master]
GO
ALTER DATABASE [Cars_Dealership] SET  READ_WRITE 
GO
