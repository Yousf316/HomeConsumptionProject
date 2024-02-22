CREATE PROCEDURE SP_SearchStoresByName
    @StoreName NVARCHAR(80)
AS
BEGIN
    SELECT * FROM Stores WHERE StoreName LIKE N'%' + @StoreName + '%'
END
