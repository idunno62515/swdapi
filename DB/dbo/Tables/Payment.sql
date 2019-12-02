CREATE TABLE [dbo].[Payment] (
    [PaymentID]        INT            IDENTITY (1, 1) NOT NULL,
    [OrderId]          INT            NOT NULL,
    [Amount]           FLOAT (53)     NOT NULL,
    [CurrencyCode]     CHAR (5)       NULL,
    [FCAmount]         MONEY          NOT NULL,
    [Notes]            NVARCHAR (250) NULL,
    [PayTime]          DATETIME       NOT NULL,
    [Status]           INT            NOT NULL,
    [Type]             INT            NOT NULL,
    [CardCode]         NVARCHAR (50)  NULL,
    [Code]             NVARCHAR (MAX) NULL,
    [Active]           BIT            NULL,
    [PaymentCode]      NVARCHAR (30)  NULL,
    [CustomerName]     NVARCHAR (100) NULL,
    [MembershipTypeId] INT            NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([PaymentID] ASC),
    CONSTRAINT [FK_Payment_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId])
);

