

Create PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByDateofType]
		@PageNumber int,
		@RowCountPerPage  int,
		@DateFrom  date,
		@DateTo  Date,
		@TypeName nvarchar,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*)  FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
  where TypeName = @TypeName;


	
	WITH ROWCTE AS (

   SELECT * FROM [dbo].[TV_PurchaseInfoByDate] (
   @DateFrom,
  @DateTo)
   where TypeName =@TypeName
)
SELECT * FROM ROWCTE
	Order By ROWCTE.PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END