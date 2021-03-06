USE [master]
GO
/****** Object:  Database [Condominium_Portoamericas]    Script Date: 09/01/2020 10:25:11 ******/
CREATE DATABASE [Condominium_Portoamericas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Condominium_Portoamericas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DESARROLLO\MSSQL\DATA\Condominium_Portoamericas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Condominium_Portoamericas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DESARROLLO\MSSQL\DATA\Condominium_Portoamericas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Condominium_Portoamericas] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Condominium_Portoamericas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Condominium_Portoamericas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Condominium_Portoamericas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Condominium_Portoamericas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Condominium_Portoamericas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Condominium_Portoamericas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Condominium_Portoamericas] SET  MULTI_USER 
GO
ALTER DATABASE [Condominium_Portoamericas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Condominium_Portoamericas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Condominium_Portoamericas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Condominium_Portoamericas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Condominium_Portoamericas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Condominium_Portoamericas] SET QUERY_STORE = OFF
GO
USE [Condominium_Portoamericas]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Relationship] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leasing]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leasing](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProperty] [int] NOT NULL,
	[IdResidentTenant] [int] NOT NULL,
	[MoveInDate] [smalldatetime] NOT NULL,
	[LeaseStartDate] [smalldatetime] NOT NULL,
	[LeaseEndDate] [smalldatetime] NULL,
	[IdStatus] [int] NOT NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Leasing] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pet]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pet](
	[Id] [uniqueidentifier] NOT NULL,
	[IdPetType] [int] NOT NULL,
	[IdBreed] [int] NULL,
	[IdColor] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IdResident] [int] NOT NULL,
	[IdVisitor] [int] NULL,
	[IsPotentiallyDangerous] [bit] NOT NULL,
 CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Property]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Property](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdResident] [int] NOT NULL,
	[IdLocation] [int] NULL,
	[Floor] [smallint] NOT NULL,
	[Number] [smallint] NOT NULL,
	[Comments] [varchar](max) NULL,
	[IdPropertyType] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyOwner]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyOwner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProperty] [int] NOT NULL,
	[IdMasterOwner] [int] NOT NULL,
	[IdSecondaryOwner] [int] NULL,
	[AcquiredDate] [smalldatetime] NOT NULL,
	[SellingDate] [smalldatetime] NULL,
 CONSTRAINT [PK_PropertyOwner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyType]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](30) NOT NULL,
 CONSTRAINT [PK_UnitType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resident]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resident](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdDocument] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](max) NOT NULL,
	[HomePhone] [nvarchar](50) NOT NULL,
	[MobilePhone] [nvarchar](50) NOT NULL,
	[IdPartner] [int] NULL,
	[IdContact] [int] NULL,
	[IsOwner] [bit] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[Fingerprint] [varbinary](max) NULL,
 CONSTRAINT [PK_Resident] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Entity] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[Id] [uniqueidentifier] NOT NULL,
	[IdMaker] [int] NOT NULL,
	[IdModel] [int] NULL,
	[IdColor] [int] NOT NULL,
	[Plate] [nchar](20) NOT NULL,
	[IdResident] [int] NULL,
	[IdVisitor] [int] NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitor]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdDocument] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[MobilePhone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Visitor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitorLog]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitorLog](
	[Id] [int] NOT NULL,
	[IdVisitor] [int] NOT NULL,
	[IdProperty] [int] NOT NULL,
	[ArrivalTime] [datetime] NOT NULL,
	[DismissalTime] [datetime] NOT NULL,
	[IdResidentApproving] [int] NOT NULL,
	[IndexCard] [nchar](10) NULL,
	[IdVisitorParking] [int] NOT NULL,
 CONSTRAINT [PK_VisitorLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitorParking]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitorParking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [smallint] NOT NULL,
	[Zona] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_VisitorParking] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 09/01/2020 10:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PropertyType] ON 

