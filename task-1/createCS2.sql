IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'CS2')
	DROP DATABASE CS2

CREATE DATABASE CS2

GO

drop table CS2.dbo.PersonMobileDevice;
drop table CS2.dbo.MobileInfo;
drop table CS2.dbo.PersonLoginInfo;
drop table CS2.dbo.DealerCenter;

CREATE TABLE CS2.dbo.PersonLoginInfo(
	id int NOT NULL IDENTITY(1, 1),
	pusername VARCHAR(100) NOT NULL,
	ppassword VARCHAR(100) NOT NULL,
	CONSTRAINT PK_PersonLoginInfo PRIMARY KEY(id)
)

CREATE TABLE CS2.dbo.MobileInfo(
	id int NOT NULL IDENTITY(1, 1),
	sms int NOT NULL,
	mail int NOT NULL,
	CONSTRAINT PK_MobileInfo PRIMARY KEY(id)
)

CREATE TABLE CS2.dbo.PersonMobileDevice(
	id int NOT NULL IDENTITY(1, 1),
	id_person_login_info int NOT NULL,
	id_mobile_info int NOT NULL,
	CONSTRAINT PK_PersonMobileDevice PRIMARY KEY(id),
	CONSTRAINT FK_id_person_login_info FOREIGN KEY(id_person_login_info) REFERENCES CS2.dbo.PersonLoginInfo(id),
	CONSTRAINT FK_id_mobile_info FOREIGN KEY(id_mobile_info) REFERENCES CS2.dbo.MobileInfo(id),
	CONSTRAINT UK_id_person_login_info UNIQUE(id_person_login_info),
	CONSTRAINT UK_id_mobile_info UNIQUE(id_mobile_info)
)

CREATE TABLE CS2.dbo.DealerCenter(
	id int NOT NULL IDENTITY(1, 1),
	address VARCHAR(100) NOT NULL,
	longitude float NOT NULL,
	latitude float NOT NULL,
	value_json VARCHAR(500) NOT NULL,
	CONSTRAINT PK_DealerCenter PRIMARY KEY(id)
)

------------------------------------
------------------------------------
------------------------------------

BULK INSERT CS2.dbo.PersonLoginInfo FROM '\\Mac\Home\Desktop\Практика\data\PersonLoginInfo.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS2.dbo.MobileInfo FROM '\\Mac\Home\Desktop\Практика\data\MobileInfo.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS2.dbo.PersonMobileDevice FROM '\\Mac\Home\Desktop\Практика\data\PersonMobileDevice.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS2.dbo.DealerCenter FROM '\\Mac\Home\Desktop\Практика\data\DealerCenter.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

