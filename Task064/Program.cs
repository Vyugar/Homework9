﻿/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите натуральное число больше 1:");
int NumberN = Convert.ToInt32(Console.ReadLine());

void NumberCounter(int NumberN)
{
    if (NumberN < 0)
    {
        Console.WriteLine($"{NumberN} не натуральное число");
        return;
    }
    if (NumberN == 0) return;
    /*
    Др. вариант:
    if (NumberN == 0)
    {
        Console.WriteLine($"Вы ввели {NumberN}, который меньше 1");
        return;
    }
    */

    else if (NumberN > 0)
    {
        Console.Write("{0,4}", NumberN);
        NumberCounter(NumberN - 1);
    }
}

NumberCounter(NumberN);