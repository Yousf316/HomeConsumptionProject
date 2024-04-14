
 CREATE PROCEDURE [dbo].[sp_insert_People]
@p_FirstName nvarchar(20),
@p_SecondName nvarchar(20),
@p_ThirdName nvarchar(20),
@p_LastName nvarchar(20),
@p_PhoneNumber nvarchar(20),
@p_Email nvarchar(50),
@p_NationalityCountryID int,
@CreatedByUserID int null,
@UpdatedByUserID int null,
@PersonID int output
AS
BEGIN
	Insert into People (FirstName,SecondName,ThirdName,LastName,PhoneNumber,Email,NationalityCountryID,[CreatedByUserID],[UpdatedByUserID])
	values(@p_FirstName,@p_SecondName,@p_ThirdName,@p_LastName,@p_PhoneNumber,@p_Email,@p_NationalityCountryID,@CreatedByUserID,@UpdatedByUserID)
	set @PersonID = @@IDENTITY;
END