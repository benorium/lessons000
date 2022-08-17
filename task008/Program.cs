// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Enter number 5 digit number : ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"your number : {number} - palindrome.");
  }
  else Console.WriteLine($"your number : {number} - not a palindrome.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"enter a correct number");
