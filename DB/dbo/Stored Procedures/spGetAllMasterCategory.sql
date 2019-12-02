CREATE PROC spGetAllMasterCategory
AS
BEGIN
SELECT [c].[Id], [c].[Name]  FROM [dbo].[Category] c WHERE c.[MasterCategory] IS NULL AND  [c].[IsUsed] = 1
END