// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter first number :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number :");
int b = Convert.ToInt32(Console.ReadLine());
int grade = a;

for (int i = 1; i < b; i++)
{
grade = grade * a;
}
Console.WriteLine($"{a} in grade {b} = " + grade);