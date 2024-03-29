# Задача 6: Вы пользуетесь общественным транспортом? Вероятно, вы расплачиваетесь
# за проезд и получали билет с номером. Счастливым билетом называют
# такой билет с шестизначным номером, где сумма первых трех цифр равна
# последних трех. Т.е. билет с номером 385916 - счастливый, т.к.
# 3 + 8 + 5 = 9 + 1 + 6. Вам требуется написать программу, которая проверяет
# счастливость билета.
# Пример: 385916 -> yes
#        123456 -> no

print('Введите шестизначное число билета: ')
k = str(input())

k_1 = int(k[0]) + int(k[1]) + int(k[2])
k_2 = int(k[3]) + int(k[4]) + int(k[5])

if k_1 == k_2:
    print('Билет счастливый: yes')
else:
    print('Билет счастливый: no')
