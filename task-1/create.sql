IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'CS')
	DROP DATABASE CS

CREATE DATABASE CS

GO

CREATE TABLE CS.dbo.Contracts(
id int NOT NULL,
id_car int NOT NULL,
id_person int NOT NULL,
id_service int NOT NULL
)

CREATE TABLE CS.dbo.Person(
id int NOT NULL,
pname VARCHAR(100) NOT NULL,
plastname VARCHAR(100) NOT NULL,
pgender VARCHAR(100) NOT NULL,
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
id_cmodel int NOT NULL,
ccolor VARCHAR(100) NOT NULL,
cnumber VARCHAR(100) NOT NULL
)


CREATE TABLE CS.dbo.ModelCar(
id int NOT NULL,
mcbrand VARCHAR(100) NOT NULL,
mcmodel VARCHAR(100) NOT NULL
)

