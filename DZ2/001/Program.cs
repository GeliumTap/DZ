/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");
//int amount = number.ToString().Length;

if (number <= 99 || number >= 1000)
//if (amount < 3 || amount > 3)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine(InCenter(number));
}
int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}


/*Рандом от -1000 до 1000 
var rnd = new Random();
int num = rnd.Next(-1000, 1000);

Console.WriteLine($"{num} -> {(num / 10) % 10 } ");

Console.WriteLine();*/