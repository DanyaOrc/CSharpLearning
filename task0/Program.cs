/* Разминка

Напишите программу, которая на вход принимает число и выдаёт его квадрат (умножение на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + sqr);
