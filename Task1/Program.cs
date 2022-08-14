// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string firstgNumber = Convert.ToString(number);
Console.WriteLine("вторая цифра  " + firstgNumber[1]);