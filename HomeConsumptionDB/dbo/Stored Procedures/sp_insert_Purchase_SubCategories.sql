
 CREATE PROCEDURE [dbo].[sp_insert_Purchase_SubCategories]
@p_SubCategoryName nvarchar(50),

@_PSCategoryID int output
AS
BEGIN
	Insert into Purchase_SubCategories (SubCategoryName)
	values(@p_SubCategoryName)

	set @_PSCategoryID = @@IDENTITY;
END