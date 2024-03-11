
 CREATE PROCEDURE [dbo].[sp_insert_Purchase_SubCategories]
@p_SubCategoryName nvarchar(50),
@p_PCategoryID int  ,
@_PSCategoryID int output
AS
BEGIN
	Insert into Purchase_SubCategories (SubCategoryName,PCategoryID)
	values(@p_SubCategoryName,@p_PCategoryID)

	set @_PSCategoryID = @@IDENTITY;
END