/*Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");
int count = number.ToString().Length;

Console.Write(MakeArray(number, count));

int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.Write("Потеряли число, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a / c) % 10;
    }
    return result;

}


/*Рандом от -1000 до 1000
var rnd = new Random();
int num = rnd.Next(-1000, 1000);

Console.WriteLine($"{num} -> {num % 10}");

Console.WriteLine();*/