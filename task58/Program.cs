// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 4;
        int columns = 5;
        
        int[,] matrixA = GenerateRandomMatrix(rows, columns);
        int[,] matrixB = GenerateRandomMatrix(rows, columns);
        int[,] matrixC = MatrixSum(matrixA, matrixB);

        PrintMatrix("Массив A:", matrixA);
        PrintMatrix("Матрица B:", matrixB);
        PrintMatrix("Результат сложения матриц A и B: ", matrixC);
    }
    

    static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];

        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(100);
            }
        }

        return matrix;
    }

    static int[,] MatrixSum(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);

        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++) 
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    static void PrintMatrix(string message, int[,] matrix)
    {
        Console.WriteLine(message);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
};
