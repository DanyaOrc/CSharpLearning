/* Напишите программу, которая на вход принимает число и выдаёт его квадрат (умножение на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + sqr); */

/* Напишите программу, которая на вход

принимает два числа и проверяет, является ли первое число квадратом второго.

a=25, b = 5-> да

a=2, b = 10 нет

a=9, b=-3 -> да

a=-3 b = 9 -> нет */

/* Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int sqr = secondNumber * secondNumber;
if
    (sqr == firstNumber)
        Console.WriteLine("Первое число является квадратом второго");
else
    Console.WriteLine("Первое число не является квадратом второго"); */

/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница

Console.Write("Введите число от 1 до 7 (числа соответсвуют дням недели): ");
int num = Convert.ToInt32(Console.ReadLine());

    switch (num) {
        case 1:
                Console.WriteLine("Понедельник");
                break;
        case 2:
                Console.WriteLine("Вторник");
                break;
        case 3:
                Console.WriteLine("Среда");
                break;
        case 4:
                Console.WriteLine("Четверг");
                break;
        case 5:
                Console.WriteLine("Пятница");
                break;
        case 6:
                Console.WriteLine("Суббота");
                break;
        case 7:
                Console.WriteLine("Воскресенье");
                break;
        default:
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 7.");
                break;
        }; */
