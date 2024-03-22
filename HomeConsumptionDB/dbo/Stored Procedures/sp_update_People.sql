
 CREATE PROCEDURE sp_update_People
@p_FirstName nvarchar(20),
@p_SecondName nvarchar(20),
@p_ThirdName nvarchar(20),
@p_LastName nvarchar(20),
@p_PhoneNumber nvarchar(20),
@p_Email nvarchar(50),
@p_NationalityCountryID int ,
@w_PersonID int 
AS
BEGIN
	UPDATE [dbo].People SET FirstName=@p_FirstName,SecondName=@p_SecondName,ThirdName=@p_ThirdName,LastName=@p_LastName,PhoneNumber=@p_PhoneNumber,Email=@p_Email,NationalityCountryID=@p_NationalityCountryID 
	WHERE PersonID=@w_PersonID
END