

CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofTotalAfterTax]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@TotalAfterTax smallmoney,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
  where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1;


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
   where TotalAfterTax between @TotalAfterTax and @TotalAfterTax+1
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END