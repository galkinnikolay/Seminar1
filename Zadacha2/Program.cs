// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;
Console.Write("Введите a: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите b: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);

if (number1 < number2)
{
 max = number2;
 min = number1;
}
else
{
 max = number1;
 min = number2;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);