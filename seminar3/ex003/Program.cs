/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
AB = √(xb - xa)2 + (yb - ya)2
*/


int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели неверное число. Введите корректное число.";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}



int ax = GetNumber("Введите координату x точки a");
int bx = GetNumber("Введите координату x точки b");
int ay = GetNumber("Введите координату y точки a");
int by = GetNumber("Введите координату y точки b");

double length = Math.Sqrt(Math.Pow(bx - ax,2) + Math.Pow(by - ay,2));
Console.WriteLine($"Расстояние между точками равняется {length}");