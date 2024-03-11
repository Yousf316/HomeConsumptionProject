-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_GetAlltotalPurchase
	-- Add the parameters for the stored procedure here
	@TotalAfterTax smallmoney Output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.


    -- Insert statements for procedure here
	SELECT @TotalAfterTax =sum(TotalAfterTax)
  FROM [HomeConsumptionDB].[dbo].[View_PurchasesInfo]

END