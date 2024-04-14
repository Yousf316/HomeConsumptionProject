
 CREATE PROCEDURE [dbo].[sp_update_PurchaseSubBaseCategories]
@p_PSCategory int,
@p_PCategory int ,
@w_PSCategory int,
@w_PCategory int ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
	UPDATE [dbo].PurchaseSubBaseCategories SET PSCategoryID=@p_PSCategory,
	PCategoryID=@p_PCategory 
	,[CreatedByUserID] = @CreatedByUserID
	,[UpdatedByUserID] =@UpdatedByUserID
	WHERE PSCategoryID=@w_PSCategory AND PCategoryID=@w_PCategory
END