/* Задача 4.
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22 */

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (firstNumber > secondNumber){
    max = firstNumber;
}
else {
    max = secondNumber;
};
if (max > thirdNumber){
    Console.WriteLine($"Самое большое число {max}!");
}
else {
    max = thirdNumber;
    Console.WriteLine($"Самое большое число {max}!");
};
