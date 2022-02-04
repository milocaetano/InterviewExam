IF NOT EXISTS(
  SELECT
    *
  FROM
    sys.databases
  WHERE
    name = 'InterviewExam'
) BEGIN CREATE DATABASE InterviewExam
GO
  USE [InterviewExam]
GO
  /****** Object:  Table [dbo].[Customers]    Script Date: 04/02/2022 16:48:20 ******/
SET
  ANSI_NULLS ON
GO
SET
  QUOTED_IDENTIFIER ON
GO
  CREATE TABLE [dbo].[Customers](
    [PersonID] [int] IDENTITY(1, 1) NOT NULL,
    [FirstName] [varchar](50) NOT NULL,
    [LastName] [varchar](50) NULL,
    [Age] [int] NULL,
    [Occupation] [varchar](50) NULL
  ) ON [PRIMARY]
GO
  /****** Object:  Table [dbo].[OrderDetails]    Script Date: 04/02/2022 16:48:20 ******/
SET
  ANSI_NULLS ON
GO
SET
  QUOTED_IDENTIFIER ON
GO
  CREATE TABLE [dbo].[OrderDetails](
    [OrderDetailID] [int] IDENTITY(1, 1) NOT NULL,
    [PersonID] [int] NOT NULL,
    [OrderId] [int] NOT NULL,
    [ProductNumber] [int] NOT NULL,
    [ProductOrigin] [nchar](30) NOT NULL
  ) ON [PRIMARY]
GO
  /****** Object:  Table [dbo].[Orders]    Script Date: 04/02/2022 16:48:20 ******/
SET
  ANSI_NULLS ON
GO
SET
  QUOTED_IDENTIFIER ON
GO
  CREATE TABLE [dbo].[Orders](
    [OrderID] [int] IDENTITY(1, 1) NOT NULL,
    [PersonID] [int] NOT NULL,
    [DateCreated] [datetime] NOT NULL,
    [MethodofPurchase] [varchar](50) NOT NULL
  ) ON [PRIMARY]
GO
ALTER TABLE
  [dbo].[OrderDetails] WITH CHECK
ADD
  CONSTRAINT [FK_OrderDetails_Customers] FOREIGN KEY([PersonID]) REFERENCES [dbo].[Customers] ([PersonID])
GO
ALTER TABLE
  [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Customers]
GO
ALTER TABLE
  [dbo].[OrderDetails] WITH CHECK
ADD
  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId]) REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE
  [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE
  [dbo].[Orders] WITH CHECK
ADD
  CONSTRAINT [FK_Orders_Customer] FOREIGN KEY([PersonID]) REFERENCES [dbo].[Customers] ([PersonID])
GO
ALTER TABLE
  [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customer]
GO
GO
END