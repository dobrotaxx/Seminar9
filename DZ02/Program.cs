/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());

int GetSum(int userNumberM, int userNumberN)
{
    if (userNumberM == userNumberN)
    {
        return userNumberN;
    }
    return userNumberN + GetSum(userNumberM, userNumberN - 1);
}

int result = GetSum(userNumberM,userNumberN);
Console.WriteLine(result);

