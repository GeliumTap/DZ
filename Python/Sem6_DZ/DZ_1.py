'''Задача 30: Заполните массив элементами арифметической прогрессии. Её первый элемент, разность и количество
элементов нужно ввести с клавиатуры. Формула для получения n-го члена прогрессии: a
n = a1 + (n-1) * d.
Каждое число вводится с новой строки.
Ввод: 7 2 5
Вывод: 7 9 11 13 15'''

a1= int(input("Введите  1-й элемент: "))
d=int(input("Введите 2-й элемент: "))
n=int(input("Введите 3-й элемент: "))
res = [a1 + (i - 1) * d for i in range(1, n + 1)]
print(*res)

'''
a1 = 7
d = 2
n = 5
for i in range(n):
    print(a1 + i * d, end=' ')
'''