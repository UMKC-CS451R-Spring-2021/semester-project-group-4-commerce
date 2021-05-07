


ALTER PROCEDURE spBuildNewUser_Account_Holder @Email nvarchar(50)
AS
BEGIN

	INSERT INTO account_holder (Email)
	VALUES (@Email);

END