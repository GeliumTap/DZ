﻿/* Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11;  82 -> 10;  9012 -> 12   */

Console.Clear();

//_____________________________________Запрос у пользователя______________________

int num = ReadInt("Enter a Number: ");
int len = NumLen(num);
SumNumb(num, len);

//_____________________________________Подсчета цифр в числе______________________
int NumLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

//_____________________________________Вывод cуммы цифр в числе___________________
void SumNumb(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"{num} -> {sum}");
}

//_____________________________________Ввод_______________________________________
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
