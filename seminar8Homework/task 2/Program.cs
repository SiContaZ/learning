/*
Задача 56:
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(-10, 11);
        }
    }
    return matrix;
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

void MinMatrixSumLine(int[,] matrix)
{
    int matrixSumLine = 0;
    int buffer = 0;
    int minMatrixSumLine = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrixSumLine += matrix[0,i];
    }
    buffer = matrixSumLine;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrixSumLine = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixSumLine +=matrix[i,j];
        }
        if (matrixSumLine<buffer)
        {
            minMatrixSumLine = i;
            buffer = matrixSumLine;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - {minMatrixSumLine+1}");
}



Random rnd = new Random();
int m = rnd.Next(1, 11);
int n = rnd.Next(1, 11);
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
MinMatrixSumLine(matrix);