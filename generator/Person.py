from faker import Faker
import random

myFaker = Faker("ru_RU")

f = open('/Users/antontimonin/Desktop/Практика/data/Person.txt', 'w', encoding='utf-8')

diaposon = 250

for i in range(diaposon):
    number = myFaker.pyint(min_value=0, max_value=12, step=1)
    gender = "male"

    if number % 3 == 0:
        gender = "female"

    f.write(str(i) + ';') #film id

    if gender == "male":
        f.write(myFaker.first_name_male() + ';')
        f.write(myFaker.last_name_male() + ';')
    else:
        f.write(myFaker.first_name_female() + ';')
        f.write(myFaker.last_name_female() + ';')

    f.write(gender + ';')
    f.write(myFaker.address() + ';')
    f.write(myFaker.phone_number() + ';')
    f.write(myFaker.email())

    f.write('\n')


#/Users/antontimonin/Desktop

f.close()