

CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByTotalAfterTax]
		@PageNumber int,
		@RowCountPerPage  int,
		@TotalAfterTax smallmoney,
		@RowCount int output
	   
	AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo
	where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1
	
	SELECT * FROM [dbo].View_PurchasesInfo
		 where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1
		 Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END