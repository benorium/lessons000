// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив


Console.Write("Enter array size :");
int size = Convert.ToInt32(Console.ReadLine());

int[,] numbres = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    numbres
[i, j] = num;
    if (i <= j + 1 && i + j < size - 1) ++j;
    else if (i < j && i + j >= size - 1) ++i;
    else if (i >= j && i + j > size - 1) --j;
    else --i;
    ++num;
}

PrintArray(numbres);

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