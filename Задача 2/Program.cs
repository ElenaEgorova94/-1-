// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());

if (n > m)
{
    Console.WriteLine("максимальное число:" + n);
    Console.WriteLine("минимальное число:" + m);
}
else
{
    Console.WriteLine("максимальное число:" + m);
    Console.WriteLine("минимальное число:" + n);
}