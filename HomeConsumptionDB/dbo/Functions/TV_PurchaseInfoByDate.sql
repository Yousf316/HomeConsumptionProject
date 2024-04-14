-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TV_PurchaseInfoByDate] 
(	
	-- Add the parameters for the function here
@DateFrom Date , @DateTo Date

)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * FROM [dbo].View_PurchasesInfo
	where View_PurchasesInfo.IssueDate between @DateFrom and @DateTo
)