Console.Clear();
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//_____________________________________Запрос у пользователя______________________

double b1 = ReadInt("Enter b1: ");
double k1 = ReadInt("Enter k1: ");
double b2 = ReadInt("Enter b2: ");
double k2 = ReadInt("Enter k2: ");

//_____________________________________Результат___________________________________

double fit = (b1 - b2) / (k2 - k1);
double two = (k2 * fit) + b2;

Console.Clear();

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({fit}; {two})");

//_____________________________________Ввод________________________________________
double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}