Console.WriteLine("Введите первое число: ");
int number_A = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
int number_B = int.Parse(Console.ReadLine() ?? "");

if (number_A > number_B)

{
    Console.WriteLine($"{number_A} > {number_B}");
}
else
{
    Console.WriteLine($"{number_B} > {number_A}");
}
