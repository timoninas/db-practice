from faker import Faker
import random

myFaker = Faker("en_US")

f = open('/Users/antontimonin/Desktop/Практика/data/Car1.txt', 'w')

diaposon = 350

id_equipment = []

for i in range(diaposon):
    f.write(str(i+1) + ';')
    while(1):
        id_equip = myFaker.pyint(min_value=1, max_value=451, step=1)
        if id_equip not in id_equipment:
            id_equipment.append(id_equip)
            f.write(str(id_equip) + ';')
            break
    f.write(str(myFaker.pyint(min_value=1, max_value=50, step=1)) + ';')
    
    f.write(myFaker.color_name() + ';')
    
    word1 = myFaker.color_name()[0]
    word2 = myFaker.color_name()[0]
    word3 = myFaker.color_name()[0]

    f.write(word1 + myFaker.credit_card_security_code() + word2 + word3)
    f.write('\n')

f.close()