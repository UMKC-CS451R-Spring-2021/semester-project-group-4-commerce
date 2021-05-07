--CREATE PROCEDURE spNotifications_transaction


ALTER PROCEDURE spNotifications_transaction 
	@Trans_Num int,						
	@Account_Num bigint,
	@Processing_Datetime datetime,		-- added for front end c#
	@Processing_Date date,
	@Processing_Time time,
	@Type varchar(2),
	@Amount decimal(10,2),
	@Description varchar(100),
	@Balance decimal(10,2),
	@Location varchar(50)
AS
BEGIN
	
	DECLARE @Timeframe_Is_On bit;
	DECLARE @leftTime time;
	DECLARE @rightTime time;
	DECLARE @Large_Withdrawal_Is_On bit;
	DECLARE @highTrans decimal(10, 2);
	DECLARE @Low_Balance_Is_On bit;
	DECLARE @lowBal decimal(10,2);

	SET @Timeframe_Is_On =		(SELECT Timeframe_Is_On
								FROM notificationParameters
								WHERE Account_Num = @Account_Num)
	
	SET @leftTime =				(SELECT Begin_Time 
								FROM notificationParameters
								WHERE Account_Num = @Account_Num)	-- less is earlier in the day
	
	SET @rightTime =			(SELECT End_Time 
								FROM notificationParameters
								WHERE Account_Num = @Account_Num)	 
	SET @Large_Withdrawal_Is_On=(SELECT Large_Withdrawal_Is_On
								FROM notificationParameters
								WHERE Account_Num = @Account_Num)	
								
	SET @highTrans =			(SELECT Withdrawal_Amount 
								FROM notificationParameters
								WHERE Account_Num = @Account_Num)	
	SET @Low_Balance_Is_On =	(SELECT Low_Balance_Is_On
								FROM notificationParameters
								WHERE Account_Num = @Account_Num)	

	SET @lowBal =				(SELECT Low_Balance_Threshold 
								FROM notificationParameters
								WHERE Account_Num = @Account_Num)


----------------- Timeframe Notification check -------------------------

	IF (@Timeframe_Is_On = 1)
	BEGIN
		IF (@rightTime < @leftTime)
		BEGIN
			IF ((@Processing_Time > @leftTime) OR (@Processing_Time < @rightTime))
			BEGIN
				PRINT 'within timeframe (over midnight), fire notification';
				INSERT INTO notificationList 
						(Account_Num, Message, Date, Notification_Type)
				VALUES	(@Account_Num, 
						'A transaction was made outside of your normal operation hours',
						@Processing_Datetime, 
						1);
			END
		END
		ELSE IF (@rightTime > @leftTime)
		BEGIN
			IF ((@Processing_Time > @leftTime) AND (@Processing_Time < @rightTime))
			BEGIN
				PRINT 'within timeframe (NOT over midnight), fire notification';
				INSERT INTO notificationList 
						(Account_Num, Message, Date, Notification_Type)
				VALUES	(@Account_Num, 
						'A transaction was made outside of your normal operation hours',
						@Processing_Datetime, 
						1);
			END
		END
		ELSE	-- This isnt working but it isn't needed either
			PRINT 'not within timeframe, DO NOT fire notification';
	END

----------------- Timeframe Notification check end ---------------------



----------------- High Withdrawal Amount notification check ------------

	IF (@Large_Withdrawal_Is_On = 1)
	BEGIN
		IF ((Abs(@Amount) >= @highTrans) AND (@Type = 'DR'))
		BEGIN
			PRINT 'High withdrawal amount, Fire notification';
			INSERT INTO notificationList 
					(Account_Num, Message, Date, Notification_Type)
			VALUES	(@Account_Num, 
					'A $' + cast(Abs(@Amount) AS varchar) + ' transaction was made',
					@Processing_Datetime, 
					2);
		END
		ELSE IF (@Type = 'CR')
			PRINT 'Transaction is a deposit, no notification needed';
		ELSE
			PRINT 'Withdrawal is below $100.00, no notification needed';
	END

----------------- High Withdrawal Amount notification check end --------



----------------- Low Balance/Overdraft notification check -------------
	

	IF (@Balance < 0)
	BEGIN
		PRINT 'OVERDRAFT on account, FIRE notification';
		INSERT INTO notificationList 
				(Account_Num, Message, Date, Notification_Type)
		VALUES	(@Account_Num, 
				'A transaction has overdrafted your account',
				@Processing_Datetime, 
				4);
	END
	ELSE IF ((@Balance < @lowBal) AND (@Low_Balance_Is_On = 1))
	BEGIN
		PRINT 'Low Balance on account, FIRE notification';
		INSERT INTO notificationList 
				(Account_Num, Message, Date, Notification_Type)
		VALUES	(@Account_Num, 
				'Low Balance Alert',
				@Processing_Datetime, 
				3);
	END
	ELSE
		PRINT 'Balance is ' + cast(@lowBal as varchar) + ' or greater, no notification needed';


----------------- Low Balance/Overdraft notification check end ---------

END