// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

int number;
Console.WriteLine("Enter a number : ");
number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 2 == 0 ? " is even" : "is odd");

