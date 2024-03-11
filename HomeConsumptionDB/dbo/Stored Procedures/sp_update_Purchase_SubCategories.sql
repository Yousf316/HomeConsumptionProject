
 CREATE PROCEDURE sp_update_Purchase_SubCategories
@p_SubCategoryName nvarchar(50),
@p_PCategoryID int ,
@w_PSCategoryID int 
AS
BEGIN
	UPDATE [dbo].Purchase_SubCategories SET SubCategoryName=@p_SubCategoryName,PCategoryID=@p_PCategoryID 
	WHERE PSCategoryID=@w_PSCategoryID
END