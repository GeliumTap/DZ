Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");
int i = 1;
bool no = true;

Console.WriteLine($"Чётные числа от 1 до {number}");
Console.Write($"{number} -> ");

while (i <= number)
{
if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        no = false;
    }
    i = i + 1;
}

if (no)
{
    Console.WriteLine("Нет чётных чисел!");
}
