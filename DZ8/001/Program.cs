Console.Clear();
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
*/

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[linesVol, columnsVol];


FillArrayRandomnum(num);
PrintArray(num);
Console.WriteLine();
Console.WriteLine("Массив До:");


for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < num.GetLength(1) - 1; z++)
        {
            if (num[i, z] < num[i, z + 1]) //от 1 поменять знак < на противоположный
            {
                int temp = 0;
                temp = num[i, z];
                num[i, z] = num[i, z + 1];
                num[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив После:");
PrintArray(num);

void FillArrayRandomnum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}