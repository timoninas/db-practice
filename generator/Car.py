from faker import Faker
import random

myFaker = Faker("en_US")

f = open('/Users/antontimonin/Desktop/Практика/data/Car.txt', 'w')

diaposon = 350

#1895

for i in range(diaposon):
    f.write(str(i) + ';')
    f.write(str(myFaker.pyint(min_value=0, max_value=49, step=1)) + ';')
    
    f.write(myFaker.color_name() + ';')
    
    word1 = myFaker.color_name()[0]
    word2 = myFaker.color_name()[0]
    word3 = myFaker.color_name()[0]

    f.write(word1 + myFaker.credit_card_security_code() + word2 + word3)
    f.write('\n')


#/Users/antontimonin/Desktop

f.close()