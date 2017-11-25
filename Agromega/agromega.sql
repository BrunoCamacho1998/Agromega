USE [master]
GO
/****** Object:  Database [Agromega]    Script Date: 11/24/2017 20:11:08 ******/
CREATE DATABASE [Agromega] ON  PRIMARY 
( NAME = N'Agromega', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Agromega.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Agromega_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Agromega_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Agromega] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Agromega].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Agromega] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Agromega] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Agromega] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Agromega] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Agromega] SET ARITHABORT OFF
GO
ALTER DATABASE [Agromega] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Agromega] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Agromega] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Agromega] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Agromega] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Agromega] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Agromega] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Agromega] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Agromega] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Agromega] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Agromega] SET  DISABLE_BROKER
GO
ALTER DATABASE [Agromega] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Agromega] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Agromega] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Agromega] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Agromega] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Agromega] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Agromega] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Agromega] SET  READ_WRITE
GO
ALTER DATABASE [Agromega] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Agromega] SET  MULTI_USER
GO
ALTER DATABASE [Agromega] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Agromega] SET DB_CHAINING OFF
GO
USE [Agromega]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 11/24/2017 20:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoSuelo]    Script Date: 11/24/2017 20:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSuelo](
	[TipoSueloId] [int] IDENTITY(1,1) NOT NULL,
	[NombreTipoSuelo] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.TipoSuelo] PRIMARY KEY CLUSTERED 
(
	[TipoSueloId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoClima]    Script Date: 11/24/2017 20:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoClima](
	[TipoClimaId] [int] IDENTITY(1,1) NOT NULL,
	[NombreClima] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.TipoClima] PRIMARY KEY CLUSTERED 
(
	[TipoClimaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produccion]    Script Date: 11/24/2017 20:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produccion](
	[ProduccionId] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [nvarchar](max) NULL,
	[TipoClimaId] [int] NOT NULL,
	[TipoSueloId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Produccion] PRIMARY KEY CLUSTERED 
(
	[ProduccionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TipoClimaId] ON [dbo].[Produccion] 
(
	[TipoClimaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TipoSueloId] ON [dbo].[Produccion] 
(
	[TipoSueloId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetProdSuelo]    Script Date: 11/24/2017 20:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProdSuelo]
	-- Add the parameters for the stored procedure here
	@Suelo int
AS
BEGIN
	select p.NombreProducto, s.NombreTipoSuelo from Produccion p inner join TipoSuelo s on p.TipoSueloId = @Suelo
END
GO
/****** Object:  StoredProcedure [dbo].[GetProdClimaSuelo]    Script Date: 11/24/2017 20:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProdClimaSuelo]
	-- Add the parameters for the stored procedure here
	@Clima int,
	@Suelo int
AS
BEGIN
	select p.NombreProducto, s.NombreClima, sl.NombreTipoSuelo from Produccion p inner join TipoClima s on p.TipoClimaId = @Clima 
	inner join TipoSuelo sl on p.TipoSueloId = @Suelo
END
GO
/****** Object:  StoredProcedure [dbo].[GetProdClima]    Script Date: 11/24/2017 20:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProdClima]
	-- Add the parameters for the stored procedure here
	@Clima int
AS
BEGIN
	select p.NombreProducto, s.NombreClima from Produccion p inner join TipoClima s on p.TipoClimaId = @Clima
END
GO
/****** Object:  Default [DF__Produccio__TipoC__08EA5793]    Script Date: 11/24/2017 20:11:09 ******/
ALTER TABLE [dbo].[Produccion] ADD  DEFAULT ((0)) FOR [TipoClimaId]
GO
/****** Object:  Default [DF__Produccio__TipoS__09DE7BCC]    Script Date: 11/24/2017 20:11:09 ******/
ALTER TABLE [dbo].[Produccion] ADD  DEFAULT ((0)) FOR [TipoSueloId]
GO
/****** Object:  ForeignKey [FK_dbo.Produccion_dbo.TipoClima_TipoClimaId]    Script Date: 11/24/2017 20:11:09 ******/
ALTER TABLE [dbo].[Produccion]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Produccion_dbo.TipoClima_TipoClimaId] FOREIGN KEY([TipoClimaId])
REFERENCES [dbo].[TipoClima] ([TipoClimaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Produccion] CHECK CONSTRAINT [FK_dbo.Produccion_dbo.TipoClima_TipoClimaId]
GO
/****** Object:  ForeignKey [FK_dbo.Produccion_dbo.TipoSuelo_TipoSueloId]    Script Date: 11/24/2017 20:11:09 ******/
ALTER TABLE [dbo].[Produccion]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Produccion_dbo.TipoSuelo_TipoSueloId] FOREIGN KEY([TipoSueloId])
REFERENCES [dbo].[TipoSuelo] ([TipoSueloId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Produccion] CHECK CONSTRAINT [FK_dbo.Produccion_dbo.TipoSuelo_TipoSueloId]
GO
