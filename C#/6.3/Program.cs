using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 25 вещественных чисел
        double[] arr = new double[25];
        
        // Заполняем массив случайными числами от 0 до 100
        Random rand = new Random();
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Math.Round(rand.NextDouble() * 100, 2);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        // Находим индекс минимального элемента
        int minIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[minIndex])
            {
                minIndex = i;
            }
        }

        // Меняем минимальный элемент с первым элементом
        double temp = arr[0];
        arr[0] = arr[minIndex];
        arr[minIndex] = temp;

        // Выводим измененный массив
        Console.WriteLine("Массив после замены:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
