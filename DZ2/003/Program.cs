Console.WriteLine("Введите число от 1 до 7: ");
int daynum = int.Parse(Console.ReadLine() ?? "");

string[] Days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
string result = "";

if (daynum > 5) result = $". Yes - ВЫХОДНОЙ!!!";
else result = $", No - Идите работать!";

Console.WriteLine();
Console.WriteLine($"{daynum}-й -> {Days[daynum - 1]}{result}");
