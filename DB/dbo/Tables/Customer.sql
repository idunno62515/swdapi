CREATE TABLE [dbo].[Customer] (
    [CustomerId]   INT            IDENTITY (1, 1) NOT NULL,
    [CustomerName] NVARCHAR (250) NULL,
    [Address]      NVARCHAR (250) NULL,
    [PhoneNumber]  NVARCHAR (250) NULL,
    [Email]        NVARCHAR (250) NULL,
    [Nationality]  INT            NULL,
    [Notes]        NVARCHAR (250) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

