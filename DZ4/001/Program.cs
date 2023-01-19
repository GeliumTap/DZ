/* Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵);   2, 4 -> 16   */

Console.Clear();

//____________________________________Возведения в степень_______________________

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + "^" + b + " -> " + result);
}

//_____________________________________Ввод_______________________________________
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = ReadInt("Enter a Number: ");
int numB = ReadInt("Enter the Degree: ");
Degree(numA, numB);