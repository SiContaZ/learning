/*
Задача 29:
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

//рандомный массив

Random rnd = new Random();
int[] array = new int[8];



for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next();
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
// массив из заданного восьмизначного числа

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
            else if(result > 9999999 && result <100000000)
                break;
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не восьмизначное число число");
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