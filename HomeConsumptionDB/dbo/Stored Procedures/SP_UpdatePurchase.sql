

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
	  @PSCategoryID int null,
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
	  [PCategoryID]     =@PCategoryID,
	  [PSCategoryID] = @PSCategoryID

 WHERE [dbo].[Purchases].PurchaseID = @PurchaseID
	  return select @@ROWCOUNT
END
