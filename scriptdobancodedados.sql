USE [master]
GO
/****** Object:  Database [TestFormSql]    Script Date: 09/01/2018 14:35:32 ******/
CREATE DATABASE [TestFormSql]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestFormSql', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TestFormSql.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TestFormSql_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TestFormSql_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TestFormSql] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestFormSql].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestFormSql] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestFormSql] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestFormSql] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestFormSql] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestFormSql] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestFormSql] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TestFormSql] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TestFormSql] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestFormSql] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestFormSql] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestFormSql] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestFormSql] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestFormSql] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestFormSql] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestFormSql] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestFormSql] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TestFormSql] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestFormSql] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestFormSql] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestFormSql] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestFormSql] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestFormSql] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestFormSql] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestFormSql] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TestFormSql] SET  MULTI_USER 
GO
ALTER DATABASE [TestFormSql] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestFormSql] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestFormSql] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestFormSql] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TestFormSql]
GO
/****** Object:  StoredProcedure [dbo].[uspClienteAlterar]    Script Date: 09/01/2018 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspClienteAlterar]
	@IdCliente INT,
	@Nome varchar(100),
	@DataNascimento datetime,
	@Sexo	bit,
	@LimiteCompra decimal(18,2)
AS
BEGIN
	update
		tblClientes
	set
		Nome = @Nome,
		DataNascimento = @DataNascimento,
		Sexo = @Sexo,
		LimiteCompra = @LimiteCompra
	where
		IdCliente = @IdCliente

	select @IdCliente as retorno

END

GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorId]    Script Date: 09/01/2018 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspClienteConsultarPorId]
	@IdCliente int
as
begin

	select
		IdCliente,
		Nome,
		DataNascimento,
		Sexo,
		LimiteCompra

		from
			tblClientes
			where 
				IdCliente = @IdCliente
	
end
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorNome]    Script Date: 09/01/2018 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery10.sql|7|0|C:\Users\Italo\AppData\Local\Temp\~vs357E.sql
CREATE procedure [dbo].[uspClienteConsultarPorNome]
	@Nome varchar(100)
as
begin

	select
		IdCliente,
		Nome,
		DataNascimento,
		Sexo,
		LimiteCompra
	from
		tblClientes
	where
		Nome LIKE '%' + @Nome + '%'
	
end
GO
/****** Object:  StoredProcedure [dbo].[uspClienteExcluir]    Script Date: 09/01/2018 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspClienteExcluir]
	@IdCliente int
AS
BEGIN

	delete from 
		 tblClientes
	where
		IdCliente = @IdCliente
	
	select @IdCliente as retorno

END

GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 09/01/2018 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspClienteInserir]
	@Nome varchar(100),
	@DataNascimento datetime,
	@Sexo	bit,
	@LimiteCompra decimal(18,2)
AS
BEGIN
	insert into tblClientes
	(
		Nome,
		DataNascimento,
		Sexo,
		LimiteCompra
	)
	values
	(
		@Nome,
		@DataNascimento,
		@Sexo,
		@LimiteCompra
	)

	select @@IDENTITY as retorno

END

GO
/****** Object:  Table [dbo].[tblClientes]    Script Date: 09/01/2018 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblClientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[DataNascimento] [datetime] NOT NULL,
	[Sexo] [bit] NOT NULL,
	[LimiteCompra] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblClientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [TestFormSql] SET  READ_WRITE 
GO
