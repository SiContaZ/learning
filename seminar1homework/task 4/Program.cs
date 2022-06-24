/*
Задача 8:
 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int numberN = int.Parse(numberStr);

for (int i = 2; i <= numberN; i += 2)
{
    Console.WriteLine(i);
}