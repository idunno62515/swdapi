CREATE TABLE [dbo].[ProductCollectMapping] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [CollectionCode] INT           NULL,
    [ProductCode]    NVARCHAR (50) NULL,
    [Active]         INT           NULL
);

