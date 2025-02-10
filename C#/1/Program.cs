using System;

class Program {
    static void Main() {
        double x = 0.4 * Math.Pow(10, 4);
        double y = -0.875;
        double z = -0.475 * Math.Pow(10, -3);

        double cosDiff = Math.Abs(Math.Cos(x) - Math.Cos(y));
        double exponent = 1 + 2 * Math.Pow(Math.Sin(y), 2);
        double series = 1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4;

        double w = Math.Pow(cosDiff, exponent) * series;

        Console.WriteLine($"w = {w:F4}");
    }
}