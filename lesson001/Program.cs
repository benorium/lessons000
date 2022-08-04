Console.Clear();

Console.Write("write a number ");
int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number;
// number ** number;
int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));
Console.Write("number in sqrt: " + sqrt1);

