// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Enter a three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
Console.WriteLine(str[1]);