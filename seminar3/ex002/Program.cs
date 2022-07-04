/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result >= 1 && result <= 4)
            {
                break;
            }
            else
                Console.Clear();
            Console.WriteLine(errorMessage);
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void Result(int quarter)
{
    if (quarter == 1)
        Console.WriteLine("x = от 0 до + бесконечности и y = от 0 до + бесконечности");
    else if (quarter == 2)
        Console.WriteLine("x = от 0 до - бесконечности и y = от 0 до + бесконечности");
    else if (quarter == 3)
        Console.WriteLine("x = от 0 до - бесконечности и y = от 0 до - бесконечности");
    else
        Console.WriteLine("x = от 0 до + бесконечности и y = от 0 до - бесконечности");
}

int quarter = GetNumber("Введите номер четверти");
Result(quarter);