//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
Console.WriteLine("Массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
int Array = Convert.ToInt32(Console.ReadLine());

int[] array = new int[Array];

Console.Write("[");

for (int i = 0; i < Array; i++)
{
    array[i] = new Random().Next(Array+1);
    Console.Write($"{array[i]}.");
}

Console.Write("]");
*/






int[] mass = new int[8];

Console.Write("[");

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 9);
    Console.Write(" " + Method(i) + "");
}
Console.Write("]");

int Method(int a)
{
    return mass[a];
}
