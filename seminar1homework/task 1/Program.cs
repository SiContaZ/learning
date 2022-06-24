/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string firstStr = Console.ReadLine();
int first = int.Parse(firstStr);

Console.WriteLine("Введите второе число");
string secondStr = Console.ReadLine();
int second = int.Parse(secondStr);

if(first > second)
{
    Console.WriteLine($"число {first} больше числа {second}");
}
else if(first < second)
{
    Console.WriteLine($"число {second} больше числа {first}");
}
else
{
    Console.WriteLine("числа равны");
}