
CREATE PROCEDURE SP_GetPurchaseByID

	@PurchaseID int 
AS
BEGIN

	SELECT * FROM [dbo].[Purchases] WHERE PurchaseID =@PurchaseID
END
