CREATE TABLE [dbo].[Promotion] (
    [PromotionID]        INT            IDENTITY (1, 1) NOT NULL,
    [PromotionCode]      NVARCHAR (250) NOT NULL,
    [PromotionName]      NVARCHAR (250) NOT NULL,
    [PromotionClassName] NVARCHAR (250) NOT NULL,
    [Description]        NVARCHAR (MAX) NULL,
    [ImageCss]           NVARCHAR (50)  NULL,
    [ApplyLevel]         INT            NOT NULL,
    [GiftType]           INT            NOT NULL,
    [IsForMember]        BIT            NOT NULL,
    [IsActive]           BIT            NOT NULL,
    [FromDate]           DATETIME       NOT NULL,
    [ToDate]             DATETIME       NOT NULL,
    [ApplyFromTime]      INT            NULL,
    [ApplyToTime]        INT            NULL,
    [PromotionType]      INT            NULL,
    [IsVoucher]          BIT            NULL,
    [IsApplyOnce]        BIT            NULL,
    [Active]             BIT            NULL,
    PRIMARY KEY CLUSTERED ([PromotionID] ASC)
);