INSERT [dbo].[PropertyType] ([Id], [Name]) VALUES (1, N'Apartmento                    ')
INSERT [dbo].[PropertyType] ([Id], [Name]) VALUES (2, N'Deposito                      ')
INSERT [dbo].[PropertyType] ([Id], [Name]) VALUES (3, N'Parqueadero                   ')
INSERT [dbo].[PropertyType] ([Id], [Name]) VALUES (4, N'Casa                          ')
SET IDENTITY_INSERT [dbo].[PropertyType] OFF
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (1, N'A la Venta', N'Property')
INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (2, N'Ocupado Propietario', N'Property')
INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (3, N'Ocupado Inquilino', N'Property')
INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (4, N'Se Arrienda', N'Property')
INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (5, N'Activo', N'Resident')
INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (6, N'Inactivo', N'Resident')
INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (7, N'Contrato Activo', N'Leasing')
INSERT [dbo].[Status] ([Id], [Name], [Entity]) VALUES (8, N'Contrato Terminado', N'Leasing')
SET IDENTITY_INSERT [dbo].[Status] OFF
ALTER TABLE [dbo].[Leasing] ADD  CONSTRAINT [DF_Leasing_Amount]  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Resident] ADD  CONSTRAINT [DF_Resident_IsOwner]  DEFAULT ((0)) FOR [IsOwner]
GO
ALTER TABLE [dbo].[Leasing]  WITH CHECK ADD  CONSTRAINT [FK_Leasing_Property] FOREIGN KEY([IdProperty])
REFERENCES [dbo].[Property] ([Id])
GO
ALTER TABLE [dbo].[Leasing] CHECK CONSTRAINT [FK_Leasing_Property]
GO
ALTER TABLE [dbo].[Leasing]  WITH CHECK ADD  CONSTRAINT [FK_Leasing_Property1] FOREIGN KEY([IdStatus])
REFERENCES [dbo].[Property] ([Id])
GO
ALTER TABLE [dbo].[Leasing] CHECK CONSTRAINT [FK_Leasing_Property1]
GO
ALTER TABLE [dbo].[Leasing]  WITH CHECK ADD  CONSTRAINT [FK_Leasing_Resident] FOREIGN KEY([IdResidentTenant])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[Leasing] CHECK CONSTRAINT [FK_Leasing_Resident]
GO
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_Resident] FOREIGN KEY([IdResident])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_Resident]
GO
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_Visitor] FOREIGN KEY([IdVisitor])
REFERENCES [dbo].[Visitor] ([Id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_Visitor]
GO
ALTER TABLE [dbo].[Property]  WITH CHECK ADD  CONSTRAINT [FK_Property_Location] FOREIGN KEY([IdLocation])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Property] CHECK CONSTRAINT [FK_Property_Location]
GO
ALTER TABLE [dbo].[Property]  WITH CHECK ADD  CONSTRAINT [FK_Property_PropertyType] FOREIGN KEY([IdPropertyType])
REFERENCES [dbo].[PropertyType] ([Id])
GO
ALTER TABLE [dbo].[Property] CHECK CONSTRAINT [FK_Property_PropertyType]
GO
ALTER TABLE [dbo].[Property]  WITH CHECK ADD  CONSTRAINT [FK_Property_Resident] FOREIGN KEY([IdResident])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[Property] CHECK CONSTRAINT [FK_Property_Resident]
GO
ALTER TABLE [dbo].[Property]  WITH CHECK ADD  CONSTRAINT [FK_Property_Status] FOREIGN KEY([IdStatus])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[Property] CHECK CONSTRAINT [FK_Property_Status]
GO
ALTER TABLE [dbo].[PropertyOwner]  WITH CHECK ADD  CONSTRAINT [FK_PropertyOwner_Property] FOREIGN KEY([IdProperty])
REFERENCES [dbo].[Property] ([Id])
GO
ALTER TABLE [dbo].[PropertyOwner] CHECK CONSTRAINT [FK_PropertyOwner_Property]
GO
ALTER TABLE [dbo].[PropertyOwner]  WITH CHECK ADD  CONSTRAINT [FK_PropertyOwner_Resident] FOREIGN KEY([IdMasterOwner])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[PropertyOwner] CHECK CONSTRAINT [FK_PropertyOwner_Resident]
GO
ALTER TABLE [dbo].[PropertyOwner]  WITH CHECK ADD  CONSTRAINT [FK_PropertyOwner_Resident1] FOREIGN KEY([IdSecondaryOwner])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[PropertyOwner] CHECK CONSTRAINT [FK_PropertyOwner_Resident1]
GO
ALTER TABLE [dbo].[Resident]  WITH CHECK ADD  CONSTRAINT [FK_Resident_Contact] FOREIGN KEY([IdContact])
REFERENCES [dbo].[Contact] ([Id])
GO
ALTER TABLE [dbo].[Resident] CHECK CONSTRAINT [FK_Resident_Contact]
GO
ALTER TABLE [dbo].[Resident]  WITH CHECK ADD  CONSTRAINT [FK_Resident_Resident] FOREIGN KEY([IdPartner])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[Resident] CHECK CONSTRAINT [FK_Resident_Resident]
GO
ALTER TABLE [dbo].[Resident]  WITH CHECK ADD  CONSTRAINT [FK_Resident_Status] FOREIGN KEY([IdStatus])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[Resident] CHECK CONSTRAINT [FK_Resident_Status]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Resident] FOREIGN KEY([IdResident])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Resident]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Visitor] FOREIGN KEY([IdVisitor])
REFERENCES [dbo].[Visitor] ([Id])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Visitor]
GO
ALTER TABLE [dbo].[VisitorLog]  WITH CHECK ADD  CONSTRAINT [FK_VisitorLog_Property] FOREIGN KEY([IdProperty])
REFERENCES [dbo].[Property] ([Id])
GO
ALTER TABLE [dbo].[VisitorLog] CHECK CONSTRAINT [FK_VisitorLog_Property]
GO
ALTER TABLE [dbo].[VisitorLog]  WITH CHECK ADD  CONSTRAINT [FK_VisitorLog_Resident] FOREIGN KEY([IdResidentApproving])
REFERENCES [dbo].[Resident] ([Id])
GO
ALTER TABLE [dbo].[VisitorLog] CHECK CONSTRAINT [FK_VisitorLog_Resident]
GO
ALTER TABLE [dbo].[VisitorLog]  WITH CHECK ADD  CONSTRAINT [FK_VisitorLog_Visitor] FOREIGN KEY([Id])
REFERENCES [dbo].[Visitor] ([Id])
GO
ALTER TABLE [dbo].[VisitorLog] CHECK CONSTRAINT [FK_VisitorLog_Visitor]
GO
ALTER TABLE [dbo].[VisitorLog]  WITH CHECK ADD  CONSTRAINT [FK_VisitorLog_VisitorParking] FOREIGN KEY([IdVisitorParking])
REFERENCES [dbo].[VisitorParking] ([Id])
GO
ALTER TABLE [dbo].[VisitorLog] CHECK CONSTRAINT [FK_VisitorLog_VisitorParking]
GO
USE [master]
GO
ALTER DATABASE [Condominium_Portoamericas] SET  READ_WRITE 
GO
