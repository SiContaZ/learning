/*
Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(-100, 101);
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

void MaxMinDiff(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        else if(array[i]<min)
        {
            min = array[i];
        }

    }
    int diff = max - min;
    Console.Write($"Максимальный элемент: {max}, минимальный элемент: {min}, разница {diff}.");

}
Console.WriteLine("Введите размерность массива");
int dimension = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
MaxMinDiff(array);