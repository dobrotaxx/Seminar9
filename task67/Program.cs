/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.WriteLine("Введите число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int GetSum(int userNumber)
{
    if (userNumber == 0)
    {
        return 0;
    }
    int digit = userNumber % 10;
    return digit + GetSum(userNumber / 10);
}

int result = GetSum(userNumber);
Console.Write($"{result}");
