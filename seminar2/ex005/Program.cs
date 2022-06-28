/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.WriteLine ("Введите первое число");
string firstStr = Console.ReadLine();
int first = int.Parse(firstStr);

Console.WriteLine ("Введите второе число");
string secondStr = Console.ReadLine();
int second = int.Parse(secondStr);

if(first == second * second || second == first * first)
{
    Console.WriteLine("одно число является квадратом другого");
}
else
{
    Console.WriteLine("одно число не является квадратом другого");
}