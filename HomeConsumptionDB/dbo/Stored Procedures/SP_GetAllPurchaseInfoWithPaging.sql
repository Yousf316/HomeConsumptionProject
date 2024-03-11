
CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPaging]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo

	
	SELECT * FROM [dbo].View_PurchasesInfo
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END