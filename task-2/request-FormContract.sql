USE CS;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --
-- A procedure that will record all the information in the main table with   --
-- contracts. When filling in Person, Service, Car, Contract will be formed  --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --

drop procedure FormContract;

CREATE PROCEDURE FormContract(@person_name VARCHAR(100), 
							  @person_lastname VARCHAR(100),
							  @person_gender VARCHAR(100),
							  @person_phone VARCHAR(100),
							  @car_brand VARCHAR(100),
							  @car_model VARCHAR(100),
							  @car_color VARCHAR(100),
							  @car_number VARCHAR(100),
							  @equipment_emei VARCHAR(100),
							  @operator VARCHAR(100)) AS
DECLARE 
	-- Contract
	@ID_CONTRACT INT,
	@DATE_START DATE,
	@DATE_END DATE,

	-- Person
	@ID_PERSON INT,
	@ID_PERSON_COOP_INFO INT,

	-- Car
	@ID_CAR INT,
	@ID_EQUIPMENT INT,
	@ID_MODELCAR INT,
	@ID_CONFIG INT,

	-- Communication Chanel
	@ID_COMMUNICATION_CHANEL INT

BEGIN

	SELECT @DATE_START = CONVERT(DATE, GETDATE());
	SELECT @DATE_END = CONVERT(DATE, DATEADD(year, 8, GETDATE()));

	--EXEC AddNewCommunicationChanel @operator;
	--SELECT @ID_COMMUNICATION_CHANEL = tt.num_id_operator FROM CS.dbo.TmpTable as tt;
	SELECT @ID_COMMUNICATION_CHANEL = 1;
	SELECT @ID_CONFIG = 1;

	---------------------------------------
	--SELECT @ID_MODELCAR = MAX(mc.id) + 1 FROM CS.dbo.ModelCar as mc;
	SELECT @ID_MODELCAR = mc.id FROM CS.dbo.ModelCar as mc
	WHERE mc.mcbrand = @car_brand and mc.mcmodel = @car_model

	IF NOT EXISTS (SELECT mc.id FROM CS.dbo.ModelCar as mc WHERE mc.id = @ID_MODELCAR)
	BEGIN
		INSERT INTO CS.dbo.ModelCar(mcbrand, mcmodel)
		VALUES (@car_brand, @car_model);
		SET @ID_MODELCAR = (SELECT SCOPE_IDENTITY());
	END;
	---------------------------------------

	EXEC GetConfigID @car_brand;
	SELECT @ID_CONFIG = tt.num_id_operator FROM CS.dbo.TmpTable as tt;

	---------------------------------------
	-- Add in Equipment table
	INSERT INTO CS.dbo.Equipment(id_communication_chanel, date_end_maintenance, emei)
	VALUES (@ID_COMMUNICATION_CHANEL, @DATE_END, @equipment_emei);
	SET @ID_EQUIPMENT = (SELECT SCOPE_IDENTITY());
	---------------------------------------

	---------------------------------------
	-- Add in Car table
	INSERT INTO CS.dbo.Car(id_equipment, id_cmodel, id_config, ccolor, cnumber)
	VALUES (@ID_EQUIPMENT, @ID_MODELCAR, @ID_CONFIG, @car_color, @car_number);
	SET @ID_CAR = (SELECT SCOPE_IDENTITY());
	---------------------------------------

	---------------------------------------
	-- Add in PersonInfo table
	INSERT INTO CS.dbo.PersonInfo(paddress, pphone, pemail)
	VALUES ('', @person_phone, '');
	SET @ID_PERSON_COOP_INFO = (SELECT SCOPE_IDENTITY());
	---------------------------------------

	---------------------------------------
	-- Add in Person table
	INSERT INTO CS.dbo.Person(id_personinfo, pname, plastname, pgender)
	VALUES (@ID_PERSON_COOP_INFO, @person_name, @person_lastname, @person_gender);
	SET @ID_PERSON = (SELECT SCOPE_IDENTITY());
	---------------------------------------

	---------------------------------------
	-- Add in Contracts table
	INSERT INTO CS.dbo.Contracts(id_car, id_person, id_service, date_start, date_end)
	VALUES (@ID_CAR, @ID_PERSON, 0, @DATE_START, @DATE_END);
	SET @ID_CONTRACT = (SELECT SCOPE_IDENTITY());
	---------------------------------------

END;

exec FormContract 'Bar', 'Baz', 'Man', 'email@mail.ru', 'Cadillac', 'X29', 'Bluebi', 'TT777T777', 'JKWNNGKWEJNGKWE', 'Yota';

exec DeleteExtraCells;

SELECT * from CS.dbo.ModelCar;
SELECT * FROM CS.dbo.Car;
SELECT * FROM CS.dbo.Contracts;
SELECT * FROM CS.dbo.Person;
SELECT * FROM CS.dbo.PersonInfo;
SELECT * FROM CS.dbo.Equipment;
SELECT * FROM CS.dbo.CommunicationChanel;
SELECT * FROM CS.dbo.PersonInfo as c

-- -- -- -- -- -- -- - --
-- Delete Extra Cells  --
-- -- -- -- -- -- -- - --
DROP PROCEDURE DeleteExtraCells;

CREATE PROCEDURE DeleteExtraCells AS
BEGIN

	DELETE FROM CS.dbo.Contracts
	WHERE CS.dbo.Contracts.id > 1000;

	DELETE FROM CS.dbo.Person
	WHERE CS.dbo.Person.id > 249;

	DELETE FROM CS.dbo.PersonInfo
	WHERE CS.dbo.PersonInfo.id > 249;

	DELETE FROM CS.dbo.Car
	WHERE CS.dbo.Car.id > 349;
END;
