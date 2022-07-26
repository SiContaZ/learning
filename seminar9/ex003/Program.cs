/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

void SumAllNumber(int number, int sum)
{
    if (number == 0)
        Console.WriteLine(sum);
    else
    {
        sum = sum + (number % 10);
        SumAllNumber(number / 10, sum);
    }
}

int m = int.Parse(Console.ReadLine());
int summ = 0;
SumAllNumber(m, summ);