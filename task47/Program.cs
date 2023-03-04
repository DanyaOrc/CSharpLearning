/*
Задача 47 (1). Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Определяем размер массива
        Console.WriteLine("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите количество столбцов: ");
        int x = int.Parse(Console.ReadLine()!);

        // Определяем массив как двумерный
        double[,] array = new double[m, x];

        // Наполянем массив случайными вещественными числами
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < x; j++)
            {
                //array[i, j] = random.NextDouble();
                array[i,j ] = Math.Round(random.Next(-100,100) * 0.1, 1);
            }
        }

        // Показываем массив
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < x; j++)
            {
                // "{0:F2}" - это строка формата в C#,
                // которая используется для форматирования вывода числового значения с двумя десятичными знаками
                Console.Write("{0:F2} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
};
