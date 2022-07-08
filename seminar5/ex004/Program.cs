/*
Задача 35:
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(0, 151);
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
int Summ(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
            summ++;
    }
    return summ;
}
int[] array = GetArray(123);

PrintArray(array);
Console.WriteLine();
int summ = Summ(array);
Console.WriteLine($"{summ} чисел лежат в промежутке от 10 до 99");