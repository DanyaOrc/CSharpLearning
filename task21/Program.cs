/* Задача 21. 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
A (3,6,8); B (2,1,-7), -> 15.84 
A (7,-5, 0); B (1,-1,9) -> 11.53 */
 
double getDistance (double xa, double ya, double za, double xb, double yb, double zb) 
{ 
     return Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za)); 
} 
Console.Write("Enter the x coordinate of the first point: "); 
double xa = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter the y coordinate of the first point: "); 
double ya = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter the z coordinate of the first point: "); 
double za = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter the x coordinate of the second point: "); 
double xb = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter the y coordinate of the second point: "); 
double yb = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter the z coordinate of the second point: "); 
double zb = Convert.ToDouble(Console.ReadLine()); 
 
Console.WriteLine("Distance between points: " + Math.Round(getDistance(xa, ya, za, xb, yb, zb), 2)); 
