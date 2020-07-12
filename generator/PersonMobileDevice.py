from faker import Faker
import random

myFaker = Faker('en_US')

fd1 = open('/Users/antontimonin/Desktop/Практика/data/PersonMobileDevice1.txt', 'w', encoding='utf-8')

diaposon = 250

existings_id = []

for i in range(diaposon):
    fd1.write(str(i+1) + ';')
    fd1.write(str(i+1) + ';')
    fd1.write(str(i+1))
    
    fd1.write('\n')


#/Users/antontimonin/Desktop
fd1.close()