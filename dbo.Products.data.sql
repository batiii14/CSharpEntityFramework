CREATE TABLE [dbo].[Products] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [UnitPrice]   MONEY        NOT NULL,
    [StockAmount] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([Id], [Name], [UnitPrice], [StockAmount]) VALUES (1, N'Gaming Laptop', CAST(5000.0000 AS Money), 20)
INSERT INTO [dbo].[Products] ([Id], [Name], [UnitPrice], [StockAmount]) VALUES (2005, N'Mouse', CAST(1300.0000 AS Money), 12)
INSERT INTO [dbo].[Products] ([Id], [Name], [UnitPrice], [StockAmount]) VALUES (2006, N'Gun', CAST(10000.0000 AS Money), 5)
INSERT INTO [dbo].[Products] ([Id], [Name], [UnitPrice], [StockAmount]) VALUES (2007, N'Machine-Gun', CAST(100000.0000 AS Money), 2)
INSERT INTO [dbo].[Products] ([Id], [Name], [UnitPrice], [StockAmount]) VALUES (2008, N'Rocket Launcher', CAST(30000000.0000 AS Money), 1)
INSERT INTO [dbo].[Products] ([Id], [Name], [UnitPrice], [StockAmount]) VALUES (2009, N'Phone', CAST(500.0000 AS Money), 22)
SET IDENTITY_INSERT [dbo].[Products] OFF
