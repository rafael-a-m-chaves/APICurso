USE [master]
GO


CREATE DATABASE [BDServico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDServico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BDServico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDServico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BDServico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDServico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BDServico] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BDServico] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BDServico] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BDServico] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BDServico] SET ARITHABORT OFF 
GO

ALTER DATABASE [BDServico] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BDServico] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BDServico] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BDServico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BDServico] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BDServico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BDServico] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BDServico] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BDServico] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BDServico] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BDServico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BDServico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BDServico] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BDServico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BDServico] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BDServico] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BDServico] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BDServico] SET RECOVERY FULL 
GO

ALTER DATABASE [BDServico] SET  MULTI_USER 
GO

ALTER DATABASE [BDServico] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BDServico] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BDServico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BDServico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BDServico] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BDServico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BDServico] SET QUERY_STORE = OFF
GO

ALTER DATABASE [BDServico] SET  READ_WRITE 
GO

USE [BDServico]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LimiteCliente](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[LimiteCredito] [decimal](9, 2) NOT NULL,
	[Nome] [varchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_LimiteCliente] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [BDServico]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Observacao] [varchar](max) NULL,
	[NomeEntidade] [varchar](max) NULL,
	[IdEntitade] [int] NULL,
	[Usuario] [varchar](max) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

USE [BDServico]
GO

INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (1200.00
           ,'Rafael Augusto'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (2200.00
           ,'Bruna'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (3200.00
           ,'Guilherme'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (1500.00
           ,'Gustavo'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (22200.00
           ,'Mhoary'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (6700.00
           ,'Geovani'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (55200.00
           ,'Gabriel'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (155200.00
           ,'Pedro'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (133200.00
           ,'José'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (126600.00
           ,'Margarida'
           ,1)
GO
INSERT INTO [dbo].[LimiteCliente]
           ([LimiteCredito]
           ,[Nome]
           ,[IsActive])
     VALUES
           (122200.00
           ,'Joserfina'
           ,1)
GO


USE [BDServico]
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$1200.00'
           ,'Cliente'
           ,1
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$2200.00'
           ,'Cliente'
           ,2
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$3200.00'
           ,'Cliente'
           ,3
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$1500.00'
           ,'Cliente'
           ,4
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$22200.00'
           ,'Cliente'
           ,5
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$6700.00'
           ,'Cliente'
           ,6
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$55200.00'
           ,'Cliente'
           ,7
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$155200.00'
           ,'Cliente'
           ,8
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$133200.00'
           ,'Cliente'
           ,9
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$126600.00'
           ,'Cliente'
           ,10
           ,'Administrador Rafael')
GO

INSERT INTO [dbo].[Log]
           ([Observacao]
           ,[NomeEntidade]
           ,[IdEntitade]
           ,[Usuario])
     VALUES
           ('Foi Criado um novo Cliente em: 13/03/2022 as 23:50 Com um Limite de R$122200.00'
           ,'Cliente'
           ,11
           ,'Administrador Rafael')
GO