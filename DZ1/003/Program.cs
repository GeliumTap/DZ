﻿Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");

if (number %2 == 0)
{
    Console.WriteLine($"{number} -> Yes");
}
else
{
    Console.WriteLine($"{number} -> No");
}
