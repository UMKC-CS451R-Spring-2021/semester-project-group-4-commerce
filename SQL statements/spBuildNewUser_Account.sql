

ALTER PROCEDURE spBuildNewUser_account @ID_Num int
AS
BEGIN
	
	INSERT INTO account (ID_Num)
	VALUES (@ID_Num);

END