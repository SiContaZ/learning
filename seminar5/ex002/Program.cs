/*
Задача 32:
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(-9, 10);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PrintArrayNeg(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите размерность массива");
int dimension = int.Parse(Console.ReadLine());

int[] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
PrintArrayNeg(array);