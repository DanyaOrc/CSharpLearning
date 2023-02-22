/* Задача 19. 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет 
12821 -> да 
23432 -> да */ 
 
Console.Write("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
int rem, sum = 0, rev; 
{ 
rev = num; 
    while (Convert.ToBoolean(num)) 
        { 
            rem = num % 10; 
            num = num / 10; 
            sum = sum * 10 + rem; 
        } 
    Console.WriteLine("Перевернутое число - это: {0} ", sum); 
    if (rev == sum)  
        { 
            Console.WriteLine("Число является палиндромом"); 
        } 
    else 
        { 
            Console.WriteLine("Число не является палиндромом"); 
        } 
};
