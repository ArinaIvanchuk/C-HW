// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Write("введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число c");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write(max);

