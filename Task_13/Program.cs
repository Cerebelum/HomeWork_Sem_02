﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Вариант 1. Без функции.
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int mod = Math.Abs(num);
//
// if (mod / 100 < 1)
// {
//     Console.Write("Третьей цифры нет");
// }
// else
// {
//     int k = mod;
//     while (k / 1000 >= 1)
//     {
//         k = (k - k % 10) / 10;
//     }
//     int thirdDigit = k % 10;
//     Console.Write($"Третья цифра числа {num}: {thirdDigit}");
// }

// Вариант 2. С функцией.
int SearchThirdDigit(int k) // ищет третью цифру числа
{
    int thirdDigit = -1; // на случай ошибки
    while (k / 1000 >= 1)
    {
        k = (k - k % 10) / 10;
    }
    thirdDigit = k % 10;
    return thirdDigit;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int mod = Math.Abs(num);

if (mod / 100 < 1)
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write($"Третья цифра числа {num}: {SearchThirdDigit(mod)}");
}