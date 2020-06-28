IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'LR1')
	DROP DATABASE LR1

CREATE DATABASE LR1

GO

CREATE TABLE LR1.dbo.Company(
CompanyID int NOT NULL,
CompanyName VARCHAR(80) NOT NULL,
YearFoundation int NOT NULL,
Country VARCHAR(80) NOT NULL
)

CREATE TABLE LR1.dbo.FilmDirector(
FilmDirectorID int NOT NULL,
NameDirector VARCHAR(50) NOT NULL,
DateBirth date NOT NULL,
Height int NOT NULL
)

CREATE TABLE LR1.dbo.Film(
FilmID int NOT NULL,
FilmName VARCHAR(40) NOT NULL,
ReleaseYear int NOT NULL,
Country VARCHAR(80) NOT NULL,
FilmDirectorID int NOT NULL,
CompanyID int NOT NULL,
GenreID int NOT NULL,
PrequelID int,
DurationMin int NOT NULL,
AgeLimit int NOT NULL
)

CREATE TABLE LR1.dbo.Film_Actor(
    Film_ActorID int NOT NULL,
	FilmID int NOT NULL,
	ActorID int NOT NULL
)

CREATE TABLE LR1.dbo.Actor(
    ActorID int NOT NULL,
	NameDirector VARCHAR(50) NOT NULL,
	DateBirth date NOT NULL,
	Country VARCHAR(80) NOT NULL,
	Height int NOT NULL
)

CREATE TABLE LR1.dbo.Genre(
    GenreID int NOT NULL,
	TypeGenre VARCHAR(50) NOT NULL
)

