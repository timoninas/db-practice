from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/MobileInfo1.txt', 'w', encoding='utf-8')

diaposon = 250

brands = ['Tesla', 'BMW', 'Ferrari', 'Ford', 'Porsche', 'Honda', 'Lamborgini', 'Toyota',
'Bentley', 'Maserati', 'Audi', 'Jeep', 'Subaru', 'Cadillac', 'Chrysler', 'Mazda',
'Jaguar', 'Ford Mustang']


for i in range(diaposon):
    f.write(str(i+1) + ";")

    sms = str(myFaker.pyint(min_value=0, max_value=1, step=1))
    mail = str(myFaker.pyint(min_value=0, max_value=1, step=1))

    f.write(sms + ";")
    f.write(mail)
    
    f.write('\n')

#/Users/antontimonin/Desktop
f.close()