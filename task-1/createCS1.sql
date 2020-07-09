IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'CS')
	DROP DATABASE CS

CREATE DATABASE CS

GO

CREATE TABLE CS.dbo.Contracts(
id int NOT NULL IDENTITY(0, 1),
id_car int NOT NULL,
id_person int NOT NULL,
id_service int NOT NULL,
date_start date not null,
date_end date not null
)

CREATE TABLE CS.dbo.Person(
id int NOT NULL,
id_personinfo int NOT NULL,
pname VARCHAR(100) NOT NULL,
plastname VARCHAR(100) NOT NULL,
pgender VARCHAR(100) NOT NULL
)

CREATE TABLE CS.dbo.PersonInfo(
id int NOT NULL,
paddress VARCHAR(100) NOT NULL,
pphone VARCHAR(100) NOT NULL,
pemail VARCHAR(100) NOT NULL
)

CREATE TABLE CS.dbo.Serviec(
id int NOT NULL,
saddress VARCHAR(100) NOT NULL,
slongitude float NOT NULL,
slatitude float NOT NULL
)

CREATE TABLE CS.dbo.Car(
id int NOT NULL,
id_equipment int NOT NULL,
id_cmodel int NOT NULL,
ccolor VARCHAR(100) NOT NULL,
cnumber VARCHAR(100) NOT NULL
)

CREATE TABLE CS.dbo.ModelCar(
id int NOT NULL,
mcbrand VARCHAR(100) NOT NULL,
mcmodel VARCHAR(100) NOT NULL
)

CREATE TABLE CS.dbo.Equipment(
id int NOT NULL,
id_communication_chanel int NOT NULL,
emei VARCHAR(100) NOT NULL,
date_end_maintenance date NOT NULL
)

CREATE TABLE CS.dbo.Message(
id int NOT NULL,
id_equipment int NOT NULL,
date_with_date datetime NOT NULL,
value_json VARCHAR(500) NOT NULL
)

CREATE TABLE CS.dbo.TelecomOperator (
id int NOT NULL,
operator VARCHAR(50) NOT NULL,
CONSTRAINT PK_TC PRIMARY KEY(id),
CONSTRAINT UK_TC UNIQUE(id)
)


CREATE TABLE CS.dbo.EquipmentMaintenance (
id INT NOT NULL,
id_equipment INT NOT NULL,
id_service_center INT NOT NULL,
date_visit DATETIME NOT NULL,
json_report VARCHAR(150) NOT NULL,
CONSTRAINT PK_EqM PRIMARY KEY(id),
CONSTRAINT UK_EqM UNIQUE(id)
)




DROP TABLE CS.dbo.CommunicationChanel;

CREATE TABLE CS.dbo.CommunicationChanel (
id int NOT NULL,
id_telecom_operator int NOT NULL,
name VARCHAR(50) NOT NULL,
CONSTRAINT PK_CC PRIMARY KEY(id),
CONSTRAINT UK_CC UNIQUE(id),
CONSTRAINT FK_id_telecom_operator FOREIGN KEY(id_telecom_operator) REFERENCES CS.dbo.TelecomOperator(id)
)

CREATE TABLE CS.dbo.Operator (
id int NOT NULL,
username VARCHAR(100) NOT NULL,
password VARCHAR(100) NOT NULL,
CONSTRAINT PK_Operator PRIMARY KEY(id),
CONSTRAINT UK_Operator UNIQUE(id)
)

INSERT INTO CS.dbo.Operator (id, username, password)  
VALUES (2, 'Ljwh82', '(EFjk2hdfq');

SELECT * FROM Operator as op WHERE op.username = 'antontimonin' AND op.password = '78egjer2023@';


-- -- -- -- -- -- -- -- -- -- -- -- -- -- --
-- CHECK unique, primary key, foreign key --
-- -- -- -- -- -- -- -- -- -- -- -- -- -- --

CREATE TABLE CS.dbo.CheckPrimary(
id int NOT NULL,
name VARCHAR(50) NOT NULL,
CONSTRAINT PK_Check PRIMARY KEY(id),
CONSTRAINT UK_Check UNIQUE(id),
)

DROP TABLE CS.dbo.CheckForeign;
DROP TABLE CS.dbo.CheckPrimary;

CREATE TABLE CS.dbo.CheckForeign(
id int NOT NULL,
id_CheckPrimary int NOT NULL,
name VARCHAR(50) NOT NULL,
CONSTRAINT PK_CheckF PRIMARY KEY(id),
CONSTRAINT UK_CheckF UNIQUE(id),
CONSTRAINT FK_id_CheckForeign FOREIGN KEY(id_CheckPrimary) REFERENCES CheckPrimary(id)
)

INSERT INTO CS.dbo.CheckPrimary(id, name)
VALUES (2, 'What');

INSERT INTO CS.dbo.CheckForeign(id, id_CheckPrimary, name)
VALUES (1, 2, 'What');

SELECT * FROM CS.dbo.CheckPrimary;