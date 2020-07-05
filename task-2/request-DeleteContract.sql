USE CS;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- - --
-- Create a procedure that deletes a row in --  
-- table Contract  with all dependencies    --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- - --

drop procedure DeleteContractWithID;

CREATE PROCEDURE DeleteContractWithID(@ID INT) AS
DECLARE 
	@ID_PERSON INT,
	@ID_PERSON_COOP_INFO INT,
	@ID_CAR INT,
	@ID_EQUIPMENT INT;
BEGIN

	SELECT @ID_PERSON = c.id_person FROM CS.dbo.Contracts as c
	WHERE c.id = @ID;

	SELECT @ID_PERSON_COOP_INFO = p.id_personinfo FROM CS.dbo.Person as p
	WHERE p.id = @ID_PERSON;

	SELECT @ID_CAR = c.id_car FROM CS.dbo.Contracts as c
	WHERE c.id = @ID;

	SELECT @ID_EQUIPMENT = cr.id_equipment FROM CS.dbo.Car as cr
	WHERE cr.id = @ID_CAR;

	-- DELETE CONTRACT
	DELETE FROM CS.dbo.Contracts
	WHERE CS.dbo.Contracts.id = @ID;

	-- DELETE PERSON
	IF EXISTS (SELECT @ID_PERSON) DELETE FROM CS.dbo.Person
	WHERE CS.dbo.Person.id = @ID_PERSON;

	-- DELETE PERSON COOP INFO
	IF EXISTS (SELECT @ID_PERSON_COOP_INFO) DELETE FROM CS.dbo.PersonInfo
	WHERE CS.dbo.PersonInfo.id = @ID_PERSON_COOP_INFO;

	-- DELETE CAR
	IF EXISTS (SELECT @ID_CAR) DELETE FROM CS.dbo.Car
	WHERE CS.dbo.Car.id = @ID_CAR;

	-- DELETE EQUIPMENT
	IF EXISTS (SELECT @ID_EQUIPMENT) DELETE FROM CS.dbo.Equipment
	WHERE CS.dbo.Equipment.id = @ID_EQUIPMENT;

	-- DELETE MESSAGES
	IF EXISTS (SELECT @ID_EQUIPMENT) DELETE FROM CS.dbo.Message
	WHERE CS.dbo.Message.id_equipment = @ID_EQUIPMENT;

	SELECT @ID, @ID_PERSON, @ID_PERSON_COOP_INFO, @ID_CAR, @ID_EQUIPMENT;
	--delete message with id_equipment id
END;

EXEC DeleteContractWithID 247;
