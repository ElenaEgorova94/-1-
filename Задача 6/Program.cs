﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите Number");
int Number = int.Parse(Console.ReadLine());

if (Number % 2 == 0)
{
    Console.WriteLine($"{Number} четное число");
}
else
{
    Console.WriteLine($"{Number} нечетное число");
}