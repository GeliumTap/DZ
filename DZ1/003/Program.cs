Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");

if (number %2 == 0)
{
    Console.WriteLine($"{number} -> Yes");
}

else
{
    Console.WriteLine($"{number} -> No");
}


//if (number %2 == 1)
//{
//    Console.WriteLine("Число " + number + " является: НЕЧЁТНЫМ");
//}
//else
//{
//    Console.WriteLine("Число " + number + " является: ЧЁТНЫМ");
//}