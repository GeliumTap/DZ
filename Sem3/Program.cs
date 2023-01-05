/*Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.*/


/*int num;

while (true) ;
{
    Console.Write("Введите целое число; ");

    try
    {
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}


int num_abc = Math.Abs(num);

if (num_abc < 100) ;
{
    Console.WriteLine($"3й Нет");
    return;
}

int thirdNumberRight = num_abc / 100 % 10;

while (num_abc > 999) ;
{
    num_abc /= 10;
}
int thirdNumberLeft = num_abc % 10;


Console.WriteLine($"3й число {num} справо -> {thirdNumberRight}");
Console.WriteLine($"3й число {num} слева -> {thirdNumberLeft}"); */

//Напишите программу, которая принимает на вход координаты точки (X и Y), причем Х не равен 0 и Y  неравен 0
//и выдает номер четверти плоскости, в которой находится эта точка.

//----------------------- Начало программы -------------------------------
/* Console.Clear();
int X = 0, Y = 0;
InitCoordinatesByUser(ref X, ref Y); //Вызов метода с передачей параметров по ссылке ref
PrintQuarterByCoords(X, Y);          //Вызов метода с передачей параметров по значению  */
//----------------------- Конец программы --------------------------------

//------------------------------------------------------------------------

//----------------------- Определение методов ----------------------------

//------------------------------------------------------------------------
//Определение функцию, выполняющию ввод значений координат
/*
static void InitCoordinatesByUser(ref int x, ref int y)
{
    try
    {
        Console.Write("Введите X: ");
        X = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Y: ");
        Y = int.Parse(Console.ReadLine() ?? "");

    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка данных! {exc.Message}");
        return;
    }
}
*/
//--------------------------------------------------------------
/* Определяем функцию, принимающая два аргумента (координат точек x и y)
и выводящую в консоль номер четверти плоскости, в которой находится эта точка*/
/*
static void PrintQuarterByCoords(int x, int y)
{
    if(x > 0 && y > 0)
        Console.WriteLine("1");
    else if(x < 0  && y > 0)
        Console.WriteLine("2");
    else if(x < 0 && y < 0)
        Cosole.WriteLine("3");
    else if(x > 0 && y < 0)
        Console.WriteLine("4");
    else
        Console.WriteLine("Ошибка! Точка на оси коор!");
}
*/
//---------------------- Конец определения методов -----------------------


//Задача 18 Нахождение четверти
/*
Console.Write("Введите целое число; ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if (num == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (num == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (num == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else
{
    Console.WriteLine("Четверти нету такой");
}
*/
//-----------------------------------------------

int x1 = ReadInt("Введите координату X.1: ");
int y1 = ReadInt("Введите координату Y.1: ");
int x2 = ReadInt("Введите координату X.2: ");
int y2 = ReadInt("Введите координату Y.2: ");

int A = x2 - x1;
int B = y2 - y1;

double length = Math.Sqrt(A * A + B * B);
Console.WriteLine("S = " + length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}