
BULK INSERT CS.dbo.ModelCar FROM '\\Mac\Home\Desktop\Практика\data\ModelCar.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS.dbo.Car FROM '\\Mac\Home\Desktop\Практика\data\Car.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS.dbo.Serviec FROM '\\Mac\Home\Desktop\Практика\data\Service.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS.dbo.Person FROM '\\Mac\Home\Desktop\Практика\data\Person.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS.dbo.PersonInfo FROM '\\Mac\Home\Desktop\Практика\data\PersonInfo.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

BULK INSERT CS.dbo.Contracts FROM '\\Mac\Home\Desktop\Практика\data\Contract.txt'
WITH
(DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', check_constraints);

