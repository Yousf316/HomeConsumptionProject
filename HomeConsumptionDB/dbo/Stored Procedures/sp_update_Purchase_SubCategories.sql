
 CREATE PROCEDURE [dbo].[sp_update_Purchase_SubCategories]
@p_SubCategoryName nvarchar(50),

@w_PSCategoryID int 
AS
BEGIN
	UPDATE [dbo].Purchase_SubCategories SET SubCategoryName=@p_SubCategoryName
	WHERE PSCategoryID=@w_PSCategoryID
END