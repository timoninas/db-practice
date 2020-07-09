from faker import Faker
import random

myFaker = Faker('en_US')

f = open('/Users/antontimonin/Desktop/Практика/data/Person1.txt', 'w', encoding='utf-8')

diaposon = 250

existings_id = []

for i in range(diaposon):
    number = myFaker.pyint(min_value=0, max_value=12, step=1)
    gender = "male"

    if number % 3 == 0:
        gender = "female"

    f.write(str(i+1) + ';')

    while(1):
        num = myFaker.pyint(min_value=1, max_value=diaposon, step=1)
        if num not in existings_id:
            existings_id.append(num)
            f.write(str(num) + ';')
            break

    if gender == "male":
        f.write(myFaker.first_name_male() + ';')
        f.write(myFaker.last_name_male() + ';')
    else:
        f.write(myFaker.first_name_female() + ';')
        f.write(myFaker.last_name_female() + ';')

    f.write(gender + ';')

    f.write('\n')


#/Users/antontimonin/Desktop

f.close()