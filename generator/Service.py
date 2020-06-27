from faker import Faker
import random

myFaker = Faker("ru_RU")

f = open('/Users/antontimonin/Desktop/Практика/data/Service.txt', 'w')

diaposon = 15

for i in range(diaposon):
    f.write(str(i) + ';')
    f.write(myFaker.address() + ';')
    f.write(str(random.randint(0, 900) / 10) + ";")
    f.write(str(random.randint(0, 900) / 10))
    f.write('\n')


#/Users/antontimonin/Desktop

f.close()