/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void SumAllNumber(int n,int m, int sum)
{
    if (n == m)
    {
        sum = sum + n;
        Console.WriteLine(sum);
    }
    else if(n>=m)
    {
        sum = sum + n;
        SumAllNumber(n-1,m, sum);
    }
    else
    {
        sum = sum + n;
        SumAllNumber(n+1,m, sum);
    }
}

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int summ = 0;
SumAllNumber(n,m, summ);