

ALTER TRIGGER after_AspNetUsers_insert ON dbo.AspNetUsers
AFTER INSERT 
AS
BEGIN
	DECLARE @Email NVARCHAR(256);
	SELECT @Email = Email FROM inserted;

	EXEC spBuildNewUser_Account_Holder @Email;

	--SELECT * FROM AspNetUsers		-- for testing 
	--WHERE Id = @Id;

END


--INSERT INTO AspNetUsers (Id, UserName, EmailConfirmed, AccessFailedCount, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled)
--VALUES ('1', 'hello', 'true', 0, 'false', 'false', 'true');