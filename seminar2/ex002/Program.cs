/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Random rnd = new Random();
int number = rnd.Next(100,1000);
Console.WriteLine(number);
int firstN = number % 10;
int secondN = number / 100;
Console.WriteLine($"{secondN}{firstN}");
