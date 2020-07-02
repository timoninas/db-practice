use CS;

SELECT * FROM CS.dbo.Equipment;
SELECT * FROM CS.dbo.Message;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --
-- По id оборудования выводит все сообщения, которые --
-- когда либо приходили на это оборудование          --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --

DROP FUNCTION GetMessageByEquipmentID;

CREATE FUNCTION GetMessageByEquipmentID (@id_equipment int)  
RETURNS TABLE  
AS  
RETURN   
(  
    SELECT m.id as id_message, e.id as id_equipment, e.emei, m.date_with_date as date_with_time, m.value_json 
	FROM CS.dbo.Equipment as e
	JOIN CS.dbo.Message as m ON m.id_equipment = e.id
	WHERE e.id = @id_equipment
);

SELECT * FROM GetMessageByEquipmentID(100) as getm ORDER BY getm.date_with_time DESC;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --
-- по id клиента достает всю инфу из json пришедшую на оборудование --
-- привязанное к определенному клиенту и вывести сообщения, которые -- 
-- пришли за последние 30 дней                                      --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --

SELECT json_value(m.value_json, '$.id_message') as id_message,
	   json_value(m.value_json, '$.message') as message,
	   json_value(m.value_json, '$.datetime') as date_with_time
FROM CS.dbo.Message as m;


DROP FUNCTION GetDecodableJsonDataByPersonID;

CREATE FUNCTION GetDecodableJsonDataByPersonID (@id_person int)  
RETURNS TABLE  
AS  
RETURN   
(  
SELECT c.id as id_contract,
	   p.id as id_person,
	   cr.id as id_car,
	   e.id as id_equipment,
	   json_value(m.value_json, '$.message') as message,
	   json_value(m.value_json, '$.id_message') as id_message,
	   m.date_with_date as date_time,
	   p.pname as name,
	   p.plastname as lastname
	   
FROM Contracts as c
JOIN Person as p ON p.id = c.id_person
JOIN Car as cr ON cr.id = c.id_car
JOIN Equipment as e ON e.id = cr.id_equipment
JOIN Message as m ON m.id_equipment = e.id
WHERE p.id = @id_person AND m.date_with_date >= '2019-05-01T00:00:00Z'
-- m.date_with_date >= DATEADD(month, -1, GETDATE()) AND m.date_with_date <= GETDATE()
);

SELECT * FROM GetDecodableJsonDataByPersonID(105) as getm ORDER BY getm.date_time DESC;







