/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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

void GetExp(int number, int degree)
{
    int temp = number;
    for (int i = 1; i < degree; i++)
    {
        number *= temp;
    }
    Console.WriteLine(number);
}



void GetExpPow(int number, int degree)
{
    Console.WriteLine(Math.Pow(number,degree));
}




int number = GetNumber("введите число");
int degree = GetNumber("Введите степень числа");
Console.WriteLine();
Console.WriteLine("Возведение в степень через математическую функцию");
GetExpPow(number, degree);
Console.WriteLine();
Console.WriteLine("Возведение в степень через цикл");
GetExp(number, degree);
