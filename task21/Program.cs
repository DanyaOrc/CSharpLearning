/* Задача 21 (2). 

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
A (3,6,8); B (2,1,-7), -> 15.84 
A (7,-5, 0); B (1,-1,9) -> 11.53 

*/
 
double getDistance (double xa, double ya, double za, double xb, double yb, double zb) 
{ 
     return Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za)); 
} 
Console.Write("Введите координату x первой точки: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: : ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки: : ");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x второй точки: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Дистанция между точками: " + Math.Round(getDistance(xa, ya, za, xb, yb, zb), 2));
