
 CREATE PROCEDURE [dbo].[sp_update_Purchase_SubCategories]
@p_SubCategoryName nvarchar(50),

@w_PSCategoryID int ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
	UPDATE [dbo].Purchase_SubCategories SET SubCategoryName=@p_SubCategoryName
	,[CreatedByUserID] = @CreatedByUserID
	,[UpdatedByUserID] =@UpdatedByUserID
	WHERE PSCategoryID=@w_PSCategoryID
END