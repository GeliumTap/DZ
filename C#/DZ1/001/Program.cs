Console.WriteLine("Введите первое число: ");
int number_A = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
int number_B = int.Parse(Console.ReadLine() ?? "");

int max = number_A;

if (number_B > max)
{
    max = number_B;
}

Console.WriteLine($"a = {number_A}, b = {number_B}, -> {max}.");
