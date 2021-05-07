--CREATE TRIGGER after_AspNetUsers_insert_EmailConfirmed ON dbo.AspNetUsers

ALTER TRIGGER after_AspNetUsers_insert_EmailConfirmed ON dbo.AspNetUsers
AFTER INSERT
AS
BEGIN
	DECLARE @Email varchar(50);
	SELECT @Email = Email FROM inserted;

	UPDATE AspNetUsers
	SET EmailConfirmed = 1
	WHERE Email = @Email;

END