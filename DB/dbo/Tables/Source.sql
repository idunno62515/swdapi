CREATE TABLE [dbo].[Source] (
    [SourceId]      INT            NOT NULL,
    [Name]          NVARCHAR (250) NOT NULL,
    [Address]       NVARCHAR (250) NULL,
    [ContactPerson] NVARCHAR (50)  NULL,
    [Phone]         NVARCHAR (50)  NULL,
    [Email]         NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Source] PRIMARY KEY CLUSTERED ([SourceId] ASC)
);

