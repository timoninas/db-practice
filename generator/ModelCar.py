from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/ModelCar1.txt', 'w')
idf = open('/Users/antontimonin/Desktop/Практика/data/IDForCar.txt', 'w')
idf.write('{')

diaposon = 52

brands = ['Teslt', 'BMW', 'Ferrari', 'Ford', 'Porsche', 'Honda', 'Lamborgini', 'Toyota',
'Bentley', 'Maserati', 'Audi', 'Jeep', 'Subaru', 'Cadillac', 'Chrysler', 'Mazda',
'Jaguar', 'Ford Mustang']

models = []

for i in range(50): 
    models.append(myFaker.word())

for i in range(diaposon):
    id = str(i+1)
    f.write(id + ';')
    random.randint(0, 50)

    id_brand = random.randint(0, len(brands) - 1)
    f.write(brands[ id_brand ] + ';')
    f.write(models[ random.randint(0, len(models) - 1) ])
    f.write('\n')

    ref_config = myFaker.pyint(min_value=id_brand * 3 + 1, max_value=(id_brand + 1) * 3, step=1)

    end = ""
    if (i % 5 == 0):
        end = "\n"
        
    if (i != diaposon - 1):
        idf.write("'" + id + "': " + str(ref_config) + "," + end)
    else:
        idf.write("'" + id + "': " + str(ref_config) + end)
    
#/Users/antontimonin/Desktop

f.close()

idf.write('}')
idf.close()