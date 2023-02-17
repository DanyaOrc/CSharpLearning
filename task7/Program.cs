/* Задача 7.

Напишите программу, которая принимает
на вход трёхзначное число и на выходе показывает
последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8 */
   
Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine();
if (input.Length == 3){
    int number = Convert.ToInt32(input);
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра: {lastDigit}");
}
else{
    Console.WriteLine("Ошибка! Введите трехзначное число.");
};
