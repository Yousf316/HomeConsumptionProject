

CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByTypeName]
		@PageNumber int,
		@RowCountPerPage  int,
		@TypeName nvarchar,
		@RowCount int output
	   
	AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo
	 where TypeName = @TypeName;
	
	SELECT * FROM [dbo].View_PurchasesInfo
	 where TypeName = @TypeName
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END