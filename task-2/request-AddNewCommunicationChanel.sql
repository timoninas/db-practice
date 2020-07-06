USE CS;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
-- Adding a new entry to the Communication Channel with a dependency -- 
-- in the Telecom Operator table                                     --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

drop procedure AddNewCommunicationChanel;

CREATE PROCEDURE AddNewCommunicationChanel(@name_communication VARCHAR(200)) AS
DECLARE 
	@ID_COMMUNICATION_CHANEL INT,
	@ID_OPERATOR INT,
	@NAME_OPERATOR VARCHAR(200);
BEGIN

	SELECT @NAME_OPERATOR = 
	CASE 
		WHEN @name_communication = 'MTC' THEN 'mtc_tech'
		WHEN @name_communication = 'Megafon' THEN 'megafon_tech'
		WHEN @name_communication = 'Tele2' THEN 'tele2_tech'
		WHEN @name_communication = 'Bilain' THEN 'bilain_tech'
		WHEN @name_communication = 'Yota' THEN 'yota_tech'
		WHEN @name_communication = 'Tinkoff' THEN 'tinkoff_tech'
		WHEN @name_communication = 'Vineah' THEN 'vineah_tech'
		ELSE 'unknown_tech'
	END;

	SELECT @ID_COMMUNICATION_CHANEL = MAX(cc.id) + 1 FROM CS.dbo.CommunicationChanel as cc;

	SELECT @ID_OPERATOR = toper.id FROM CS.dbo.TelecomOperator as toper
	WHERE toper.operator = @NAME_OPERATOR;
	
	INSERT INTO CS.dbo.CommunicationChanel(id, id_telecom_operator, name)
	VALUES (@ID_COMMUNICATION_CHANEL, @ID_OPERATOR, @name_communication);

	--INSERT INTO CS.dbo.TelecomOperator(id, operator)
	--VALUES (@ID_OPERATOR, @NAME_OPERATOR);

	SELECT @NAME_OPERATOR, @ID_OPERATOR;
END;

EXEC AddNewCommunicationChanel 'Yota';

SELECT * from CS.dbo.CommunicationChanel;
SELECT * FROM CS.dbo.TelecomOperator;
