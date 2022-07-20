/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

int [,,] InitMatrix(int m, int n, int k)
{
    int [,,] matrix = new int[m,n,k];
    int [] buffer = new int[m*n*k];
    int count = 0;
    Random randomizer = new Random();
    for (int i = 0; i < buffer.Length; i++)
    {
        buffer[i] = randomizer.Next(1,101);
        if(i>=1)
        {
            for (int j = 0; j < i; j++)
            {
                while (buffer[i] == buffer[j])
                {
                    buffer[i] = randomizer.Next(1,101);
                    j = 0;
                }
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                matrix[i,j,l] = buffer[count];
                count++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]} ({i}, {j}, {k});   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

Random rnd = new Random();
int x = rnd.Next(1, 5);
int y = rnd.Next(1, 5);
int z = rnd.Next(1, 5);
int[,,] matrix3D = InitMatrix(x,y,z);
Console.WriteLine($"В матрице {x} строки,{y} столбца,{z} слоя.");
Console.WriteLine();
PrintMatrix(matrix3D);
