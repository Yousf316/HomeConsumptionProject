
 CREATE PROCEDURE [dbo].[sp_insert_Users]
@p_PersonID int,
@p_Password nvarchar(50),
@p_IsActive bit  ,
@UserID int output
AS
BEGIN
	Insert into Users (PersonID,[Password],IsActive)
	values(@p_PersonID,@p_Password,@p_IsActive)
	set @UserID =@@IDENTITY;
END