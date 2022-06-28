/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 0 && number < 8)
{
    if (number < 6)
    {
        Console.WriteLine("Сегодня рабочий день");
    }
    else
    {
        Console.WriteLine("Сегодня выходной");
    }
}
else
{
    Console.WriteLine("Такого дня в неделе нет");
}