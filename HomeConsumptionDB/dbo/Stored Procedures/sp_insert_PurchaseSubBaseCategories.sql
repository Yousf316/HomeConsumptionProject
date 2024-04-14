
 CREATE PROCEDURE [dbo].[sp_insert_PurchaseSubBaseCategories]
@p_PSCategory int,
@p_PCategory int  ,
@CreatedByUserID int null,
@UpdatedByUserID int null
AS
BEGIN
	Insert into PurchaseSubBaseCategories (PSCategoryID,PCategoryID,[CreatedByUserID],[UpdatedByUserID])
	values(@p_PSCategory,@p_PCategory,@CreatedByUserID,@UpdatedByUserID)
END