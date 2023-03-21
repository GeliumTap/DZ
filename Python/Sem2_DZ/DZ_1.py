# Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой,
# а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
# чтобы все монетки были повернуты вверх одной и той же стороной.
# Выведите минимальное количество монет, которые нужно перевернуть.

# sourcery skip: for-index-underscore
n = int(input('Введите количество монеток: '))
from random import randint
m = [randint(0, 1) for x in range(n)]
count0 = 0
count1 = 0
for i in range(n):
    if m[i] == 0:
        count0 += 1
    else:
        count1 += 1

print(m)
if count0 > count1:
    print(count1,'Нужно перевернуть')
else:
    print(count0,'Нужно перевернуть')