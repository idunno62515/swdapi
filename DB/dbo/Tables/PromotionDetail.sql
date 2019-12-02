CREATE TABLE [dbo].[PromotionDetail] (
    [PromotionDetailID]   INT            IDENTITY (1, 1) NOT NULL,
    [PromotionCode]       NVARCHAR (250) NOT NULL,
    [RegExCode]           NVARCHAR (50)  NULL,
    [MinOrderAmount]      FLOAT (53)     NULL,
    [MaxOrderAmount]      FLOAT (53)     NULL,
    [BuyProductCode]      NVARCHAR (250) NULL,
    [MinBuyQuantity]      INT            NULL,
    [MaxBuyQuantity]      INT            NULL,
    [GiftProductCode]     NVARCHAR (50)  NULL,
    [PromotionDetailCode] NVARCHAR (250) NOT NULL,
    [GiftQuantity]        INT            NULL,
    [DiscountAmount]      MONEY          NULL,
    [DiscountRate]        INT            NULL,
    [Active]              BIT            NULL,
    [CollectionCode]      INT            NULL,
    CONSTRAINT [PK__Promotio__FF43FD6429572725] PRIMARY KEY CLUSTERED ([PromotionDetailID] ASC)
);

