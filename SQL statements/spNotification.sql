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

	SET @leftTime = '18:00:00.0';		-- less than is earlier in the day
	SET @rightTime = '1:00:00.0';		-- to customize, take input for values 
	SET @highTrans = 100.00;			-- SELECT FROM dbo.notificationParameters
	SET @lowBal = 100.00;

	--------- Timeframe Notification check -------------------------
	IF (@rightTime < @leftTime)
	BEGIN
		IF ((@Processing_Time > @leftTime) OR (@Processing_Time < @rightTime))
			PRINT 'within timeframe (over midnight), fire notification'
	END
	ELSE IF (@rightTime > @leftTime)
	BEGIN
		IF ((@Processing_Time > @leftTime) AND (@Processing_Time < @rightTime))
			PRINT 'within timeframe (NOT over midnight), fire notification'
	END
	ELSE
		PRINT 'not within timeframe, DO NOT fire notification';
	--------- Timeframe Notification check end ---------------------

	--------- High Withdrawal Amount notification check ------------
	IF ((@Amount >= @highTrans) AND (@Type = 'DR'))
		PRINT 'High withdrawal amount, Fire notification'
	ELSE IF (@Type = 'CR')
		PRINT 'Transaction is a deposit, no notification needed'
	ELSE
		PRINT 'Withdrawal is below $100.00, no notification needed';
	--------- High Withdrawal Amount notification check end --------

	--------- Low Balance/Overdraft notification check -------------
	IF (@Balance < 0)
		PRINT 'OVERDRAFT on account, FIRE notification'
	ELSE IF (@Balance < @lowBal)
		PRINT 'Low Balance on account, FIRE notification'
	ELSE
		PRINT 'Balance is ' + cast(@lowBal as varchar) + ' or greater, no notification needed';
	--------- Low Balance/Overdraft notification check end ---------

END