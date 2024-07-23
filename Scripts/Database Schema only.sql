USE [master]
GO
/****** Object:  Database [HomeConsumptionDB]    Script Date: 7/23/2024 6:32:02 AM ******/
CREATE DATABASE [HomeConsumptionDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HomeConsumptionDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HomeConsumptionDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HomeConsumptionDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HomeConsumptionDB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HomeConsumptionDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeConsumptionDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeConsumptionDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeConsumptionDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeConsumptionDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeConsumptionDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeConsumptionDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET RECOVERY FULL 
GO
ALTER DATABASE [HomeConsumptionDB] SET  MULTI_USER 
GO
ALTER DATABASE [HomeConsumptionDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeConsumptionDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HomeConsumptionDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HomeConsumptionDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HomeConsumptionDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HomeConsumptionDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HomeConsumptionDB', N'ON'
GO
ALTER DATABASE [HomeConsumptionDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [HomeConsumptionDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HomeConsumptionDB]
GO
/****** Object:  Table [dbo].[Purchase_SubCategories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_SubCategories](
	[PSCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [nvarchar](50) NOT NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_Purchase_SubCategories] PRIMARY KEY CLUSTERED 
(
	[PSCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase_Categories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Categories](
	[PCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_Purchase_Categories] PRIMARY KEY CLUSTERED 
(
	[PCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Purchase_Categories] UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stores]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stores](
	[StoreID] [int] IDENTITY(1,1) NOT NULL,
	[StoreName] [nvarchar](80) NOT NULL,
	[StoreLocation] [nvarchar](255) NULL,
 CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED 
(
	[StoreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[IssueDate] [date] NOT NULL,
	[Type] [int] NOT NULL,
	[TotalBeforTax] [smallmoney] NOT NULL,
	[Discount] [smallmoney] NULL,
	[TaxAmount] [smallmoney] NOT NULL,
	[TotalAfterTax] [smallmoney] NOT NULL,
	[StoreID] [int] NOT NULL,
	[PCategoryID] [int] NOT NULL,
	[PSCategoryID] [int] NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_Purchases] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_PurchasesInfo]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_PurchasesInfo]
AS
SELECT        dbo.Purchases.PurchaseID, dbo.Purchases.IssueDate, CASE WHEN dbo.Purchases.Type = 1 THEN 'سريعة' WHEN dbo.Purchases.Type = 2 THEN 'عادية' ELSE NULL END AS TypeName, dbo.Purchases.TotalAfterTax, 
                         dbo.Stores.StoreName, dbo.Purchase_Categories.CategoryName, dbo.Purchase_SubCategories.SubCategoryName
FROM            dbo.Stores INNER JOIN
                         dbo.Purchases ON dbo.Stores.StoreID = dbo.Purchases.StoreID INNER JOIN
                         dbo.Purchase_Categories ON dbo.Purchases.PCategoryID = dbo.Purchase_Categories.PCategoryID LEFT OUTER JOIN
                         dbo.Purchase_SubCategories ON dbo.Purchases.PSCategoryID = dbo.Purchase_SubCategories.PSCategoryID
GO
/****** Object:  UserDefinedFunction [dbo].[TV_PurchaseInfoByDate]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TV_PurchaseInfoByDate] 
(	
	-- Add the parameters for the function here
@DateFrom Date , @DateTo Date

)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * FROM [dbo].View_PurchasesInfo
	where View_PurchasesInfo.IssueDate between @DateFrom and @DateTo
)
GO
/****** Object:  Table [dbo].[PurchaseSubBaseCategories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseSubBaseCategories](
	[PSCategoryID] [int] NOT NULL,
	[PCategoryID] [int] NOT NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_PurchaseSubBaseCategories] PRIMARY KEY CLUSTERED 
(
	[PSCategoryID] ASC,
	[PCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_SubBaseCategoriesInfo]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SubBaseCategoriesInfo]
AS
SELECT        dbo.PurchaseSubBaseCategories.PCategoryID, dbo.Purchase_Categories.CategoryName, dbo.PurchaseSubBaseCategories.PSCategoryID, dbo.Purchase_SubCategories.SubCategoryName
FROM            dbo.PurchaseSubBaseCategories INNER JOIN
                         dbo.Purchase_SubCategories ON dbo.PurchaseSubBaseCategories.PSCategoryID = dbo.Purchase_SubCategories.PSCategoryID INNER JOIN
                         dbo.Purchase_Categories ON dbo.PurchaseSubBaseCategories.PCategoryID = dbo.Purchase_Categories.PCategoryID
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] NOT NULL,
	[CountryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Sizes]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Sizes](
	[ItemID] [int] NOT NULL,
	[SizeID] [int] NOT NULL,
	[Price] [smallmoney] NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName_AR] [nvarchar](255) NOT NULL,
	[ItemName_EN] [varchar](500) NULL,
	[CategoryID] [int] NOT NULL,
	[Price] [smallmoney] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[SecondName] [nvarchar](20) NOT NULL,
	[ThirdName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[NationalityCountryID] [int] NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchases_sub]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases_sub](
	[PurchaseID] [int] NOT NULL,
	[P_subID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[ItemName] [nvarchar](255) NOT NULL,
	[Size] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[ItemPrice] [smallmoney] NOT NULL,
	[Quantity] [smallmoney] NOT NULL,
	[TotalAmount] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Purchases_sub] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC,
	[P_subID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sizes]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizes](
	[SizeID] [int] IDENTITY(1,1) NOT NULL,
	[SizeName] [nvarchar](50) NOT NULL,
	[CreatedByUserID] [int] NULL,
	[UpdatedByUserID] [int] NULL,
 CONSTRAINT [PK_Sizes] PRIMARY KEY CLUSTERED 
(
	[SizeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Sizes] UNIQUE NONCLUSTERED 
(
	[SizeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Users]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Users1]
GO
ALTER TABLE [dbo].[Item_Sizes]  WITH CHECK ADD  CONSTRAINT [FK_Item_Sizes_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO
ALTER TABLE [dbo].[Item_Sizes] CHECK CONSTRAINT [FK_Item_Sizes_Items]
GO
ALTER TABLE [dbo].[Item_Sizes]  WITH CHECK ADD  CONSTRAINT [FK_Item_Sizes_Sizes1] FOREIGN KEY([SizeID])
REFERENCES [dbo].[Sizes] ([SizeID])
GO
ALTER TABLE [dbo].[Item_Sizes] CHECK CONSTRAINT [FK_Item_Sizes_Sizes1]
GO
ALTER TABLE [dbo].[Item_Sizes]  WITH CHECK ADD  CONSTRAINT [FK_Item_Sizes_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Item_Sizes] CHECK CONSTRAINT [FK_Item_Sizes_Users]
GO
ALTER TABLE [dbo].[Item_Sizes]  WITH CHECK ADD  CONSTRAINT [FK_Item_Sizes_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Item_Sizes] CHECK CONSTRAINT [FK_Item_Sizes_Users1]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categories]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Users]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Users1]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Countries] FOREIGN KEY([NationalityCountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Countries]
GO
ALTER TABLE [dbo].[Purchase_Categories]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Categories_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Purchase_Categories] CHECK CONSTRAINT [FK_Purchase_Categories_Users]
GO
ALTER TABLE [dbo].[Purchase_Categories]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Categories_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Purchase_Categories] CHECK CONSTRAINT [FK_Purchase_Categories_Users1]
GO
ALTER TABLE [dbo].[Purchase_SubCategories]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_SubCategories_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Purchase_SubCategories] CHECK CONSTRAINT [FK_Purchase_SubCategories_Users]
GO
ALTER TABLE [dbo].[Purchase_SubCategories]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_SubCategories_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Purchase_SubCategories] CHECK CONSTRAINT [FK_Purchase_SubCategories_Users1]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Purchase_Categories] FOREIGN KEY([PCategoryID])
REFERENCES [dbo].[Purchase_Categories] ([PCategoryID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Purchase_Categories]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Purchase_SubCategories] FOREIGN KEY([PSCategoryID])
REFERENCES [dbo].[Purchase_SubCategories] ([PSCategoryID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Purchase_SubCategories]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Stores] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Stores] ([StoreID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Stores]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Users]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Users1]
GO
ALTER TABLE [dbo].[Purchases_sub]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_sub_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO
ALTER TABLE [dbo].[Purchases_sub] CHECK CONSTRAINT [FK_Purchases_sub_Items]
GO
ALTER TABLE [dbo].[Purchases_sub]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_sub_Purchases] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchases] ([PurchaseID])
GO
ALTER TABLE [dbo].[Purchases_sub] CHECK CONSTRAINT [FK_Purchases_sub_Purchases]
GO
ALTER TABLE [dbo].[Purchases_sub]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_sub_Sizes] FOREIGN KEY([Size])
REFERENCES [dbo].[Sizes] ([SizeID])
GO
ALTER TABLE [dbo].[Purchases_sub] CHECK CONSTRAINT [FK_Purchases_sub_Sizes]
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseSubBaseCategories_Purchase_Categories] FOREIGN KEY([PCategoryID])
REFERENCES [dbo].[Purchase_Categories] ([PCategoryID])
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories] CHECK CONSTRAINT [FK_PurchaseSubBaseCategories_Purchase_Categories]
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseSubBaseCategories_Purchase_SubCategories] FOREIGN KEY([PSCategoryID])
REFERENCES [dbo].[Purchase_SubCategories] ([PSCategoryID])
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories] CHECK CONSTRAINT [FK_PurchaseSubBaseCategories_Purchase_SubCategories]
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseSubBaseCategories_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories] CHECK CONSTRAINT [FK_PurchaseSubBaseCategories_Users]
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseSubBaseCategories_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[PurchaseSubBaseCategories] CHECK CONSTRAINT [FK_PurchaseSubBaseCategories_Users1]
GO
ALTER TABLE [dbo].[Sizes]  WITH CHECK ADD  CONSTRAINT [FK_Sizes_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Sizes] CHECK CONSTRAINT [FK_Sizes_Users]
GO
ALTER TABLE [dbo].[Sizes]  WITH CHECK ADD  CONSTRAINT [FK_Sizes_Users1] FOREIGN KEY([UpdatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Sizes] CHECK CONSTRAINT [FK_Sizes_Users1]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_People]
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewPurchase]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================

CREATE PROCEDURE [dbo].[SP_AddNewPurchase]
	-- Add the parameters for the stored procedure here
	  @IssueDate date ,
	  @TotalBeforTax smallmoney,
      @TaxAmount smallmoney,
      @TotalAfterTax smallmoney,
      @StoreID int,
	  @Discount smallmoney null,
	  @Type int ,
	  @PCategoryID int ,
	  @PSCategoryID int null,
	  @CreatedByUserID int null,
	  @UpdatedByUserID int null,
	  @PurchaseID int out
AS
BEGIN
	INSERT INTO [dbo].[Purchases]
           ([IssueDate]
           ,[TotalBeforTax]
           ,[TaxAmount]
           ,[TotalAfterTax]
           ,[StoreID]
		   ,[Discount]
		   ,[Type]
		   ,[PCategoryID]
		   ,[PSCategoryID]
		   ,[CreatedByUserID]
		   ,[UpdatedByUserID])
     VALUES
           ( @IssueDate ,
	  @TotalBeforTax ,
      @TaxAmount ,
      @TotalAfterTax ,
      @StoreID ,
	  @Discount,
	  @Type,
	  @PCategoryID,
	  @PSCategoryID
	  ,@CreatedByUserID
	  ,@UpdatedByUserID);

	 set @PurchaseID = @@IDENTITY
	 --Test  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewPurchase_Sub]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddNewPurchase_Sub]
	-- Add the parameters for the stored procedure here
	  @PurchaseID int ,
	  
      @ItemID int,
      @ItemName nvarchar(255),
      @Size int null,
	  @Description nvarchar(max) null,
	  @ItemPrice smallmoney ,
	  @Quantity smallmoney,
	  @TotalAmount smallmoney,
	  @P_subID int 
AS
BEGIN
	INSERT INTO [dbo].[Purchases_sub]
           ([PurchaseID]
		   ,[P_subID]
           ,[ItemID]
           ,[ItemName]
           ,[Size]
           ,[Description]
           ,[ItemPrice]
           ,[Quantity]
           ,[TotalAmount])
     VALUES
           ( @PurchaseID ,
	   @P_subID,
      @ItemID ,
      @ItemName ,
	  @Size,
	  @Description,
	  @ItemPrice,
	  @Quantity,
	  @TotalAmount);

	
	   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllCategories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SP_GetAllCategories]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].[Categories]

	
	SELECT * FROM [dbo].[Categories] 
	Order By CategoryID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllItems]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetAllItems]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].Items

	
	SELECT * FROM [dbo].Items 
	Order By ItemID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchase]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllPurchase]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].[Purchases]

	
	SELECT * FROM [dbo].[Purchases]
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPaging]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPaging]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo

	
	SELECT * FROM [dbo].View_PurchasesInfo
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPagingByDate]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDate]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo);


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofStoreName]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofStoreName]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@StoreName  nvarchar(50),
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
  where StoreName like '%'+@StoreName+'%';


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
   where StoreName like '%'+@StoreName+'%'
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofTotalAfterTax]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofTotalAfterTax]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@TotalAfterTax smallmoney,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
  where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1;


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
   where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofType]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofType]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@TypeName nvarchar(20),
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
  where TypeName = @TypeName;


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
   where TypeName =@TypeName
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPagingByStoreName]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByStoreName]
		@PageNumber int,
		@RowCountPerPage  int,
		@StoreName nvarchar(50),
		@RowCount int output
	   
	AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo
	where StoreName like '%'+@StoreName+'%';
	
	SELECT * FROM [dbo].View_PurchasesInfo
	where StoreName like '%'+@StoreName+'%'
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPagingByTotalAfterTax]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByTotalAfterTax]
		@PageNumber int,
		@RowCountPerPage  int,
		@TotalAfterTax smallmoney,
		@RowCount int output
	   
	AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo
	where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1
	
	SELECT * FROM [dbo].View_PurchasesInfo
		 where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1
		 Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPurchaseInfoWithPagingByTypeName]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByTypeName]
		@PageNumber int,
		@RowCountPerPage  int,
		@TypeName nvarchar(20),
		@RowCount int output
	   
	AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo
	 where TypeName = @TypeName;
	
	SELECT * FROM [dbo].View_PurchasesInfo
	 where TypeName = @TypeName
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllSizesInfoWithPaging]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[SP_GetAllSizesInfoWithPaging]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].Sizes

	
	SELECT * FROM [dbo].Sizes
	Order By SizeID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAlltotalPurchase]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetAlltotalPurchase]
	-- Add the parameters for the stored procedure here
	@TotalAfterTax smallmoney Output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.


    -- Insert statements for procedure here
	SELECT @TotalAfterTax =sum(TotalAfterTax)
  FROM [HomeConsumptionDB].[dbo].[View_PurchasesInfo]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCategoryByName]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 

CREATE PROCEDURE [dbo].[SP_GetCategoryByName] 
	-- Add the parameters for the stored procedure here
	@NameCategory nvarchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	select * from Categories where CategoryName = @NameCategory;

    -- Insert statements for procedure here
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetPurchaseByID]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetPurchaseByID]

	@PurchaseID int 
AS
BEGIN

	SELECT * FROM [dbo].[Purchases] WHERE PurchaseID =@PurchaseID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_People]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_insert_People]
@p_FirstName nvarchar(20),
@p_SecondName nvarchar(20),
@p_ThirdName nvarchar(20),
@p_LastName nvarchar(20),
@p_PhoneNumber nvarchar(20),
@p_Email nvarchar(50),
@p_NationalityCountryID int,
@CreatedByUserID int null,
@UpdatedByUserID int null,
@PersonID int output
AS
BEGIN
	Insert into People (FirstName,SecondName,ThirdName,LastName,PhoneNumber,Email,NationalityCountryID,[CreatedByUserID],[UpdatedByUserID])
	values(@p_FirstName,@p_SecondName,@p_ThirdName,@p_LastName,@p_PhoneNumber,@p_Email,@p_NationalityCountryID,@CreatedByUserID,@UpdatedByUserID)
	set @PersonID = @@IDENTITY;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_Purchase_Categories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_insert_Purchase_Categories]
@out_error_number INT = 0 OUTPUT,
@p_CategoryName nvarchar(50)  ,
@CreatedByUserID int null,
@UpdatedByUserID int null,
@p_PCategoryID int  Output
AS
BEGIN
BEGIN TRY
	Insert into Purchase_Categories (CategoryName,[CreatedByUserID],[UpdatedByUserID])
	values(@p_CategoryName,@CreatedByUserID,@UpdatedByUserID)


	set @p_PCategoryID = @@IDENTITY;
END TRY
BEGIN CATCH
	SELECT @out_error_number=ERROR_NUMBER()
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_Purchase_SubCategories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_insert_Purchase_SubCategories]
@p_SubCategoryName nvarchar(50),
@CreatedByUserID int null,
@UpdatedByUserID int null,
@_PSCategoryID int output
AS
BEGIN
	Insert into Purchase_SubCategories (SubCategoryName,[CreatedByUserID],[UpdatedByUserID])
	values(@p_SubCategoryName,@CreatedByUserID,@UpdatedByUserID)

	set @_PSCategoryID = @@IDENTITY;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_PurchaseSubBaseCategories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_insert_PurchaseSubBaseCategories]
@p_PSCategory int,
@p_PCategory int  ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
	Insert into PurchaseSubBaseCategories (PSCategoryID,PCategoryID,[CreatedByUserID],[UpdatedByUserID])
	values(@p_PSCategory,@p_PCategory,@CreatedByUserID,@UpdatedByUserID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_Users]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_insert_Users]
@p_PersonID int,
@p_Password nvarchar(200),
@p_UserName nvarchar(50),

@p_IsActive bit  ,
@UserID int output
AS
BEGIN
	Insert into Users (PersonID,[UserName],[Password],IsActive)
	values(@p_PersonID,@p_UserName,@p_Password,@p_IsActive)
	set @UserID =@@IDENTITY;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchStoresByName]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SearchStoresByName]
    @StoreName NVARCHAR(80)
AS
BEGIN
    SELECT * FROM Stores WHERE StoreName LIKE N'%' + @StoreName + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_People]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_update_People]
@p_FirstName nvarchar(20),
@p_SecondName nvarchar(20),
@p_ThirdName nvarchar(20),
@p_LastName nvarchar(20),
@p_PhoneNumber nvarchar(20),
@p_Email nvarchar(50),
@p_NationalityCountryID int ,
@CreatedByUserID int null,
@UpdatedByUserID int null,
@w_PersonID int 
AS
BEGIN
	UPDATE [dbo].People SET FirstName=@p_FirstName,SecondName=@p_SecondName,ThirdName=@p_ThirdName,LastName=@p_LastName,PhoneNumber=@p_PhoneNumber,Email=@p_Email,NationalityCountryID=@p_NationalityCountryID 
	,[CreatedByUserID] = @CreatedByUserID
	,[UpdatedByUserID] =@UpdatedByUserID
	WHERE PersonID=@w_PersonID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_Purchase_Categories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_update_Purchase_Categories]
@out_error_number INT = 0 OUTPUT,
@p_CategoryName nvarchar(50) ,
@w_PCategoryID int ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
BEGIN TRY
	UPDATE [dbo].Purchase_Categories SET CategoryName=@p_CategoryName 
	,[CreatedByUserID] = @CreatedByUserID
	,[UpdatedByUserID] =@UpdatedByUserID
	WHERE PCategoryID=@w_PCategoryID
END TRY
BEGIN CATCH
	SELECT @out_error_number=ERROR_NUMBER()
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_Purchase_SubCategories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_update_Purchase_SubCategories]
@p_SubCategoryName nvarchar(50),

@w_PSCategoryID int ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
	UPDATE [dbo].Purchase_SubCategories SET SubCategoryName=@p_SubCategoryName
	,[CreatedByUserID] = @CreatedByUserID
	,[UpdatedByUserID] =@UpdatedByUserID
	WHERE PSCategoryID=@w_PSCategoryID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_PurchaseSubBaseCategories]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_update_PurchaseSubBaseCategories]
@p_PSCategory int,
@p_PCategory int ,
@w_PSCategory int,
@w_PCategory int ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
	UPDATE [dbo].PurchaseSubBaseCategories SET PSCategoryID=@p_PSCategory,
	PCategoryID=@p_PCategory 
	,[CreatedByUserID] = @CreatedByUserID
	,[UpdatedByUserID] =@UpdatedByUserID
	WHERE PSCategoryID=@w_PSCategory AND PCategoryID=@w_PCategory
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_Users]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[sp_update_Users]
@p_PersonID int,
@p_Password nvarchar(50),
@p_UserName nvarchar(50),

@p_IsActive bit ,
@w_UserID int 
AS
BEGIN
	UPDATE [dbo].Users SET PersonID=@p_PersonID,[Password]=@p_Password,IsActive=@p_IsActive ,[UserName] = @p_UserName
	WHERE UserID=@w_UserID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdatePurchase]    Script Date: 7/23/2024 6:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_UpdatePurchase]
	-- Add the parameters for the stored procedure here
	  @IssueDate date ,
	  @TotalBeforTax smallmoney,
      @TaxAmount money,
      @TotalAfterTax smallmoney,
      @StoreID int ,
	  @Discount smallmoney null ,
	  @Type int ,
	  @PCategoryID int ,
	  @PSCategoryID int null,
	  @CreatedByUserID int null,
	  @UpdatedByUserID int null,
	  @PurchaseID int 
AS
BEGIN
	UPDATE [dbo].[Purchases]
   SET [IssueDate]     = @IssueDate  ,
      [TotalBeforTax] = @TotalBeforTax ,
      [TaxAmount]     = @TaxAmount ,
      [TotalAfterTax] = @TotalAfterTax ,
      [StoreID]       = @StoreID ,
	  [Discount]       = @Discount,
	  [Type]			=@Type,
	  [PCategoryID]     =@PCategoryID,
	  [PSCategoryID] = @PSCategoryID
	  ,[CreatedByUserID] =@CreatedByUserID
	  ,[UpdatedByUserID] =@UpdatedByUserID
 WHERE [dbo].[Purchases].PurchaseID = @PurchaseID
	  return select @@ROWCOUNT
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1-simple 2-Normal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Purchases', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Stores"
            Begin Extent = 
               Top = 84
               Left = 558
               Bottom = 197
               Right = 728
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Purchases"
            Begin Extent = 
               Top = 23
               Left = 325
               Bottom = 229
               Right = 495
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Purchase_Categories"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Purchase_SubCategories"
            Begin Extent = 
               Top = 202
               Left = 615
               Bottom = 298
               Right = 804
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PurchasesInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PurchasesInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PurchaseSubBaseCategories"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Purchase_SubCategories"
            Begin Extent = 
               Top = 126
               Left = 269
               Bottom = 222
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Purchase_Categories"
            Begin Extent = 
               Top = 6
               Left = 473
               Bottom = 102
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2100
         Alias = 900
         Table = 3150
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubBaseCategoriesInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubBaseCategoriesInfo'
GO
USE [master]
GO
ALTER DATABASE [HomeConsumptionDB] SET  READ_WRITE 
GO
