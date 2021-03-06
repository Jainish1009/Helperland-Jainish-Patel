USE [master]
GO
/****** Object:  Database [Helperlandsql]    Script Date: 21-01-2022 11:30:05 ******/
CREATE DATABASE [Helperlandsql]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Helperlandsql', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Helperlandsql.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Helperlandsql_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Helperlandsql_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Helperlandsql] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Helperlandsql].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Helperlandsql] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Helperlandsql] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Helperlandsql] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Helperlandsql] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Helperlandsql] SET ARITHABORT OFF 
GO
ALTER DATABASE [Helperlandsql] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Helperlandsql] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Helperlandsql] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Helperlandsql] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Helperlandsql] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Helperlandsql] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Helperlandsql] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Helperlandsql] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Helperlandsql] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Helperlandsql] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Helperlandsql] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Helperlandsql] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Helperlandsql] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Helperlandsql] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Helperlandsql] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Helperlandsql] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Helperlandsql] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Helperlandsql] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Helperlandsql] SET  MULTI_USER 
GO
ALTER DATABASE [Helperlandsql] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Helperlandsql] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Helperlandsql] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Helperlandsql] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Helperlandsql] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Helperlandsql] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Helperlandsql] SET QUERY_STORE = OFF
GO
USE [Helperlandsql]
GO
/****** Object:  Table [dbo].[Customer_details]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_details](
	[id] [int] NOT NULL,
	[Street_name] [text] NOT NULL,
	[House_no] [text] NOT NULL,
	[postalcode] [int] NOT NULL,
	[city] [text] NOT NULL,
	[phone_number] [int] NOT NULL,
	[Serpro_name] [varchar](20) NOT NULL,
 CONSTRAINT [PK_CUSTOMER_DETAILS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_sign_up]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_sign_up](
	[Id] [int] NOT NULL,
	[F_Name] [varchar](100) NOT NULL,
	[L_Name] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Mobile_no] [int] NOT NULL,
	[Password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_CUSTOMER_SIGN_UP] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Forget_Pass]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Forget_Pass](
	[id] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_FORGET_PASS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log_in]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log_in](
	[Id] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_LOG_IN] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment_detail]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment_detail](
	[transaction_id] [int] NOT NULL,
	[transaction_value] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_PAYMENT_DETAIL] PRIMARY KEY CLUSTERED 
(
	[transaction_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule_Plan]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule_Plan](
	[Id] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Starttime] [time](7) NOT NULL,
	[Duration] [time](7) NOT NULL,
	[Extra_Service] [varchar](20) NOT NULL,
 CONSTRAINT [PK_SCHEDULE_PLAN] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serpro_Forget_Pass]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serpro_Forget_Pass](
	[id] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_SERPRO_FORGET_PASS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serpro_Log_in]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serpro_Log_in](
	[Id] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_SERPRO_LOG_IN] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SerPro_sign_up]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SerPro_sign_up](
	[Id] [int] NOT NULL,
	[F_Name] [varchar](100) NOT NULL,
	[S_Name] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Mobile_no] [int] NOT NULL,
	[Password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_SERPRO_SIGN_UP] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 21-01-2022 11:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[id] [int] NOT NULL,
	[Serpro_name] [varchar](20) NOT NULL,
	[Serpro_contact] [int] NOT NULL,
	[Service_name] [varchar](20) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Zipcode] [int] NOT NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_SERVICES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Service_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customer_details]  WITH CHECK ADD  CONSTRAINT [Customer_details_Service_Provider_Name_fk0] FOREIGN KEY([Serpro_name])
REFERENCES [dbo].[Services] ([Service_name])
GO
ALTER TABLE [dbo].[Customer_details] CHECK CONSTRAINT [Customer_details_Service_Provider_Name_fk0]
GO
ALTER TABLE [dbo].[Forget_Pass]  WITH CHECK ADD  CONSTRAINT [Forget_Pass_Email_fk0] FOREIGN KEY([Email])
REFERENCES [dbo].[Customer_sign_up] ([Email])
GO
ALTER TABLE [dbo].[Forget_Pass] CHECK CONSTRAINT [Forget_Pass_Email_fk0]
GO
ALTER TABLE [dbo].[Log_in]  WITH CHECK ADD  CONSTRAINT [Log_in_Email_fk0] FOREIGN KEY([Email])
REFERENCES [dbo].[Customer_sign_up] ([Email])
GO
ALTER TABLE [dbo].[Log_in] CHECK CONSTRAINT [Log_in_Email_fk0]
GO
ALTER TABLE [dbo].[Schedule_Plan]  WITH CHECK ADD  CONSTRAINT [Schedule_Plan_Extra_Service_fk0] FOREIGN KEY([Extra_Service])
REFERENCES [dbo].[Services] ([Service_name])
GO
ALTER TABLE [dbo].[Schedule_Plan] CHECK CONSTRAINT [Schedule_Plan_Extra_Service_fk0]
GO
ALTER TABLE [dbo].[Serpro_Forget_Pass]  WITH CHECK ADD  CONSTRAINT [Serpro_Forget_Pass_Email_fk0] FOREIGN KEY([Email])
REFERENCES [dbo].[SerPro_sign_up] ([Email])
GO
ALTER TABLE [dbo].[Serpro_Forget_Pass] CHECK CONSTRAINT [Serpro_Forget_Pass_Email_fk0]
GO
ALTER TABLE [dbo].[Serpro_Log_in]  WITH CHECK ADD  CONSTRAINT [Serpro_Log_Email_in_fk0] FOREIGN KEY([Email])
REFERENCES [dbo].[SerPro_sign_up] ([Email])
GO
ALTER TABLE [dbo].[Serpro_Log_in] CHECK CONSTRAINT [Serpro_Log_Email_in_fk0]
GO
USE [master]
GO
ALTER DATABASE [Helperlandsql] SET  READ_WRITE 
GO
