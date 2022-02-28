USE [master]
GO
/****** Object:  Database [BOOKSHOP]    Script Date: 27/02/2022 20:18:22 ******/
CREATE DATABASE [BOOKSHOP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibreriaBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LibreriaBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibreriaBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LibreriaBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BOOKSHOP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BOOKSHOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ARITHABORT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BOOKSHOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BOOKSHOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BOOKSHOP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BOOKSHOP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BOOKSHOP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BOOKSHOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BOOKSHOP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BOOKSHOP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BOOKSHOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BOOKSHOP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BOOKSHOP] SET  MULTI_USER 
GO
ALTER DATABASE [BOOKSHOP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BOOKSHOP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BOOKSHOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BOOKSHOP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BOOKSHOP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BOOKSHOP] SET QUERY_STORE = OFF
GO
USE [BOOKSHOP]
GO
/****** Object:  Table [dbo].[AUTHOR]    Script Date: 27/02/2022 20:18:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUTHOR](
	[ID_AUTHOR] [int] IDENTITY(1,1) NOT NULL,
	[NAME1] [varchar](50) NOT NULL,
	[NAME2] [varchar](50) NULL,
	[LASTNAME1] [varchar](50) NOT NULL,
	[LASTNAME2] [varchar](50) NULL,
	[DATE_BIRTH] [datetime] NOT NULL,
	[HOMETOWN] [varchar](50) NOT NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[STATUS] [bit] NOT NULL,
 CONSTRAINT [PK_AUTHOR] PRIMARY KEY CLUSTERED 
(
	[ID_AUTHOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BOOK]    Script Date: 27/02/2022 20:18:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOK](
	[IDBOOK] [int] IDENTITY(1,1) NOT NULL,
	[TITLE] [varchar](50) NOT NULL,
	[YEAR] [int] NOT NULL,
	[GENRE] [varchar](50) NOT NULL,
	[NUMBERPAGES] [int] NOT NULL,
	[IDPUBLISHER] [int] NOT NULL,
	[IDAUTHOR] [int] NOT NULL,
	[STATUS] [bit] NOT NULL,
 CONSTRAINT [PK_BOOK] PRIMARY KEY CLUSTERED 
(
	[IDBOOK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PUBLISHER]    Script Date: 27/02/2022 20:18:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUBLISHER](
	[ID_PUBLISHER] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](50) NOT NULL,
	[MAILING_ADDRESS] [varchar](50) NOT NULL,
	[TELEPHONE] [int] NOT NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[MAX_BOOKS_REG] [int] NOT NULL,
	[BOOKS_REG_COUNT] [int] NULL,
	[STATUS] [bit] NOT NULL,
 CONSTRAINT [PK_PUBLISHER] PRIMARY KEY CLUSTERED 
(
	[ID_PUBLISHER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AUTHOR] ON 

INSERT [dbo].[AUTHOR] ([ID_AUTHOR], [NAME1], [NAME2], [LASTNAME1], [LASTNAME2], [DATE_BIRTH], [HOMETOWN], [EMAIL], [STATUS]) VALUES (1, N'Joanne', NULL, N'Rowling', NULL, CAST(N'1965-02-01T00:00:00.000' AS DateTime), N'Jamaica', N'jkrowling@correo.com', 1)
INSERT [dbo].[AUTHOR] ([ID_AUTHOR], [NAME1], [NAME2], [LASTNAME1], [LASTNAME2], [DATE_BIRTH], [HOMETOWN], [EMAIL], [STATUS]) VALUES (2, N'Alejandro', N'', N'Perez', N'', CAST(N'1990-02-25T00:00:00.000' AS DateTime), N'Colombia', N'Alejandro@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[AUTHOR] OFF
GO
SET IDENTITY_INSERT [dbo].[BOOK] ON 

INSERT [dbo].[BOOK] ([IDBOOK], [TITLE], [YEAR], [GENRE], [NUMBERPAGES], [IDPUBLISHER], [IDAUTHOR], [STATUS]) VALUES (1, N'Harry Potter', 1, N'Fantasia', 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[BOOK] OFF
GO
SET IDENTITY_INSERT [dbo].[PUBLISHER] ON 

INSERT [dbo].[PUBLISHER] ([ID_PUBLISHER], [NAME], [MAILING_ADDRESS], [TELEPHONE], [EMAIL], [MAX_BOOKS_REG], [BOOKS_REG_COUNT], [STATUS]) VALUES (1, N'EDITORIAL 1', N'CALLE 1 2 3', 123456789, N'EDITORIAL1@GMAIL.COM', 2, 2, 1)
INSERT [dbo].[PUBLISHER] ([ID_PUBLISHER], [NAME], [MAILING_ADDRESS], [TELEPHONE], [EMAIL], [MAX_BOOKS_REG], [BOOKS_REG_COUNT], [STATUS]) VALUES (2, N'EDITORIAL 2', N'CALLE 123', 123456789, N'EDITORIAL2@GMAIL.COM', -1, 0, 1)
INSERT [dbo].[PUBLISHER] ([ID_PUBLISHER], [NAME], [MAILING_ADDRESS], [TELEPHONE], [EMAIL], [MAX_BOOKS_REG], [BOOKS_REG_COUNT], [STATUS]) VALUES (3, N'EDITORIAL 5', N'mailingAddress', 12315, N'EDITORIAL3@GMAIL.COM', 3, NULL, 1)
SET IDENTITY_INSERT [dbo].[PUBLISHER] OFF
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [FK_BOOK_AUTHOR] FOREIGN KEY([IDAUTHOR])
REFERENCES [dbo].[AUTHOR] ([ID_AUTHOR])
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [FK_BOOK_AUTHOR]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [FK_BOOK_PUBLISHER] FOREIGN KEY([IDPUBLISHER])
REFERENCES [dbo].[PUBLISHER] ([ID_PUBLISHER])
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [FK_BOOK_PUBLISHER]
GO
USE [master]
GO
ALTER DATABASE [BOOKSHOP] SET  READ_WRITE 
GO
