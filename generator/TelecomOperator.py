from faker import Faker
import random
import json

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/TelecomOperator1.txt', 'w', encoding='utf-8')

operators = ['mtc_tech', 'megafon_tech', 'tele2_tech',
'bilain_tech', 'yota_tech', 'tinkoff_tech', 'vineah_tech']

diaposon = len(operators)

for i in range(diaposon):
    f.write(str(i+1) + ';')
    f.write(operators[i])

    f.write('\n')

#/Users/antontimonin/Desktop
f.close()