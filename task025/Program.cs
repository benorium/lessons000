// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int size1 = InputInt("Enter size of array 1: ");
int size2 = InputInt("Enter size of array 2: ");
int size3 = InputInt("Enter size of array 3: ");
int count = 99;

if (size1 * size2 * size3 > count)
{
    Console.Write("array is too big");
    return;
}

int[,,] result = newArray(size1, size2, size3);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int k = 0; k < result.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {result[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] newArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[count];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomIndex = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomIndex];
        values[randomIndex] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}