// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

int num1, num2;
Console.WriteLine("Enter first number : ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number : ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("{0} is max", num1);
}
else
{
    Console.WriteLine("{0} is max", num2);
}
