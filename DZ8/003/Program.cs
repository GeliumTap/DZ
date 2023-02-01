Console.Clear();
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
//_____________________________________Методы_____________________________________
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10); //Для увеличения размера чисел в матрицах поменять число 10 на нужное число
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
//_____________________________________Запрос у пользователя______________________
int size = InputInt("Размерность матриц: ");
Console.WriteLine();
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];
//_____________________________________Результат___________________________________
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
Console.WriteLine();
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
Console.WriteLine();
PrintArray(matrixC);