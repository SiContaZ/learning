/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string firstStr = Console.ReadLine();
int first = int.Parse(firstStr);

Console.WriteLine("Введите второе число");
string secondStr = Console.ReadLine();
int second = int.Parse(secondStr);

Console.WriteLine("Введите третье число");
string thirdStr = Console.ReadLine();
int third = int.Parse(thirdStr);

if (first > second)
{
    if (first > third)
    {
        Console.WriteLine($"максимальное число - {first}");
    }
    else
    {
        Console.WriteLine($"максимальное число - {third}");
    }
}
else
{
    if (second > third)
    {
        Console.WriteLine($"максимальное число - {second}");
    }
    else
    {
        Console.WriteLine($"максимальное число - {third}");
    }
}