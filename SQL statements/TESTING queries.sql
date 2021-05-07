/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [City]
      ,[Temperature]
  FROM [BasicAuth].[dbo].[WeatherForecasts]

  ALTER TABLE transactions
ALTER COLUMN Amount decimal(10,2);
DROP TABLE transactions;


UPDATE transactions
SET Account_Num = 211111118
WHERE Account_Num = 10002;


INSERT INTO WeatherForecasts (City, Temperature)
VALUES
		('Kansas City', 70),
		('somewhere else', 77);

EXEC spTimeFrameNotification_transaction 
	100, 
	'1/1/2020 18:00:00.0', 
	'1/1/2020 18:00:00.001',
	'DR', 
	99, 
	'testing',
	-100,
	'Here';



INSERT INTO transactions 
		(Account_Num, Processing_Date, Type, Amount, Description, Balance, Location)
VALUES
		(100, '1/1/2020 17:00:00.000', 'DR', 10, 'testing notifications', -10, 'db query');
		-- 18:00:00.001 is not within range, but 18:00:00.002 is... odd
		-- 22:59:59.999 is not within range, but 22:59:59.998 is... huh?



		------ For customizing notifications -------
--INSERT INTO notificationParameters
--		(Account_Num, Start_Time, End_Time, High_Trans_Amount, Low_Balance_Amount)
--VALUES
--		(100, '22:00:00.000', 

