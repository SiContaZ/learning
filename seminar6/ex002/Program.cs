/*
Задача 40:
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
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


void Triangle(int a, int b, int c)
{
    if (a<b+c && b<a+c && c<a+b)
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} может существовать");
    }
    else
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не может существовать");
    }
}

int a = GetNumber("Введите длину стороны a");
int b = GetNumber("Введите длину стороны b");
int c = GetNumber("Введите длину стороны c");

Triangle(a, b, c);
