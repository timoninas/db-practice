from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/ModelCar1.txt', 'w')

diaposon = 52

brands = ['Teslt', 'BMW', 'Ferrari', 'Ford', 'Porsche', 'Honda', 'Lamborgini', 'Toyota',
'Bentley', 'Maserati', 'Audi', 'Jeep', 'Subaru', 'Cadillac', 'Chrysler', 'Mazda',
'Jaguar', 'Ford Mustang']

models = []

for i in range(50): 
    models.append(myFaker.word())

for i in range(diaposon):
    f.write(str(i+1) + ';')
    random.randint(0, 50)
    f.write(brands[ random.randint(0, len(brands) - 1) ] + ';')
    f.write(models[ random.randint(0, len(models) - 1) ])
    f.write('\n')


#/Users/antontimonin/Desktop

f.close()