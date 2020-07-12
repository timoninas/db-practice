from faker import Faker
import json
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/ConfigCar1.txt', 'w', encoding='utf-8')

diaposon = 250

brands = ['Teslt', 'BMW', 'Ferrari', 'Ford', 'Porsche', 'Honda', 'Lamborgini', 'Toyota',
'Bentley', 'Maserati', 'Audi', 'Jeep', 'Subaru', 'Cadillac', 'Chrysler', 'Mazda',
'Jaguar', 'Ford Mustang']

id = 1

for i in range(len(brands)):

    for j in range(1, 4):
        f.write(str(id) + ';')
        id += 1

        brand = brands[i]
        name_config = brand + "#cfg# " + str(j)
        f.write(name_config + ';')


        personDict = {
            'doors': str(myFaker.pyint(min_value=0, max_value=1, step=1)),
            'butterfly_doors': str(myFaker.pyint(min_value=0, max_value=1, step=1)),
            'engine': str(myFaker.pyint(min_value=0, max_value=1, step=1)),
          'clutch': str(myFaker.pyint(min_value=0, max_value=1, step=1)),
          'hood_car': str(myFaker.pyint(min_value=0, max_value=1, step=1)),
          'trunk_car': str(myFaker.pyint(min_value=0, max_value=1, step=1))
        }
        app_json = json.dumps(personDict, sort_keys=True)
        f.write(app_json)
    
        f.write('\n')

#/Users/antontimonin/Desktop
f.close()