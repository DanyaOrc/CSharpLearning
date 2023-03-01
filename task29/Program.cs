/*
Задача 29:
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

int[] numbers = new int[8];
Console.WriteLine("Введите 8 чисел: ");
for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Элемент {i}: ");
        numbers[i] = int.Parse(Console.ReadLine()!);
    }

Console.WriteLine("Массив элементов:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.ReadLine();
