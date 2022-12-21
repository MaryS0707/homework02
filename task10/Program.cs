/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */

 void ShowSecondNum (int number)
 {
    Console.WriteLine($"Трехзначное число: {number}");
    string str = number.ToString();
    Console.WriteLine($"Вторая цифра числа: {str[1]}");
 }

 ShowSecondNum (729);