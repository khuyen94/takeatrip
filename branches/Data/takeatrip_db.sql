USE [master]
GO
/****** Object:  Database [TakeATrip]    Script Date: 7/6/2018 10:30:34 AM ******/
CREATE DATABASE [TakeATrip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TakeATrip', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TakeATrip.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TakeATrip_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TakeATrip_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TakeATrip] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TakeATrip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TakeATrip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TakeATrip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TakeATrip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TakeATrip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TakeATrip] SET ARITHABORT OFF 
GO
ALTER DATABASE [TakeATrip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TakeATrip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TakeATrip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TakeATrip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TakeATrip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TakeATrip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TakeATrip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TakeATrip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TakeATrip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TakeATrip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TakeATrip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TakeATrip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TakeATrip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TakeATrip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TakeATrip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TakeATrip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TakeATrip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TakeATrip] SET RECOVERY FULL 
GO
ALTER DATABASE [TakeATrip] SET  MULTI_USER 
GO
ALTER DATABASE [TakeATrip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TakeATrip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TakeATrip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TakeATrip] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TakeATrip] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TakeATrip', N'ON'
GO
USE [TakeATrip]
GO
/****** Object:  User [pgsc]    Script Date: 7/6/2018 10:30:34 AM ******/
CREATE USER [pgsc] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [News]    Script Date: 7/6/2018 10:30:34 AM ******/
CREATE USER [News] FOR LOGIN [News] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[UserName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Images]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourId] [int] NOT NULL,
	[Link] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourId] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[Rate] [tinyint] NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tours]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tours](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[ShortDes] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[Location] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[Views] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TourTypes]    Script Date: 7/6/2018 10:30:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_TourTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.1.0-rtm-30799')
