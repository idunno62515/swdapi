CREATE TABLE [dbo].[CategoryExtra] (
    [CategoryExtraId]     INT IDENTITY (1, 1) NOT NULL,
    [PrimaryCategoryCode] INT NOT NULL,
    [ExtraCategoryCode]   INT NOT NULL,
    [IsEnable]            BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoryExtraId] ASC)
);

