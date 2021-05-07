--CREATE PROCEDURE spGet_Account_Num

ALTER PROCEDURE spGet_Account_Num
	@User_Email varchar(50)
AS
BEGIN
	SELECT Account_Num FROM account
		INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num
		WHERE account_holder.Email = @User_Email;
END