﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max = 0;
Console.Write("Введите a: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите b: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);
Console.Write("Введите c: ");
string text3 = Console.ReadLine();
int number3 = Convert.ToInt32(text3);

if (number1 > max)
{
 max = number1;
}
if (number2 > max)
{
 max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine("max = " + max);