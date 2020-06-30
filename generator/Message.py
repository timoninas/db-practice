from faker import Faker
import random
import json

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/Message1.txt', 'w', encoding='utf-8')

diaposon = 4500

def formateDate(year):
    if year >= 0 and year < 10:
        return "0" + str(year)
    else:
        return str(year)

for i in range(diaposon):
    id = str(i)
    f.write(id + ';')
    f.write(str(myFaker.pyint(min_value=0, max_value=450, step=1)) + ';')

    day = myFaker.pyint(min_value=1, max_value=28, step=1)
    month = myFaker.pyint(min_value=1, max_value=12, step=1)
    year = myFaker.pyint(min_value=2005, max_value=2020, step=1)

    datetime = formateDate(year) + "-" + formateDate(month) + "-" + formateDate(day) + "T" 

    hour = myFaker.pyint(min_value=0, max_value=23, step=1)
    minute = myFaker.pyint(min_value=0, max_value=59, step=1)
    second = myFaker.pyint(min_value=0, max_value=59, step=1)

    datetime += formateDate(hour) + ":" + formateDate(minute) + ":" + formateDate(second) + "Z"

    f.write(datetime + ";")

    personDict = {
        'message': 'Car force opened',
        'datetime': datetime,
        'id_equipment': id
    }
    app_json = json.dumps(personDict, sort_keys=True)
    f.write(app_json)
    
    f.write('\n')

#/Users/antontimonin/Desktop
f.close()