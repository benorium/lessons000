﻿// Многомерные массивы и рекурсия

// string[,] table = new string[2, 5];
// String.Empty
// table[0,0]  table[0,1] table[0,2]
// table[1,0]   table[1,1]  table[1,2]

// table[1, 2] = "word";

// for (int rows = 0; rows < 2 ; rows++ )
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"{table[rows, colums]}");
//     }
// }



// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0) ; i++ )
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0) ; i++ )
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1,10); //[1;10]
//         }
//     Console.WriteLine();
//     }
// }

// int[,] matrix = new int [3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);



// РЕКУРСИЯ!!!!!

// int Factorial (int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++ )
// Console.WriteLine($"{i}! = {Factorial(i)}");



// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 50 ; i++ )
// {
//     Console.WriteLine($"f({i} = {Fibonacci(i)}");
// }

