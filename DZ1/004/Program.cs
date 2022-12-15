
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");
int i = 1;
bool not = true;

Console.WriteLine($"Чётные числа от 1 до {number}");
Console.Write($"{number} -> ");

while (i <= number)
{
if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i = i + 1;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}