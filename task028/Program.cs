// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of all natural elements between M and N = {summ(M, N)}");
 
static int summ(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + summ(M, N - 1); 
    else return N + summ(M, N + 1);            
}
