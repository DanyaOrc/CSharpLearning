//  Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

using System;

namespace EvenNumbersRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Четные числа между {0} и {1}:", m, n);
            PrintEvenNumbers(m, n);

            Console.ReadKey();
        }

        static void PrintEvenNumbers(int m, int n)
        {
            if (m > n)
            {
                return;
            }

            if (m % 2 == 0)
            {
                Console.WriteLine(m);
            }

            PrintEvenNumbers(m + 1, n);
        }
    }
}
