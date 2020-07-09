use CS;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --
-- Displays hardware-enabled messages for a specific user  --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --

DROP FUNCTION GetEquipmentMaintenanceByPersonID;

CREATE FUNCTION GetEquipmentMaintenanceByPersonID (@id_person int)  
RETURNS TABLE  
AS  
RETURN   
(  
    SELECT eqm.id_equipment, eqm.date_visit, eqm.json_report, eqm.id_service_center FROM CS.dbo.Person as p
	JOIN CS.dbo.Contracts as c ON c.id_person = p.id
	JOIN CS.dbo.Car as cr ON c.id_car = cr.id
	JOIN CS.dbo.Equipment as eq ON cr.id_equipment = eq.id
	JOIN CS.dbo.EquipmentMaintenance as eqm ON eq.id = eqm.id_equipment
	WHERE p.id = @id_person
);

SELECT * FROM CS.dbo.GetEquipmentMaintenanceByPersonID(2) as formedTable ORDER BY formedTable.id_equipment;
