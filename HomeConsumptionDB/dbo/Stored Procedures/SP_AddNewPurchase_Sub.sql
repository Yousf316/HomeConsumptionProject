CREATE PROCEDURE [dbo].[SP_AddNewPurchase_Sub]
	-- Add the parameters for the stored procedure here
	  @PurchaseID int ,
	  
      @ItemID int,
      @ItemName nvarchar(255),
      @Size int null,
	  @Description nvarchar(max) null,
	  @ItemPrice smallmoney ,
	  @Quantity smallmoney,
	  @TotalAmount smallmoney,
	  @P_subID int 
AS
BEGIN
	INSERT INTO [dbo].[Purchases_sub]
           ([PurchaseID]
		   ,[P_subID]
           ,[ItemID]
           ,[ItemName]
           ,[Size]
           ,[Description]
           ,[ItemPrice]
           ,[Quantity]
           ,[TotalAmount])
     VALUES
           ( @PurchaseID ,
	   @P_subID,
      @ItemID ,
      @ItemName ,
	  @Size,
	  @Description,
	  @ItemPrice,
	  @Quantity,
	  @TotalAmount);

	
	   
END