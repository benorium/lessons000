// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
int start = 1;
Console.Write("Write number : ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = start; i <= n; i++)
    if (i % 2 == 0) 
    {
         Console.Write(i + " ");
    }
Console.ReadKey();


