using System;

class Program
{
    // Метод для вычисления n / x^n
    static double Calc(int n, double x)
    {
        return n / Math.Pow(x, n);
    }

    static void Main()
    {
        double x = 2; // Можно изменить значение x при необходимости
        double product = 1;
        for (int i = 1; i <= 10; i++)
        {
            product *= Calc(i, x);
        }
        Console.WriteLine($"Произведение: {product}");
    }
}