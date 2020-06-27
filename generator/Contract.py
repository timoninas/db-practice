from faker import Faker
import random

# Contract 1000
# Person 250
# Service 15
# Car 350

myFaker = Faker()

f = open('/Users/antontimonin/Desktop/Практика/data/Contract.txt', 'w')

diaposon = 1001

for i in range(diaposon):
    f.write(str(i) + ';') #contract id
    f.write(str(myFaker.pyint(min_value=0, max_value=350, step=1)) + ';') #car id
    f.write(str(myFaker.pyint(min_value=0, max_value=250, step=1)) + ';') #person id
    f.write(str(myFaker.pyint(min_value=0, max_value=15, step=1))) #service id
    f.write('\n')

#/Users/antontimonin/Desktop

f.close()