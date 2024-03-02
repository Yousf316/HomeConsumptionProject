
 CREATE PROCEDURE [dbo].[sp_insert_Purchase_Categories]
@out_error_number INT = 0 OUTPUT,
@p_CategoryName nvarchar(50)  ,
@p_PCategoryID int  Output
AS
BEGIN
BEGIN TRY
	Insert into Purchase_Categories (CategoryName)
	values(@p_CategoryName)


	set @p_PCategoryID = @@IDENTITY;
END TRY
BEGIN CATCH
	SELECT @out_error_number=ERROR_NUMBER()
END CATCH
END