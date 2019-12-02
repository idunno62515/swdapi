CREATE TABLE [dbo].[OrderDetailPromotionMapping] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [OrderDetailId]       INT            NOT NULL,
    [PromotionCode]       NVARCHAR (250) NOT NULL,
    [PromotionDetailCode] NVARCHAR (250) NOT NULL,
    [MappingIndex]        INT            NOT NULL,
    [DiscountAmount]      MONEY          NULL,
    [DiscountRate]        INT            NULL,
    [TmpMappingId]        INT            NULL,
    CONSTRAINT [PK_OrderDetailPromotionMapping] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderDetailPromotionMapping_OrderDetail] FOREIGN KEY ([OrderDetailId]) REFERENCES [dbo].[OrderDetail] ([OrderDetailID])
);

