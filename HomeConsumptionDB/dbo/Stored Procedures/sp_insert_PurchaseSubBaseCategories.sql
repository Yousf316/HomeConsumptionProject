
 CREATE PROCEDURE [dbo].[sp_insert_PurchaseSubBaseCategories]
@p_PSCategory int,
@p_PCategory int  
AS
BEGIN
	Insert into PurchaseSubBaseCategories (PSCategoryID,PCategoryID)
	values(@p_PSCategory,@p_PCategory)
END