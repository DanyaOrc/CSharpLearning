// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



    static int[,] GenerateRandomArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns];

        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(100);
            }
        }

        return array;
    }

    static void PrintArray(string message, int[,] array)
    {
        Console.WriteLine(message);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

