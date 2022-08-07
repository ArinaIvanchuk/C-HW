// напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число N");
double N = Convert.ToInt32(Console.ReadLine());
double num1 = 1;
double num2 = 0;
double num3 = -1;
while (num1 < N)
{
    double result = num1 % 2;
    if (result == 0)
    {
        num2 = num1;
        Console.WriteLine(num2);
    } 
    num1 +=1;
    
}
while(num3 > N)
{
    double result = num3 % 2;
    if (result == 0)
    {
        num2 = num3;
        Console.WriteLine(num2);
    } 
    num3 -=1;
}
if (N == 0)
{
    Console.WriteLine("Четные целые числа отсутствуют");
}

