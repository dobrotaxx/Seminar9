/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int ExponentiationOfANumber(int userNumber, int thePowerOfANumber)
{
    if (thePowerOfANumber == 1)
    {
        return userNumber;
    }
    return userNumber *= ExponentiationOfANumber(userNumber, thePowerOfANumber - 1);
}

Console.WriteLine("Введите число А: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень для числа А, число B: ");
int userNumberB = Convert.ToInt32(Console.ReadLine());

int result = ExponentiationOfANumber(userNumberA, userNumberB);
Console.Write($"Число {userNumberA} в степени {userNumberB} = {result}");

