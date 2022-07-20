/*Задача 53:
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
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

int [,] InitNewMatrix(int [,] matrix)
{
    int [,] matrix2 = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==0)
            {
                matrix2[i,j] = matrix[matrix.GetLength(0)-1, j];
            }
            else if(i == matrix.GetLength(0)-1)
            {
                matrix2[i,j] = matrix[0,j];
            }
            else
            {
                matrix2[i,j] = matrix[i,j];
            }
        }
    }
    return matrix2;
}


Random rnd = new Random();
int m = rnd.Next(1,11);
int n = rnd.Next(1,11);
int[,] matrix = InitMatrix(m,n);
int [,] newMatrix = InitNewMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(newMatrix);
