Console.Clear();
/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

//_____________________________________Запрос у пользователя______________________

Console.WriteLine("Размер квадратного массива");
int mass = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[mass, mass];
int minsum = Int32.MaxValue;
int indexLine = 0;

FillArrayRandomnum(num);
PrintArray(num);

//_____________________________________Результат___________________________________

for (int i = 0; i < num.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + num[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

//_____________________________________Методы_____________________________________

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