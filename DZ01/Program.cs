/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());

void PrintRange(int userNumberN)
{
    if (userNumberN == 1)
    {
        return;
    }
    Console.Write($"{userNumberN}, ");
    PrintRange(userNumberN - 1);
}

PrintRange(userNumberN);
Console.Write("1.");

