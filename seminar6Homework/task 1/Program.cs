/*
Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

void PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"В введёных вами {array.Length} числах - {count} положительных.");
}

int[] GetNumbers()
{

    List <int> numbersLst = new List<int>();
    int result = 0;
    string buffer = string.Empty;
    while (true)
    {
        Console.WriteLine("Введите число. Для прекращения ввода введите \"стоп\"");
        buffer = Console.ReadLine();
        if (buffer == "стоп")
        {
            break;
        }
        else if (int.TryParse(buffer, out result))
        {
            Console.Clear();
            numbersLst.Add(result);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }
    int[] numbersArray = numbersLst.ToArray();
    return numbersArray;
}
void PrintArray(int[] arr)
{
    Console.Write("Вы ввели: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



int[] numbers = GetNumbers();
PrintArray(numbers);
Console.WriteLine();
PositiveNumbers(numbers);