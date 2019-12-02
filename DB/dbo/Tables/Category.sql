CREATE TABLE [dbo].[Category] (
    [Id]                 INT            IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [Code]               INT            NOT NULL,
    [Name]               NVARCHAR (50)  NOT NULL,
    [Type]               INT            NOT NULL,
    [DisplayOrder]       INT            NOT NULL,
    [IsDisplayed]        BIT            NOT NULL,
    [IsUsed]             BIT            NOT NULL,
    [IsExtra]            INT            NULL,
    [AdjustmentNote]     NVARCHAR (250) NULL,
    [ImageFontAwsomeCss] VARCHAR (50)   DEFAULT ('glass') NOT NULL,
    [ParentCateId]       INT            NULL,
    [MasterCategory]     INT            NULL,
    [ShortName]          NVARCHAR (50)  NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

