/*
Задача 27:
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
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
//метод через массив
void SummArray(int number)
{
    string numberStr = Convert.ToString(number);
    int[] array = new int[numberStr.Length];

    int summ = 0;
    for (int i = 0; i < array.Length; i++)
        array[i] = numberStr[i] - '0';

    for (int j = 0; j < array.Length; j++)
        summ = summ + array[j];

    Console.WriteLine(summ);
}

// метод через int
void SummInt(int number)
{
    int summ = 0;
    if(number == 0)
        Console.WriteLine(summ);
    else
    {
        while (number > 0)
        {
            summ = summ + number % 10;
            number /= 10;
        }
        Console.WriteLine(summ);
    }
}


int number = GetNumber("Введите число");

SummArray(number);

SummInt(number);
