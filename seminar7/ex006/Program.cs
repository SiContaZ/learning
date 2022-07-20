/*
умножение матриц
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

int [,] IntegMatrix(int[,] matrix, int[,] matrix2)
{
    int [,] integMatrix = new int[matrix.GetLength(0),matrix2.GetLength(1)];
    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                integMatrix[i,j] += matrix[i,x] * matrix2[x,j];
            }
        }
    }
    return integMatrix;
}






Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);
int[,] matrix2 = InitMatrix(m, n);
int[,] integMatrix = IntegMatrix(matrix, matrix2);

Console.WriteLine($"первая Матрица размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"вторая Матрица размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(integMatrix);