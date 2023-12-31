USE [master]
GO
/****** Object:  Database [inmobiliaria3]    Script Date: 21/11/2023 17:34:22 ******/
CREATE DATABASE [inmobiliaria3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'inmobiliaria3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\inmobiliaria3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'inmobiliaria3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\inmobiliaria3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [inmobiliaria3] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inmobiliaria3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [inmobiliaria3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [inmobiliaria3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [inmobiliaria3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [inmobiliaria3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [inmobiliaria3] SET ARITHABORT OFF 
GO
ALTER DATABASE [inmobiliaria3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [inmobiliaria3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [inmobiliaria3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [inmobiliaria3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [inmobiliaria3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [inmobiliaria3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [inmobiliaria3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [inmobiliaria3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [inmobiliaria3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [inmobiliaria3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [inmobiliaria3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [inmobiliaria3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [inmobiliaria3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [inmobiliaria3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [inmobiliaria3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [inmobiliaria3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [inmobiliaria3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [inmobiliaria3] SET RECOVERY FULL 
GO
ALTER DATABASE [inmobiliaria3] SET  MULTI_USER 
GO
ALTER DATABASE [inmobiliaria3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [inmobiliaria3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [inmobiliaria3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [inmobiliaria3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [inmobiliaria3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [inmobiliaria3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'inmobiliaria3', N'ON'
GO
ALTER DATABASE [inmobiliaria3] SET QUERY_STORE = ON
GO
ALTER DATABASE [inmobiliaria3] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [inmobiliaria3]
GO
/****** Object:  Table [dbo].[AGENTES_INMOBILIARIOS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGENTES_INMOBILIARIOS](
	[cod_agente_inmobiliario] [int] NOT NULL,
	[nombre] [varchar](200) NULL,
	[apellido] [varchar](200) NULL,
	[fecha_nacimiento] [date] NULL,
	[cuil] [varchar](16) NULL,
	[cod_barrio] [int] NULL,
	[direccion] [varchar](200) NULL,
	[nro_direccion] [int] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_AGENTES_INMOBILIARIOS] PRIMARY KEY CLUSTERED 
(
	[cod_agente_inmobiliario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ALQUILERES]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALQUILERES](
	[cod_alquiler] [int] NOT NULL,
	[cod_inmueble] [int] NOT NULL,
	[cod_cliente] [int] NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_finalizacion] [date] NOT NULL,
	[fecha_firma] [date] NOT NULL,
	[precio] [float] NULL,
	[estado_alquiler] [bit] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_ALQUILERES] PRIMARY KEY CLUSTERED 
(
	[cod_alquiler] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BARRIOS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BARRIOS](
	[cod_barrio] [int] NOT NULL,
	[nom_barrio] [varchar](200) NULL,
	[cod_localidad] [int] NOT NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_BARRIOS] PRIMARY KEY CLUSTERED 
(
	[cod_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[cod_cliente] [int] NOT NULL,
	[nombre] [varchar](200) NULL,
	[apellido] [varchar](200) NULL,
	[fecha_nacimiento] [date] NULL,
	[documento] [varchar](16) NULL,
	[cuil] [varchar](16) NULL,
	[fecha_registro] [date] NULL,
	[cod_barrio] [int] NULL,
	[direccion] [varchar](200) NULL,
	[nro_direccion] [int] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[cod_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONTACTOS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTACTOS](
	[cod_contacto] [int] NOT NULL,
	[cod_cliente] [int] NULL,
	[cod_agente_inmobiliario] [int] NULL,
	[cod_propietario] [int] NULL,
	[contacto] [varchar](200) NULL,
	[cod_tipo_contacto] [int] NOT NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_CONTACTOS] PRIMARY KEY CLUSTERED 
(
	[cod_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONTRATOS_INTERMEDIACION]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTRATOS_INTERMEDIACION](
	[cod_contrato_intermediacion] [int] NOT NULL,
	[cod_propietario] [int] NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_finalizacion] [date] NOT NULL,
	[porcentaje_comision] [float] NOT NULL,
	[cod_tipo_contrato] [int] NOT NULL,
	[activo] [bit] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_CONTRATOS_INTERMEDIACION] PRIMARY KEY CLUSTERED 
(
	[cod_contrato_intermediacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES_FACTURAS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_FACTURAS](
	[nro_detalle_factura] [int] NOT NULL,
	[nro_factura] [int] NOT NULL,
	[cod_inmueble] [int] NOT NULL,
	[precio] [float] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_DETALLES_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[nro_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURAS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURAS](
	[nro_factura] [int] NOT NULL,
	[fecha_factura] [date] NULL,
	[cod_agente_inmobiliario] [int] NOT NULL,
	[cod_cliente] [int] NOT NULL,
	[comision_cliente] [float] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[nro_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURAS_ALQUILERES]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURAS_ALQUILERES](
	[cod_factura_alquiler] [int] NOT NULL,
	[nro_factura] [int] NOT NULL,
	[cod_alquiler] [int] NOT NULL,
	[nro_cuota] [int] NOT NULL,
	[precio] [float] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_FACTURAS_ALQUILERES] PRIMARY KEY CLUSTERED 
(
	[cod_factura_alquiler] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FORMAS_PAGOS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FORMAS_PAGOS](
	[cod_forma_pago] [int] NOT NULL,
	[forma_pago] [varchar](200) NULL,
	[recargo] [float] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_FORMAS_PAGOS] PRIMARY KEY CLUSTERED 
(
	[cod_forma_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FORMAS_PAGOS_FACTURAS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FORMAS_PAGOS_FACTURAS](
	[cod_forma_pago_factura] [int] NOT NULL,
	[cod_forma_pago] [int] NOT NULL,
	[nro_factura] [int] NOT NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_FORMAS_PAGOS_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[cod_forma_pago_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INMUEBLES]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INMUEBLES](
	[cod_inmueble] [int] NOT NULL,
	[superficie] [float] NOT NULL,
	[año_construccion] [int] NULL,
	[descripcion] [varchar](200) NULL,
	[cod_tipo_inmueble] [int] NOT NULL,
	[cod_barrio] [int] NULL,
	[direccion] [varchar](200) NULL,
	[nro_direccion] [int] NULL,
	[cod_contrato_intermediacion] [int] NOT NULL,
	[precio] [float] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_INMUEBLES] PRIMARY KEY CLUSTERED 
(
	[cod_inmueble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOCALIDADES]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOCALIDADES](
	[cod_localidad] [int] NOT NULL,
	[nom_localidad] [varchar](200) NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_LOCALIDADES] PRIMARY KEY CLUSTERED 
(
	[cod_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROPIETARIOS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROPIETARIOS](
	[cod_propietario] [int] NOT NULL,
	[nombre] [varchar](200) NULL,
	[apellido] [varchar](200) NULL,
	[cuil] [varchar](16) NOT NULL,
	[cod_barrio] [int] NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_PROPIETARIOS] PRIMARY KEY CLUSTERED 
(
	[cod_propietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_CONTACTOS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_CONTACTOS](
	[cod_tipo_contacto] [int] NOT NULL,
	[tipo_contacto] [varchar](200) NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_TIPOS_CONTACTOS] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_CONTRATOS]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_CONTRATOS](
	[cod_tipo_contrato] [int] NOT NULL,
	[tipo_contrato] [varchar](200) NOT NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_TIPOS_CONTRATOS] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_contrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_INMUEBLES]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_INMUEBLES](
	[cod_tipo_inmueble] [int] NOT NULL,
	[tipo_inmueble] [varchar](200) NULL,
	[cod_usuario] [int] NULL,
 CONSTRAINT [PK_TIPOS_INMUEBLES] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_inmueble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/11/2023 17:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[cod_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
 CONSTRAINT [pk_usuarios] PRIMARY KEY CLUSTERED 
(
	[cod_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (1, N'Juan', N'Pérez', CAST(N'1990-03-15' AS Date), N'20-20345678-1', 1, N'San Juan', 123, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (2, N'María', N'González', CAST(N'1985-07-20' AS Date), N'27-98765432-2', 2, N'Buenos Aires', 456, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (3, N'Luis', N'Martínez', CAST(N'1988-12-10' AS Date), N'18-34432109-3', 1, N'Rosario', 789, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (4, N'Ana', N'Rodríguez', CAST(N'1992-06-25' AS Date), N'15-20112222-4', 3, N'Mendoza', 1011, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (5, N'Pedro', N'López', CAST(N'1986-04-02' AS Date), N'16-14556666-5', 2, N'Tucumán', 1314, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (6, N'Laura', N'Fernández', CAST(N'1991-09-28' AS Date), N'19-20990000-6', 3, N'Córdoba', 1617, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (7, N'Diego', N'Torres', CAST(N'1987-03-07' AS Date), N'17-12344321-7', 1, N'San Lorenzo', 1920, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (8, N'Silvia', N'Hernández', CAST(N'1995-12-18' AS Date), N'22-98761234-8', 2, N'San Jerónimo', 2223, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (9, N'Carlos', N'Martínez', CAST(N'1989-08-15' AS Date), N'20-25887777-9', 1, N'9 de Julio', 2526, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (10, N'Marta', N'Sánchez', CAST(N'1994-05-30' AS Date), N'15-18113333-0', 3, N'Laprida', 2829, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (11, N'Javier', N'Gómez', CAST(N'1989-11-05' AS Date), N'16-22224444-1', 2, N'Santa Rosa', 3132, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (12, N'Elena', N'Ramírez', CAST(N'1997-07-20' AS Date), N'17-25335555-2', 1, N'Dean Funes', 3435, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (13, N'Gustavo', N'Fernández', CAST(N'1983-02-12' AS Date), N'20-44446666-3', 3, N'Maipú', 3738, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (14, N'Cecilia', N'Díaz', CAST(N'1996-03-19' AS Date), N'18-35553333-4', 2, N'25 de Mayo', 4041, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (15, N'Martín', N'Luna', CAST(N'1982-09-10' AS Date), N'19-34661111-5', 1, N'General Paz', 4344, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (16, N'Marcela', N'Soto', CAST(N'1990-01-28' AS Date), N'15-19772222-6', 3, N'Obispo Trejo', 4647, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (17, N'Roberto', N'Ortega', CAST(N'1985-07-04' AS Date), N'19-38889999-7', 2, N'San Francisco', 4950, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (18, N'Lorena', N'Rojas', CAST(N'1993-06-15' AS Date), N'16-28998888-8', 1, N'San Martín', 5253, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (19, N'Santiago', N'Cruz', CAST(N'1987-04-30' AS Date), N'19-27001111-9', 3, N'Santa Isabel', 5556, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (20, N'Valentina', N'Giménez', CAST(N'1998-08-25' AS Date), N'20-44110000-0', 2, N'Ayacucho', 5859, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (21, N'Pablo', N'Suárez', CAST(N'1984-10-10' AS Date), N'18-23225373-1', 1, N'Independencia', 6162, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (22, N'Carolina', N'Dominguez', CAST(N'1991-05-07' AS Date), N'18-33231894-2', 3, N'Belgrano', 6465, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (23, N'Fernando', N'Navarro', CAST(N'1989-07-18' AS Date), N'20-44445555-3', 2, N'Avellaneda', 6768, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (24, N'Andrea', N'López', CAST(N'1982-08-26' AS Date), N'16-20556666-4', 1, N'Av.Juan B. Justo', 7071, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (25, N'Jorge', N'García', CAST(N'1995-03-22' AS Date), N'19-38667777-5', 3, N'Colón', 7374, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (26, N'Sofía', N'Martínez', CAST(N'1987-06-13' AS Date), N'16-18778888-6', 2, N'Rioja', 7677, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (27, N'Andrés', N'Torres', CAST(N'1992-07-05' AS Date), N'20-43889999-7', 1, N'Balcarce', 7980, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (28, N'Camila', N'Sánchez', CAST(N'1980-01-14' AS Date), N'20-42990000-8', 3, N'Chacabuco', 8283, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (29, N'Eduardo', N'Gómez', CAST(N'1988-12-08' AS Date), N'19-21001111-9', 2, N'Santa Fe', 8586, 1)
INSERT [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario], [nombre], [apellido], [fecha_nacimiento], [cuil], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (30, N'Paola', N'Hernández', CAST(N'1994-04-03' AS Date), N'17-38110096-0', 1, N'Laplace', 8889, 1)
GO
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (1, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date), CAST(N'2020-12-01' AS Date), 42714.84375, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (2, 2, 2, CAST(N'2022-02-01' AS Date), CAST(N'2025-01-31' AS Date), CAST(N'2022-01-01' AS Date), 52734.375, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (3, 3, 3, CAST(N'2020-03-01' AS Date), CAST(N'2023-02-28' AS Date), CAST(N'2020-02-01' AS Date), 189843.75, 0, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (4, 4, 4, CAST(N'2023-04-01' AS Date), CAST(N'2023-09-30' AS Date), CAST(N'2023-03-25' AS Date), 21875, 0, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (5, 5, 5, CAST(N'2021-05-01' AS Date), CAST(N'2024-04-30' AS Date), CAST(N'2021-04-01' AS Date), 234931.640625, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (6, 6, 6, CAST(N'2022-06-01' AS Date), CAST(N'2025-05-31' AS Date), CAST(N'2022-05-01' AS Date), 39375, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (7, 7, 7, CAST(N'2020-07-01' AS Date), CAST(N'2022-06-30' AS Date), CAST(N'2019-06-29' AS Date), 67500, 0, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (8, 8, 8, CAST(N'2021-08-01' AS Date), CAST(N'2024-07-31' AS Date), CAST(N'2021-07-01' AS Date), 69609.375, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (9, 9, 9, CAST(N'2020-09-01' AS Date), CAST(N'2023-08-31' AS Date), CAST(N'2020-08-01' AS Date), 37968.75, 0, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (10, 10, 10, CAST(N'2020-10-01' AS Date), CAST(N'2021-03-31' AS Date), CAST(N'2020-09-22' AS Date), 23750, 0, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (11, 11, 11, CAST(N'2023-10-01' AS Date), CAST(N'2026-09-30' AS Date), CAST(N'2023-09-01' AS Date), 18750, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (12, 12, 12, CAST(N'2020-12-01' AS Date), CAST(N'2023-11-30' AS Date), CAST(N'2020-11-01' AS Date), 47223.6328125, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (13, 13, 13, CAST(N'2022-01-01' AS Date), CAST(N'2022-06-30' AS Date), CAST(N'2021-12-30' AS Date), 15000, 0, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (14, 14, 14, CAST(N'2023-09-01' AS Date), CAST(N'2026-08-31' AS Date), CAST(N'2023-08-01' AS Date), 5312.5, 1, 1)
INSERT [dbo].[ALQUILERES] ([cod_alquiler], [cod_inmueble], [cod_cliente], [fecha_inicio], [fecha_finalizacion], [fecha_firma], [precio], [estado_alquiler], [cod_usuario]) VALUES (15, 15, 15, CAST(N'2020-03-01' AS Date), CAST(N'2023-02-28' AS Date), CAST(N'2020-02-01' AS Date), 151875, 0, 1)
GO
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (1, N'Nueva Córdoba', 1, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (2, N'Alberdi', 1, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (3, N'Centro', 1, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (4, N'Güemes', 1, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (5, N'General Paz', 1, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (6, N'San Vicente', 1, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (7, N'Los Naranjos', 2, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (8, N'Cofico', 2, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (9, N'Altos de Villa Cabrera', 2, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (10, N'Villa Belgrano', 2, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (11, N'Villa Warcalde', 3, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (12, N'Villa Revol', 3, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (13, N'Argüello', 3, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (14, N'Quebrada de las Rosas', 3, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (15, N'Ciudad Universitaria', 3, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (16, N'Las Palmas', 4, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (17, N'Villa Retiro', 4, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (18, N'Marqués de Sobremonte', 4, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (19, N'General Bustos', 5, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (20, N'Pueyrredón', 5, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (21, N'San Vicente Este', 6, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (22, N'Alto Alberdi', 6, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (23, N'Villa Cabrera', 7, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (24, N'Villa El Libertador', 7, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (25, N'San Martín', 8, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (26, N'Colonia Lola', 8, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (27, N'Gral. Bustos', 9, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (28, N'Noroeste', 9, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (29, N'Los Boulevares', 10, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (30, N'Los Álamos', 10, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (31, N'Bº Jardín', 11, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (32, N'Los Nogales', 11, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (33, N'Las Violetas', 12, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (34, N'Gral. Urquiza', 12, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (35, N'Santa Rosa', 13, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (36, N'Villa Azalais', 13, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (37, N'Parque Liceo', 14, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (38, N'San Ignacio', 14, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (39, N'Ituzaingó Anexo', 15, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (40, N'San Lorenzo', 15, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (41, N'San Fernando', 16, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (42, N'Lomas Oeste', 16, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (43, N'Juniors', 17, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (44, N'Villa El Libertador', 17, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (45, N'Los Olmos', 18, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (46, N'Los Álamos', 18, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (47, N'San Nicolás', 19, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (48, N'Villa Revol', 19, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (49, N'Guiñazú', 20, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (50, N'Los Filtros', 20, 1)
INSERT [dbo].[BARRIOS] ([cod_barrio], [nom_barrio], [cod_localidad], [cod_usuario]) VALUES (51, N'San Lorenzo Sur', 1, 1)
GO
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (1, N'Juan', N'Gómez', CAST(N'1980-06-15' AS Date), N'20345678', N'18-20345678-1', CAST(N'2020-09-07' AS Date), 1, N'Obispo Trejo', 123, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (2, N'María', N'Rodríguez', CAST(N'1995-03-22' AS Date), N'31765432', N'27-31765432-2', CAST(N'2019-09-07' AS Date), 2, N'Artigas', 456, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (3, N'Luis', N'Martínez', CAST(N'1988-09-05' AS Date), N'21443322', N'20-21443322-3', CAST(N'2020-09-07' AS Date), 3, N'Ituzaingo', 789, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (4, N'Ana', N'López', CAST(N'1990-12-11' AS Date), N'32556677', N'27-32556677-4', CAST(N'2020-09-07' AS Date), 4, N'Marcelo T de Alvear', 1011, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (5, N'Javier', N'Pérez', CAST(N'1998-04-30' AS Date), N'33221100', N'20-33221100-5', CAST(N'2022-10-25' AS Date), 5, N'Juan Garay', 1213, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (6, N'Laura', N'Díaz', CAST(N'1985-07-02' AS Date), N'19887777', N'27-19887777-6', CAST(N'2019-01-11' AS Date), 6, N'Tristan Narvaja', 1415, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (7, N'Carlos', N'Sánchez', CAST(N'1993-11-17' AS Date), N'26223344', N'20-26223344-7', CAST(N'2018-09-15' AS Date), 7, N'Gilardo Gilardi', 1617, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (8, N'Sofía', N'García', CAST(N'1982-05-24' AS Date), N'19669999', N'27-19669999-8', CAST(N'2019-08-12' AS Date), 8, N'Faustino Allende', 1819, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (9, N'Alejandro', N'Fernández', CAST(N'1997-08-29' AS Date), N'20776666', N'20-20776666-9', CAST(N'2023-07-09' AS Date), 9, N'Domingo Zipoli', 2021, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (10, N'Elena', N'Torres', CAST(N'1994-02-14' AS Date), N'20553333', N'27-20553333-0', CAST(N'2022-04-04' AS Date), 10, N'Lasalle', 2223, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (11, N'Lucas', N'Ramírez', CAST(N'1999-06-03' AS Date), N'31112222', N'20-31112222-1', CAST(N'2023-06-06' AS Date), 11, N'Molino de Torres', 2425, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (12, N'Cecilia', N'Hernández', CAST(N'1992-09-18' AS Date), N'28332222', N'27-28332222-2', CAST(N'2023-01-01' AS Date), 12, N'Baradero', 2627, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (13, N'Diego', N'Silva', CAST(N'1987-11-26' AS Date), N'18667777', N'20-18667777-3', CAST(N'2023-02-02' AS Date), 13, N'Miguel Vera', 2829, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (14, N'Valentina', N'Gómez', CAST(N'1996-04-10' AS Date), N'34993333', N'27-34993333-4', CAST(N'2023-03-03' AS Date), 14, N'Cumpeo', 3031, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (15, N'Manuel', N'Pérez', CAST(N'1984-02-20' AS Date), N'20553333', N'20-20553333-5', CAST(N'2023-04-04' AS Date), 15, N'Ambrosio Olmos', 3233, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (16, N'Camila', N'López', CAST(N'1993-08-14' AS Date), N'19774444', N'27-19774444-6', CAST(N'2019-05-05' AS Date), 16, N'Juan Garcia Martinez', 3435, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (17, N'Carlos', N'Fernández', CAST(N'1991-03-07' AS Date), N'17885555', N'20-17885555-7', CAST(N'2021-06-06' AS Date), 1, N'Calle 5', 3637, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (18, N'Isabella', N'Sánchez', CAST(N'1986-12-31' AS Date), N'19446666', N'27-22446666-8', CAST(N'2019-07-07' AS Date), 18, N'Buenos Aires', 3839, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (19, N'Lucía', N'Torres', CAST(N'1998-05-15' AS Date), N'35347777', N'27-35347777-9', CAST(N'2021-08-08' AS Date), 19, N'Calle 19', 4041, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (20, N'Carlos', N'Herrera', CAST(N'1997-10-27' AS Date), N'35996666', N'20-35996666-0', CAST(N'2021-09-09' AS Date), 20, N'Nores Martinez', 4243, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (21, N'Valentino', N'Morales', CAST(N'1983-07-23' AS Date), N'18774444', N'20-18774444-1', CAST(N'2019-10-10' AS Date), 21, N'Cochabamba', 4445, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (22, N'Luna', N'González', CAST(N'1989-02-16' AS Date), N'19112222', N'27-19112222-2', CAST(N'2019-11-11' AS Date), 22, N'Jose de Calasanz', 4647, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (23, N'Nicolás', N'Díaz', CAST(N'1990-08-05' AS Date), N'38667777', N'20-38667777-3', CAST(N'2023-12-12' AS Date), 23, N'Manuel Gorriti', 4849, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (24, N'Mía', N'Castro', CAST(N'1995-11-30' AS Date), N'39553333', N'27-39553333-4', CAST(N'2023-01-12' AS Date), 24, N'La Paz', 5051, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (25, N'Eduardo', N'Andrade', CAST(N'1992-04-02' AS Date), N'36446666', N'20-36446666-5', CAST(N'2022-02-11' AS Date), 25, N'Ortiz Barboza', 5253, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (26, N'Olivia', N'Rojas', CAST(N'1988-03-15' AS Date), N'25347777', N'27-25347777-6', CAST(N'2022-03-10' AS Date), 1, N'San Martin', 5455, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (27, N'Juan Pablo', N'Fuentes', CAST(N'1997-06-11' AS Date), N'40996666', N'20-40996666-7', CAST(N'2022-10-09' AS Date), 27, N'Gallardo', 5657, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (28, N'Carolina', N'Navarro', CAST(N'1994-12-18' AS Date), N'38774444', N'27-38774444-8', CAST(N'2023-09-07' AS Date), 28, N'Corrientes', 5859, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (29, N'Martín', N'Giménez', CAST(N'1985-02-22' AS Date), N'27112222', N'20-27112222-9', CAST(N'2023-09-07' AS Date), 29, N'Las Moras', 6061, 1)
INSERT [dbo].[CLIENTES] ([cod_cliente], [nombre], [apellido], [fecha_nacimiento], [documento], [cuil], [fecha_registro], [cod_barrio], [direccion], [nro_direccion], [cod_usuario]) VALUES (30, N'Isabel', N'Ortiz', CAST(N'1996-07-04' AS Date), N'30667777', N'27-30667777-0', CAST(N'2023-09-07' AS Date), 30, N'Cataluña', 6263, 1)
GO
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (1, 5, 1, 1, N'3516808103', 1, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (2, 6, 2, 2, N'fefe@gmail.com', 2, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (3, 7, 3, 3, N'instagram', 3, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (4, 8, 4, 4, N'3516354556', 4, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (5, 9, 5, 5, N'master42.com.ar', 5, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (6, 10, 6, 6, N'', 6, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (7, 11, 7, 7, N'3516908103', 1, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (8, 12, 8, 8, N'retee@gmail.com', 2, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (9, 13, 9, 9, N'facebook', 3, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (10, 14, 10, 10, N'3516399556', 4, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (11, 15, 11, 11, N'lobaso.com.ar', 5, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (12, 16, 12, 12, N'3518399556', 1, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (13, 17, 13, 13, N'3516399588', 1, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (14, 18, 14, 14, N'juju@gmail.com', 2, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (15, 19, 15, 15, N'x', 3, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (16, 20, 16, 16, N'3516339556', 4, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (17, 21, 17, 17, N'contacto17', 4, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (18, 22, 18, 18, N'', 6, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (19, 23, 19, 19, N'3516336656', 4, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (20, 24, 20, 20, N'3516370556', 4, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (21, 25, 21, 21, N'lala@gmail.com', 2, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (22, 25, 22, 22, N'toto@gmail.com', 2, 1)
INSERT [dbo].[CONTACTOS] ([cod_contacto], [cod_cliente], [cod_agente_inmobiliario], [cod_propietario], [contacto], [cod_tipo_contacto], [cod_usuario]) VALUES (23, 25, 23, 23, N'3516320556', 4, 1)
GO
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (1, 1, CAST(N'2019-12-01' AS Date), CAST(N'2020-12-01' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (2, 2, CAST(N'2020-06-10' AS Date), CAST(N'2021-06-10' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (3, 3, CAST(N'2018-11-05' AS Date), CAST(N'2019-11-05' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (4, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-01' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (5, 5, CAST(N'2020-04-03' AS Date), CAST(N'2020-10-03' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (6, 6, CAST(N'2021-04-15' AS Date), CAST(N'2022-04-15' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (7, 7, CAST(N'2019-07-10' AS Date), CAST(N'2020-07-10' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (8, 8, CAST(N'2020-06-01' AS Date), CAST(N'2021-06-01' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (9, 9, CAST(N'2019-05-01' AS Date), CAST(N'2020-05-01' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (10, 10, CAST(N'2020-08-20' AS Date), CAST(N'2021-08-20' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (11, 11, CAST(N'2023-08-15' AS Date), CAST(N'2024-08-15' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (12, 12, CAST(N'2019-09-10' AS Date), CAST(N'2020-09-10' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (13, 13, CAST(N'2021-11-05' AS Date), CAST(N'2022-11-05' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (14, 14, CAST(N'2023-06-01' AS Date), CAST(N'2023-12-01' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (15, 15, CAST(N'2018-03-20' AS Date), CAST(N'2019-03-20' AS Date), 0.1, 1, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (16, 16, CAST(N'2021-04-15' AS Date), CAST(N'2024-03-15' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (17, 17, CAST(N'2021-05-10' AS Date), CAST(N'2023-01-10' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (18, 18, CAST(N'2021-12-05' AS Date), CAST(N'2023-08-05' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (19, 19, CAST(N'2022-01-01' AS Date), CAST(N'2023-09-01' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (20, 20, CAST(N'2022-07-20' AS Date), CAST(N'2023-12-20' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (21, 21, CAST(N'2022-06-15' AS Date), CAST(N'2024-03-15' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (22, 22, CAST(N'2022-11-10' AS Date), CAST(N'2025-11-10' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (23, 23, CAST(N'2022-09-05' AS Date), CAST(N'2023-09-05' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (24, 24, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-01' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (25, 25, CAST(N'2022-10-20' AS Date), CAST(N'2024-10-20' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (26, 26, CAST(N'2021-12-15' AS Date), CAST(N'2025-05-15' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (27, 27, CAST(N'2022-06-10' AS Date), CAST(N'2023-06-10' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (28, 28, CAST(N'2022-08-05' AS Date), CAST(N'2023-08-05' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (29, 29, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-01' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (30, 30, CAST(N'2022-11-20' AS Date), CAST(N'2023-11-20' AS Date), 0.03, 2, 0, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (31, 31, CAST(N'2022-12-20' AS Date), CAST(N'2024-11-15' AS Date), 0.03, 2, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (32, 32, CAST(N'2020-12-20' AS Date), CAST(N'2025-11-15' AS Date), 0.03, 2, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (33, 33, CAST(N'2019-07-20' AS Date), CAST(N'2026-12-07' AS Date), 0.03, 2, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (34, 34, CAST(N'2021-01-20' AS Date), CAST(N'2024-11-23' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (35, 35, CAST(N'2022-01-20' AS Date), CAST(N'2026-11-29' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (36, 36, CAST(N'2019-12-20' AS Date), CAST(N'2024-11-13' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (37, 37, CAST(N'2023-01-20' AS Date), CAST(N'2026-01-03' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (38, 38, CAST(N'2019-01-20' AS Date), CAST(N'2023-12-15' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (39, 39, CAST(N'2020-01-20' AS Date), CAST(N'2024-01-12' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (40, 40, CAST(N'2020-02-20' AS Date), CAST(N'2023-12-28' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (41, 1, CAST(N'2022-04-10' AS Date), CAST(N'2024-04-09' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (42, 2, CAST(N'2022-05-11' AS Date), CAST(N'2024-05-10' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (43, 5, CAST(N'2022-06-12' AS Date), CAST(N'2024-06-11' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (44, 11, CAST(N'2022-07-13' AS Date), CAST(N'2024-07-12' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (45, 1, CAST(N'2022-08-14' AS Date), CAST(N'2024-08-13' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (46, 2, CAST(N'2022-09-15' AS Date), CAST(N'2024-09-14' AS Date), 0.03, 2, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (47, 5, CAST(N'2022-10-16' AS Date), CAST(N'2024-10-15' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (48, 11, CAST(N'2022-11-17' AS Date), CAST(N'2024-11-16' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (49, 1, CAST(N'2022-12-18' AS Date), CAST(N'2024-12-17' AS Date), 0.03, 2, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (50, 2, CAST(N'2022-01-19' AS Date), CAST(N'2024-01-18' AS Date), 0.1, 1, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (51, 20, CAST(N'2022-02-20' AS Date), CAST(N'2024-02-19' AS Date), 0.03, 2, 1, 1)
INSERT [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion], [cod_propietario], [fecha_inicio], [fecha_finalizacion], [porcentaje_comision], [cod_tipo_contrato], [activo], [cod_usuario]) VALUES (52, 18, CAST(N'2022-03-21' AS Date), CAST(N'2024-03-20' AS Date), 0.1, 1, 1, 1)
GO
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (1, 326, 16, 125000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (2, 327, 17, 260000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (3, 328, 18, 600000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (4, 329, 19, 310000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (5, 330, 20, 530000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (6, 331, 21, 320000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (7, 332, 22, 480000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (8, 333, 23, 60000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (9, 334, 24, 160000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (10, 335, 25, 380000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (11, 336, 26, 120000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (12, 337, 27, 280000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (13, 338, 28, 520000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (14, 339, 29, 360000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (15, 340, 30, 140000, 1)
INSERT [dbo].[DETALLES_FACTURAS] ([nro_detalle_factura], [nro_factura], [cod_inmueble], [precio], [cod_usuario]) VALUES (16, 341, 34, 260000, 1)
GO
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (1, CAST(N'2021-01-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (2, CAST(N'2021-02-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (3, CAST(N'2021-03-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (4, CAST(N'2021-04-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (5, CAST(N'2021-05-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (6, CAST(N'2021-06-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (7, CAST(N'2021-07-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (8, CAST(N'2021-08-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (9, CAST(N'2021-09-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (10, CAST(N'2021-10-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (11, CAST(N'2021-11-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (12, CAST(N'2021-12-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (13, CAST(N'2022-01-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (14, CAST(N'2022-02-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (15, CAST(N'2022-03-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (16, CAST(N'2022-04-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (17, CAST(N'2022-05-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (18, CAST(N'2022-06-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (19, CAST(N'2022-07-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (20, CAST(N'2022-08-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (21, CAST(N'2022-09-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (22, CAST(N'2022-10-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (23, CAST(N'2022-11-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (24, CAST(N'2022-12-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (25, CAST(N'2023-01-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (26, CAST(N'2023-02-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (27, CAST(N'2023-03-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (28, CAST(N'2023-04-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (29, CAST(N'2023-05-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (30, CAST(N'2023-06-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (31, CAST(N'2023-07-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (32, CAST(N'2023-08-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (33, CAST(N'2023-09-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (34, CAST(N'2023-10-01' AS Date), 1, 1, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (35, CAST(N'2022-02-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (36, CAST(N'2022-03-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (37, CAST(N'2022-04-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (38, CAST(N'2022-05-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (39, CAST(N'2022-06-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (40, CAST(N'2022-07-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (41, CAST(N'2022-08-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (42, CAST(N'2022-09-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (43, CAST(N'2022-10-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (44, CAST(N'2022-11-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (45, CAST(N'2022-12-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (46, CAST(N'2023-01-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (47, CAST(N'2023-02-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (48, CAST(N'2023-03-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (49, CAST(N'2023-04-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (50, CAST(N'2023-05-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (51, CAST(N'2023-06-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (52, CAST(N'2023-07-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (53, CAST(N'2023-08-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (54, CAST(N'2023-09-01' AS Date), 2, 2, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (57, CAST(N'2021-05-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (58, CAST(N'2021-06-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (59, CAST(N'2021-07-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (60, CAST(N'2021-08-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (61, CAST(N'2021-09-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (62, CAST(N'2021-10-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (63, CAST(N'2021-11-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (64, CAST(N'2021-12-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (65, CAST(N'2022-01-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (66, CAST(N'2022-02-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (67, CAST(N'2022-03-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (68, CAST(N'2022-04-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (69, CAST(N'2022-05-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (70, CAST(N'2022-06-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (71, CAST(N'2022-07-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (72, CAST(N'2022-08-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (73, CAST(N'2022-09-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (74, CAST(N'2022-10-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (75, CAST(N'2022-11-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (76, CAST(N'2022-12-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (77, CAST(N'2023-01-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (78, CAST(N'2023-02-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (79, CAST(N'2023-03-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (80, CAST(N'2023-04-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (81, CAST(N'2023-05-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (82, CAST(N'2023-06-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (83, CAST(N'2023-07-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (84, CAST(N'2023-08-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (85, CAST(N'2023-09-01' AS Date), 5, 5, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (88, CAST(N'2022-06-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (89, CAST(N'2022-07-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (90, CAST(N'2022-08-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (91, CAST(N'2022-09-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (92, CAST(N'2022-10-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (93, CAST(N'2022-11-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (94, CAST(N'2022-12-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (95, CAST(N'2023-01-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (96, CAST(N'2023-02-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (97, CAST(N'2023-03-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (98, CAST(N'2023-04-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (99, CAST(N'2023-05-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (100, CAST(N'2023-06-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (101, CAST(N'2023-07-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (102, CAST(N'2023-08-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (103, CAST(N'2023-09-01' AS Date), 6, 6, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (104, CAST(N'2023-10-01' AS Date), 6, 6, 0.05, 1)
GO
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (107, CAST(N'2021-09-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (108, CAST(N'2021-10-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (109, CAST(N'2021-11-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (110, CAST(N'2021-12-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (111, CAST(N'2022-01-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (112, CAST(N'2022-02-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (113, CAST(N'2022-03-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (114, CAST(N'2022-04-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (115, CAST(N'2022-05-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (116, CAST(N'2022-06-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (117, CAST(N'2022-07-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (118, CAST(N'2022-08-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (119, CAST(N'2022-09-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (120, CAST(N'2022-10-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (121, CAST(N'2022-11-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (122, CAST(N'2022-12-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (123, CAST(N'2023-01-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (124, CAST(N'2023-02-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (125, CAST(N'2023-03-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (126, CAST(N'2023-04-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (127, CAST(N'2023-05-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (128, CAST(N'2023-06-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (129, CAST(N'2023-07-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (130, CAST(N'2023-08-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (131, CAST(N'2023-09-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (132, CAST(N'2023-10-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (133, CAST(N'2023-11-01' AS Date), 8, 8, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (134, CAST(N'2023-10-01' AS Date), 11, 11, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (135, CAST(N'2023-11-01' AS Date), 11, 11, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (136, CAST(N'2020-12-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (137, CAST(N'2021-01-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (138, CAST(N'2021-02-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (139, CAST(N'2021-03-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (140, CAST(N'2021-04-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (141, CAST(N'2021-05-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (142, CAST(N'2021-06-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (143, CAST(N'2021-07-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (144, CAST(N'2021-08-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (145, CAST(N'2021-09-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (146, CAST(N'2021-10-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (147, CAST(N'2021-11-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (148, CAST(N'2021-12-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (149, CAST(N'2022-01-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (150, CAST(N'2022-02-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (151, CAST(N'2022-03-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (152, CAST(N'2022-04-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (153, CAST(N'2022-05-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (154, CAST(N'2022-06-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (155, CAST(N'2022-07-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (156, CAST(N'2022-08-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (157, CAST(N'2022-09-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (158, CAST(N'2022-10-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (159, CAST(N'2022-11-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (160, CAST(N'2022-12-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (161, CAST(N'2023-01-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (162, CAST(N'2023-02-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (163, CAST(N'2023-03-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (164, CAST(N'2023-04-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (165, CAST(N'2023-05-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (166, CAST(N'2023-06-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (167, CAST(N'2023-07-01' AS Date), 12, 12, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (172, CAST(N'2023-09-01' AS Date), 14, 14, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (173, CAST(N'2023-10-01' AS Date), 14, 14, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (174, CAST(N'2023-11-01' AS Date), 14, 14, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (175, CAST(N'2020-03-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (176, CAST(N'2020-04-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (177, CAST(N'2020-05-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (178, CAST(N'2020-06-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (179, CAST(N'2020-07-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (180, CAST(N'2020-08-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (181, CAST(N'2020-09-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (182, CAST(N'2020-10-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (183, CAST(N'2020-11-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (184, CAST(N'2020-12-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (185, CAST(N'2021-01-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (186, CAST(N'2021-02-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (187, CAST(N'2021-03-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (188, CAST(N'2021-04-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (189, CAST(N'2021-05-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (190, CAST(N'2021-06-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (191, CAST(N'2021-07-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (192, CAST(N'2021-08-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (193, CAST(N'2021-09-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (194, CAST(N'2021-10-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (195, CAST(N'2021-11-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (196, CAST(N'2021-12-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (197, CAST(N'2022-01-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (198, CAST(N'2022-02-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (199, CAST(N'2022-03-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (200, CAST(N'2022-04-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (201, CAST(N'2022-05-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (202, CAST(N'2022-06-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (203, CAST(N'2022-07-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (204, CAST(N'2022-08-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (205, CAST(N'2022-09-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (206, CAST(N'2022-10-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (207, CAST(N'2022-11-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (208, CAST(N'2022-12-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (209, CAST(N'2023-01-01' AS Date), 3, 3, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (210, CAST(N'2023-02-01' AS Date), 3, 3, 0.05, 1)
GO
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (211, CAST(N'2023-04-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (212, CAST(N'2023-05-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (213, CAST(N'2023-06-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (214, CAST(N'2023-07-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (215, CAST(N'2023-08-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (216, CAST(N'2023-09-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (217, CAST(N'2020-07-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (218, CAST(N'2020-08-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (219, CAST(N'2020-09-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (220, CAST(N'2020-10-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (221, CAST(N'2020-11-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (222, CAST(N'2020-12-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (223, CAST(N'2021-01-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (224, CAST(N'2021-02-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (225, CAST(N'2021-03-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (226, CAST(N'2021-04-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (227, CAST(N'2021-05-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (228, CAST(N'2021-06-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (229, CAST(N'2021-07-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (230, CAST(N'2021-08-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (231, CAST(N'2021-09-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (232, CAST(N'2021-10-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (233, CAST(N'2021-11-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (234, CAST(N'2021-12-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (235, CAST(N'2022-01-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (236, CAST(N'2022-02-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (237, CAST(N'2022-03-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (238, CAST(N'2022-04-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (239, CAST(N'2022-05-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (240, CAST(N'2022-06-01' AS Date), 4, 4, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (241, CAST(N'2020-09-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (242, CAST(N'2020-10-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (243, CAST(N'2020-11-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (244, CAST(N'2020-12-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (245, CAST(N'2021-01-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (246, CAST(N'2021-02-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (247, CAST(N'2021-03-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (248, CAST(N'2021-04-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (249, CAST(N'2021-05-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (250, CAST(N'2021-06-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (251, CAST(N'2021-07-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (252, CAST(N'2021-08-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (253, CAST(N'2021-09-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (254, CAST(N'2021-10-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (255, CAST(N'2021-11-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (256, CAST(N'2021-12-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (257, CAST(N'2022-01-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (258, CAST(N'2022-02-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (259, CAST(N'2022-03-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (260, CAST(N'2022-04-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (261, CAST(N'2022-05-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (262, CAST(N'2022-06-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (263, CAST(N'2022-07-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (264, CAST(N'2022-08-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (265, CAST(N'2022-09-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (266, CAST(N'2022-10-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (267, CAST(N'2022-11-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (268, CAST(N'2022-12-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (269, CAST(N'2023-01-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (270, CAST(N'2023-02-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (271, CAST(N'2023-03-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (272, CAST(N'2023-04-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (273, CAST(N'2023-05-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (274, CAST(N'2023-06-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (275, CAST(N'2023-07-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (276, CAST(N'2023-08-01' AS Date), 9, 9, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (277, CAST(N'2020-10-01' AS Date), 10, 10, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (278, CAST(N'2020-11-01' AS Date), 10, 10, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (279, CAST(N'2020-12-01' AS Date), 10, 10, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (280, CAST(N'2021-01-01' AS Date), 10, 10, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (281, CAST(N'2021-02-01' AS Date), 10, 10, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (282, CAST(N'2021-03-01' AS Date), 10, 10, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (283, CAST(N'2022-01-01' AS Date), 13, 13, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (284, CAST(N'2022-02-01' AS Date), 13, 13, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (285, CAST(N'2022-03-01' AS Date), 13, 13, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (286, CAST(N'2022-04-01' AS Date), 13, 13, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (287, CAST(N'2022-05-01' AS Date), 13, 13, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (288, CAST(N'2022-06-01' AS Date), 13, 13, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (289, CAST(N'2020-03-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (290, CAST(N'2020-04-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (291, CAST(N'2020-05-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (292, CAST(N'2020-06-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (293, CAST(N'2020-07-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (294, CAST(N'2020-08-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (295, CAST(N'2020-09-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (296, CAST(N'2020-10-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (297, CAST(N'2020-11-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (298, CAST(N'2020-12-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (299, CAST(N'2021-01-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (300, CAST(N'2021-02-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (301, CAST(N'2021-03-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (302, CAST(N'2021-04-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (303, CAST(N'2021-05-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (304, CAST(N'2021-06-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (305, CAST(N'2021-07-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (306, CAST(N'2021-08-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (307, CAST(N'2021-09-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (308, CAST(N'2021-10-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (309, CAST(N'2021-11-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (310, CAST(N'2021-12-01' AS Date), 15, 15, 0.05, 1)
GO
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (311, CAST(N'2022-01-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (312, CAST(N'2022-02-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (313, CAST(N'2022-03-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (314, CAST(N'2022-04-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (315, CAST(N'2022-05-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (316, CAST(N'2022-06-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (317, CAST(N'2022-07-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (318, CAST(N'2022-08-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (319, CAST(N'2022-09-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (320, CAST(N'2022-10-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (321, CAST(N'2022-11-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (322, CAST(N'2022-12-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (323, CAST(N'2023-01-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (324, CAST(N'2023-02-01' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (325, CAST(N'2023-02-28' AS Date), 15, 15, 0.05, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (326, CAST(N'2021-08-20' AS Date), 16, 16, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (327, CAST(N'2021-09-15' AS Date), 17, 17, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (328, CAST(N'2022-04-20' AS Date), 18, 18, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (329, CAST(N'2023-01-25' AS Date), 19, 19, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (330, CAST(N'2022-11-01' AS Date), 20, 20, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (331, CAST(N'2023-03-05' AS Date), 21, 21, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (332, CAST(N'2023-08-10' AS Date), 22, 22, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (333, CAST(N'2022-12-15' AS Date), 23, 23, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (334, CAST(N'2023-07-20' AS Date), 24, 24, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (335, CAST(N'2023-02-25' AS Date), 25, 25, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (336, CAST(N'2022-01-28' AS Date), 26, 26, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (337, CAST(N'2023-05-05' AS Date), 27, 27, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (338, CAST(N'2023-04-10' AS Date), 28, 28, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (339, CAST(N'2023-09-15' AS Date), 29, 29, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (340, CAST(N'2023-07-20' AS Date), 30, 30, 0.03, 1)
INSERT [dbo].[FACTURAS] ([nro_factura], [fecha_factura], [cod_agente_inmobiliario], [cod_cliente], [comision_cliente], [cod_usuario]) VALUES (341, CAST(N'2023-11-21' AS Date), 21, 29, 0.05000000074505806, 1)
GO
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (1, 1, 1, 1, 5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (2, 2, 1, 2, 5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (3, 3, 1, 3, 5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (4, 4, 1, 4, 5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (5, 5, 1, 5, 5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (6, 6, 1, 6, 5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (7, 7, 1, 7, 8437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (8, 8, 1, 8, 8437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (9, 9, 1, 9, 8437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (10, 10, 1, 10, 8437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (11, 11, 1, 11, 8437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (12, 12, 1, 12, 8437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (13, 13, 1, 13, 12656.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (14, 14, 1, 14, 12656.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (15, 15, 1, 15, 12656.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (16, 16, 1, 16, 12656.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (17, 17, 1, 17, 12656.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (18, 18, 1, 18, 12656.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (19, 19, 1, 19, 18984.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (20, 20, 1, 20, 18984.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (21, 21, 1, 21, 18984.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (22, 22, 1, 22, 18984.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (23, 23, 1, 23, 18984.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (24, 24, 1, 24, 18984.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (25, 25, 1, 25, 28476.5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (26, 26, 1, 26, 28476.5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (27, 27, 1, 27, 28476.5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (28, 28, 1, 28, 28476.5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (29, 29, 1, 29, 28476.5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (30, 30, 1, 30, 28476.5625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (31, 31, 1, 31, 42714.84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (32, 32, 1, 32, 42714.84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (33, 33, 1, 33, 42714.84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (34, 34, 1, 34, 42714.84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (36, 36, 2, 1, 15625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (37, 37, 2, 2, 15625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (38, 38, 2, 3, 15625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (39, 39, 2, 4, 15625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (40, 40, 2, 5, 15625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (41, 41, 2, 6, 15625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (42, 42, 2, 7, 23437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (43, 43, 2, 8, 23437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (44, 44, 2, 9, 23437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (45, 45, 2, 10, 23437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (46, 46, 2, 1, 23437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (47, 47, 2, 12, 23437.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (48, 48, 2, 13, 35156.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (49, 49, 2, 14, 35156.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (50, 50, 2, 15, 35156.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (51, 51, 2, 16, 35156.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (52, 52, 2, 17, 35156.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (53, 53, 2, 18, 35156.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (54, 54, 2, 19, 52734.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (57, 57, 2, 22, 52734.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (58, 58, 5, 1, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (59, 59, 5, 2, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (60, 60, 5, 3, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (61, 61, 5, 4, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (62, 62, 5, 5, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (63, 63, 5, 6, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (64, 64, 5, 7, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (65, 65, 5, 8, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (66, 66, 5, 9, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (67, 67, 5, 10, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (68, 68, 5, 11, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (69, 69, 5, 12, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (70, 70, 5, 13, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (71, 71, 5, 14, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (72, 72, 5, 15, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (73, 73, 5, 16, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (74, 74, 5, 17, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (75, 75, 5, 18, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (76, 76, 5, 19, 104414.0625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (77, 77, 5, 20, 104414.0625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (78, 78, 5, 21, 104414.0625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (79, 79, 5, 22, 104414.0625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (80, 81, 5, 23, 104414.0625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (82, 82, 5, 24, 104414.0625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (83, 83, 5, 25, 156621.09375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (84, 84, 5, 26, 156621.09375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (85, 85, 5, 27, 156621.09375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (88, 88, 5, 30, 156621.09375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (89, 89, 5, 31, 234931.640625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (90, 90, 6, 1, 17500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (91, 91, 6, 2, 17500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (92, 92, 6, 3, 17500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (93, 93, 6, 4, 17500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (94, 94, 6, 5, 17500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (95, 95, 6, 6, 17500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (96, 96, 6, 7, 26250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (97, 97, 6, 8, 26250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (98, 98, 6, 9, 26250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (99, 99, 6, 10, 26250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (100, 100, 6, 11, 26250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (101, 101, 6, 12, 26250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (102, 102, 6, 13, 39375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (103, 103, 6, 14, 39375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (104, 104, 6, 15, 39375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (107, 107, 8, 1, 13750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (108, 108, 8, 2, 13750, 1)
GO
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (109, 109, 8, 3, 13750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (110, 110, 8, 4, 13750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (111, 111, 8, 5, 13750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (112, 112, 8, 6, 13750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (113, 113, 8, 7, 20625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (114, 114, 8, 8, 20625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (115, 115, 8, 9, 20625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (116, 116, 8, 10, 20625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (117, 117, 8, 11, 20625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (118, 118, 8, 12, 20625, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (119, 119, 8, 13, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (120, 120, 8, 14, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (121, 121, 8, 15, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (122, 122, 8, 16, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (123, 123, 8, 17, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (124, 124, 8, 18, 30937.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (125, 125, 8, 19, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (126, 126, 8, 20, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (127, 127, 8, 21, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (128, 128, 8, 22, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (129, 129, 8, 23, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (130, 130, 8, 24, 46406.25, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (131, 131, 8, 25, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (132, 132, 8, 26, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (133, 133, 8, 27, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (134, 134, 8, 28, 69609.375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (135, 135, 11, 1, 18750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (136, 136, 11, 2, 18750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (137, 137, 12, 1, 6218.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (138, 138, 12, 2, 6218.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (139, 139, 12, 3, 6218.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (140, 140, 12, 4, 6218.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (141, 141, 12, 5, 6218.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (142, 142, 12, 6, 6218.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (143, 143, 12, 7, 9328.125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (144, 144, 12, 8, 9328.125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (145, 145, 12, 9, 9328.125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (146, 146, 12, 10, 9328.125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (147, 147, 12, 11, 9328.125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (148, 148, 12, 12, 9328.125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (149, 149, 12, 13, 13992.1875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (150, 150, 12, 14, 13992.1875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (151, 151, 12, 15, 13992.1875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (152, 152, 12, 16, 13992.1875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (153, 153, 12, 17, 13992.1875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (154, 154, 12, 18, 13992.1875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (155, 155, 12, 19, 20988.28125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (156, 156, 12, 20, 20988.28125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (157, 157, 12, 21, 20988.28125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (158, 158, 12, 22, 20988.28125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (159, 159, 12, 23, 20988.28125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (160, 160, 12, 24, 20988.28125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (161, 161, 12, 25, 31482.421875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (162, 162, 12, 26, 31482.421875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (163, 163, 12, 27, 31482.421875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (164, 164, 12, 28, 31482.421875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (165, 165, 12, 29, 31482.421875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (166, 166, 12, 30, 31482.421875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (167, 167, 12, 31, 47223.6328125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (172, 172, 12, 36, 47223.6328125, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (173, 173, 14, 1, 5312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (174, 174, 14, 2, 5312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (175, 175, 14, 3, 5312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (176, 176, 3, 1, 25000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (177, 177, 3, 2, 25000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (178, 178, 3, 3, 25000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (179, 179, 3, 4, 25000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (180, 180, 3, 5, 25000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (181, 181, 3, 6, 25000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (182, 182, 3, 7, 37500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (183, 183, 3, 8, 37500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (184, 184, 3, 9, 37500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (185, 185, 3, 10, 37500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (186, 186, 3, 11, 37500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (187, 187, 3, 12, 37500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (188, 188, 3, 13, 56250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (189, 189, 3, 14, 56250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (190, 190, 3, 15, 56250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (191, 191, 3, 16, 56250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (192, 192, 3, 17, 56250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (193, 193, 3, 18, 56250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (194, 194, 3, 19, 84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (195, 195, 3, 20, 84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (196, 196, 3, 21, 84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (197, 197, 3, 22, 84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (198, 198, 3, 23, 84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (199, 199, 3, 24, 84375, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (200, 200, 3, 25, 126562.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (201, 201, 3, 26, 126562.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (202, 202, 3, 27, 126562.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (203, 203, 3, 28, 126562.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (204, 204, 3, 29, 126562.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (205, 205, 3, 30, 126562.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (206, 206, 3, 31, 189843.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (207, 207, 3, 32, 189843.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (208, 208, 3, 33, 189843.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (209, 209, 3, 34, 189843.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (210, 210, 3, 35, 189843.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (211, 211, 3, 36, 189843.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (212, 212, 4, 1, 21875, 1)
GO
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (213, 213, 4, 2, 21875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (214, 214, 4, 3, 21875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (215, 215, 4, 4, 21875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (216, 216, 4, 5, 21875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (217, 217, 4, 6, 21875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (218, 218, 7, 1, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (219, 219, 7, 2, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (220, 220, 7, 3, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (221, 221, 7, 4, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (222, 222, 7, 5, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (223, 223, 7, 6, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (224, 224, 7, 7, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (225, 225, 7, 8, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (226, 226, 7, 9, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (227, 227, 7, 10, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (228, 228, 7, 11, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (229, 229, 7, 12, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (230, 230, 7, 13, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (231, 231, 7, 14, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (232, 232, 7, 15, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (233, 233, 7, 16, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (234, 234, 7, 17, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (235, 235, 7, 18, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (236, 236, 7, 19, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (237, 237, 7, 20, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (238, 238, 7, 21, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (239, 239, 7, 22, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (240, 240, 7, 23, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (241, 241, 7, 24, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (242, 242, 9, 1, 5000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (243, 243, 9, 2, 5000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (244, 244, 9, 3, 5000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (245, 245, 9, 4, 5000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (246, 246, 9, 5, 5000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (247, 247, 9, 6, 5000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (248, 248, 9, 7, 7500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (249, 249, 9, 8, 7500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (250, 250, 9, 9, 7500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (251, 251, 9, 10, 7500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (252, 252, 9, 11, 7500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (253, 253, 9, 12, 7500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (254, 254, 9, 13, 11250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (255, 255, 9, 14, 11250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (256, 256, 9, 15, 11250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (257, 257, 9, 16, 11250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (258, 258, 9, 17, 11250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (259, 259, 9, 18, 11250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (260, 260, 9, 19, 16875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (261, 261, 9, 20, 16875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (262, 262, 9, 21, 16875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (263, 263, 9, 22, 16875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (264, 264, 9, 23, 16875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (265, 265, 9, 24, 16875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (266, 266, 9, 25, 25312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (267, 267, 9, 26, 25312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (268, 268, 9, 27, 25312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (269, 269, 9, 28, 25312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (270, 270, 9, 29, 25312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (271, 271, 9, 30, 25312.5, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (272, 272, 9, 31, 37968.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (273, 273, 9, 32, 37968.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (274, 274, 9, 33, 37968.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (275, 275, 9, 34, 37968.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (276, 276, 9, 35, 37968.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (277, 277, 9, 36, 37968.75, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (278, 278, 10, 1, 23750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (279, 279, 10, 2, 23750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (280, 280, 10, 3, 23750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (281, 281, 10, 4, 23750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (282, 282, 10, 5, 23750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (283, 283, 10, 6, 23750, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (284, 284, 13, 1, 15000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (285, 285, 13, 2, 15000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (286, 286, 13, 3, 15000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (287, 287, 13, 4, 15000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (288, 288, 13, 5, 15000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (289, 289, 13, 6, 15000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (290, 290, 15, 1, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (291, 291, 15, 2, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (292, 292, 15, 3, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (293, 293, 15, 4, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (294, 294, 15, 5, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (295, 295, 15, 6, 20000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (296, 296, 15, 7, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (297, 297, 15, 8, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (298, 298, 15, 9, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (299, 299, 15, 10, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (300, 300, 15, 11, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (301, 301, 15, 12, 30000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (302, 302, 15, 13, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (303, 303, 15, 14, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (304, 304, 15, 15, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (305, 305, 15, 16, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (306, 306, 15, 17, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (307, 307, 15, 18, 45000, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (308, 308, 15, 19, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (309, 309, 15, 20, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (310, 310, 15, 21, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (311, 311, 15, 22, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (312, 312, 15, 23, 67500, 1)
GO
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (313, 313, 15, 24, 67500, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (314, 314, 15, 25, 101250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (315, 315, 15, 26, 101250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (316, 316, 15, 27, 101250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (317, 317, 15, 28, 101250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (318, 318, 15, 29, 101250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (319, 319, 15, 30, 101250, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (320, 320, 15, 31, 151875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (321, 321, 15, 32, 151875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (322, 322, 15, 33, 151875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (323, 323, 15, 34, 151875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (324, 324, 15, 35, 151875, 1)
INSERT [dbo].[FACTURAS_ALQUILERES] ([cod_factura_alquiler], [nro_factura], [cod_alquiler], [nro_cuota], [precio], [cod_usuario]) VALUES (325, 325, 15, 36, 151875, 1)
GO
INSERT [dbo].[FORMAS_PAGOS] ([cod_forma_pago], [forma_pago], [recargo], [cod_usuario]) VALUES (1, N'Efectivo', 0, 1)
INSERT [dbo].[FORMAS_PAGOS] ([cod_forma_pago], [forma_pago], [recargo], [cod_usuario]) VALUES (2, N'Tarjeta de crédito', 0.15, 1)
INSERT [dbo].[FORMAS_PAGOS] ([cod_forma_pago], [forma_pago], [recargo], [cod_usuario]) VALUES (3, N'Tarjeta de débito', 0.15, 1)
INSERT [dbo].[FORMAS_PAGOS] ([cod_forma_pago], [forma_pago], [recargo], [cod_usuario]) VALUES (4, N'Transferencia bancaria', 0, 1)
INSERT [dbo].[FORMAS_PAGOS] ([cod_forma_pago], [forma_pago], [recargo], [cod_usuario]) VALUES (5, N'Cheque', 0, 1)
INSERT [dbo].[FORMAS_PAGOS] ([cod_forma_pago], [forma_pago], [recargo], [cod_usuario]) VALUES (6, N'Billeteras virtuales', 0, 1)
INSERT [dbo].[FORMAS_PAGOS] ([cod_forma_pago], [forma_pago], [recargo], [cod_usuario]) VALUES (7, N'Crédito hipotecario', 0, 1)
GO
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (1, 120.5, 2005, N'Casa con jardín', 1, 1, N'Peru', 123, 1, 250000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (2, 160.2, 2010, N'Departamento céntrico', 2, 2, N'Duarte Quiroz', 456, 2, 180000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (3, 180.7, 1998, N'Casa amplia', 1, 3, N'Maipu', 789, 3, 320000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (4, 90.8, 1985, N'Departamento luminoso', 2, 4, N'Larrañaga', 987, 4, 450000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (5, 220, 2012, N'Casa con piscina', 1, 5, N'Catamarca', 1470, 5, 600000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (6, 130.6, 2000, N'Departamento en zona tranquila', 2, 6, N'San Jerónimo', 258, 6, 130000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (7, 200.1, 2003, N'Casa con patio trasero', 1, 7, N'Leon Pinelo', 654, 7, 380000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (8, 150.3, 1995, N'Departamento con balcón', 2, 8, N'Sucre', 987, 8, 150000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (9, 110.2, 1980, N'Casa en zona residencial', 1, 9, N'Bazan Pedraza', 132, 9, 280000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (10, 180.9, 2007, N'Departamento con vistas', 2, 10, N'Juan Nepper', 451, 10, 520000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (11, 130, 1990, N'Casa en esquina', 1, 11, N'Eguia Zanon', 567, 11, 360000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (12, 120.6, 2008, N'Departamento moderno', 2, 12, N'Pehuajó', 789, 12, 140000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (13, 160.8, 2013, N'Casa con jardín grande', 1, 13, N'Fidel Pelliza', 246, 13, 420000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (14, 140.4, 2009, N'Departamento céntrico', 2, 14, N'Chacay', 852, 14, 155000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (15, 200.1, 2005, N'Casa con quincho', 1, 15, N'Bolivia', 357, 15, 450000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (16, 90.2, 1997, N'Departamento luminoso', 2, 16, N'Yavi', 963, 16, 125000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (17, 110.4, 2002, N'Casa en zona tranquila', 1, 17, N'Av Rancagua', 1246, 17, 260000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (18, 220.7, 2011, N'Departamento con vistas panorámicas', 2, 18, N'Diego Diaz', 789, 18, 600000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (19, 120.5, 1998, N'Casa con jardín y piscina', 1, 19, N'Diagonal Ica', 132, 19, 310000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (20, 160.2, 2003, N'Departamento en zona residencial', 2, 20, N'Roma', 451, 20, 530000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (21, 180.7, 2000, N'Casa en barrio residencial', 1, 1, N'Hipolito Yrigoyen', 789, 21, 320000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (22, 90.8, 2005, N'Departamento con terraza', 2, 2, N'Corro', 987, 22, 480000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (23, 250, 2015, N'Amplio terreno en esquina', 3, 3, N'Corrientes', 147, 23, 60000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (24, 110.6, 2001, N'Departamento con garaje', 2, 4, N'San Luis', 258, 24, 160000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (25, 300.1, 2006, N'Casa moderna con piscina', 1, 5, N'Lima', 654, 25, 380000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (26, 140.3, 1992, N'Departamento con parque', 2, 6, N'Agustin Garzon', 987, 26, 120000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (27, 95.5, 1989, N'Casa de diseño contemporáneo', 1, 7, N'Espora', 132, 27, 280000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (28, 210.9, 1994, N'Departamento en zona céntrica', 2, 8, N'Avellaneda', 451, 28, 520000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (29, 120, 2008, N'Casa con jardín grande', 1, 9, N'La Posta', 567, 29, 360000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (30, 160.4, 2017, N'Departamento con piscina', 2, 10, N'Edmundo Mariotte', 789, 30, 140000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (31, 400.09, 2018, N'Casa con piscina y parque', 1, 30, N'Urquiza', 789, 31, 535000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (32, 51.4, 2005, N'Departamento con balcón', 2, 35, N'Montes de Oca', 444, 32, 445000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (33, 300.2, 2012, N'Casa con jardín grande', 1, 40, N'Castelli', 555, 33, 500000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (34, 100.7, 2004, N'Departamento en zona céntrica', 2, 5, N'Bolívar', 333, 34, 109000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (35, 400.9, 2014, N'Casa con piscina y quincho', 1, 10, N'Belgrano', 123, 35, 520000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (36, 68.8, 2007, N'Departamento con balcón y garaje', 2, 15, N'Sucre', 101, 36, 100000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (37, 250, 2011, N'Casa con jardín interior y pileta', 1, 20, N'San Juan', 222, 37, 495000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (38, 75.5, 2006, N'Departamento con vista al río', 2, 25, N'San Martín', 123, 38, 195000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (39, 620.1, 2017, N'Casa de dos pisos con terraza', 1, 30, N'Córdoba', 789, 39, 550000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (40, 73.6, 2015, N'Departamento en zona residencial', 2, 35, N'Río Gallegos', 444, 40, 450000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (41, 173.6, 2000, N'Casa con piscina y parque', 1, 3, N'Ramon Gil Barros', 1370, 41, 550000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (42, 80, 1999, N'Departamento con vistas panorámicas', 2, 32, N'Corrientes', 234, 42, 150000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (43, 103, 2020, N'Departamento en zona residencial', 2, 22, N'Sarmiento', 23, 43, 200000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (44, 99, 2017, N'Casa de diseño contemporáneo', 1, 12, N'Artigas', 2690, 44, 350000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (45, 100, 2021, N'Departamento con parque', 2, 30, N'Corro', 333, 45, 800000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (46, 50, 2011, N'Terreno subdividido', 3, 21, N'Estrada', 12, 46, 90000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (47, 69.9, 2010, N'Departamento en zona residencial', 2, 17, N'Miguel Funes', 3000, 47, 460000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (48, 70.5, 2015, N'Casa con jardín grande', 1, 10, N'Gina Lamer', 902, 48, 230000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (49, 93.7, 2022, N'Amplio terreno en esquina', 3, 1, N'Ricota', 666, 49, 100000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (50, 100.2, 2008, N'Casa con quincho', 1, 19, N'Mirador', 100, 50, 310000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (51, 100.2, 2008, N'Terreno', 3, 19, N'Alabama', 808, 51, 980000, 1)
INSERT [dbo].[INMUEBLES] ([cod_inmueble], [superficie], [año_construccion], [descripcion], [cod_tipo_inmueble], [cod_barrio], [direccion], [nro_direccion], [cod_contrato_intermediacion], [precio], [cod_usuario]) VALUES (52, 100.2, 2008, N'Casa con quincho y terraza', 1, 19, N'Funes', 110, 52, 280000, 1)
GO
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (1, N'Córdoba', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (2, N'Villa María', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (3, N'Río Cuarto', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (4, N'Carlos Paz', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (5, N'Villa Allende', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (6, N'San Francisco', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (7, N'Jesús María', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (8, N'La Calera', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (9, N'Alta Gracia', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (10, N'Cosquín', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (11, N'Villa Carlos Paz', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (12, N'Unquillo', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (13, N'Río Tercero', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (14, N'Bell Ville', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (15, N'Villa Dolores', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (16, N'Villa General Belgrano', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (17, N'Villa del Rosario', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (18, N'Mina Clavero', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (19, N'Arroyito', 1)
INSERT [dbo].[LOCALIDADES] ([cod_localidad], [nom_localidad], [cod_usuario]) VALUES (20, N'Laboulaye', 1)
GO
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (1, N'Mateo', N'Peiretti', N'20-44345678-1', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (2, N'Emanuel', N'Córdoba', N'16-34765432-2', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (3, N'Lautaro', N'Martínez', N'14-20432109-3', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (4, N'Lionel', N'Pedraza', N'13-19112222-4', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (5, N'Luciano', N'Córdoba', N'20-43556666-5', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (6, N'Alberto', N'Fernández', N'18-28990000-6', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (7, N'Diego', N'Breppe', N'18-34344321-7', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (8, N'Natalia', N'Hernández', N'20-40761234-8', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (9, N'Carlos', N'Luna', N'15-29887777-9', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (10, N'Marta', N'Piconi', N'16-31113333-0', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (11, N'Joaquín', N'Benegas', N'13-12224444-1', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (12, N'Elena', N'Moreno', N'17-39335555-2', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (13, N'Tobias', N'Fernández', N'20-44366861-3', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (14, N'Cecilia', N'Vazquez', N'17-26553333-4', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (15, N'Martína', N'Mendez', N'15-29661111-5', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (16, N'Pedro', N'Soto', N'12-17772222-6', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (17, N'Roberto', N'Gutierrez', N'20-38889999-7', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (18, N'Lorena', N'Alvarez', N'19-33996588-8', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (19, N'Julián', N'Rodriguez', N'17-38001111-9', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (20, N'Josefina', N'Giménez', N'15-33110000-0', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (21, N'Pablo', N'Molina', N'20-42223333-1', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (22, N'Juan', N'Domínguez', N'13-13334444-2', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (23, N'Fernando', N'Navarro', N'15-21445555-3', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (24, N'Andrea', N'López', N'13-12556666-4', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (25, N'Jorge', N'García', N'20-44667777-5', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (26, N'Sofía', N'Martínez', N'16-19778888-6', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (27, N'Andrés', N'Torres', N'20-41884699-7', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (28, N'Camila', N'Sánchez', N'20-99990000-8', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (29, N'Eduardo', N'Gómez', N'14-32002191-9', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (30, N'Paola', N'Hernández', N'17-39110000-0', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (31, N'Diego', N'Pérez', N'18-40220000-1', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (32, N'Valeria', N'González', N'20-44123072-2', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (33, N'Gustavo', N'Martínez', N'12-11440950-3', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (34, N'Marta', N'Rodríguez', N'20-40550009-4', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (35, N'Luis', N'López', N'11-10660000-5', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (36, N'Laura', N'Fernández', N'17-25778001-6', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (37, N'Juan', N'Torres', N'17-30880000-7', 2, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (38, N'María', N'Hernández', N'19-32970103-8', 3, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (39, N'Javier', N'Soto', N'20-44001001-9', 1, 1)
INSERT [dbo].[PROPIETARIOS] ([cod_propietario], [nombre], [apellido], [cuil], [cod_barrio], [cod_usuario]) VALUES (40, N'Ana', N'Gómez', N'16-23111111-0', 2, 1)
GO
INSERT [dbo].[TIPOS_CONTACTOS] ([cod_tipo_contacto], [tipo_contacto], [cod_usuario]) VALUES (1, N'Teléfono', 1)
INSERT [dbo].[TIPOS_CONTACTOS] ([cod_tipo_contacto], [tipo_contacto], [cod_usuario]) VALUES (2, N'Correo electrónico', 1)
INSERT [dbo].[TIPOS_CONTACTOS] ([cod_tipo_contacto], [tipo_contacto], [cod_usuario]) VALUES (3, N'Red social', 1)
INSERT [dbo].[TIPOS_CONTACTOS] ([cod_tipo_contacto], [tipo_contacto], [cod_usuario]) VALUES (4, N'WhatsApp', 1)
INSERT [dbo].[TIPOS_CONTACTOS] ([cod_tipo_contacto], [tipo_contacto], [cod_usuario]) VALUES (5, N'Sitio web', 1)
INSERT [dbo].[TIPOS_CONTACTOS] ([cod_tipo_contacto], [tipo_contacto], [cod_usuario]) VALUES (6, N'Otro', 1)
GO
INSERT [dbo].[TIPOS_CONTRATOS] ([cod_tipo_contrato], [tipo_contrato], [cod_usuario]) VALUES (1, N'ALQUILER', 1)
INSERT [dbo].[TIPOS_CONTRATOS] ([cod_tipo_contrato], [tipo_contrato], [cod_usuario]) VALUES (2, N'VENTA', 1)
GO
INSERT [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble], [tipo_inmueble], [cod_usuario]) VALUES (1, N'CASA', 1)
INSERT [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble], [tipo_inmueble], [cod_usuario]) VALUES (2, N'DEPARTAMENTO', 1)
INSERT [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble], [tipo_inmueble], [cod_usuario]) VALUES (3, N'LOTE', 1)
INSERT [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble], [tipo_inmueble], [cod_usuario]) VALUES (4, N'LOCAL COMERCIAL', 1)
INSERT [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble], [tipo_inmueble], [cod_usuario]) VALUES (5, N'OFICINA', 1)
INSERT [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble], [tipo_inmueble], [cod_usuario]) VALUES (6, N'GALPON', 1)
INSERT [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble], [tipo_inmueble], [cod_usuario]) VALUES (7, N'COCHERA', 1)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([cod_usuario], [usuario], [contraseña]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[AGENTES_INMOBILIARIOS]  WITH CHECK ADD  CONSTRAINT [FK_AGENTES_INMOBILIARIOS__BARRIOS] FOREIGN KEY([cod_barrio])
REFERENCES [dbo].[BARRIOS] ([cod_barrio])
GO
ALTER TABLE [dbo].[AGENTES_INMOBILIARIOS] CHECK CONSTRAINT [FK_AGENTES_INMOBILIARIOS__BARRIOS]
GO
ALTER TABLE [dbo].[AGENTES_INMOBILIARIOS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_Agentes_inmobiliarios] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[AGENTES_INMOBILIARIOS] CHECK CONSTRAINT [fk_usuarios_Agentes_inmobiliarios]
GO
ALTER TABLE [dbo].[ALQUILERES]  WITH CHECK ADD  CONSTRAINT [FK_ALQUILERES__CLIENTES] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[CLIENTES] ([cod_cliente])
GO
ALTER TABLE [dbo].[ALQUILERES] CHECK CONSTRAINT [FK_ALQUILERES__CLIENTES]
GO
ALTER TABLE [dbo].[ALQUILERES]  WITH CHECK ADD  CONSTRAINT [FK_ALQUILERES__INMUEBLES] FOREIGN KEY([cod_inmueble])
REFERENCES [dbo].[INMUEBLES] ([cod_inmueble])
GO
ALTER TABLE [dbo].[ALQUILERES] CHECK CONSTRAINT [FK_ALQUILERES__INMUEBLES]
GO
ALTER TABLE [dbo].[ALQUILERES]  WITH CHECK ADD  CONSTRAINT [fk_alquileres_clientes] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[CLIENTES] ([cod_cliente])
GO
ALTER TABLE [dbo].[ALQUILERES] CHECK CONSTRAINT [fk_alquileres_clientes]
GO
ALTER TABLE [dbo].[ALQUILERES]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_alquileres] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[ALQUILERES] CHECK CONSTRAINT [fk_usuarios_alquileres]
GO
ALTER TABLE [dbo].[BARRIOS]  WITH CHECK ADD  CONSTRAINT [FK_BARRIOS__LOCALIDADES] FOREIGN KEY([cod_localidad])
REFERENCES [dbo].[LOCALIDADES] ([cod_localidad])
GO
ALTER TABLE [dbo].[BARRIOS] CHECK CONSTRAINT [FK_BARRIOS__LOCALIDADES]
GO
ALTER TABLE [dbo].[BARRIOS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_barrios] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[BARRIOS] CHECK CONSTRAINT [fk_usuarios_barrios]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES__BARRIOS] FOREIGN KEY([cod_barrio])
REFERENCES [dbo].[BARRIOS] ([cod_barrio])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_CLIENTES__BARRIOS]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_clientes] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [fk_usuarios_clientes]
GO
ALTER TABLE [dbo].[CONTACTOS]  WITH CHECK ADD  CONSTRAINT [FK_CONTACTOS__AGENTES_INMOBILIARIOS] FOREIGN KEY([cod_agente_inmobiliario])
REFERENCES [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario])
GO
ALTER TABLE [dbo].[CONTACTOS] CHECK CONSTRAINT [FK_CONTACTOS__AGENTES_INMOBILIARIOS]
GO
ALTER TABLE [dbo].[CONTACTOS]  WITH CHECK ADD  CONSTRAINT [FK_CONTACTOS__CLIENTES] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[CLIENTES] ([cod_cliente])
GO
ALTER TABLE [dbo].[CONTACTOS] CHECK CONSTRAINT [FK_CONTACTOS__CLIENTES]
GO
ALTER TABLE [dbo].[CONTACTOS]  WITH CHECK ADD  CONSTRAINT [FK_CONTACTOS__PROPIETARIOS] FOREIGN KEY([cod_propietario])
REFERENCES [dbo].[PROPIETARIOS] ([cod_propietario])
GO
ALTER TABLE [dbo].[CONTACTOS] CHECK CONSTRAINT [FK_CONTACTOS__PROPIETARIOS]
GO
ALTER TABLE [dbo].[CONTACTOS]  WITH CHECK ADD  CONSTRAINT [FK_CONTACTOS__TIPOS_CONTACTOS] FOREIGN KEY([cod_tipo_contacto])
REFERENCES [dbo].[TIPOS_CONTACTOS] ([cod_tipo_contacto])
GO
ALTER TABLE [dbo].[CONTACTOS] CHECK CONSTRAINT [FK_CONTACTOS__TIPOS_CONTACTOS]
GO
ALTER TABLE [dbo].[CONTACTOS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_contactos] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[CONTACTOS] CHECK CONSTRAINT [fk_usuarios_contactos]
GO
ALTER TABLE [dbo].[CONTRATOS_INTERMEDIACION]  WITH CHECK ADD  CONSTRAINT [FK_CONTRATOS_INTERMEDIACION__PROPIETARIOS] FOREIGN KEY([cod_propietario])
REFERENCES [dbo].[PROPIETARIOS] ([cod_propietario])
GO
ALTER TABLE [dbo].[CONTRATOS_INTERMEDIACION] CHECK CONSTRAINT [FK_CONTRATOS_INTERMEDIACION__PROPIETARIOS]
GO
ALTER TABLE [dbo].[CONTRATOS_INTERMEDIACION]  WITH CHECK ADD  CONSTRAINT [FK_CONTRATOS_INTERMEDIACION__TIPOS_CONTRATOS] FOREIGN KEY([cod_tipo_contrato])
REFERENCES [dbo].[TIPOS_CONTRATOS] ([cod_tipo_contrato])
GO
ALTER TABLE [dbo].[CONTRATOS_INTERMEDIACION] CHECK CONSTRAINT [FK_CONTRATOS_INTERMEDIACION__TIPOS_CONTRATOS]
GO
ALTER TABLE [dbo].[CONTRATOS_INTERMEDIACION]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_contratos_intermediacion] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[CONTRATOS_INTERMEDIACION] CHECK CONSTRAINT [fk_usuarios_contratos_intermediacion]
GO
ALTER TABLE [dbo].[DETALLES_FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLES_FACTURAS__FACTURAS] FOREIGN KEY([nro_factura])
REFERENCES [dbo].[FACTURAS] ([nro_factura])
GO
ALTER TABLE [dbo].[DETALLES_FACTURAS] CHECK CONSTRAINT [FK_DETALLES_FACTURAS__FACTURAS]
GO
ALTER TABLE [dbo].[DETALLES_FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLES_FACTURAS_INMUEBLES] FOREIGN KEY([cod_inmueble])
REFERENCES [dbo].[INMUEBLES] ([cod_inmueble])
GO
ALTER TABLE [dbo].[DETALLES_FACTURAS] CHECK CONSTRAINT [FK_DETALLES_FACTURAS_INMUEBLES]
GO
ALTER TABLE [dbo].[DETALLES_FACTURAS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_detalles_facturas] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[DETALLES_FACTURAS] CHECK CONSTRAINT [fk_usuarios_detalles_facturas]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS__AGENTES_INMOBILIARIOS] FOREIGN KEY([cod_agente_inmobiliario])
REFERENCES [dbo].[AGENTES_INMOBILIARIOS] ([cod_agente_inmobiliario])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURAS__AGENTES_INMOBILIARIOS]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS__CLIENTES] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[CLIENTES] ([cod_cliente])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURAS__CLIENTES]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_facturas] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [fk_usuarios_facturas]
GO
ALTER TABLE [dbo].[FACTURAS_ALQUILERES]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_ALQUILERES__ALQUILERES] FOREIGN KEY([cod_alquiler])
REFERENCES [dbo].[ALQUILERES] ([cod_alquiler])
GO
ALTER TABLE [dbo].[FACTURAS_ALQUILERES] CHECK CONSTRAINT [FK_FACTURAS_ALQUILERES__ALQUILERES]
GO
ALTER TABLE [dbo].[FACTURAS_ALQUILERES]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_ALQUILERES__FACTURAS] FOREIGN KEY([nro_factura])
REFERENCES [dbo].[FACTURAS] ([nro_factura])
GO
ALTER TABLE [dbo].[FACTURAS_ALQUILERES] CHECK CONSTRAINT [FK_FACTURAS_ALQUILERES__FACTURAS]
GO
ALTER TABLE [dbo].[FACTURAS_ALQUILERES]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_facturas_alquileres] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[FACTURAS_ALQUILERES] CHECK CONSTRAINT [fk_usuarios_facturas_alquileres]
GO
ALTER TABLE [dbo].[FORMAS_PAGOS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_formas_pagos] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[FORMAS_PAGOS] CHECK CONSTRAINT [fk_usuarios_formas_pagos]
GO
ALTER TABLE [dbo].[FORMAS_PAGOS_FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FORMAS_PAGOS_FACTURAS__FACTURAS] FOREIGN KEY([nro_factura])
REFERENCES [dbo].[FACTURAS] ([nro_factura])
GO
ALTER TABLE [dbo].[FORMAS_PAGOS_FACTURAS] CHECK CONSTRAINT [FK_FORMAS_PAGOS_FACTURAS__FACTURAS]
GO
ALTER TABLE [dbo].[FORMAS_PAGOS_FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FORMAS_PAGOS_FACTURAS__FORMAS_PAGOS] FOREIGN KEY([cod_forma_pago])
REFERENCES [dbo].[FORMAS_PAGOS] ([cod_forma_pago])
GO
ALTER TABLE [dbo].[FORMAS_PAGOS_FACTURAS] CHECK CONSTRAINT [FK_FORMAS_PAGOS_FACTURAS__FORMAS_PAGOS]
GO
ALTER TABLE [dbo].[FORMAS_PAGOS_FACTURAS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_formas_pagos_facturas] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[FORMAS_PAGOS_FACTURAS] CHECK CONSTRAINT [fk_usuarios_formas_pagos_facturas]
GO
ALTER TABLE [dbo].[INMUEBLES]  WITH CHECK ADD  CONSTRAINT [FK_INMUEBLES__BARRIOS] FOREIGN KEY([cod_barrio])
REFERENCES [dbo].[BARRIOS] ([cod_barrio])
GO
ALTER TABLE [dbo].[INMUEBLES] CHECK CONSTRAINT [FK_INMUEBLES__BARRIOS]
GO
ALTER TABLE [dbo].[INMUEBLES]  WITH CHECK ADD  CONSTRAINT [FK_INMUEBLES__CONTRATOS_INTERMEDIACION] FOREIGN KEY([cod_contrato_intermediacion])
REFERENCES [dbo].[CONTRATOS_INTERMEDIACION] ([cod_contrato_intermediacion])
GO
ALTER TABLE [dbo].[INMUEBLES] CHECK CONSTRAINT [FK_INMUEBLES__CONTRATOS_INTERMEDIACION]
GO
ALTER TABLE [dbo].[INMUEBLES]  WITH CHECK ADD  CONSTRAINT [FK_INMUEBLES__TIPOS_INMUEBLES] FOREIGN KEY([cod_tipo_inmueble])
REFERENCES [dbo].[TIPOS_INMUEBLES] ([cod_tipo_inmueble])
GO
ALTER TABLE [dbo].[INMUEBLES] CHECK CONSTRAINT [FK_INMUEBLES__TIPOS_INMUEBLES]
GO
ALTER TABLE [dbo].[INMUEBLES]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_inmuebles] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[INMUEBLES] CHECK CONSTRAINT [fk_usuarios_inmuebles]
GO
ALTER TABLE [dbo].[LOCALIDADES]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_localidades] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[LOCALIDADES] CHECK CONSTRAINT [fk_usuarios_localidades]
GO
ALTER TABLE [dbo].[PROPIETARIOS]  WITH CHECK ADD  CONSTRAINT [FK_PROPIETARIOS__BARRIOS] FOREIGN KEY([cod_barrio])
REFERENCES [dbo].[BARRIOS] ([cod_barrio])
GO
ALTER TABLE [dbo].[PROPIETARIOS] CHECK CONSTRAINT [FK_PROPIETARIOS__BARRIOS]
GO
ALTER TABLE [dbo].[PROPIETARIOS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_propietarios] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[PROPIETARIOS] CHECK CONSTRAINT [fk_usuarios_propietarios]
GO
ALTER TABLE [dbo].[TIPOS_CONTACTOS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_tipos_contactos] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[TIPOS_CONTACTOS] CHECK CONSTRAINT [fk_usuarios_tipos_contactos]
GO
ALTER TABLE [dbo].[TIPOS_CONTRATOS]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_tipos_contratos] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[TIPOS_CONTRATOS] CHECK CONSTRAINT [fk_usuarios_tipos_contratos]
GO
ALTER TABLE [dbo].[TIPOS_INMUEBLES]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_tipos_inmuebles] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[TIPOS_INMUEBLES] CHECK CONSTRAINT [fk_usuarios_tipos_inmuebles]
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarUsuario]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarUsuario]
    @tabla NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);

    -- Construir la consulta dinámica
    SET @sql = 'UPDATE ' + QUOTENAME(@tabla) + 
	'                SET cod_usuario = 1
                WHERE cod_usuario IS NULL';

    -- Ejecutar la consulta dinámica
    EXEC sp_executesql @sql;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_CANT_INMUEBLE_PROP]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CANT_INMUEBLE_PROP]
@CANT_MIN_PROP INT
AS
BEGIN
SELECT
 p.apellido + ' ' + p.nombre 'Propietario',
 COUNT(*) 'Cantidad de Propiedades'
FROM PROPIETARIOS p
JOIN CONTRATOS_INTERMEDIACION ci ON p.cod_propietario = ci.cod_propietario
GROUP BY p.nombre, p.apellido
HAVING COUNT(*) >= @CANT_MIN_PROP
ORDER BY 1
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTES_CUMPLIDORES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CLIENTES_CUMPLIDORES]
@fechaDesde DATE,
@fechaHasta DATE,
@cantDias int
AS
BEGIN
	SELECT
	 c.nombre + ' ' + c.apellido			'Cliente',
	 i.descripcion							'Inmueble',
	 b.nom_barrio							'Barrio',
	 i.direccion							'Direccion',
	 i.nro_direccion						'Altura'
	FROM CLIENTES c
	JOIN ALQUILERES a ON a.cod_cliente = c.cod_cliente
	JOIN INMUEBLES i ON a.cod_inmueble = i.cod_inmueble
	JOIN BARRIOS b ON i.cod_barrio = b.cod_barrio
	WHERE a.estado_alquiler = 1
	 AND c.cod_cliente NOT IN (
		 SELECT f2.cod_cliente
		 FROM FACTURAS f2
		 WHERE f2.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
		 AND DAY(f2.fecha_factura) > @cantDias
	 );
 END

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_AGENTES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_AGENTES]
AS 
BEGIN
	SELECT * FROM AGENTES_INMOBILIARIOS
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ALQUILERES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_ALQUILERES]
AS
BEGIN
	SELECT
	a.cod_alquiler,
	c.nombre + ' ' + c.apellido 'nombre_cliente',
	a.fecha_inicio,
	a.fecha_finalizacion
	FROM ALQUILERES a
	JOIN CLIENTES c ON a.cod_cliente = c.cod_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_BARRIOS]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_BARRIOS]
AS 
BEGIN
	SELECT * FROM BARRIOS
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES]
AS 
BEGIN
	SELECT * FROM CLIENTES
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_INMUEBLES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_INMUEBLES]
AS 
BEGIN
	SELECT * FROM INMUEBLES
	WHERE cod_inmueble NOT IN (SELECT a.cod_inmueble FROM ALQUILERES a WHERE a.estado_alquiler = 1)
	  AND cod_inmueble NOT IN (SELECT df.cod_inmueble FROM DETALLES_FACTURAS df)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPOS_INMUEBLES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CONSULTAR_TIPOS_INMUEBLES]
AS
BEGIN
SELECT * FROM TIPOS_INMUEBLES
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTRATOS_POR_FINALIZAR]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONTRATOS_POR_FINALIZAR] 
@cantMeses int, 
@tipoContrato int
as
BEGIN
	SELECT
	 p.nombre + ' ' + p.apellido 'Propietario',
	 i.descripcion 'Inmueble',
	 b.nom_barrio 'Barrio',
	 i.direccion 'Direccion',
	 i.nro_direccion 'Altura',
	 ci.fecha_finalizacion 'Fecha de Finalización', 
	 tp.tipo_contrato 'Transacción'
	FROM INMUEBLES i
	JOIN CONTRATOS_INTERMEDIACION ci ON ci.cod_contrato_intermediacion =
	i.cod_contrato_intermediacion
	JOIN BARRIOS b ON i.cod_barrio = b.cod_barrio
	JOIN PROPIETARIOS p ON ci.cod_propietario = p.cod_propietario
	JOIN TIPOS_CONTRATOS tp ON ci.cod_tipo_contrato = tp.cod_tipo_contrato
	WHERE DATEDIFF(MONTH, GETDATE(),ci.fecha_finalizacion) BETWEEN 1 AND @cantMeses
	 AND ci.activo = 1
	 AND i.cod_inmueble NOT IN (
	 SELECT a.cod_inmueble
	 FROM ALQUILERES a
	 WHERE a.estado_alquiler = 1
	 )
	 AND i.cod_inmueble NOT IN (
	 SELECT df.cod_inmueble
	 FROM DETALLES_FACTURAS df
	 )
	 AND
    (
        (@tipoContrato = 1 AND tp.cod_tipo_contrato = 1)
        OR
        (@tipoContrato = 2 AND tp.cod_tipo_contrato = 2)
        OR
        (@tipoContrato NOT IN (1, 2))
    )
	ORDER BY 2;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_CLIENTE]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ELIMINAR_CLIENTE]
@COD_CLIENTE INT 
AS
BEGIN
DELETE FROM CLIENTES
WHERE cod_cliente = @COD_CLIENTE
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_INMUEBLE]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--SP_ELIMINAR_INMUEBLE
CREATE PROCEDURE [dbo].[SP_ELIMINAR_INMUEBLE]
@COD_INMUEBLE INT
AS
BEGIN
DELETE  FROM INMUEBLES
WHERE cod_inmueble = @COD_INMUEBLE
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_INFLACION_ALQUILER]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INFLACION_ALQUILER]
    @año_desde INT,
    @año_hasta INT
AS
BEGIN
    DECLARE @promedio_desde NVARCHAR(150);
    SET @promedio_desde = 'Promedio del precio en ' + CAST(@año_desde AS NVARCHAR(4));

    DECLARE @promedio_hasta NVARCHAR(150);
    SET @promedio_hasta = 'Promedio del precio en ' + CAST(@año_hasta AS NVARCHAR(4));

    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = '
        SELECT
            ROUND(AVG(fa.precio), 2)                                                    AS ['+ @promedio_hasta +'],
            ROUND((
                SELECT AVG(fa2.precio)
                FROM FACTURAS_ALQUILERES fa2
                JOIN FACTURAS f2 ON f2.nro_factura = fa2.nro_factura
                WHERE YEAR(f2.fecha_factura) = ' + CAST(@año_desde AS NVARCHAR(4)) + '
            ), 2)                                                                          AS ['+ @promedio_desde +'],
            ROUND(AVG(fa.precio) - (
                SELECT AVG(fa2.precio)
                FROM FACTURAS_ALQUILERES fa2
                JOIN FACTURAS f2 ON f2.nro_factura = fa2.nro_factura
                WHERE YEAR(f2.fecha_factura) = ' + CAST(@año_desde AS NVARCHAR(4)) + '
            ), 2)                                                                          AS [Diferencia],
            CONVERT(VARCHAR, ((
                ROUND(AVG(fa.precio), 2) - (
                    SELECT AVG(fa2.precio)
                    FROM FACTURAS_ALQUILERES fa2
                    JOIN FACTURAS f2 ON f2.nro_factura = fa2.nro_factura
                    WHERE YEAR(f2.fecha_factura) = ' + CAST(@año_desde AS NVARCHAR(4)) + '
                )
            ) / (
                SELECT AVG(fa2.precio)
                FROM FACTURAS_ALQUILERES fa2
                JOIN FACTURAS f2 ON f2.nro_factura = fa2.nro_factura
                WHERE YEAR(f2.fecha_factura) = ' + CAST(@año_desde AS NVARCHAR(4)) + '
            )) * 100) + ''%''                                                                AS [Porcentaje de aumento]
        FROM FACTURAS_ALQUILERES fa
        JOIN FACTURAS f ON f.nro_factura = fa.nro_factura
        WHERE YEAR(f.fecha_factura) = ' + CAST(@año_hasta AS NVARCHAR(4));

    EXEC sp_executesql @SQL;
END


UPDATE FACTURAS_ALQUILERES
SET precio = precio*0.5

UPDATE ALQUILERES
SET precio = precio*0.5

GO
/****** Object:  StoredProcedure [dbo].[SP_IniciarSesion]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_IniciarSesion]
    @usuario VARCHAR(30),
    @contraseña VARCHAR(10),
	@salida INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @codUsuarioExistente INT;

    -- Verificar si el usuario y contraseña existen
    SELECT @codUsuarioExistente = cod_usuario
    FROM Usuarios
    WHERE usuario = @usuario AND contraseña = @contraseña;

    -- Si el usuario y contraseña existen, permitir iniciar sesión
    IF @codUsuarioExistente IS NOT NULL
    BEGIN
        SET @salida = 1;
    END
    ELSE
    BEGIN
        SET @salida =0;
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_INMUEBLES_DISPONIBLES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INMUEBLES_DISPONIBLES]
@LOCALIDAD VARCHAR(250),
 @BARRIO VARCHAR(250),
 @PRECIO1 FLOAT,
 @PRECIO2 FLOAT
AS
BEGIN
 SELECT
 l.nom_localidad 'Localidad',
 b.nom_barrio 'Barrio',
 i.descripcion 'Inmueble',
 i.direccion 'Direccion',
 i.nro_direccion 'Altura',
 i.precio 'Precio',
 t.tipo_contrato 'Transaccion'
 FROM INMUEBLES i
 JOIN BARRIOS b ON b.cod_barrio = i.cod_barrio
 JOIN LOCALIDADES l ON l.cod_localidad = B.cod_localidad
 JOIN CONTRATOS_INTERMEDIACION c ON c.cod_contrato_intermediacion = i.cod_contrato_intermediacion
 JOIN TIPOS_CONTRATOS t ON t.cod_tipo_contrato = c.cod_tipo_contrato
 WHERE i.cod_inmueble NOT IN (
 SELECT a.cod_inmueble
 FROM ALQUILERES a
 WHERE a.estado_alquiler = 1
 )
 AND i.cod_inmueble NOT IN (
 SELECT df.cod_inmueble
 FROM DETALLES_FACTURAS df
 )
 AND l.nom_localidad LIKE '%'+@LOCALIDAD+'%'
 AND b.nom_barrio LIKE '%'+ @BARRIO +'%'
 AND i.precio BETWEEN @PRECIO1 AND @PRECIO2
 ORDER BY 1 ASC, 2 ASC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INQUILINOS_DEUDORES]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INQUILINOS_DEUDORES] 
    @cant_cuotas INT
AS
BEGIN
    WITH FacturasContadas AS (
        SELECT
            fa.cod_alquiler,
            COUNT(f.nro_factura) AS 'CantidadDeFacturasPagas',
            MAX(f.fecha_factura) AS 'FechaUltimaFacturaPagada'
        FROM FACTURAS f
        JOIN FACTURAS_ALQUILERES fa ON f.nro_factura = fa.nro_factura
        GROUP BY fa.cod_alquiler
    )

    SELECT 
        c.nombre + ' ' + c.apellido AS 'Cliente',
        a.cod_alquiler AS 'Nro. Alquiler',
        i.descripcion AS 'Inmueble',
        a.fecha_inicio AS 'Fecha Inicio',
        DATEDIFF(MONTH, a.fecha_inicio, GETDATE()) AS 'Meses de alquiler a la fecha',
        COALESCE(fc.CantidadDeFacturasPagas, 0) AS 'Cantidad de facturas pagas',
        DATEDIFF(MONTH, a.fecha_inicio, GETDATE()) - COALESCE(fc.CantidadDeFacturasPagas, 0) AS 'Debe'
    FROM CLIENTES c
    JOIN ALQUILERES a ON c.cod_cliente = a.cod_cliente
    JOIN INMUEBLES i ON a.cod_inmueble = i.cod_inmueble
    LEFT JOIN FacturasContadas fc ON a.cod_alquiler = fc.cod_alquiler
    WHERE a.estado_alquiler = 1
      --AND DATEDIFF(MONTH, COALESCE(fc.FechaUltimaFacturaPagada, a.fecha_inicio), GETDATE()) >= @cantDebidas;
	  AND DATEDIFF(MONTH, a.fecha_inicio, GETDATE()) - COALESCE(fc.CantidadDeFacturasPagas, 0) >= @cant_cuotas;
END;

-- Borrar factura
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CLIENTE]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_INSERTAR_CLIENTE]
@COD_CLIENTE INT,
@NOMBRE VARCHAR(30),
@APELLIDO VARCHAR(30),
@FECHA_NACIMIENTO DATE,
@DOCUMENTO VARCHAR(30),
@CUIL VARCHAR(30),
@FECHA_REGISTRO DATE,
@cod_barrio int,
@direccion varchar(30),
@nro_direccion int
as
begin 
insert into CLIENTES 
values
(@COD_CLIENTE ,
@NOMBRE ,
@APELLIDO ,
@FECHA_NACIMIENTO,
@DOCUMENTO ,
@CUIL ,
@FECHA_REGISTRO,
@cod_barrio ,
@direccion ,
@nro_direccion, 1)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@nro_detalle_factura INT,
	@nro_factura INT,
	@cod_inmueble INT,
	@precio FLOAT
AS
BEGIN 
	INSERT INTO DETALLES_FACTURAS
	VALUES
	(@nro_detalle_factura, @nro_factura, @cod_inmueble, @precio,1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE_ALQUILER]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE_ALQUILER]
	@cod_factura_alquiler INT,
	@nro_factura INT,
	@cod_alquiler INT,
	@nro_cuota INT,
	@precio FLOAT
AS
BEGIN
	INSERT INTO FACTURAS_ALQUILERES
	VALUES
	(@cod_factura_alquiler, @nro_factura, @cod_alquiler, @nro_cuota, @precio,1)

	UPDATE ALQUILERES
	SET precio = @precio
	WHERE cod_alquiler = @cod_alquiler
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_FACTURA]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_FACTURA]
	@nro_factura INT,
	@cod_agente_inmobiliario INT,
	@cod_cliente INT,
	@comision_cliente FLOAT
AS
BEGIN 
	INSERT INTO FACTURAS
	VALUES 
	(@nro_factura, GETDATE(), @cod_agente_inmobiliario, @cod_cliente, @comision_cliente,1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_INMUEBLE]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_INMUEBLE]
@COD_INMUEBLE INT,
@SUPERFICIE FLOAT,
@ANIO_CONSTRUCCION INT,
@DESCRIPCION VARCHAR(30),
@COD_TIPO_INMUEBLE INT,
@COD_BARRIO INT,
@DIRECCION VARCHAR(200),
@NRO_DIRECCION INT,
@COD_CONTRATO_INTERMEDIACION INT,
@PRECIO FLOAT 
AS
BEGIN 
INSERT INTO INMUEBLES
VALUES 
(
@COD_INMUEBLE ,
@SUPERFICIE ,
@ANIO_CONSTRUCCION ,
@DESCRIPCION ,
@COD_TIPO_INMUEBLE ,
@COD_BARRIO ,
@DIRECCION ,
@NRO_DIRECCION ,
@COD_CONTRATO_INTERMEDIACION ,
@PRECIO, 1 
)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_CLIENTE]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MODIFICAR_CLIENTE]
@COD_CLIENTE INT,
@NOMBRE VARCHAR(30),
@APELLIDO VARCHAR(30),
@FECHA_NACIMIENTO DATE,
@DOCUMENTO VARCHAR(30),
@CUIL VARCHAR(30),
@FECHA_REGISTRO DATE,
@cod_barrio int,
@direccion varchar(30),
@nro_direccion int
AS
BEGIN 
UPDATE CLIENTES
SET 

nombre=@NOMBRE ,
apellido=@APELLIDO ,
fecha_nacimiento=@FECHA_NACIMIENTO,
documento=@DOCUMENTO ,
cuil=@CUIL ,
fecha_registro=@FECHA_REGISTRO,
cod_barrio=@cod_barrio ,
direccion=@direccion ,
nro_direccion=@nro_direccion 
WHERE cod_cliente = @COD_CLIENTE
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_INMUEBLE]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SP_MODIFICAR_INMUEBLE
CREATE PROCEDURE [dbo].[SP_MODIFICAR_INMUEBLE]
@COD_INMUEBLE INT,
@SUPERFICIE FLOAT,
@ANIO_CONSTRUCCION INT,
@DESCRIPCION VARCHAR(30),
@COD_TIPO_INMUEBLE INT,
@COD_BARRIO INT,
@DIRECCION VARCHAR(200),
@NRO_DIRECCION INT,
@COD_CONTRATO_INTERMEDIACION INT,
@PRECIO FLOAT
AS
BEGIN
UPDATE INMUEBLES 
SET 

superficie=@SUPERFICIE ,
año_construccion=@ANIO_CONSTRUCCION ,
descripcion=@DESCRIPCION ,
cod_tipo_inmueble=@COD_TIPO_INMUEBLE ,
cod_barrio=@COD_BARRIO ,
direccion=@DIRECCION ,
nro_direccion=@NRO_DIRECCION ,
cod_contrato_intermediacion=@COD_CONTRATO_INTERMEDIACION ,
precio=@PRECIO 
WHERE 
cod_inmueble = @COD_INMUEBLE
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerProximoCodCliente]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerProximoCodCliente]
    @ProximoCliente INT OUTPUT
AS
BEGIN
    -- Obtener el máximo valor actual de cod_cliente
    SELECT @ProximoCliente = ISNULL(MAX(cod_cliente), 0) + 1
    FROM CLIENTES;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerProximoCodFacturaAlquiler]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerProximoCodFacturaAlquiler]
 @ProximoCodAlq INT OUTPUT
AS
BEGIN
    
    

-- Obtener el máximo código actual
    SELECT @ProximoCodAlq = ISNULL(MAX(cod_factura_alquiler),0) + 1
    FROM FACTURAS_ALQUILERES;

   
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerProximoCodigoFactura]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerProximoCodigoFactura]
@ProximoCodigo INT OUTPUT
AS
BEGIN
-- Obtener el máximo código actual
    SELECT @ProximoCodigo = ISNULL (MAX(nro_factura),0) + 1
    FROM FACTURAS;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerProximoCodInmueble]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerProximoCodInmueble]
    @Proximoinmueble INT OUTPUT
AS
BEGIN
    -- Obtener el máximo valor actual de cod_cliente
    SELECT @Proximoinmueble = ISNULL(MAX(cod_inmueble), 0) + 1
    FROM INMUEBLES;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerProximoNroDetalleFactura]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerProximoNroDetalleFactura]
@ProximoDetalle INT OUTPUT
AS
BEGIN
     

    

-- Obtener el máximo código actual
    SELECT @ProximoDetalle = ISNULL(MAX(nro_detalle_factura),0) + 1
    FROM DETALLES_FACTURAS;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_PROPIEDADES_CAPTADAS]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_PROPIEDADES_CAPTADAS]
@año_desde INT,
@año_hasta INT,
@agente_inmobiliario VARCHAR(100)
AS
SELECT
 i.descripcion 'Inmueble',
 ai.nombre + ' ' + ai.apellido 'Agente Inmobiliario',
 c.nombre + ' ' + c.apellido 'Cliente',
 YEAR(ci.fecha_inicio) 'Año',
 CONVERT(VARCHAR, f.nro_factura) 'Nro. Factura',
 df.precio 'Costo de venta',
 '$' + CONVERT(VARCHAR, (df.precio * ci.porcentaje_comision) / 100) 'Comision por contrato',
 '$' + CONVERT(VARCHAR, (df.precio * f.comision_cliente) / 100) 'Comision por parte del cliente',
 '$' + CONVERT(VARCHAR, ((df.precio * ci.porcentaje_comision) / 100) + ((df.precio 
* f.comision_cliente) / 100)) 'Total de Ganancia'
FROM INMUEBLES i
JOIN CONTRATOS_INTERMEDIACION ci ON ci.cod_contrato_intermediacion =
i.cod_contrato_intermediacion
JOIN DETALLES_FACTURAS df ON i.cod_inmueble = df.cod_inmueble 
JOIN FACTURAS f ON f.nro_factura = df.nro_factura
JOIN AGENTES_INMOBILIARIOS ai ON f.cod_agente_inmobiliario =
ai.cod_agente_inmobiliario
JOIN CLIENTES c ON f.cod_cliente = c.cod_cliente
WHERE YEAR(ci.fecha_inicio) BETWEEN  @año_desde AND @año_hasta
AND ai.nombre + ai.apellido LIKE'%'+ @agente_inmobiliario +'%'
UNION
SELECT
 i.descripcion,
  '' AS 'Agente Inmobiliario',
  NULL,
 YEAR(ci.fecha_inicio),
 'Aun no se vendió',
 NULL, NULL, NULL, NULL
FROM INMUEBLES i
JOIN CONTRATOS_INTERMEDIACION ci ON ci.cod_contrato_intermediacion =
i.cod_contrato_intermediacion
WHERE YEAR(ci.fecha_inicio) BETWEEN @año_desde AND @año_hasta
 AND i.cod_inmueble NOT IN (
 SELECT df2.cod_inmueble
 FROM DETALLES_FACTURAS df2
 )
ORDER BY 5;
GO
/****** Object:  StoredProcedure [dbo].[SP_TOTAL_FACTURADO_VENTA_Y_ALQUILER]    Script Date: 21/11/2023 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_TOTAL_FACTURADO_VENTA_Y_ALQUILER]
    @desde DATE,
    @hasta DATE
AS
BEGIN
    SELECT
        'Venta' AS 'Tipo de Transaccion',
        SUM(DF.precio) AS 'Total Recaudado'
    FROM FACTURAS F
    JOIN DETALLES_FACTURAS DF ON DF.nro_factura = F.nro_factura
    JOIN INMUEBLES I ON I.cod_inmueble = DF.cod_inmueble
    JOIN CONTRATOS_INTERMEDIACION CI ON CI.cod_contrato_intermediacion = I.cod_contrato_intermediacion
    WHERE F.fecha_factura BETWEEN @desde AND @hasta
    AND CI.cod_tipo_contrato = 2
    UNION
    SELECT
        'Alquiler',
        SUM(FA.precio)
    FROM FACTURAS F
    JOIN FACTURAS_ALQUILERES FA ON FA.nro_factura = F.nro_factura
    WHERE F.fecha_factura BETWEEN @desde AND @hasta
END;
GO
USE [master]
GO
ALTER DATABASE [inmobiliaria3] SET  READ_WRITE 
GO
