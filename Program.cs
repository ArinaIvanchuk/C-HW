// Напишиите программу, которая на вход принимает два числа и выдает какое число больше, а какое меньше
Console.Write("введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число b");
int b = Convert.ToInt32(Console.ReadLine());
if(a < b)
{
    Console.Write("b больше a");
}
if(b < a)
{
    Console.Write("a больше b");
}
if(a == b)
{
    Console.Write("a и b равны");
}

