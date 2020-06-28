--\\Mac\Home\Desktop\DB\data

--INSERT INTO Company([ID],[CompanyName],[Country],[Budget],[YearFoundation])
--	VALUES	(1,'Weeks-Tucker','New Zealand',-686,152)
--GO

--use LR1

--INSERT INTO Film([FilmID],[FilmName],[ReleaseYear],[Country],[FilmDirectorID], [CompanyID], [GenreID], [PrequelID], [DurationMin], [AgeLimit])
--	VALUES	(5, 'Lul', 1992, 'Russia', 4, 4, 4, NULL, 150, 10)
--GO

--SELECT * FROM Film


--0;mind;1989;Uganda;4;11;8;196;18;

BULK INSERT LR1.dbo.Film FROM '\\Mac\Home\Desktop\DB\data\Film.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT LR1.dbo.Company FROM '\\Mac\Home\Desktop\DB\data\Company.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT LR1.dbo.FilmDirector FROM '\\Mac\Home\Desktop\DB\data\FilmDirector.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT Film_Actor FROM '\\Mac\Home\Desktop\DB\data\Film_Actor.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT LR1.dbo.Actor FROM '\\Mac\Home\Desktop\DB\data\Actor.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT LR1.dbo.Genre FROM '\\Mac\Home\Desktop\DB\data\Genre.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);