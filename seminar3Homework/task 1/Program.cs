/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if(result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else if(result > 9999 && result <100000)
                break;
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не пятизначное число");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}
string number = Convert.ToString(GetNumber("Введите пятизначное число"));

if (number[0] == number[4] && number[1] == number[3])
    Console.WriteLine($"Число {number} является палиндромом");
else
    Console.WriteLine($"Число {number} не является палиндромом");
