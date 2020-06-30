from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/PersonLoginInfo1.txt', 'w', encoding='utf-8')

diaposon = 250

existings_id = []

for i in range(diaposon):
    f.write(str(i) + ';')
    profile = myFaker.simple_profile()
    f.write(profile['username'] + ';')
    f.write(myFaker.password())
    
    f.write('\n')

#/Users/antontimonin/Desktop
f.close()