use CS
use CS2

SELECT * FROM Contracts;
SELECT * FROM Person;
SELECT * FROM PersonInfo;
SELECT * FROM Serviec;
SELECT * FROM Car;
SELECT * FROM ModelCar;
SELECT * FROM Equipment;
SELECT * FROM CS.dbo.Message;

-- -- -- -- --  -- -- 
-- -  COMMENTY   - --
-- -- -- -- -- - - --
drop procedure GetContracts;

CREATE PROCEDURE GetContracts AS
BEGIN
	SELECT c.id, p.pname, p.plastname, pinf.paddress, pinf.pemail, 
		  pinf.pphone, s.saddress, mc.mcbrand, mc.mcmodel, cr.cnumber FROM Contracts as c
    JOIN Serviec AS s ON s.id = c.id_service
	JOIN Person AS p ON p.id = c.id_person
	JOIN PersonInfo as pinf ON pinf.id = p.id_personinfo
	JOIN Car AS cr ON cr.id = c.id_car
	JOIN ModelCar as mc ON mc.id = cr.id_cmodel
END;

exec GetContracts


-- -- -- -- -- -- -- -- -- -- -- -- -- -- --  
--  Get concrete info about person by id  --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 

DROP FUNCTION GetConcreteCarByID;

CREATE FUNCTION GetConcreteCarByID (@id_person int)  
RETURNS TABLE  
AS  
RETURN   
(  
    SELECT c.id, p.pname, p.plastname, pinf.paddress, pinf.pemail, pinf.pphone, mc.mcbrand, mc.mcmodel, cr.cnumber 
	FROM Contracts as c
	JOIN Person AS p ON p.id = c.id_person
	JOIN PersonInfo AS pinf ON pinf.id = p.id_personinfo
	JOIN Car AS cr ON cr.id = c.id_car
	JOIN ModelCar as mc ON mc.id = cr.id_cmodel
	WHERE c.id = @id_person
);

SELECT * FROM GetConcreteCarByID(15);

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
-- Create tmp table for holding full info in contract --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

drop procedure AddAllInfo;

select * from TmpFullInfo;

CREATE PROCEDURE AddAllInfo(@id_contract int) AS
BEGIN
	DROP TABLE IF EXISTS dbo.TmpFullInfo

	create TABLE CS.dbo.TmpFullInfo(
	id int NOT NULL,
	person_name VARCHAR(100) NOT NULL,
	person_lastname VARCHAR(100) NOT NULL,
	person_address VARCHAR(100) NOT NULL,
	person_email VARCHAR(100) NOT NULL,
	person_phone VARCHAR(100) NOT NULL,
	service_address VARCHAR(100) NOT NULL,
	car_brand VARCHAR(100) NOT NULL,
	car_model VARCHAR(100) NOT NULL,
	car_number VARCHAR(100) NOT NULL
	)

	insert into dbo.TmpFullInfo
	SELECT c.id, p.pname, p.plastname, pinf.paddress, pinf.pemail, 
		   pinf.pphone, s.saddress, mc.mcbrand, mc.mcmodel, cr.cnumber FROM Contracts as c
	JOIN Serviec AS s ON s.id = c.id_service
	JOIN Person AS p ON p.id = c.id_person
	JOIN PersonInfo as pinf ON pinf.id = p.id_personinfo
	JOIN Car AS cr ON cr.id = c.id_car
	JOIN ModelCar as mc ON mc.id = cr.id_cmodel
	WHERE c.id = @id_contract
END;

exec AddAllInfo 3;

select * from TmpFullInfo;


-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
-- Get data from CS, CS2 and form net table  --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

DROP FUNCTION GetFullInfoAboutPerson;

CREATE FUNCTION GetFullInfoAboutPerson()  
RETURNS TABLE  
AS  
RETURN   
(  
	SELECT p.id, p.pname, p.plastname, pinf.pemail, plog.pusername, plog.ppassword FROM CS.dbo.Person as p
	JOIN CS.dbo.PersonInfo as pinf ON pinf.id = p.id_personinfo
	JOIN CS2.dbo.PersonLoginInfo AS plog ON plog.id = p.id
);

SELECT * FROM GetFullInfoAboutPerson();
