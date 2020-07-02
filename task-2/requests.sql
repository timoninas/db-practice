use CS;

SELECT * FROM CS.dbo.Equipment;
SELECT * FROM CS.dbo.Message;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --
-- Displays all messages that have ever been sent to --
-- this hardware by the hardware id                  --
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
-- Using the client id, it retrieves all the information from json  --
-- that came to the hardware linked to a particular client and      --
-- displays messages that came in the last 30 days                  --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --

SELECT json_value(m.value_json, '$.id_message') as id_message,
	   json_value(m.value_json, '$.message') as message,
	   json_value(m.value_json, '$.datetime') as date_with_time
FROM CS.dbo.Message as m;

DROP FUNCTION GetDecodableJsonDataByPersonID;

CREATE FUNCTION GetDecodableJsonDataByPersonID (@id_person int, @date datetime)  
RETURNS TABLE  
AS  
RETURN   
(  
SELECT c.id as id_contract,
	   p.id as id_person,
	   cr.id as id_car,
	   e.id as id_equipment,
	   json_value(m.value_json, '$.id_message') as id_message,
	   json_value(m.value_json, '$.message') as message,
	   m.date_with_date as date_time,
	   p.pname as name,
	   p.plastname as lastname
	   
FROM Contracts as c
JOIN Person as p ON p.id = c.id_person
JOIN Car as cr ON cr.id = c.id_car
JOIN Equipment as e ON e.id = cr.id_equipment
JOIN Message as m ON m.id_equipment = e.id
WHERE p.id = @id_person AND --m.date_with_date >= '2019-05-01T00:00:00Z'
m.date_with_date >= DATEADD(month, -1, @date) AND m.date_with_date <= DATEADD(month, 1, @date)
);

SELECT * FROM GetDecodableJsonDataByPersonID(9, '2020-05-01T00:00:00Z') as getm ORDER BY getm.date_time DESC;



-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
-- Write a query that defines the Message and DealerCenter     --
-- tables whether and when the user visited the service center --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
DROP FUNCTION GetNearbyMessagesWithDealerCenter;

CREATE FUNCTION GetNearbyMessagesWithDealerCenter ()  
RETURNS TABLE AS RETURN   
(  
SELECT m.id as id_message,
	   dc.id as id_dealer_center, dc.address, dc.value_json,
	   json_value(m.value_json, '$.latitude') as message_latitude,
	   json_value(m.value_json, '$.longitude') as message_longitude,
	   dc.latitude as dealer_center_latitude,
	   dc.longitude as dealer_center_longitude
FROM CS.dbo.Message as m
JOIN CS2.dbo.DealerCenter as dc 
ON abs((dc.latitude - convert(float, json_value(m.value_json, '$.latitude')))) < 0.15
AND abs((dc.longitude - json_value(m.value_json, '$.longitude'))) < 0.15
);

SELECT * FROM GetNearbyMessagesWithDealerCenter();




-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --
-- A procedure that will record all the information in the main table with   --
-- contracts. When filling in Person, Service, Car, Contract will be formed  --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - --

