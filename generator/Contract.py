from faker import Faker
import random

# Contract 1000
# Person 250
# Service 15
# Car 350
# Model Car 50
# Equipment 450

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/Contract1.txt', 'w')

diaposon = 1001

def formateDate(year):
    if year >= 0 and year < 10:
        return "0" + str(year)
    else:
        return str(year)

for i in range(diaposon):
    f.write(str(i) + ';') #contract id
    f.write(str(myFaker.pyint(min_value=0, max_value=350, step=1)) + ';') #car id
    f.write(str(myFaker.pyint(min_value=0, max_value=250, step=1)) + ';') #person id
    f.write(str(myFaker.pyint(min_value=0, max_value=15, step=1)) + ';') #service id

    day1 = myFaker.pyint(min_value=1, max_value=28, step=1)
    month1 = myFaker.pyint(min_value=1, max_value=12, step=1)
    year1 = myFaker.pyint(min_value=0, max_value=20, step=1)

    day2 = myFaker.pyint(min_value=1, max_value=28, step=1)
    month2 = myFaker.pyint(min_value=1, max_value=12, step=1)
    year2 = myFaker.pyint(min_value=0, max_value=20, step=1)

    if year1 < year2:
        day1, day2 = day2, day1
        month1, month2 = month2, month1
        year1, year2 = year2, year1

    elif year1 == year2 :
        if month1 < month2:
            day1, day2 = day2, day1
            month1, month2 = month2, month1
            year1, year2 = year2, year1
        elif month1 == month2:
            if day1 <= day2:
                day1, day2 = day2, day1
                month1, month2 = month2, month1
                year1, year2 = year2, year1

    date2 = str(day1) + "." + formateDate(month1) + "." + formateDate(year1)
    date1 = str(day2) + "." + formateDate(month2) + "." + formateDate(year2)

    f.write(date1 + ';') #date start id
    f.write(date2) #date end id
    f.write('\n')

#/Users/antontimonin/Desktop

f.close()