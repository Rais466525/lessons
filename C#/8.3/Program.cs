using System;
using ScottPlot;

class Program
{
    static double CalculateW(double x)
    {
        double y = -0.875;
        double z = -0.475 * Math.Pow(10, -3);

        double cosDiff = Math.Abs(Math.Cos(x) - Math.Cos(y));
        double exponent = 1 + 2 * Math.Pow(Math.Sin(y), 2);
        double series = 1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4;

        return Math.Pow(cosDiff, exponent) * series;
    }

    static void Main()
    {
        var plt = new Plot(800, 600);
        
        // Создаем массивы для точек графика
        double[] xPoints = new double[1000];
        double[] yPoints = new double[1000];
        
        // Заполняем массивы значениями
        for (int i = 0; i < 1000; i++)
        {
            xPoints[i] = i * 0.01; // x от 0 до 10
            yPoints[i] = CalculateW(xPoints[i]);
        }

        plt.AddScatter(xPoints, yPoints);
        plt.Title("График функции w(x)");
        plt.XLabel("x");
        plt.YLabel("w");
        
        plt.SaveFig("graph.png");
        Console.WriteLine("График сохранен в файл graph.png");
    }
} 