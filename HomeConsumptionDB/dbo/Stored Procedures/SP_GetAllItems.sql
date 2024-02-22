-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetAllItems]
		@PageNumber int,
		@RowCountPerPage  int,
		@RowCount int output
	
AS
BEGIN

	SELECT @RowCount=count(*) FROM [dbo].Items

	
	SELECT * FROM [dbo].Items 
	Order By ItemID
	offset (@PageNumber -1)*@RowCountPerPage rows
	Fetch Next @RowCountPerPage rows only;
END
