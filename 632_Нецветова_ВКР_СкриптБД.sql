USE [master]
GO
/****** Object:  Database [DBPlanProizv]    Script Date: 05.06.2022 23:57:05 ******/
CREATE DATABASE [DBPlanProizv]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBPlanProizv', FILENAME = N'S:\колледж\4 курс\Диплом\БД\DBPlanProizv.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBPlanProizv_log', FILENAME = N'S:\колледж\4 курс\Диплом\БД\DBPlanProizv_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBPlanProizv] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBPlanProizv].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBPlanProizv] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBPlanProizv] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBPlanProizv] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBPlanProizv] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBPlanProizv] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBPlanProizv] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBPlanProizv] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBPlanProizv] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBPlanProizv] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBPlanProizv] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBPlanProizv] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBPlanProizv] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBPlanProizv] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBPlanProizv] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBPlanProizv] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBPlanProizv] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBPlanProizv] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBPlanProizv] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBPlanProizv] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBPlanProizv] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBPlanProizv] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBPlanProizv] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBPlanProizv] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBPlanProizv] SET  MULTI_USER 
GO
ALTER DATABASE [DBPlanProizv] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBPlanProizv] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBPlanProizv] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBPlanProizv] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBPlanProizv] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBPlanProizv] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DBPlanProizv] SET QUERY_STORE = OFF
GO
USE [DBPlanProizv]
GO
/****** Object:  Table [dbo].[Balloons]    Script Date: 05.06.2022 23:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Balloons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Diameter] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Actuality] [bit] NOT NULL,
 CONSTRAINT [PK_Balloons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoryLogin]    Script Date: 05.06.2022 23:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_HistoryLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanProduction]    Script Date: 05.06.2022 23:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanProduction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProduct] [int] NOT NULL,
	[QuantityOfProducts] [int] NOT NULL,
	[QuantityOfShifts] [int] NOT NULL,
 CONSTRAINT [PK_PlanProduction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 05.06.2022 23:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProductType] [int] NOT NULL,
	[IdBalloon] [int] NOT NULL,
	[OneLine] [int] NULL,
	[TwoLine] [int] NULL,
	[ThreeLine] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 05.06.2022 23:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeProduct] [nvarchar](50) NOT NULL,
	[Actuality] [bit] NOT NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 05.06.2022 23:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05.06.2022 23:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[IdRole] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Balloons] ON 

INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (1, 35, NULL, 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (2, 45, NULL, 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (3, 53, NULL, 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (4, 52, NULL, 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (5, 57, NULL, 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (6, 65, NULL, 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (7, 45, N'(150 мл.)', 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (8, 45, N'(200 мл.)', 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (9, 52, N'сухие', 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (10, 52, N'водные', 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (11, 65, N'сменники', 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (12, 52, N'(400 мл)', 1)
INSERT [dbo].[Balloons] ([Id], [Diameter], [Description], [Actuality]) VALUES (13, 52, N'(200 мл)', 1)
SET IDENTITY_INSERT [dbo].[Balloons] OFF
GO
SET IDENTITY_INSERT [dbo].[HistoryLogin] ON 

INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (1, 1, CAST(N'2022-05-19T19:05:55.563' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (2, 1, CAST(N'2022-05-19T19:09:47.273' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (3, 1, CAST(N'2022-05-19T19:10:03.683' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (4, 2, CAST(N'2022-05-19T19:16:12.007' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (5, 2, CAST(N'2022-05-19T19:21:56.727' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (6, 1, CAST(N'2022-05-19T19:22:40.553' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (7, 1, CAST(N'2022-05-20T19:14:41.877' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (8, 1, CAST(N'2022-05-20T19:14:56.267' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (9, 1, CAST(N'2022-05-20T19:16:19.633' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (10, 1, CAST(N'2022-05-20T19:16:36.430' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (11, 1, CAST(N'2022-05-20T19:17:33.963' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (12, 1, CAST(N'2022-05-20T19:18:25.587' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (13, 1, CAST(N'2022-05-20T19:29:02.783' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (14, 1, CAST(N'2022-05-20T19:35:34.613' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (15, 1, CAST(N'2022-05-21T15:32:25.770' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (16, 1, CAST(N'2022-05-21T15:46:25.090' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (17, 1, CAST(N'2022-05-21T16:14:53.683' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (18, 1, CAST(N'2022-05-21T16:37:07.430' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (19, 1, CAST(N'2022-05-21T16:39:12.800' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (20, 1, CAST(N'2022-05-21T16:41:43.603' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (21, 1, CAST(N'2022-05-21T16:42:20.020' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (22, 1, CAST(N'2022-05-21T19:24:16.077' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (23, 1, CAST(N'2022-05-21T19:27:19.787' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (24, 1, CAST(N'2022-05-22T12:56:24.180' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (25, 1, CAST(N'2022-05-22T13:05:27.497' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (26, 1, CAST(N'2022-05-22T13:11:27.123' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (27, 1, CAST(N'2022-05-22T16:31:42.160' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (28, 1, CAST(N'2022-05-22T16:35:24.420' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (29, 1, CAST(N'2022-05-22T16:53:35.127' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (30, 1, CAST(N'2022-05-22T20:32:51.737' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (31, 1, CAST(N'2022-05-22T20:39:00.093' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (32, 1, CAST(N'2022-05-22T20:47:08.973' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (33, 1, CAST(N'2022-05-22T20:50:51.697' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (34, 1, CAST(N'2022-05-22T20:51:58.567' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (35, 1, CAST(N'2022-05-22T20:54:13.397' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (36, 1, CAST(N'2022-05-23T16:44:43.103' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (37, 1, CAST(N'2022-05-23T16:47:36.097' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (38, 1, CAST(N'2022-05-23T16:54:36.143' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (39, 1, CAST(N'2022-05-23T16:55:13.920' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (40, 1, CAST(N'2022-05-23T16:57:40.070' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (41, 1, CAST(N'2022-05-23T17:12:44.100' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (42, 1, CAST(N'2022-05-23T17:15:19.743' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (43, 1, CAST(N'2022-05-23T18:40:35.883' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (44, 1, CAST(N'2022-05-24T13:13:36.090' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (45, 1, CAST(N'2022-05-24T13:24:40.783' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (46, 1, CAST(N'2022-05-24T13:26:28.100' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (47, 1, CAST(N'2022-05-24T13:27:09.213' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (48, 1, CAST(N'2022-05-24T14:16:15.980' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (49, 1, CAST(N'2022-05-24T17:39:17.777' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (50, 1, CAST(N'2022-05-25T14:11:38.403' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (51, 1, CAST(N'2022-05-25T14:13:53.257' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (52, 1, CAST(N'2022-05-25T20:46:41.903' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (53, 1, CAST(N'2022-05-25T22:41:30.407' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (54, 2, CAST(N'2022-05-26T20:28:56.910' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (55, 1, CAST(N'2022-05-26T20:29:57.390' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (56, 1, CAST(N'2022-05-27T15:03:49.743' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (57, 1, CAST(N'2022-05-27T15:49:52.997' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (58, 1, CAST(N'2022-05-30T01:04:34.720' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (59, 2, CAST(N'2022-05-30T01:07:04.627' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (60, 2, CAST(N'2022-05-30T01:08:39.870' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (61, 1, CAST(N'2022-05-30T01:10:55.010' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (1058, 2, CAST(N'2022-06-02T17:42:45.227' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (1059, 1, CAST(N'2022-06-05T22:08:16.470' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (1060, 1, CAST(N'2022-06-05T22:08:35.050' AS DateTime))
INSERT [dbo].[HistoryLogin] ([Id], [IdUser], [DateTime]) VALUES (1061, 1, CAST(N'2022-06-05T22:10:11.883' AS DateTime))
SET IDENTITY_INSERT [dbo].[HistoryLogin] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (1, 1, 1, 16000, NULL, NULL)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (2, 1, 2, NULL, 18000, NULL)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (3, 1, 3, NULL, 15000, NULL)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (4, 2, 2, NULL, 30000, 30000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (5, 2, 4, 18000, 28000, 30000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (6, 2, 5, NULL, NULL, 26000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (7, 2, 6, 15000, NULL, 15000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (8, 3, 2, NULL, 18000, 19000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (9, 4, 7, NULL, 35000, 35000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (10, 4, 8, NULL, 35000, 35000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (11, 5, 9, 15000, NULL, 15000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (12, 5, 10, 25000, 35000, 35000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (13, 5, 11, 15000, NULL, 15000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (14, 6, 1, 19000, NULL, NULL)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (15, 6, 5, NULL, NULL, 18000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (16, 7, 3, NULL, 16000, 16000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (17, 8, 2, NULL, NULL, 6000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (18, 9, 4, 18000, 18000, 18000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (19, 10, 4, 15000, 15000, 15000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (20, 11, 12, 16000, 16000, 16000)
INSERT [dbo].[Products] ([Id], [IdProductType], [IdBalloon], [OneLine], [TwoLine], [ThreeLine]) VALUES (24, 11, 13, NULL, 16000, 16000)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (1, N'Термальная вода', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (2, N'Дихлофос', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (3, N'Пантенол', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (4, N'Акарицид', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (5, N'Освежитель воздуха', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (6, N'Лаки', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (7, N'Муссы', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (8, N'Сухой шампунь', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (9, N'Смазка', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (10, N'Краска', 1)
INSERT [dbo].[ProductTypes] ([Id], [TypeProduct], [Actuality]) VALUES (11, N'Пена для бритья', 1)
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Type]) VALUES (1, N'Главный технолог')
INSERT [dbo].[Roles] ([Id], [Type]) VALUES (2, N'Технолог')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Patronymic], [IdRole], [Login], [Password]) VALUES (1, N'Иванов', N'Иван', N'Иванович', 1, N'Ivan', N'Ivanov')
INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Patronymic], [IdRole], [Login], [Password]) VALUES (2, N'Головатов', N'Кирилл', N'Михайлович', 2, N'Kiril', N'Golova')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[HistoryLogin]  WITH CHECK ADD  CONSTRAINT [FK_HistoryLogin_Users] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[HistoryLogin] CHECK CONSTRAINT [FK_HistoryLogin_Users]
GO
ALTER TABLE [dbo].[PlanProduction]  WITH CHECK ADD  CONSTRAINT [FK_PlanProduction_Products] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[PlanProduction] CHECK CONSTRAINT [FK_PlanProduction_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Balloons] FOREIGN KEY([IdBalloon])
REFERENCES [dbo].[Balloons] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Balloons]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductTypes] FOREIGN KEY([IdProductType])
REFERENCES [dbo].[ProductTypes] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductTypes]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [DBPlanProizv] SET  READ_WRITE 
GO
