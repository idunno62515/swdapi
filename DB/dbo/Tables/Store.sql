CREATE TABLE [dbo].[Store] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [StoreCode]    INT            NOT NULL,
    [Name]         NVARCHAR (50)  NOT NULL,
    [Address]      NVARCHAR (50)  NOT NULL,
    [Lat]          NVARCHAR (50)  NULL,
    [Lon]          NVARCHAR (50)  NULL,
    [isAvailable]  BIT            NULL,
    [Email]        NVARCHAR (50)  NULL,
    [Phone]        NVARCHAR (50)  NULL,
    [Fax]          NVARCHAR (50)  NULL,
    [CreateDate]   DATETIME       NULL,
    [Type]         INT            NOT NULL,
    [RoomRentMode] INT            NULL,
    [ReportDate]   DATETIME       NULL,
    [ShortName]    NVARCHAR (100) NULL,
    [IsUsed]       BIT            NOT NULL,
    CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED ([Id] ASC)
);

