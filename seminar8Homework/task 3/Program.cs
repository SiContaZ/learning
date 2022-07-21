/*
Задача 58:
Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49
*/

/*
В Примере ошибка: произведение этих матриц будет равоно
70	61	46	69
61	119	92	76
46	92	100	88
69	76	88	114
*/
int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
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

int[,] IntegMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] integMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];


    for (int i = 0; i < integMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < integMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                integMatrix[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return integMatrix;
}






Random rnd = new Random();
int m = rnd.Next(1, 11);
int n = rnd.Next(1, 11);
int k = rnd.Next(1, 11);

int[,] matrix = InitMatrix(m, n);
int[,] matrix2 = InitMatrix(n, k);
int[,] integMatrix = IntegMatrix(matrix, matrix2);

Console.WriteLine($"первая Матрица");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"вторая Матрица");
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(integMatrix);