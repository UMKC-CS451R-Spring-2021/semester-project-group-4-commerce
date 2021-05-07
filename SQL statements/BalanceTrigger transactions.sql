--CREATE TRIGGER after_transactions_insert ON dbo.transactions

ALTER TRIGGER after_transactions_insert ON dbo.transactions
FOR INSERT
AS
BEGIN
	DECLARE @Balance decimal(10,2);
	DECLARE @Account_Num bigint;
	SELECT @Balance = Balance FROM inserted;
	SELECT @Account_Num = Account_Num FROM inserted;

	EXEC spUpdate_Balance_account @Balance, @Account_Num;
END