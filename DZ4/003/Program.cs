int[] mass = new int[8];

Console.Write("[");

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 9);
    Console.Write(" " + Method(i) + ".");
}
Console.Write(" ]");

int Method(int a)
{
    return mass[a];
}