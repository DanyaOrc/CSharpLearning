/* Задача 13.
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int number = ReadInt("Введите число: "); 
int count = number.ToString().Length; 
Console.Write(MakeArray(number, count)); 
 
int ReadInt(string message) 
{ 
    Console.Write(message); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
 
int MakeArray(int number, int count) 
{ 
int result = 0; 
    if (count < 3) 
    { 
    Console.Write("Ошибка! Пожалуйста, введите трёхзначное цисло: "); 
    } 
    else 
    { 
        int current = 1; 
        for (int i = count; i > 3; i--) 
        { 
            current = current * 10; 
        } 
 
        result = (number / current) % 10;
    } 
 return result; 
};
