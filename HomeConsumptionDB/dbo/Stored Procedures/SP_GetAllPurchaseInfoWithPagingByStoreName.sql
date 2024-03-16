

CREATE PROCEDURE [dbo].[SP_GetAllPurchaseInfoWithPagingByStoreName]
		@PageNumber int,
		@RowCountPerPage  int,
		@StoreName nvarchar(50),
		@RowCount int output
	   
	AS
BEGIN

	SELECT @RowCount=count(*) FROM  View_PurchasesInfo
	where StoreName like '%'+@StoreName+'%';
	
	SELECT * FROM [dbo].View_PurchasesInfo
	where StoreName like '%'+@StoreName+'%'
	Order By PurchaseID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;

END