from faker import Faker
import random
import json

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/DealerCenter1.txt', 'w', encoding='utf-8')

diaposon = 20

# longitude 49-75
# latitude   9-28

brands = ['Teslt', 'BMW', 'Ferrari', 'Ford', 'Porsche', 'Honda', 'Lamborgini', 'Toyota',
'Bentley', 'Maserati', 'Audi', 'Jeep', 'Subaru', 'Cadillac', 'Chrysler', 'Mazda',
'Jaguar', 'Ford Mustang']

for i in range(diaposon):
    id = str(i)
    f.write(id + ';')
    f.write(myFaker.address() + ';')

    longitude = float(myFaker.pyint(min_value=49000, max_value=75000, step=1)) / 1000
    f.write(str(longitude) + ';')

    latitude = float(myFaker.pyint(min_value=9000, max_value=28000, step=1)) / 1000
    f.write(str(latitude) + ';')

    num = myFaker.pyint(min_value=1, max_value=3, step=1)
    tmp_brands = []

    for i in range(num):
        brand = brands[myFaker.pyint(min_value=0, max_value=len(brands)-1, step=1)]
        if brand not in tmp_brands:
            tmp_brands.append(brand)

    personDict = {
        'brands': tmp_brands
    }
    app_json = json.dumps(personDict, sort_keys=True)
    f.write(app_json)
    
    f.write('\n')

#/Users/antontimonin/Desktop
f.close()