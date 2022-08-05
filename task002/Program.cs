// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
int num1, num2, num3, max;
Console.WriteLine("Enter first number : ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number : ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number : ");
num3 = Convert.ToInt32(Console.ReadLine());
max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("{0} is max", max);