INSERT [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Facebook', N'1723613291063516', N'Facebook', N'6aac33df-216b-4eca-88ad-0dc0590d0cfa')
INSERT [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'100607422883288366175', N'Google', N'bcc4555a-2c76-4153-b567-6be310de32a4')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'6aac33df-216b-4eca-88ad-0dc0590d0cfa', 0, N'af6f6c54-fbe6-4cf7-9988-9028436201b4', N'khuyen95@gmail.com', 0, 1, NULL, N'KHUYEN95@GMAIL.COM', N'KHUYEN95@GMAIL.COM', NULL, NULL, 0, N'NCNVSHJAYJRXAJCZ4TRIDFSRWLDLSCOU', 0, N'khuyen95@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'843f82ed-8822-4bdf-bffc-4d56da42f880', 0, N'93e98d76-aa66-434d-bac1-45e02c26f341', N'khuyen94@gmail.com', 0, 1, NULL, N'KHUYEN94@GMAIL.COM', N'KHUYEN94@GMAIL.COM', N'AQAAAAEAACcQAAAAEHGpedDuEcELoc32PXLlCFJDlvUypILvka7ylr1+Aixxnwptcwv8biTaqn+Oygn07g==', N'0965251323', 0, N'SN4Q5BYLCDU6FF56ILHJA2BMTJMAVI5B', 0, N'khuyen94@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'bcc4555a-2c76-4153-b567-6be310de32a4', 0, N'fa681286-2145-4a2c-bc27-8386dcdc9f0a', N'thangkhonnan7@gmail.com', 1, 1, NULL, N'THANGKHONNAN7@GMAIL.COM', N'THANGKHONNAN7@GMAIL.COM', NULL, NULL, 0, N'3LTUXGPQOZ6ZDMD5Z5ZHAM3HFYVKIWBN', 0, N'thangkhonnan7@gmail.com')
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([Id], [TourId], [Link], [Status], [CreatedDate], [CreatedBy]) VALUES (1, 3, N'dn_01.jpg', 1, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Images] ([Id], [TourId], [Link], [Status], [CreatedDate], [CreatedBy]) VALUES (4, 1012, N'mt_01.jpg', 1, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Images] ([Id], [TourId], [Link], [Status], [CreatedDate], [CreatedBy]) VALUES (5, 1013, N'dl_01.jpg', 1, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Images] ([Id], [TourId], [Link], [Status], [CreatedDate], [CreatedBy]) VALUES (7, 1020, N'bmt_01.jpg', 1, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Images] ([Id], [TourId], [Link], [Status], [CreatedDate], [CreatedBy]) VALUES (8, 1021, N'nt_01.jpg', 1, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Images] ([Id], [TourId], [Link], [Status], [CreatedDate], [CreatedBy]) VALUES (9, 1022, N'mt_01.jpg', 1, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
SET IDENTITY_INSERT [dbo].[Images] OFF
SET IDENTITY_INSERT [dbo].[Tours] ON 

INSERT [dbo].[Tours] ([Id], [Name], [ShortDes], [Description], [Price], [Location], [Status], [Views], [TypeId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (3, N'ĐÀ NẴNG', N'Núi Bà Nà một trong những núi đẹp nhất Đà Nẵng cùng với núi Ngũ Hành Sơn và núi Sơn Trà.
', N'Núi Bà Nà một trong những núi đẹp nhất Đà Nẵng cùng với núi Ngũ Hành Sơn và núi Sơn Trà.
', CAST(3500000.00 AS Decimal(18, 2)), N'Hồ Chí Minh', 1, 0, 3, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Tours] ([Id], [Name], [ShortDes], [Description], [Price], [Location], [Status], [Views], [TypeId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1012, N'MIỀN TÂY', N'Quý khách tập trung tại Trụ sở công ty Vietravel, khởi hành đi Bạc Liêu, đoàn tham quan ', N'Quý khách tập trung tại Trụ sở công ty Vietravel, khởi hành đi Bạc Liêu, đoàn tham quan : 
- Nhà Công Tử Bạc Liêu: Trần Trinh Huy - công tử nổi danh nhất xứ Nam Kỳ đầu thế kỷ 20, được xem là ngôi nhà bề thế nhất Nam Kỳ lục tỉnh lúc bấy giờ.
Xe khởi hành đi Cà Mau và nghỉ đêm tại Cà Mau.
', CAST(2890000.00 AS Decimal(18, 2)), N'Hồ Chí Minh', 1, 0, 3, CAST(N'2018-06-27 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Tours] ([Id], [Name], [ShortDes], [Description], [Price], [Location], [Status], [Views], [TypeId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1013, N'ĐÀ LẠT', N'Quý khách tập trung tại Vietravel (190 Pasteur, Q3, Tp.HCM), khởi hành đi Đà Lạt. ', N'Quý khách tập trung tại Vietravel (190 Pasteur, Q3, Tp.HCM), khởi hành đi Đà Lạt. Trên đường đi Quý khách dừng chân ăn sáng. Tiếp tục hành trình đến Đà Lạt, đoàn dừng ăn trưa tại khu vực Tâm Châu. Đến nơi, đoàn tham quan Nhà thờ Domain De Marie. Ăn tối và nhận phòng khách sạn. Buổi tối, Quý khách tự do tham quan Hồ Xuân Hương, thưởng thức cà phê trong không khí se lạnh của phố núi Đà Lạt. Nghỉ đêm tại Đà Lạt.', CAST(2290000.00 AS Decimal(18, 2)), N'Hồ Chí Minh', 1, 0, 3, CAST(N'2018-06-28 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Tours] ([Id], [Name], [ShortDes], [Description], [Price], [Location], [Status], [Views], [TypeId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1020, N'BUÔN MA THUỘC ', N'Khám phá Buôn Mê Thuộc - Cưỡi voi Bản Đôn', N'Quý khách tập trung tại sân bay Tân Sơn Nhất, Ga đi Trong Nước. Hướng dẫn viên làm thủ tục cho Quý khách đáp chuyến bay đi Buôn Ma Thuột. Đến sân bay, xe đón đoàn về khách sạn nhận phòng nghỉ ngơi. Buổi tối, Qúy khách có thể tự do khám phá thành phố Buôn Ma Thuột về đêm. Nghỉ đêm tại Buôn Ma Thuột.', CAST(4190000.00 AS Decimal(18, 2)), N'Hồ Chí Minh', 1, 0, 3, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Tours] ([Id], [Name], [ShortDes], [Description], [Price], [Location], [Status], [Views], [TypeId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1021, N'NHA TRANG', N'- Bãi biển Cà Ná - Một trong những bãi biển đẹp nhất miền Trung.', N'- Bãi biển Cà Ná - Một trong những bãi biển đẹp nhất miền Trung.', CAST(3990000.00 AS Decimal(18, 2)), N'Hồ Chí Minh', 1, 0, 3, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[Tours] ([Id], [Name], [ShortDes], [Description], [Price], [Location], [Status], [Views], [TypeId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1022, N'MIỀN TÂY', N'- Vườn quốc gia Tràm Chim - khu Ramsar có tầm quan trọng quốc tế.', N'- Vườn quốc gia Tràm Chim - khu Ramsar có tầm quan trọng quốc tế, xếp thứ 2.000 trên thế giới ', CAST(450000.00 AS Decimal(18, 2)), N'Hồ Chí Minh', 1, 0, 3, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
SET IDENTITY_INSERT [dbo].[Tours] OFF
SET IDENTITY_INSERT [dbo].[TourTypes] ON 

INSERT [dbo].[TourTypes] ([Id], [Name], [Status], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (3, N'Khám Phá', 1, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
INSERT [dbo].[TourTypes] ([Id], [Name], [Status], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (11, N'Mua sắm', 2, CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd', CAST(N'2018-06-08 09:19:41.610' AS DateTime), N'hungtvd')
SET IDENTITY_INSERT [dbo].[TourTypes] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_UserId]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 7/6/2018 10:30:35 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [TakeATrip] SET  READ_WRITE 
GO
