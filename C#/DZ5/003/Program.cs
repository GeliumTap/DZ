Console.Clear();
/* 
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76 
*/

//_____________________________________Запрос у пользователя______________________

int size = ReadInt("Array Size: ");
int min = ReadInt("Minimum number of the array: ");
int max = ReadInt("Maximum array number: ");
int [] num = new int[size];

FillArrayRandomNum(num);
PrintArray(num);

int maxFillarray = num[0];
int minFillarray = num[0];

//_____________________________________Результат__________________________________

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > maxFillarray)
    {
        maxFillarray = num[i];
    }
    if (num[i] < minFillarray)
    {
        minFillarray = num[i];
    }
}
Console.WriteLine($"The difference between the maximum and minimum = {maxFillarray - minFillarray}");


//_____________________________________Методы_____________________________________

//_____________________________________Заполнение массива_________________________

void FillArrayRandomNum(int [] array)
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