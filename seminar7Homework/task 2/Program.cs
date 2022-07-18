/*
Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int [,] InitMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = randomizer.Next(1,10);
        }
    }
    return matrix;
}

int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void MatrixNumber(int[,] matrix, int m, int n)
{
    int i = GetNumber("Введите строку");
    int j = GetNumber("Введите столбец");
    if (i>m || j> n)
    {
        Console.WriteLine("Такого числа в матрице нет");
    }
    else
    {
        Console.WriteLine(matrix[i,j]);
    }
}

Random rnd = new Random();
int m = rnd.Next(1,11);
int n = rnd.Next(1,11);
int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
MatrixNumber(matrix,m,n);