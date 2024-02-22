-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 

CREATE PROCEDURE SP_GetCategoryByName 
	-- Add the parameters for the stored procedure here
	@NameCategory nvarchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	select * from Categories where CategoryName = @NameCategory;

    -- Insert statements for procedure here
	
END
