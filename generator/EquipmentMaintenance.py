from faker import Faker
import random
import json

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/EquipmentMaintenance1.txt', 'w', encoding='utf-8')

diaposon = 2500

messages_maintenance = ['Checking the machine equipment', 
'Incomplete technical inspection of the machine', 
'Checking the machine for external defects', 
'Technical inspection of the machine',
'Checking the machine body']

def formateDate(year):
    if year >= 0 and year < 10:
        return "0" + str(year)
    else:
        return str(year)

for i in range(diaposon):
    f.write(str(i+1) + ';')
    f.write(str(myFaker.pyint(min_value=1, max_value=450, step=1)) + ';')
    f.write(str(myFaker.pyint(min_value=1, max_value=15, step=1)) + ';')

    day = myFaker.pyint(min_value=1, max_value=28, step=1)
    month = myFaker.pyint(min_value=1, max_value=12, step=1)
    year = myFaker.pyint(min_value=2015, max_value=2020, step=1)

    datetime = formateDate(year) + "-" + formateDate(month) + "-" + formateDate(day) + "T" 

    hour = myFaker.pyint(min_value=0, max_value=23, step=1)
    minute = myFaker.pyint(min_value=0, max_value=59, step=1)
    second = myFaker.pyint(min_value=0, max_value=59, step=1)

    datetime += formateDate(hour) + ":" + formateDate(minute) + ":" + formateDate(second) + "Z"

    f.write(datetime + ";")

    title_num = 0
    engine = myFaker.pyint(min_value=0, max_value=1, step=1)
    clutch = myFaker.pyint(min_value=0, max_value=1, step=1)
    doors = myFaker.pyint(min_value=0, max_value=1, step=1)
    wheels = myFaker.pyint(min_value=0, max_value=1, step=1)
    machine_body = myFaker.pyint(min_value=0, max_value=1, step=1)

    if (engine == 1 or clutch == 1) and ((doors + wheels + machine_body) >= 2):
        title_num = 1
    elif (engine == 0 and clutch == 0) and (doors == 1 or wheels == 1 or machine_body == 1):
        title_num = 2
    elif (engine == 1 or clutch == 1) and doors == 0 and wheels == 0 or machine_body == 0:
        title_num = 3
    elif machine_body == 1:
        title_num = 4

    
    personDict = {
        'title': messages_maintenance[title_num],
        'engine': myFaker.pyint(min_value=0, max_value=1, step=1),
        'clutch': myFaker.pyint(min_value=0, max_value=1, step=1),
        'doors': myFaker.pyint(min_value=0, max_value=1, step=1),
        'wheels': myFaker.pyint(min_value=0, max_value=1, step=1),
        'machine_body': myFaker.pyint(min_value=0, max_value=1, step=1)
    }

    app_json = json.dumps(personDict, sort_keys=True)
    f.write(app_json)
    
    f.write('\n')
    
    f.write('\n')

#/Users/antontimonin/Desktop
f.close()