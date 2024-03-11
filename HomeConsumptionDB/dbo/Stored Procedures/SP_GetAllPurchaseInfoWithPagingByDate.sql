

CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDate]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo);


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END