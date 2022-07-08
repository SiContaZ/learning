/*
Задача 33:
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(0, 6);
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

bool IsNumberExist(int[] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }
    }
    return result;
}

Console.WriteLine("Введите размерность массива");
int dimension = int.Parse(Console.ReadLine());

int[] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
bool exist = IsNumberExist(array, number);

if (exist == true)
{
    Console.WriteLine("Число присутсвует в массиве");
}
else
{
    Console.WriteLine("Число не присутсвует в массиве");
}