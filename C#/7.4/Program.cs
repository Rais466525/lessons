using System;

class Program
{
    static void Main()
    {
        int rows = 3, cols = 4;
        int[,] matrix = new int[rows, cols];

        // Заполнение матрицы случайными целыми числами от 1 до 10
        Random rand = new Random();
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 11);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sumDiagonal = 0;
        for (int i = 0; i < Math.Min(rows, cols); i++)
        {
            sumDiagonal += matrix[i, i];
        }

        matrix[rows - 1, cols - 1] = sumDiagonal;

        Console.WriteLine("\nОтвет:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}