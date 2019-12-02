CREATE TABLE [dbo].[ProductExtra] (
    [ProductExtraId]     INT           IDENTITY (1, 1) NOT NULL,
    [PrimaryProductCode] NVARCHAR (50) NOT NULL,
    [ExtraProductCode]   NVARCHAR (50) NOT NULL,
    [IsEnable]           BIT           NOT NULL,
    [IsDisplayed]        BIT           NULL,
    [MaxItem]            INT           NULL,
    [Price]              FLOAT (53)    NULL,
    [TimeStamp]          NUMERIC (18)  NULL,
    [IsUsed]             BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductExtraId] ASC)
);

