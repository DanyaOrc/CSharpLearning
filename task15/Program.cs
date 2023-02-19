/* Задача 15.
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число от 1 до 7 (числа соответсвуют дням недели): ");
int num = Convert.ToInt32(Console.ReadLine());

    switch (num) {
        case 1:
                Console.WriteLine("Понедельник - Будний день.");
                break;
        case 2:
                Console.WriteLine("Вторник - Будний день.");
                break;
        case 3:
                Console.WriteLine("Среда - Будний день.");
                break;
        case 4:
                Console.WriteLine("Четверг - Будний день.");
                break;
        case 5:
                Console.WriteLine("Пятница - Будний день.");
                break;
        case 6:
                Console.WriteLine("Суббота - Выходной день.");
                break;
        case 7:
                Console.WriteLine("Воскресенье - Выходной день.");
                break;
        default:
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 7.");
                break;
        };
