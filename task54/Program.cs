// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System;

class Program
{
    static void Main(string[] args)
    {
        int rowCount = 4;
        int colCount = 4;

        // Создаем двумерный массив 4х4
        int[,] array = CreateRandomArray(rowCount, colCount);

        // Показываем оригинальный массив
        Console.WriteLine("Массив:");
        ShowArray(array);

        // Сортируем по убыванию элементов
        SortArrayDescending(array);

        // Показываем отсортированный массив
        Console.WriteLine("Массив по убыванию:");
        ShowArray(array);

        // Ждём пока пользователь нажмёт любую кнопку прежде чем закрыть окно консоли
        Console.ReadKey();
    }

    static int[,] CreateRandomArray(int rowCount, int colCount)
    {
        // Создаем двумерный массив заданной размерности
        int[,] array = new int[rowCount, colCount];

        // Наполняем массив случайными числами
        Random random = new Random();
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                array[i, j] = random.Next(100);
            }
        }

        return array;
    }

    static void SortArrayDescending(int[,] array)
    {
        // Сортируем каждую строку по убыванию
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = j + 1; k < 4; k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }

    static int[] GetRow(int[,] array, int rowIndex)
    {
        // Получаем заданную строку в виде массива
        int[] row = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[rowIndex, j];
        }

        return row;
    }

    static void SetRow(int[,] array, int[] row, int rowIndex)
    {
        // Устанавливаем заданную строку из массива
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[rowIndex, j] = row[j];
        }
    }

    static void ShowArray(int[,] array)
    {
        // Выводим массив на экран
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
};
