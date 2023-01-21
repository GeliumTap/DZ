Console.Clear();
/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0 
*/

//_____________________________________Запрос у пользователя______________________

int size = ReadInt("Array Size: ");
int min = ReadInt("Minimum number of the array: ");
int max = ReadInt("Maximum array number: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

//_____________________________________Результат__________________________________

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Odd positions = {result}");

//_____________________________________Методы_____________________________________

//_____________________________________Заполнение массива_________________________

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
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












