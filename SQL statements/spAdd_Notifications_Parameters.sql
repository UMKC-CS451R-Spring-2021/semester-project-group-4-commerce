--CREATE PROCEDURE spAdd_Notifications_Parameters

ALTER PROCEDURE spAdd_Notifications_Parameters
	@Account_Num bigint
AS
BEGIN
	
	INSERT INTO notificationParameters (Account_Num)
	VALUES (@Account_Num);
END