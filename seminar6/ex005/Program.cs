/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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

int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] GetArrayCopy(int[] arr)
{
    int [] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length ; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

int dimension = GetNumber();
int [] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
int [] copyArray = GetArrayCopy(array);
PrintArray(copyArray);