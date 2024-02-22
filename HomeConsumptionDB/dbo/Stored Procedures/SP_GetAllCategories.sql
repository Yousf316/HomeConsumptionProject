
Create PROCEDURE [dbo].[SP_GetAllCategories]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].[Categories]

	
	SELECT * FROM [dbo].[Categories] 
	Order By CategoryID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END