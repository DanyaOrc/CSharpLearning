/*

Задача 23 (3):

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int cub = 1;
while (cub <= num)
    {
        Console.WriteLine((cub * cub * cub));
        cub = cub + 1;
    };
Console.ReadKey();
