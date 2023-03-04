/*
Задача 50 (2). Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет
*/

using System;

class Program {
    static void Main(string[] args) {
        // Определяем двумерный массив 4 на 4 из случайных вещественных чисел
        double[,] arr = new double[4, 4];
        Random rnd = new Random();
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                arr[i,j ] = Math.Round(rnd.Next(-100,100) * 0.1, 1);
            }
        }

        // Показываем двумерный массив
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Принимаем на вход позиции элемента
        Console.Write("Введите строку элемента (0-3): ");
        int row = int.Parse(Console.ReadLine()!);
        Console.Write("Введите столбец элемента (0-3): ");
        int col = int.Parse(Console.ReadLine()!);

        // Возвращаем значения элемента, или говорим что такого нет
        if (row >= 0 && row < 4 && col >= 0 && col < 4) {
            Console.WriteLine($"Значение элемента [{row},{col}] это {arr[row, col]}");
        } else {
            Console.WriteLine("Ошибка! Нет такого элемента в массиве.");
        }
        Console.ReadKey();
    }
};
