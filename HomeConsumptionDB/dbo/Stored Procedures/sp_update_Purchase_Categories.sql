
 CREATE PROCEDURE [dbo].[sp_update_Purchase_Categories]
@out_error_number INT = 0 OUTPUT,
@p_CategoryName nvarchar(50) ,
@w_PCategoryID int ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
BEGIN TRY
	UPDATE [dbo].Purchase_Categories SET CategoryName=@p_CategoryName 
	,[CreatedByUserID] = @CreatedByUserID
	,[UpdatedByUserID] =@UpdatedByUserID
	WHERE PCategoryID=@w_PCategoryID
END TRY
BEGIN CATCH
	SELECT @out_error_number=ERROR_NUMBER()
END CATCH
END