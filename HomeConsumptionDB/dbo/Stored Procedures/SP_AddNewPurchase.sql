-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================

CREATE PROCEDURE [dbo].[SP_AddNewPurchase]
	-- Add the parameters for the stored procedure here
	  @IssueDate date ,
	  @TotalBeforTax smallmoney,
      @TaxAmount smallmoney,
      @TotalAfterTax smallmoney,
      @StoreID int,
	  @Discount smallmoney null,
	  @Type int ,
	  @PCategoryID int ,
	  @PSCategoryID int null,
	  @CreatedByUserID int null,
	  @UpdatedByUserID int null,
	  @PurchaseID int out
AS
BEGIN
	INSERT INTO [dbo].[Purchases]
           ([IssueDate]
           ,[TotalBeforTax]
           ,[TaxAmount]
           ,[TotalAfterTax]
           ,[StoreID]
		   ,[Discount]
		   ,[Type]
		   ,[PCategoryID]
		   ,[PSCategoryID]
		   ,[CreatedByUserID]
		   ,[UpdatedByUserID])
     VALUES
           ( @IssueDate ,
	  @TotalBeforTax ,
      @TaxAmount ,
      @TotalAfterTax ,
      @StoreID ,
	  @Discount,
	  @Type,
	  @PCategoryID,
	  @PSCategoryID
	  ,@CreatedByUserID
	  ,@UpdatedByUserID);

	 set @PurchaseID = @@IDENTITY
	 --Test  
END
