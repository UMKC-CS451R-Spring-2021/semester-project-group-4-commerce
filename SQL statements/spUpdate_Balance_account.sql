

ALTER PROCEDURE spUpdate_Balance_account
	@Balance decimal(10, 2), 
	@Account_Num bigint
AS
BEGIN
	UPDATE account
	SET Balance = @Balance
	WHERE Account_Num = @Account_Num;

END