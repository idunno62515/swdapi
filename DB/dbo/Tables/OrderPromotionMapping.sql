CREATE TABLE [dbo].[OrderPromotionMapping] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [OrderId]             INT            NOT NULL,
    [PromotionCode]       NVARCHAR (250) NOT NULL,
    [PromotionDetailCode] NVARCHAR (250) NOT NULL,
    [MappingIndex]        INT            NOT NULL,
    [DiscountAmount]      MONEY          NULL,
    [DiscountRate]        INT            NULL,
    [TmpMappingId]        INT            NULL,
    CONSTRAINT [PK_OrderPromotionMapping] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderPromotionMapping_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId])
);

