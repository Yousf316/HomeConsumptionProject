
 CREATE PROCEDURE [dbo].[sp_update_PurchaseSubBaseCategories]
@p_PSCategory int,
@p_PCategory int ,
@w_PSCategory int,
@w_PCategory int 
AS
BEGIN
	UPDATE [dbo].PurchaseSubBaseCategories SET PSCategoryID=@p_PSCategory,PCategoryID=@p_PCategory 
	WHERE PSCategoryID=@w_PSCategory AND PCategoryID=@w_PCategory
END