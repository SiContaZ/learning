/*
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(100, 1000);
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

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размерность массива");
int dimension = int.Parse(Console.ReadLine());

int[] array = GetArray(dimension);

Console.WriteLine();
int evenNumbers = EvenNumbers(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"В массиве {evenNumbers} чётных чисел.");