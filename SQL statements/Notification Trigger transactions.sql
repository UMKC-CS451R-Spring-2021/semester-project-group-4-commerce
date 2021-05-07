-- Trigger for notifications

--CREATE TRIGGER after_transactions_Notifications_insert ON dbo.transactions

ALTER TRIGGER after_transactions_Notifications_insert ON dbo.transactions
FOR INSERT
AS
BEGIN
	DECLARE @Trans_Num				int;
	DECLARE @Account_Num			bigint;
	DECLARE @Processing_Datetime	datetime;
	DECLARE @Processing_Date		date;
	DECLARE @Processing_Time		time;
	DECLARE @Type					varchar(2);
	DECLARE @Amount					decimal(10, 2);
	DECLARE @Description			varchar(100);
	DECLARE @Balance				decimal(10, 2);
	DECLARE @Location				varchar(50);

	SELECT 
		@Trans_Num = Trans_Num,
		@Account_Num = Account_Num,
		@Processing_Datetime = Processing_Date,
		@Processing_Date = cast(Processing_Date as date),
		@Processing_Time = cast(Processing_Date as time),
		@Type = Type,
		@Amount = Amount,
		@Description = Description,
		@Balance = Balance,
		@Location = Location		
		FROM inserted;

	EXEC spNotifications_transaction
		@Trans_Num,
		@Account_Num,
		@Processing_Datetime,
		@Processing_Date,
		@Processing_Time,
		@Type,
		@Amount,
		@Description,
		@Balance,	
		@Location;

END