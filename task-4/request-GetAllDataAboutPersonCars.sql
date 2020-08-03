USE CS;

DROP FUNCTION GetAllDataAboutPersonCars;

CREATE FUNCTION GetAllDataAboutPersonCars (@id_person int)  
RETURNS TABLE  
AS  
RETURN   
(  
SELECT mc.mcbrand, mc.mcmodel, cr.ccolor, cr.cnumber, cc.name_config, cc.json FROM CS.dbo.Person as p
JOIN CS.dbo.Contracts as c ON c.id_person = p.id
JOIN CS.dbo.Car as cr ON c.id_car = cr.id
JOIN CS.dbo.ModelCar as mc ON cr.id_cmodel = mc.id
JOIN CS.dbo.ConfigCar as cc ON cr.id_config = cc.id
WHERE p.id = @id_person
);

SELECT * FROM GetAllDataAboutPersonCars(2);