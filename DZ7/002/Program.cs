Console.Clear();
/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в
двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

//_____________________________________Запрос у пользователя______________________

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[10, 10];


//_____________________________________Результат___________________________________

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}

//_____________________________________Методы_____________________________________

//_____________________________________Заполнение массива_________________________



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

//_____________________________________Вывод массива______________________________

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

//_____________________________________Ввод_______________________________________

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}