Console.Clear();

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/

//_____________________________________Запрос у пользователя______________________

int size = ReadInt("Array Size: ");
int[] num = new int[size];

FillArrayRandomNumbers(num);
PrintArray(num);
int result = 0;

//_____________________________________Результат__________________________________

for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"{result} an even number");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"{result} even numbers");
}
else
{
    Console.WriteLine($"{result} even numbers");
}

//_____________________________________Методы_____________________________________

//_____________________________________Заполнение массива_________________________

void FillArrayRandomNumbers(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
    Console.WriteLine();
}

//_____________________________________Вывод массива______________________________

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"] -> ");
}

//_____________________________________Ввод_______________________________________
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

