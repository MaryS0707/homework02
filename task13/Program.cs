/* 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void ShowThirdNum (int number)
 {
    Console.WriteLine($"Заданное число: {number}");
    string str = number.ToString();
    if (str.Length >= 3) Console.WriteLine($"Третья цифра числа: {str[2]}");
    else Console.WriteLine("Третьей цифры нет");
 }

 ShowThirdNum (759);