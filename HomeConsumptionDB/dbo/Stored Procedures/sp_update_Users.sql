
 CREATE PROCEDURE sp_update_Users
@p_PersonID int,
@p_Password nvarchar(50),
@p_IsActive bit ,
@w_UserID int 
AS
BEGIN
	UPDATE [dbo].Users SET PersonID=@p_PersonID,[Password]=@p_Password,IsActive=@p_IsActive 
	WHERE UserID=@w_UserID
END