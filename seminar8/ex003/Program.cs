/*
Задача 59:
Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
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

void NewMatrix(int[,] matrix)
{
    List<int> minI = new List<int>();
    List<int> minJ = new List<int>();

    int min = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]<=min)
            {
                min = matrix[i,j];
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]==min)
            {
                minI.Add(i);
                minJ.Add(j);
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (minI.Contains(i))
        {
            continue;
        }
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minJ.Contains(j))
            {
                continue;
            }
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}


Random rnd = new Random();
int m = rnd.Next(1,11);
int n = rnd.Next(1,11);
int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
NewMatrix(matrix);