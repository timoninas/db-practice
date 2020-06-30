from faker import Faker
import random

myFaker = Faker('en_US')

fd1 = open('/Users/antontimonin/Desktop/Практика/data/PersonInfo1.txt', 'w', encoding='utf-8')

diaposon = 250

existings_id = []

for i in range(diaposon):
    fd1.write(str(i) + ';')
    fd1.write(myFaker.address() + ';')
    fd1.write(myFaker.phone_number() + ';')
    fd1.write(myFaker.email())
    
    fd1.write('\n')


#/Users/antontimonin/Desktop
fd1.close()