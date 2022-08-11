// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input a number of the day: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("Incorrect number ");
}
else
{
    if (day == 1)
    {
        Console.Write("no ");
    }
    if (day == 2)
    {
        Console.Write("no ");
    }
    if (day == 3)
    {
        Console.Write("no ");
    }
    if (day == 4)
    {
        Console.Write("no ");
    }
    if (day == 5)
    {
        Console.Write("no ");
    }
    if (day == 6)
    {
        Console.Write("yes ");
    }
    if (day == 7)
    {
        Console.Write("yes ");
    }
}