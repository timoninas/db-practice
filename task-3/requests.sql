use CS;



SELECT msg.id, srtMsg.message, srtMsg.date_with_time
FROM CS.dbo.Message as msg
JOIN (SELECT
	   msg.id,
	   json_value(msg.value_json, '$.message') as message,
	   CONVERT(DATETIME, json_value(msg.value_json, '$.datetime')) as date_with_time,
	   DATEPART(hour, date_with_date) as hour,
	   DATEPART(minute, date_with_date) as minute,
	   DATEPART(second, date_with_date) as second
	  FROM CS.dbo.Message as msg
	  WHERE msg.date_with_date >= DATEADD(month, -1, GETDATE()) AND msg.date_with_date <= GETDATE()) AS srtMsg
ON srtMsg.id = msg.id
WHERE srtMsg.hour >= 7 AND srtMsg.hour < 12
      AND (srtMsg.minute > 0 OR srtMsg.second > 0)
ORDER BY srtMsg.date_with_time DESC;


SELECT DATEPART(time, '2020-07-07T21:07:46Z')
