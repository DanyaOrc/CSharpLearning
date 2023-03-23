// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        SumFromMToN(m, n);
    }

    static void SumFromMToN(int m, int n)
    {
        Console.Write(SumMN(m - 1, n));
    }

    static int SumMN(int m, int n)
    {
        int res = m;
        if (m == n)
            return 0;
        else
        {
            m++;
            res = m + SumMN(m, n);
            return res;
        }
    }
};
