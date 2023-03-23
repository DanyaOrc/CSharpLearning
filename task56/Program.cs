// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


class Program
{
    static void Main(string[] args)
    {
        int rows = 4;
        int columns = 5;

        int[,] array = GenerateRandomArray(rows, columns);

        PrintArray("Массив:", array);

        int minRow = FindRowWithMinSum(rows, columns, array);

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");

        Console.ReadKey();
    }

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

    static int FindRowWithMinSum(int rows, int columns, int[,] array)
    {
        int minSum = int.MaxValue;
        int minRow = -1;
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minRow = i;
            }
        }

        return minRow;
    }
}
