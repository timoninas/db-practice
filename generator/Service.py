from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/Service1.txt', 'w')

diaposon = 15

for i in range(diaposon):
    f.write(str(i) + ';')
    f.write(myFaker.address() + ';')
    f.write(str(random.randint(0, 900) / 10) + ";")
    f.write(str(random.randint(0, 900) / 10))
    f.write('\n')


#/Users/antontimonin/Desktop

f.close()