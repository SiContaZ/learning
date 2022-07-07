/*
Задача 29:
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


// массив из заданного восьмизначного числа

/*int GetNumber(string message)
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
void ArrayNumber(int number)
{
    while(number>0)
    {
        Console.Write(number%10 );
        number/=10;
    }
}

int number = GetNumber("Введите восьмизначное число");
int [] array = new 
ArrayNumber(number);
*/
void PrintArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintArrayForEach(int[] array)
{
    foreach(int item in array)
    {
        //int item = array[i], в цикле по i 

        Console.Write($"{item} ");
    }
}


var array = new int[8];
Random rnd = new Random();

for(int i=0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,10);
}

Console.WriteLine("Вывод через цикл for: ");
PrintArray(array);
Console.WriteLine();


Console.WriteLine("Вывод через цикл foreach: ");
PrintArrayForEach(array);