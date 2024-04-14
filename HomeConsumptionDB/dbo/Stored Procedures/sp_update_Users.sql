
 CREATE PROCEDURE [dbo].[sp_update_Users]
@p_PersonID int,
@p_Password nvarchar(50),
@p_UserName nvarchar(50),

@p_IsActive bit ,
@w_UserID int 
AS
BEGIN
	UPDATE [dbo].Users SET PersonID=@p_PersonID,[Password]=@p_Password,IsActive=@p_IsActive ,[UserName] = @p_UserName
	WHERE UserID=@w_UserID
END