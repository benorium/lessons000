﻿// Задайте прямоугольный? двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Enter size of the array :");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[arraySize, arraySize];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int minValue = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minValue)
    {
        minValue = sum;
        indexLine++;
    }
}

Console.WriteLine("row with min sum: " + (indexLine) + ", sum of the elements: " + (minValue));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
