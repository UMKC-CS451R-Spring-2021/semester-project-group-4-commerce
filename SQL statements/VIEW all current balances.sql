-- returns current balances of all account holders
DROP VIEW all_current_balances;

CREATE VIEW all_current_balances AS
SELECT First_Name, Last_Name, Balance 
FROM account_holder INNER JOIN account
ON account_holder.ID_Num = account.ID_Num;

SELECT * FROM all_current_balances;