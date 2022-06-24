/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите первое число");
string firstStr = Console.ReadLine();
int first = int.Parse(firstStr);

Console.WriteLine("Введите второе число");
string secondStr = Console.ReadLine();
int second = int.Parse(secondStr);

if (first == second*second)
{
    Console.WriteLine($"Число {first} является квадратом {second}");
}
else
{
    Console.WriteLine($"Число {first} не является квадратом {second}");
}