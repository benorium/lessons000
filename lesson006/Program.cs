﻿// // СЕММИНАР 6!!!!

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);      // [0; 20) по умолчанию 
//         }
//     }
//     return matrix;
// }

// int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);      // [0; 20) по умолчанию 
//         }
//     }
//     return matrix;
// }


// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t"); 
//         }
//         Console.WriteLine();
//     }
// }

// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");     // Необязательно
// int minRand = Prompt("Введите нижнюю границу диапазона ");      // Необязательно    
// int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand); // Диапазон значений можно не указывать, будут взяты условия по умолчанию
// PrintArray(matrix);







// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns) 
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     
//         {
//             matrix[i, j] = i + j;      
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = FillArray(Prompt("Введите ислосток >"),Prompt("Введите колличество столбцов >"));
// PrintArray(array);




// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
// {
//     int[,] matrix = new int[numLine, numColumns];   // Создание нового массива
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = i + j;      // Формула для заполнения массива
//         }
//     }
//     return matrix;      // Возвращаем результат
// }
// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");     // Вывод значений очередной строки 
//         }
//         Console.WriteLine();    // Переход на следующую строку
//     }
// }


// int[,] ConvertToSQR(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
//     return array;

// }

// int [,] massiv = FillArray(5, 5);
// PrintArray(massiv);
// System.Console.WriteLine();
// int [,] newmassiv = ConvertToSQR(massiv);
// PrintArray(newmassiv);




// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12
// Random rand = new Random();

// void FillMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 15);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] matrix = new int[3, 3];

// FillMatrix(matrix);
// PrintArray(matrix);
// System.Console.WriteLine(GetSum(matrix));
// int GetSum(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }


// Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// int CalcDifferenceSumMaxSumMin(int[,] array)
// {

//     int sumMinNum = 0;
//     int sumMaxNum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int minNum = array[i, 0];
//         int maxNum = array[i, 0];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < minNum) { minNum = array[i, j]; }
//             if (array[i, j] > maxNum) { maxNum = array[i, j]; }
//         }

//         sumMinNum += minNum;
//         sumMaxNum += maxNum;
//     }
//     int answer = sumMaxNum - sumMinNum;

//     return answer;
// }


// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]

// Введенный элемент 6, результат: такого элемента нет.

Random rand = new Random();

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[3, 3];

FillMatrix(matrix);
PrintArray(matrix);

System.Console.WriteLine("Input a number: ");
int element = int.Parse(Console.ReadLine() ?? "0");
findElem(matrix, element);


void findElem (int[,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(element == matrix[i, j])
            {
              System.Console.WriteLine($"Entered number is on the [{i},{j}] position");
              return;
            }
        }

    }
    System.Console.WriteLine($"There is no such element in this matrix");

    
}