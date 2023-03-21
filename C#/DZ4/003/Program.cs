/* Задача 29 Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33] */

Console.Clear();

//_____________________________________Запрос у пользователя______________________

int lenArray = ReadInt("Enter the length of the array: ");

Console.Write($"{lenArray} -> [");
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write($" {i}");
}

Console.Write(" ]");

//_____________________________________Ввод_______________________________________
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}