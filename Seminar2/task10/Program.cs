﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

iНапишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
int Prompt(string message);
{
    System.Console.Write(message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзнвчное число > ");
    return;
}
Console.WriteLine("Введите число");
int secondRank = number / 10 % 10;
Console.WriteLine("Вторая цифра");
