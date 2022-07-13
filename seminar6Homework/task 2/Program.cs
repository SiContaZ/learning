/*
Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
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
// Представляем уравнения в системе. Из неё находим х = (b2-b1)/(k1-k2)

void CrossPoint(double b1,double k1,double b2,double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x + b1;
    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые полностью совпадают");
    }
    else
    {
        Console.WriteLine($"Прямые пересекаются в точке ({x} {y})");
    }
}




double b1 = GetNumber("Введите значение b1");
double k1 = GetNumber("Введите значение k1");
double b2 = GetNumber("Введите значение b2");
double k2 = GetNumber("Введите значение k2");
CrossPoint(b1,k1,b2,k2);