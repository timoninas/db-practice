IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'CS2')
	DROP DATABASE CS2

CREATE DATABASE CS2

GO

CREATE TABLE CS2.dbo.PersonLoginInfo(
id int NOT NULL,
pusername VARCHAR(100) NOT NULL,
ppassword VARCHAR(100) NOT NULL
)

BULK INSERT CS2.dbo.PersonLoginInfo FROM '\\Mac\Home\Desktop\Практика\data\PersonLoginInfo.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

SELECT * FROM CS2.dbo.PersonLoginInfo;

CREATE TABLE CS2.dbo.DealerCenter(
	id int NOT NULL,
	address VARCHAR(100) NOT NULL,
	longitude float NOT NULL,
	latitude float NOT NULL,
	value_json VARCHAR(500) NOT NULL,
)

BULK INSERT CS2.dbo.DealerCenter FROM '\\Mac\Home\Desktop\Практика\data\DealerCenter.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

SELECT * FROM CS2.dbo.DealerCenter;

SELECT * FROM CS.dbo.Message;