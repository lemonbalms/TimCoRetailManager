CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(128) NOT NULL, 
    [Description] NVARCHAR(256) NOT NULL, 
	[RetailPrice] MONEY NOT NULL,
    [QuantityInStock] INT NOT NULL DEFAULT 1,
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] DATETIME2 NOT NULL DEFAULT getutcdate()
)
