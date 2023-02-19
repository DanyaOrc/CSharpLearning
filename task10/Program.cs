/* Задача 10.
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число: ");
string input = (Console.ReadLine()!);
if (input.Length == 3){
    int number = Convert.ToInt32(input);
    int lastDigit = (number / 10) % 10;
    Console.WriteLine($"Последняя цифра: {lastDigit}");
}
else{
    Console.WriteLine("Ошибка! Введите трехзначное число.");
};
