// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от.

Console.Write("enter a number : ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArr(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arr = new int[cube+1];
Cube(arr);
PrintArr(arr);