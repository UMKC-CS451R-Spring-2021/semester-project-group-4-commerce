--CREATE PROCEDURE spNotifications_transaction


ALTER PROCEDURE spNotifications_transaction 
	@Trans_Num int,						
	@Account_Num bigint,
	@Processing_Date date,
	@Processing_Time time,
	@Type varchar(2),
	@Amount decimal(10,2),
	@Description varchar(100),
	@Balance decimal(10,2),
	@Location varchar(50)
AS
BEGIN
	
	DECLARE @leftTime time;
	DECLARE @rightTime time;
	DECLARE @highTrans decimal(10, 2);
	DECLARE @lowBal decimal(10,2);

	SET @leftTime = '22:00:00.0';		-- less than is earlier in the day
	SET @rightTime = '6:00:00.0';		-- to customize, take input for values 
	SET @highTrans = 100.00;			-- SELECT FROM dbo.notificationParameters
	SET @lowBal = 100.00;


------------- Timeframe Notification check -------------------------

	IF (@rightTime < @leftTime)
	BEGIN
		IF ((@Processing_Time > @leftTime) OR (@Processing_Time < @rightTime))
		BEGIN
			PRINT 'within timeframe (over midnight), fire notification';
			INSERT INTO notificationList 
					(Account_Num, Message, Date, Time, Notification_Type)
			VALUES	(@Account_Num, 
					'A transaction was made outside of your normal operation hours',
					@Processing_Date,
					@Processing_Time, 
					1);
		END
	END
	ELSE IF (@rightTime > @leftTime)
	BEGIN
		IF ((@Processing_Time > @leftTime) AND (@Processing_Time < @rightTime))
		BEGIN
			PRINT 'within timeframe (NOT over midnight), fire notification';
			INSERT INTO notificationList 
					(Account_Num, Message, Date, Time, Notification_Type)
			VALUES	(@Account_Num, 
					'A transaction was made outside of your normal operation hours',
					@Processing_Date,
					@Processing_Time, 
					1);
		END
	END
	ELSE	-- This isnt working but it isn't needed either
		PRINT 'not within timeframe, DO NOT fire notification';

------------- Timeframe Notification check end ---------------------



------------- High Withdrawal Amount notification check ------------

	IF ((Abs(@Amount) >= @highTrans) AND (@Type = 'DR'))
	BEGIN
		PRINT 'High withdrawal amount, Fire notification';
		INSERT INTO notificationList 
				(Account_Num, Message, Date, Time, Notification_Type)
		VALUES	(@Account_Num, 
				'A $' + cast(Abs(@Amount) AS varchar) + ' transaction was made',
				@Processing_Date,
				@Processing_Time, 
				2);
	END
	ELSE IF (@Type = 'CR')
		PRINT 'Transaction is a deposit, no notification needed';
	ELSE
		PRINT 'Withdrawal is below $100.00, no notification needed';

------------- High Withdrawal Amount notification check end --------



------------- Low Balance/Overdraft notification check -------------

	IF (@Balance < 0)
	BEGIN
		PRINT 'OVERDRAFT on account, FIRE notification';
		INSERT INTO notificationList 
				(Account_Num, Message, Date, Time, Notification_Type)
		VALUES	(@Account_Num, 
				'A transaction has overdrafted your account',
				@Processing_Date,
				@Processing_Time, 
				4);
	END
	ELSE IF (@Balance < @lowBal)
	BEGIN
		PRINT 'Low Balance on account, FIRE notification';
		INSERT INTO notificationList 
				(Account_Num, Message, Date, Time, Notification_Type)
		VALUES	(@Account_Num, 
				'Low Balance Alert',
				@Processing_Date,
				@Processing_Time, 
				3);
	END
	ELSE
		PRINT 'Balance is ' + cast(@lowBal as varchar) + ' or greater, no notification needed';

------------- Low Balance/Overdraft notification check end ---------

END