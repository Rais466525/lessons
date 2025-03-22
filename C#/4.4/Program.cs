using System;

class Program
{
    static void Main()
    {
        double x0 = 5.3;
        double xk = 10.3;
        double dx = 0.25;
        double a = 1.35;
        double b = -6.25;

        Console.WriteLine("  x        y(x)");

        for (double x = x0; x <= xk + 1e-12; x += dx)
        {
            double y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);

            Console.WriteLine("{0,6:F2}   {1,10:F6}", x, y);
        }

        Console.ReadKey();
    }
}
