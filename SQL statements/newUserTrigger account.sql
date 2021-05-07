--CREATE TRIGGER after_account_insert on dbo.account

ALTER TRIGGER after_account_insert on dbo.account
AFTER INSERT
AS
BEGIN
	DECLARE @Account_Num bigint;
	SELECT @Account_Num = Account_Num FROM inserted;

	EXEC spAdd_Notifications_Parameters @Account_Num;
END