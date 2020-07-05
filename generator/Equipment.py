from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/Equipment1.txt', 'w', encoding='utf-8')

diaposon = 450

def formateDate(year):
    if year >= 0 and year < 10:
        return "0" + str(year)
    else:
        return str(year)

for i in range(diaposon):
    f.write(str(i) + ';')
    f.write(str(myFaker.pyint(min_value=0, max_value=19, step=1)) + ';')

    emei = ""
    for i in range (20):
        radnom_index = myFaker.pyint(min_value=0, max_value=2, step=1)
        emei += myFaker.color_name()[radnom_index].upper()

    f.write(emei + ';')

    day = myFaker.pyint(min_value=1, max_value=28, step=1)
    month = myFaker.pyint(min_value=1, max_value=12, step=1)
    year = myFaker.pyint(min_value=19, max_value=35, step=1)

    date = formateDate(day) + "." + formateDate(month) + "." + formateDate(year)

    f.write(date)
    
    f.write('\n')

#/Users/antontimonin/Desktop
f.close()