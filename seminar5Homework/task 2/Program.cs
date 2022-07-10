/*
Задача 36:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

//судя по примерам нужно выдать сумму чисел под нечётными индесами.
void PrintSumm(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        summ += array[i];
    }
    Console.WriteLine(summ);
}

Console.WriteLine("Введите размерность массива");
int dimension = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
PrintSumm(array);
