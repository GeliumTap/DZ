/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.*/

var rnd = new Random();
int num = rnd.Next(-10, 1000);

Console.WriteLine($"{num} -> {num / 10 % 10 } ");

Console.WriteLine();