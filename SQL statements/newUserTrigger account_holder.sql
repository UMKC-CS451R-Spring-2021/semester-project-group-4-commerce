

ALTER TRIGGER after_account_holder_insert on dbo.account_holder
AFTER INSERT
AS
BEGIN
	DECLARE @ID_Num int;
	SELECT @ID_Num = ID_Num FROM inserted;

	EXEC spBuildNewUser_account @ID_Num;
END