from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/Service1.txt', 'w')

diaposon = 15

for i in range(diaposon):
    f.write(str(i+1) + ';')
    f.write(myFaker.address() + ';')
    
    longitude = float(myFaker.pyint(min_value=49000, max_value=75000, step=1)) / 1000
    f.write(str(longitude) + ';')

    latitude = float(myFaker.pyint(min_value=9000, max_value=28000, step=1)) / 1000
    f.write(str(latitude))
    f.write('\n')


#/Users/antontimonin/Desktop

f.close()