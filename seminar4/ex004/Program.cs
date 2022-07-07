/*
Задача 30:
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Random rnd = new Random();
int[] array = new int[8];



for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,2);
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}




/*
доп примеры
*/
/*
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
*/