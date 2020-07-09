IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'CS')
	DROP DATABASE CS

CREATE DATABASE CS

GO

CREATE TABLE CS.dbo.Contracts(
id int NOT NULL IDENTITY(1, 1),
id_car int NOT NULL,
id_person int NOT NULL,
id_service int NOT NULL,
date_start date not null,
date_end date not null
)


CREATE TABLE CS.dbo.Person(
id int NOT NULL IDENTITY(1, 1),
id_personinfo int NOT NULL,
pname VARCHAR(100) NOT NULL,
plastname VARCHAR(100) NOT NULL,
pgender VARCHAR(100) NOT NULL,
CONSTRAINT PK_Person PRIMARY KEY(id),
CONSTRAINT UK_Person UNIQUE(id)
)


CREATE TABLE CS.dbo.PersonInfo(
id int NOT NULL IDENTITY(1, 1),
paddress VARCHAR(100) NOT NULL,
pphone VARCHAR(100) NOT NULL,
pemail VARCHAR(100) NOT NULL,
CONSTRAINT PK_PersonInfo PRIMARY KEY(id),
CONSTRAINT UK_PersonInfo UNIQUE(id)
)


CREATE TABLE CS.dbo.Serviec(
id int NOT NULL IDENTITY(1, 1),
saddress VARCHAR(100) NOT NULL,
slongitude float NOT NULL,
slatitude float NOT NULL,
CONSTRAINT PK_Serviec PRIMARY KEY(id),
CONSTRAINT UK_Serviec UNIQUE(id)
)


CREATE TABLE CS.dbo.Car(
id int NOT NULL IDENTITY(1, 1),
id_equipment int NOT NULL,
id_cmodel int NOT NULL,
ccolor VARCHAR(100) NOT NULL,
cnumber VARCHAR(100) NOT NULL,
CONSTRAINT PK_Car PRIMARY KEY(id),
CONSTRAINT UK_Car UNIQUE(id)
)


CREATE TABLE CS.dbo.ModelCar(
id int NOT NULL IDENTITY(1, 1),
mcbrand VARCHAR(100) NOT NULL,
mcmodel VARCHAR(100) NOT NULL,
CONSTRAINT PK_ModelCar PRIMARY KEY(id),
CONSTRAINT UK_ModelCar UNIQUE(id)
)


CREATE TABLE CS.dbo.Equipment(
id int NOT NULL IDENTITY(1, 1),
id_communication_chanel int NOT NULL,
emei VARCHAR(100) NOT NULL,
date_end_maintenance date NOT NULL,
CONSTRAINT PK_Equipment PRIMARY KEY(id),
CONSTRAINT UK_Equipment UNIQUE(id)
)


CREATE TABLE CS.dbo.Message(
id int NOT NULL IDENTITY(1, 1),
id_equipment int NOT NULL,
date_with_date datetime NOT NULL,
value_json VARCHAR(500) NOT NULL,
CONSTRAINT PK_Message PRIMARY KEY(id),
CONSTRAINT UK_Message UNIQUE(id)
)


CREATE TABLE CS.dbo.TelecomOperator (
id int NOT NULL IDENTITY(1, 1),
operator VARCHAR(50) NOT NULL,
CONSTRAINT PK_TC PRIMARY KEY(id),
CONSTRAINT UK_TC UNIQUE(id)
)

CREATE TABLE CS.dbo.EquipmentMaintenance (
id INT NOT NULL IDENTITY(1, 1),
id_equipment INT NOT NULL,
id_service_center INT NOT NULL,
date_visit DATETIME NOT NULL,
json_report VARCHAR(150) NOT NULL,
CONSTRAINT PK_EqM PRIMARY KEY(id),
CONSTRAINT UK_EqM UNIQUE(id)
)

CREATE TABLE CS.dbo.CommunicationChanel (
id int NOT NULL IDENTITY(1, 1),
id_telecom_operator int NOT NULL,
name VARCHAR(50) NOT NULL,
CONSTRAINT PK_CC PRIMARY KEY(id),
CONSTRAINT UK_CC UNIQUE(id),
CONSTRAINT FK_id_telecom_operator FOREIGN KEY(id_telecom_operator) REFERENCES CS.dbo.TelecomOperator(id)
)

CREATE TABLE CS.dbo.Operator (
id int NOT NULL IDENTITY(1, 1),
username VARCHAR(100) NOT NULL,
password VARCHAR(100) NOT NULL,
CONSTRAINT PK_Operator PRIMARY KEY(id),
CONSTRAINT UK_Operator UNIQUE(id)
)
