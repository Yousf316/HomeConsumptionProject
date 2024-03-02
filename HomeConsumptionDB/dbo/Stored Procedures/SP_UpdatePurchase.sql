

CREATE PROCEDURE [dbo].[SP_UpdatePurchase]
	-- Add the parameters for the stored procedure here
	  @IssueDate date ,
	  @TotalBeforTax smallmoney,
      @TaxAmount money,
      @TotalAfterTax smallmoney,
      @StoreID int ,
	  @Discount smallmoney null ,
	  @Type int ,
	  @PCategoryID int ,
	  @PurchaseID int 
AS
BEGIN
	UPDATE [dbo].[Purchases]
   SET [IssueDate]     = @IssueDate  ,
      [TotalBeforTax] = @TotalBeforTax ,
      [TaxAmount]     = @TaxAmount ,
      [TotalAfterTax] = @TotalAfterTax ,
      [StoreID]       = @StoreID ,
	  [Discount]       = @Discount,
	  [Type]			=@Type,
	  [PCategoryID]     =@PCategoryID

 WHERE [dbo].[Purchases].PurchaseID = @PurchaseID
	  return select @@ROWCOUNT
END
