﻿/*

Задача 34 (1):
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// Создаём массив из 10
int[] numbers = new int[10];

// Генерируем случайные числа от 100 до 999 и заполняем массив
Random random = new Random();
for (int i = 0; i < numbers.Length; i++) {
numbers[i] = random.Next(100, 1000);
}

// Показываем получившийся массив
Console.WriteLine("Массив: " + string.Join(", ", numbers));

// Считаем количество чётных чисел в массиве
int count = 0;
foreach (int number in numbers){
    if (number % 2 == 0) {
    count++;
        }
    }

// Показываем количество чётных чисел в массиве
Console.WriteLine($"Количество чётных чисел в массиве: {count}");
