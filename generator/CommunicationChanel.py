from faker import Faker
import random
import json

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/CommunicationChanel1.txt', 'w', encoding='utf-8')

diaposon = 19

# longitude 49-75
# latitude   9-28

brands = ['Teslt', 'BMW', 'Ferrari', 'Ford', 'Porsche', 'Honda', 'Lamborgini', 'Toyota',
'Bentley', 'Maserati', 'Audi', 'Jeep', 'Subaru', 'Cadillac', 'Chrysler', 'Mazda',
'Jaguar', 'Ford Mustang']

for i in range(diaposon):
    id = str(i)
    f.write(id + ';')

    id_communication = myFaker.pyint(min_value=0, max_value=6, step=1)
    f.write(str(id_communication) + ';')

    name_operator = "Operator"
    if id_communication == 0:
        name_operator = "MTC"
    elif id_communication == 1:
        name_operator = "Megafon"
    elif id_communication == 2:
        name_operator = "Tele2"
    elif id_communication == 3:
        name_operator = "Bilain"
    elif id_communication == 4:
        name_operator = "Yota"
    elif id_communication == 5:
        name_operator = "Tinkoff"
    elif id_communication == 6:
        name_operator = "Vineah"

    f.write(name_operator)

    f.write('\n')

#/Users/antontimonin/Desktop
f.close()