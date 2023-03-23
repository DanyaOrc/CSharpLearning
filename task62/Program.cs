// Задача 62 *. Напишите программу, которая заполнит квадратный массив спирально (например 4х4).

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 4; 
        int[,] squareMatrix = new int[n, n]; 
        
        int temp = 1; 
        int i = 0; 
        int j = 0; 
        
        while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1)) 
        { 
            squareMatrix[i, j] = temp; 
            temp++; 
            
            // движение направо
            if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1) 
                j++; 
            // движение вниз
            else if (i < j && i + j >= squareMatrix.GetLength(0) - 1) 
                i++; 
            // движение влево
            else if (i >= j && i + j > squareMatrix.GetLength(1) - 1) 
                j--; 
            //движение вверх
            else 
                i--; 
        } 

        WriteArray(squareMatrix);
    }
    
    static void WriteArray (int[,] array) 
    { 
        for (int i = 0; i < array.GetLength(0); i++) 
        { 
            for (int j = 0; j < array.GetLength(1); j++) 
            { 
                if (array[i,j] / 10 <= 0) 
                    Console.Write($" {array[i,j]} ");
                else 
                    Console.Write($"{array[i,j]} "); 
            } 
            Console.WriteLine(); 
        } 
    }
}
