Create PROC [dbo].[spGetAllTable]
AS
BEGIN
	
	SELECT tab.Id, tab.Number, tab.[Text], tab.[Status] FROM dbo.[Table] AS tab 
END