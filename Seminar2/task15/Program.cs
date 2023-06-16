﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

internal class Program
{
    private static int Main(string[] args)
    {
        int Prompt(string message);
        {
            System.Console.Write(message);
            string value = Console.ReadLine();
            int result = Convert.ToInt32(value);
            return result;
        }

        bool ValidateWeekday(int number)
        {
            if (weekDay > 5)
            {
                return true;
            }
            return false;
        }

        bool ValidateWeekday(int number)
        {
            if (number > 0 && number <= 7)
            {
                return true;
            }
            Console.WriteLine("Это не день недели!");
            return
        }
        int weekDay = Prompt("Введите день недели: ");
        if (ValidateWeekday(weekDay))
        {
            if (IsWeekend(weekDay))
            {
                Console.WriteLine("Наконец_то выходной");
            }
            else
            {
                Console.WriteLine("Придется поработать");
            }
        }
    }
}