/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
//int number = int.Parse(numberStr);

//if (number > 99)
if (numberStr.Length >= 3)
{
    Console.WriteLine($"третья цифра - {numberStr[2]}");
}
else
{
    Console.WriteLine("третей цифры нет");
}