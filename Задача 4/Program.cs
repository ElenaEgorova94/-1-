// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.



Console.WriteLine("Введите firstNumber");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите secondNumber");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите thirdNumber");
int thirdNumber = int.Parse(Console.ReadLine());

int max = firstNumber;


if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    max = firstNumber;
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    max = secondNumber;
}
else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    max = thirdNumber;
}

Console.WriteLine(max);