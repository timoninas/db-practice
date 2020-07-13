USE CS;

drop procedure TestPr;

CREATE PROCEDURE TestPr(@brand VARCHAR(100)) AS
DECLARE 
	@lowercased_brand varchar(100),
	@ID_CONFIG INT;
BEGIN

	SELECT @lowercased_brand = LOWER(@brand);

	IF (object_id('CS.dbo.TmpTable','U')) IS NOT NULL
	BEGIN
		DROP TABLE CS.dbo.TmpTable;
	END;

	CREATE TABLE CS.dbo.TmpTable(
		num_id_operator varchar(100)
	);

	SELECT @ID_CONFIG = cc.id FROM CS.dbo.ConfigCar as cc
	WHERE LOWER(cc.name_config) LIKE CONCAT('%', @lowercased_brand, '%');

	IF (SELECT @ID_CONFIG) IS NULL
	BEGIN
		SELECT @ID_CONFIG = 1;
	END;
	
	SELECT @ID_CONFIG;
END;

EXEC TestPr 'Teslt';

SELECT * FROM CS.dbo.ConfigCar

SELECT * FROM CS.dbo.ModelCar as mc
WHERE mc.mcbrand LIKE '%B%'
