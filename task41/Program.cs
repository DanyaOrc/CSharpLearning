/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество чисел для ввода: ");
        int count = int.Parse(Console.ReadLine()!);

        int positiveCount = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите число {i+1}: ");
            int num = int.Parse(Console.ReadLine()!);
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                Console.WriteLine("Ошибка! Отрицательные числа не поддерживаются.");
                i--;
            }
        }

        Console.WriteLine($"Вы ввели {positiveCount} позитивных чисел.");
        Console.ReadLine();
    }
};
