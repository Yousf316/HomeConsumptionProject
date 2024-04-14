
 CREATE PROCEDURE [dbo].[sp_insert_Purchase_SubCategories]
@p_SubCategoryName nvarchar(50),
@CreatedByUserID int null,
@UpdatedByUserID int null,
@_PSCategoryID int output
AS
BEGIN
	Insert into Purchase_SubCategories (SubCategoryName,[CreatedByUserID],[UpdatedByUserID])
	values(@p_SubCategoryName,@CreatedByUserID,@UpdatedByUserID)

	set @_PSCategoryID = @@IDENTITY;
END