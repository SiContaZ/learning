/*
Задача 29:
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

//ручной ввод массива

int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
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
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
        array[i] = GetNumber("Введите число");
    }
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
}
int [] array = new int[8];

FillArray(array);