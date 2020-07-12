from faker import Faker
import random

myFaker = Faker("en_US")

f = open('/Users/antontimonin/Desktop/Практика/data/Car1.txt', 'w')

diaposon = 350

id_equipment = []

configs_id = {'1': 24,
'2': 5,'3': 1,'4': 50,'5': 43,'6': 11,
'7': 17,'8': 49,'9': 29,'10': 31,'11': 9,
'12': 50,'13': 31,'14': 10,'15': 41,'16': 13,
'17': 24,'18': 35,'19': 4,'20': 39,'21': 42,
'22': 51,'23': 1,'24': 27,'25': 24,'26': 44,
'27': 38,'28': 4,'29': 51,'30': 37,'31': 26,
'32': 43,'33': 23,'34': 22,'35': 25,'36': 50,
'37': 5,'38': 32,'39': 32,'40': 53,'41': 47,
'42': 49,'43': 19,'44': 25,'45': 36,'46': 17,
'47': 40,'48': 29,'49': 40,'50': 13,'51': 19,
'52': 20}

for i in range(diaposon):
    f.write(str(i+1) + ';')
    while(1):
        id_equip = myFaker.pyint(min_value=1, max_value=451, step=1)
        if id_equip not in id_equipment:
            id_equipment.append(id_equip)
            f.write(str(id_equip) + ';')
            break
    
    number_for_ModelCar_and_ConfigCar = str(myFaker.pyint(min_value=1, max_value=50, step=1))
    f.write(number_for_ModelCar_and_ConfigCar + ';')
    f.write(str(configs_id[number_for_ModelCar_and_ConfigCar]) + ';')
    
    f.write(myFaker.color_name() + ';')
    
    word1 = myFaker.color_name()[0]
    word2 = myFaker.color_name()[0]
    word3 = myFaker.color_name()[0]

    f.write(word1 + myFaker.credit_card_security_code() + word2 + word3)
    f.write('\n')



f.close()