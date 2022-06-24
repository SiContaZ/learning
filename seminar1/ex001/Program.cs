/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Наприме:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число, которое хотите возвести в квадрат");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int result = number * number;

Console.WriteLine($"Квадрат числа {number} равняется {result}");
