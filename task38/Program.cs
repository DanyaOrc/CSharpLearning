﻿/*
Задача 38 (3):
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// Массив из вещественных чисел (в нашем случае дробных)
double[] numbers = { 1.2, 5.7, 3.9, 2.1, 6.5 };

// Находим максимальный и минимальный элементы
double max = numbers[0];
double min = numbers[0];
foreach (double number in numbers) {
if (number > max) {
max = number;
}
if (number < min) {
min = number;
    }
}

// Считаем и показываем разницу
double diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами массива составляет: " + diff);
