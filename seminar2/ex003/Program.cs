/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число");
string firstStr = Console.ReadLine();
int first = int.Parse(firstStr);

Console.WriteLine("Введите второе число");
string secondStr = Console.ReadLine();
int second = int.Parse(secondStr);

int remainder = first % second;

if (remainder ==0)
{
    Console.WriteLine("Число кратное");
}
else
{
     Console.WriteLine($"Число не кратное, остаток {remainder}.");
}