/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void CheckDay (int number)
{
    if (number <= 7 && number >= 1)
    {
        if (number <= 5) Console.WriteLine($"{number} -> нет");
        else Console.WriteLine($"{number} -> да");
    }
    else Console.WriteLine("Число не верное");
}

CheckDay (8);