CREATE TABLE [dbo].[Table] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Number]           NVARCHAR (50)  NULL,
    [Text]             NVARCHAR (MAX) NULL,
    [Status]           INT            NULL,
    [DisplayOrder]     INT            NOT NULL,
    [IsCircle]         BIT            NOT NULL,
    [TableRow]         INT            NOT NULL,
    [TableColumn]      INT            NOT NULL,
    [SpanTableRow]     INT            NOT NULL,
    [SpanTableColumn]  INT            NOT NULL,
    [Floor]            INT            NOT NULL,
    [CurrentOrderId]   INT            NULL,
    [CurrentOrderDate] DATETIME       NULL,
    [ForOrderType]     INT            NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Id] ASC)
);

