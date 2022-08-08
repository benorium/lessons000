// // 4 Напишите программу, которая на вход принимает одно число (N), 
// //а на выходе показывает все целые числа в промежутке от -N до N.

// // выводим текст с запросом в терминал
// Console.Write("Введите число: ");
// // присваиваем переменной N введенное число
// int N = Convert.ToInt32(Console.ReadLine());
// // обяъвляем новую переменную, в которую сохраняем значение N с противоположным знаком
// int B = -N;

// // условный цикл, который будет "работать" до тех пор, пока значение переменной B меньше либо равно значению N
// while (B <= N)
// {
//     // выводим на экран значение B и пробел
//     Console.Write(B+ " ");
//     // увеличиваем значение B на единицу
//     B++; // B = B + 1 аналогично B += 1 
// }

// Задача на вывод третьего числа из трехзначного числа
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num <= 999){
//     int x = num % 10;
//     Console.WriteLine(x);
// }
// else{
//     Console.WriteLine("Введенное число не трехзначное");
// }
// решение с помощью функци
// Console.WriteLine("enter the number");
// // int num = Convert.ToInt32(Console.ReadLine());
// // Console.Write("result " + Math.Abs(num) % 10);

// 1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Console.Clear();
// int num = new Random().Next(10, 100);
// Console.WriteLine(num);
// int dejets = num % 10;
// int doesnts = num / 10;
// if (dejets > doesnts)
// {
//     Console.WriteLine("{0} is max", dejets);
// }
// else
// {
//     Console.WriteLine("{0} is max", doesnts);
// }

// 2 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Console.Clear();
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int dejets = num % 10;
// int doesnts = num / 100;
// Console.Write($"{doesnts}{dejets}");

// 3 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Console.Clear();
// Console.WriteLine("Enter first number : ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number : ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// bool true1 = num2 % num1 == 0;
// if (true1)
// {
// Console.Write(true1);
// }
// else 
// {
//     Console.WriteLine(num2 % num1);
// }

// 4 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.Clear();
// Console.WriteLine("Enter number : ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// bool multip7 = num1 % 7 == 0;
// bool multip23 = num1 % 23 ==0;
// Console.WriteLine(multip7 && multip23);

// 5 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2)
{
    Console.WriteLine("Первое число является квадртом второго");
}
else
{
    Console.WriteLine("Первое число не является квадртом второго");
}
if(num2 == num1*num1)
{
    Console.WriteLine("Второе число явлеятся квадратом первого");
}
else
{
      Console.WriteLine("Второе число не явлеятся квадратом первого");
}