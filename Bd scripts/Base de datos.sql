USE [master]
GO
/****** Object:  Database [proyectoprog]    Script Date: 23/11/2020 03:25:27 p. m. ******/
CREATE DATABASE [proyectoprog]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyectoprog', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\proyectoprog.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'proyectoprog_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\proyectoprog_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [proyectoprog] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyectoprog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyectoprog] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyectoprog] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyectoprog] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyectoprog] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyectoprog] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyectoprog] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyectoprog] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyectoprog] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyectoprog] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyectoprog] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyectoprog] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyectoprog] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyectoprog] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyectoprog] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyectoprog] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyectoprog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyectoprog] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyectoprog] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyectoprog] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyectoprog] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyectoprog] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyectoprog] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyectoprog] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [proyectoprog] SET  MULTI_USER 
GO
ALTER DATABASE [proyectoprog] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyectoprog] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyectoprog] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyectoprog] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [proyectoprog]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 23/11/2020 03:25:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[nombre] [varchar](30) NULL,
	[matricula] [varchar](30) NOT NULL,
	[edad] [int] NULL,
	[carrera] [varchar](30) NULL,
	[paisOri] [varchar](30) NULL,
 CONSTRAINT [matricula] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 23/11/2020 03:25:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](15) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CorreoElectronico] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loginx]    Script Date: 23/11/2020 03:25:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loginx](
	[userx] [varchar](30) NOT NULL,
	[pass] [varchar](30) NULL,
 CONSTRAINT [userx] PRIMARY KEY CLUSTERED 
(
	[userx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovientosPrestamos]    Script Date: 23/11/2020 03:25:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovientosPrestamos](
	[IdMovimientos] [int] IDENTITY(1,1) NOT NULL,
	[IdPrestamos] [int] NOT NULL,
	[MontoPendiente] [decimal](20, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMovimientos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 23/11/2020 03:25:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[IdPagos] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Prestamo] [decimal](20, 2) NOT NULL,
	[IdPrestamo] [int] NOT NULL,
	[MontoPagado] [decimal](20, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPagos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 23/11/2020 03:25:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamos](
	[IdPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[MontoPrestamo] [decimal](20, 2) NOT NULL,
	[Cedula] [varchar](15) NOT NULL,
	[Cuotas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[alumnos] ([nombre], [matricula], [edad], [carrera], [paisOri]) VALUES (N'Juan Perez', N'2019-5695', 19, N'Software', N'Republica Dominicana')
GO
INSERT [dbo].[alumnos] ([nombre], [matricula], [edad], [carrera], [paisOri]) VALUES (N'Paulina Jimenez', N'2019-7741', 20, N'Multimedia', N'Mexico')
GO
INSERT [dbo].[alumnos] ([nombre], [matricula], [edad], [carrera], [paisOri]) VALUES (N'Laura Rodriguez', N'2019-7765', 20, N'Multimedia', N'Italia')
GO
INSERT [dbo].[alumnos] ([nombre], [matricula], [edad], [carrera], [paisOri]) VALUES (N'Abiel Contreras', N'2019-8542', 18, N'Redes', N'Republica Dominicana')
GO
INSERT [dbo].[alumnos] ([nombre], [matricula], [edad], [carrera], [paisOri]) VALUES (N'Henry Cristopher', N'2019-8761', 18, N'Software', N'Republica Dominicana')
GO
INSERT [dbo].[alumnos] ([nombre], [matricula], [edad], [carrera], [paisOri]) VALUES (N'Enmanuel Jimenez', N'2019-8952', 18, N'Mecatronica', N'Republica Dominicana')
GO
INSERT [dbo].[alumnos] ([nombre], [matricula], [edad], [carrera], [paisOri]) VALUES (N'Juan Mendez', N'2019-9630', 18, N'Software', N'Republica Dominicana')
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (44, N'001-0818945-7', N'Alejandra', N'asporgeon17@webeden.co.uk', N'292 Arapahoe Center', N'499-903-5055')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (107, N'001-12345', N'Pablo', N'Pablo@gmail', N'wedwd', N'123456')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (53, N'056057', N'Hy', N'hzieme1g@flickr.com', N'6 Lindbergh Center', N'837-645-8495')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (95, N'102 46', N'Melly', N'mcoetzee2m@wufoo.com', N'5980 Sherman Way', N'624-263-1674')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (43, N'10464', N'Kristien', N'kdakhov16@theglobeandmail.com', N'7 Elka Avenue', N'718-259-4996')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (6, N'1227', N'Ranee', N'rneathway5@sourceforge.net', N'7 Dennis Parkway', N'163-216-1081')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (78, N'123 57', N'Missy', N'mmountcastle25@php.net', N'8 Sutteridge Point', N'413-377-5036')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (19, N'12700-000', N'Jamesy', N'jthirtlei@squarespace.com', N'1030 Dryden Alley', N'695-710-5466')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (39, N'164 83', N'Manuel', N'mwilber12@zdnet.com', N'954 Southridge Park', N'519-455-9771')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (71, N'175320', N'Pansie', N'pnannoni1y@vistaprint.com', N'06 Old Shore Terrace', N'755-175-5437')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (25, N'19010', N'Giffie', N'gburgeo@tripod.com', N'8405 Debra Parkway', N'615-800-0512')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (46, N'203027', N'Rosalyn', N'rmcgauhy19@wp.com', N'3715 Butterfield Point', N'996-607-1563')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (22, N'249111', N'Natalie', N'nwadlyl@ebay.com', N'3999 Gerald Way', N'176-706-6649')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (86, N'252219', N'Terrell', N'tthurner2d@ft.com', N'16 Eastwood Pass', N'954-819-0931')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (1, N'27-630', N'Evaleen', N'ewhye0@upenn.edu', N'5 Graceland Court', N'564-529-6687')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (24, N'28263', N'Michale', N'msimecekn@meetup.com', N'4 Tony Way', N'704-169-7647')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (75, N'28904', N'Garrett', N'gbreakspear22@prlog.org', N'61820 Anderson Pass', N'250-753-4217')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (93, N'332 37', N'Shem', N'sstreatfield2k@google.ca', N'475 Sherman Circle', N'277-612-2665')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (40, N'3363', N'Ulrika', N'ubullent13@flavors.me', N'1237 Forest Dale Terrace', N'839-251-5433')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (84, N'35236', N'Ruby', N'rphilliphs2b@webnode.com', N'85051 Ridgeview Hill', N'205-733-9324')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (89, N'353483', N'Giorgio', N'gmathivet2g@webeden.co.uk', N'9 Alpine Avenue', N'212-559-3372')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (80, N'361424', N'Clayborne', N'cgeerdts27@europa.eu', N'8 Delaware Park', N'872-221-9005')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (54, N'366406', N'Curt', N'cemps1h@google.de', N'9382 Waubesa Crossing', N'642-277-1811')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (50, N'38-473', N'Thom', N'tcurm1d@earthlink.net', N'9 Longview Hill', N'408-753-4818')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (35, N'40-401', N'Wynn', N'wtregidgay@jigsy.com', N'9 Farragut Avenue', N'438-462-4205')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (65, N'400036', N'Marlow', N'mdunbleton1s@sfgate.com', N'1201 Calypso Center', N'838-935-5340')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (2, N'4201', N'Jeralee', N'jkent1@wisc.edu', N'41 Crest Line Road', N'734-125-1838')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (27, N'4212', N'Charita', N'cbartropq@webeden.co.uk', N'3 Burning Wood Plaza', N'566-955-8031')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (79, N'4290', N'Brittany', N'bleverich26@facebook.com', N'9 Johnson Crossing', N'854-112-0823')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (23, N'4505-569', N'Cookie', N'climrickm@vimeo.com', N'1422 Eagan Parkway', N'684-623-4487')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (42, N'4595-414', N'Westbrooke', N'wglusby15@apache.org', N'8 Stuart Trail', N'401-239-8348')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (31, N'4755-463', N'Faustine', N'fpetrashovu@furl.net', N'5774 David Way', N'415-662-0847')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (16, N'47732', N'Pietra', N'pfilderyf@telegraph.co.uk', N'3 Clarendon Road', N'812-591-7476')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (70, N'47812', N'Elmira', N'epimbley1x@etsy.com', N'7 Darwin Street', N'812-517-3549')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (87, N'5509', N'Mackenzie', N'mmelvin2e@nationalgeographic.com', N'619 Jana Parkway', N'779-342-2161')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (38, N'5805', N'Rici', N'rmcgonigal11@feedburner.com', N'8 Jana Lane', N'718-776-4865')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (58, N'61110', N'Brooke', N'brobet1l@cbslocal.com', N'9 Di Loreto Road', N'815-465-4893')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (98, N'629008', N'Skipper', N'scozens2p@nifty.com', N'4 Monterey Lane', N'371-969-3949')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (77, N'652240', N'Robyn', N'rhowitt24@wisc.edu', N'48 Meadow Vale Parkway', N'189-910-8097')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (56, N'6530', N'Sarette', N'smacavaddy1j@independent.co.uk', N'52 Fordem Crossing', N'191-234-7812')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (96, N'658089', N'Arron', N'ajuschke2n@skyrock.com', N'0235 Mariners Cove Alley', N'630-792-9778')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (62, N'701 86', N'Perceval', N'pcovil1p@squidoo.com', N'53859 Declaration Road', N'233-778-0631')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (72, N'7104', N'Hildegarde', N'hlinnit1z@nationalgeographic.com', N'4 Anthes Court', N'502-500-8908')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (37, N'7209', N'Aurthur', N'arigmond10@sakura.ne.jp', N'85 Randy Crossing', N'189-903-8090')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (11, N'7700', N'Tucky', N'tlaverenza@diigo.com', N'6091 Ridgeway Road', N'239-115-8323')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (30, N'77800-000', N'Chicky', N'cgoort@miitbeian.gov.cn', N'8595 Morrow Alley', N'529-783-0340')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (49, N'8010', N'Delly', N'dclemenzi1c@chronoengine.com', N'2881 Bartillon Street', N'308-850-3963')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (52, N'8421', N'Cam', N'cebbers1f@java.com', N'6191 Continental Crossing', N'130-508-4932')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (61, N'9011', N'Ginevra', N'gtomkiss1o@list-manage.com', N'01 Main Plaza', N'160-438-3315')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (88, N'93350', N'Hurley', N'hcatcheside2f@imageshack.us', N'4 Forest Road', N'389-323-7950')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Cedula], [Nombre], [CorreoElectronico], [Direccion], [Telefono]) VALUES (94, N'K8H', N'Wynn', N'wjagiello2l@g.co', N'09 Kedzie Center', N'490-751-8128')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
INSERT [dbo].[loginx] ([userx], [pass]) VALUES (N'Admin', N'1234')
GO
INSERT [dbo].[loginx] ([userx], [pass]) VALUES (N'Administrador', N'1234')
GO
INSERT [dbo].[loginx] ([userx], [pass]) VALUES (N'Cris', N'1909')
GO
INSERT [dbo].[loginx] ([userx], [pass]) VALUES (N'User', N'456')
GO
SET IDENTITY_INSERT [dbo].[MovientosPrestamos] ON 
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (1, 1, CAST(2000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (2, 2, CAST(5000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (3, 3, CAST(25000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (4, 4, CAST(6000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (5, 3, CAST(15000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (6, 3, CAST(10000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (7, 1, CAST(1000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (8, 2, CAST(2500.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (9, 5, CAST(100000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (10, 5, CAST(50000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (11, 5, CAST(30000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (12, 6, CAST(25000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[MovientosPrestamos] ([IdMovimientos], [IdPrestamos], [MontoPendiente]) VALUES (13, 6, CAST(15000.00 AS Decimal(20, 2)))
GO
SET IDENTITY_INSERT [dbo].[MovientosPrestamos] OFF
GO
SET IDENTITY_INSERT [dbo].[Pagos] ON 
GO
INSERT [dbo].[Pagos] ([IdPagos], [Fecha], [Prestamo], [IdPrestamo], [MontoPagado]) VALUES (1, N'19/11/2020 01:46:00 p. m.', CAST(25000.00 AS Decimal(20, 2)), 3, CAST(15000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[Pagos] ([IdPagos], [Fecha], [Prestamo], [IdPrestamo], [MontoPagado]) VALUES (2, N'19/11/2020 01:49:00 p. m.', CAST(10000.00 AS Decimal(20, 2)), 3, CAST(10000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[Pagos] ([IdPagos], [Fecha], [Prestamo], [IdPrestamo], [MontoPagado]) VALUES (3, N'19/11/2020 03:04:41 p. m.', CAST(2000.00 AS Decimal(20, 2)), 1, CAST(1000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[Pagos] ([IdPagos], [Fecha], [Prestamo], [IdPrestamo], [MontoPagado]) VALUES (4, N'19/11/2020 09:48:32 p. m.', CAST(5000.00 AS Decimal(20, 2)), 2, CAST(2500.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[Pagos] ([IdPagos], [Fecha], [Prestamo], [IdPrestamo], [MontoPagado]) VALUES (5, N'21/11/2020 03:39:28 a. m.', CAST(100000.00 AS Decimal(20, 2)), 5, CAST(50000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[Pagos] ([IdPagos], [Fecha], [Prestamo], [IdPrestamo], [MontoPagado]) VALUES (6, N'21/11/2020 03:39:48 a. m.', CAST(50000.00 AS Decimal(20, 2)), 5, CAST(30000.00 AS Decimal(20, 2)))
GO
INSERT [dbo].[Pagos] ([IdPagos], [Fecha], [Prestamo], [IdPrestamo], [MontoPagado]) VALUES (7, N'23/11/2020 02:15:11 p. m.', CAST(25000.00 AS Decimal(20, 2)), 6, CAST(15000.00 AS Decimal(20, 2)))
GO
SET IDENTITY_INSERT [dbo].[Pagos] OFF
GO
SET IDENTITY_INSERT [dbo].[Prestamos] ON 
GO
INSERT [dbo].[Prestamos] ([IdPrestamo], [Fecha], [MontoPrestamo], [Cedula], [Cuotas]) VALUES (1, N'18/11/2020 01:34:04 p. m.', CAST(1000.00 AS Decimal(20, 2)), N'001-0818945-7', 1)
GO
INSERT [dbo].[Prestamos] ([IdPrestamo], [Fecha], [MontoPrestamo], [Cedula], [Cuotas]) VALUES (2, N'18/11/2020 01:34:16 p. m.', CAST(2500.00 AS Decimal(20, 2)), N'001-0818945-7', 1)
GO
INSERT [dbo].[Prestamos] ([IdPrestamo], [Fecha], [MontoPrestamo], [Cedula], [Cuotas]) VALUES (3, N'18/11/2020 11:00:42 p. m.', CAST(0.00 AS Decimal(20, 2)), N'658089', 0)
GO
INSERT [dbo].[Prestamos] ([IdPrestamo], [Fecha], [MontoPrestamo], [Cedula], [Cuotas]) VALUES (4, N'18/11/2020 11:00:58 p. m.', CAST(6000.00 AS Decimal(20, 2)), N'7209', 1)
GO
INSERT [dbo].[Prestamos] ([IdPrestamo], [Fecha], [MontoPrestamo], [Cedula], [Cuotas]) VALUES (5, N'21/11/2020 03:38:35 a. m.', CAST(20000.00 AS Decimal(20, 2)), N'8421', 2)
GO
INSERT [dbo].[Prestamos] ([IdPrestamo], [Fecha], [MontoPrestamo], [Cedula], [Cuotas]) VALUES (6, N'23/11/2020 02:14:12 p. m.', CAST(10000.00 AS Decimal(20, 2)), N'27-630', 2)
GO
SET IDENTITY_INSERT [dbo].[Prestamos] OFF
GO
/****** Object:  Index [UQ__Clientes__D594664312103358]    Script Date: 23/11/2020 03:25:28 p. m. ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MovientosPrestamos]  WITH CHECK ADD FOREIGN KEY([IdPrestamos])
REFERENCES [dbo].[Prestamos] ([IdPrestamo])
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD FOREIGN KEY([IdPrestamo])
REFERENCES [dbo].[Prestamos] ([IdPrestamo])
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD FOREIGN KEY([Cedula])
REFERENCES [dbo].[Clientes] ([Cedula])
GO
USE [master]
GO
ALTER DATABASE [proyectoprog] SET  READ_WRITE 
GO
