

create PROCEDURE [dbo].[SP_GetAllSizesInfoWithPaging]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].Sizes

	
	SELECT * FROM [dbo].Sizes
	Order By SizeID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END