/*
Задача 52 (3).
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Определяем двумерный массив со случайными числами
        Random random = new Random();
        int[,] array = new int[5, 3];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                array[i, j] = random.Next(10);
            }
        }

        // Находим среднее арифметическое в каждом столбце
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);
        double[] means = new double[numCols];
        for (int j = 0; j < numCols; j++)
        {
            double sum = 0;
            for (int i = 0; i < numRows; i++)
            {
                sum += array[i, j];
            }
            means[j] = sum / numRows;
        }

        // Показываем результат
        Console.WriteLine("Массив:");
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Значение:");
        for (int j = 0; j < numCols; j++)
        {
            Console.WriteLine($"Столбец {j}: {means[j]}");
        }
    }
};
