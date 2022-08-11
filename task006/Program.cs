// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter a number : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n > 99 ? n.ToString()[2] : '-');
Console.ReadKey(true);


