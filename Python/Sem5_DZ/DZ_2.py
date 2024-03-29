'''Задача 28: Напишите рекурсивную функцию sum(a, b),
возвращающую сумму двух целых неотрицательных чисел.
Из всех арифметических операций допускаются только +1 и -1.
Также нельзя использовать циклы.
2 2
4'''

def recsum(a, b):  # sourcery skip: assign-if-exp, reintroduce-else
    if b == 0:
        return a
    return 1 + recsum(a, b - 1)

print(recsum(3, 2))