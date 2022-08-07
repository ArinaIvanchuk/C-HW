// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка)

Console.WriteLine("введите число");
double a = Convert.ToInt32(Console.ReadLine());
double result = a % 2;
if (result == 0) 
{
    Console.Write("a-число четное");
}
else
{
    Console.Write("a-число не четное");
}
if (a == 0)
{
    Console.WriteLine("чётные целые числа отсутствуют")
}


