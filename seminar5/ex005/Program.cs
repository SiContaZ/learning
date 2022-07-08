/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 11);
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
void Multiple(int[] arr)
{
    int result = 0;
    int j = arr.Length - 1;
    for (int i = 0; i <= arr.Length/2 +1; i++)
    {
        if (i < j)
        {
            result = arr[i] * arr[j];
            Console.Write($"{result} ");
            j--;
        }
        else if (i == j)
        {
            result = arr[i];
            Console.Write($" {result}");
        }
        /*else
        {
            break;
        }*/
    }
}
Console.WriteLine("Введите размерность массива");
int dimension = int.Parse(Console.ReadLine());


int[] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
Multiple(array);









/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3*/
/*
int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 10);
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

void Multipl(int[] arr)
{
    string result = string.Empty;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int res = arr[i] * arr[arr.Length - 1 - i];
        result += $"{res} ";
    }
    if (arr.Length % 2 == 0)
        Console.WriteLine(result);
    else
    {
        Console.WriteLine(result + $" {arr[arr.Length / 2]}");

    }

}

Console.WriteLine("Введите число элементов: ");
int multiple = int.Parse(Console.ReadLine());

int[] array = GetArray(multiple);
PrintArray(array);
Console.WriteLine();
Multipl(array);
*/