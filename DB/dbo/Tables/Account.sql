CREATE TABLE [dbo].[Account] (
    [AccountId]       NVARCHAR (50)  NOT NULL,
    [AccountPassword] NVARCHAR (MAX) NULL,
    [StaffName]       NVARCHAR (50)  NULL,
    [Role]            NVARCHAR (50)  NOT NULL,
    [IsUsed]          BIT            NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([AccountId] ASC)
);

