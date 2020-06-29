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