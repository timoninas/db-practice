from faker import Faker
import random
import json

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/Message1.txt', 'w', encoding='utf-8')

diaposon = 4500

equipment_ids = []

status_messages = ['Car force opened', 'Car was knocked', 'Car was knocked', 'Car was yanked by the handle', 'Hit the wheels of a car',
'The trunk was broken into']

def formateDate(year):
    if year >= 0 and year < 10:
        return "0" + str(year)
    else:
        return str(year)

for i in range(diaposon):
    id = str(i+1)
    f.write(id + ';')
    while(1):
        number = myFaker.pyint(min_value=1, max_value=350, step=1)
        if (number not in equipment_ids or len(equipment_ids) >= 350):
            equipment_ids.append(number)
            f.write(str(number) + ';')
            break
        
    day = myFaker.pyint(min_value=1, max_value=28, step=1)
    month = myFaker.pyint(min_value=1, max_value=12, step=1)
    year = myFaker.pyint(min_value=2015, max_value=2020, step=1)

    datetime = formateDate(year) + "-" + formateDate(month) + "-" + formateDate(day) + "T" 

    hour = myFaker.pyint(min_value=0, max_value=23, step=1)
    minute = myFaker.pyint(min_value=0, max_value=59, step=1)
    second = myFaker.pyint(min_value=0, max_value=59, step=1)

    datetime += formateDate(hour) + ":" + formateDate(minute) + ":" + formateDate(second) + "Z"

    f.write(datetime + ";")

    longitude = float(myFaker.pyint(min_value=49000, max_value=75000, step=1)) / 1000

    latitude = float(myFaker.pyint(min_value=9000, max_value=28000, step=1)) / 1000

    personDict = {
        'message': status_messages[myFaker.pyint(min_value=0, max_value=len(status_messages)-1, step=1)],
        'datetime': datetime,
        'id_message': id,
        'longitude': longitude,
        'latitude': latitude
    }
    app_json = json.dumps(personDict, sort_keys=True)
    f.write(app_json)
    
    f.write('\n')

#/Users/antontimonin/Desktop
f.close()