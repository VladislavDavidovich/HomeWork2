// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string firstgNumber = Convert.ToString(number);

if(firstgNumber.Length > 2)
{
    Console.WriteLine("третья цифра  " + firstgNumber[2]);
}
else
{
    Console.WriteLine("третьей цифры нет " );
}