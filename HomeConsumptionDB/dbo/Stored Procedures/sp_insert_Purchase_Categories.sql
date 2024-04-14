
 CREATE PROCEDURE [dbo].[sp_insert_Purchase_Categories]
@out_error_number INT = 0 OUTPUT,
@p_CategoryName nvarchar(50)  ,
@CreatedByUserID int null,
@UpdatedByUserID int null,
@p_PCategoryID int  Output
AS
BEGIN
BEGIN TRY
	Insert into Purchase_Categories (CategoryName,[CreatedByUserID],[UpdatedByUserID])
	values(@p_CategoryName,@CreatedByUserID,@UpdatedByUserID)


	set @p_PCategoryID = @@IDENTITY;
END TRY
BEGIN CATCH
	SELECT @out_error_number=ERROR_NUMBER()
END CATCH
END