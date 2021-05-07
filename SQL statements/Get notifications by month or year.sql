
  SELECT * FROM notificationList
  --WHERE MONTH(notificationList.Date) > = /* enter varible for start month */ AND MONTH(notificationList.Date) <= /* enter variable for stop month */;		-- works for range of months
  --WHERE notificationList.Date >= DATEADD(month, -1, GETDATE())		-- gets notifications within the last month
  WHERE notificationList.Date >= DATEADD(year, -1, GETDATE())		  -- gets notifications within the last year
	AND Account_Num = (SELECT Account_Num FROM account INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num WHERE account_holder.Email = '" + UserEmail + "');
