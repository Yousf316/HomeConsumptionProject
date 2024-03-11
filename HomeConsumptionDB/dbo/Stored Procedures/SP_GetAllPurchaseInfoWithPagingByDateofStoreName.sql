

Create PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofStoreName]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@StoreName  nvarchar(50),
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
  where StoreName like '%'+@StoreName+'%';


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
   where StoreName like '%'+@StoreName+'%'
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END