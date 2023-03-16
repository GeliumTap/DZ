# Задача 8: Требуется определить, можно ли от шоколадки размером
# n x m долек отломить k долек, если разрешается сделать один
# разлом по прямой между дольками(то есть разломить на два прямоугольника).
# Пример: 3 2 4 -> yes
#        3 2 1 -> no

print('Длинна n: ')
n = int(input())
print('Высота m : ')
m = int(input())
print('Число долек k: ')
k = int(input())

if (k < (m * n)) and (k % n == 0 or k % m == 0):
    print(n, m, k, '-> yes')
else:
    print(n, m, k, '-> no')