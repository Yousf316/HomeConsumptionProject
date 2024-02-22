
CREATE PROCEDURE [dbo].[SP_GetAllPurchase]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].[Purchases]

	
	SELECT * FROM [dbo].[Purchases]
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END