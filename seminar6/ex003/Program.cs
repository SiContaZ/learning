/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

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

string DecimalToBinar(int number)
{
    int result = 0;
    string buffer = string.Empty;
    while(number>0)
    {
        result = number%2;
        number = number/2;
        buffer = buffer + result;
    }
    return buffer;
}

void PrintArray(string arr)
{
    for (int i = arr.Length-1; i >= 0; i--)
    {
        Console.Write($"{arr[i]}");
    }
}

int number = GetNumber("Введите число");
string resultStrig = DecimalToBinar(number);
PrintArray(resultStrig);