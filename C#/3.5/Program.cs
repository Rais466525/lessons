using System;

class Program {
    static double f(double x) {
        return Math.Sin(x);
    }

    static void Main() {
        double x = 2.0;
        double y = 3.0;
        double d;

        switch (x.CompareTo(y)) {
            case 1: // x > y
                d = Math.Pow(f(x) - y, 3) + Math.Atan2(f(x), x) * y;
                break;
            case -1: // x < y
                d = Math.Pow(y - f(x), 3) + Math.Atan(f(x)) * x;
                break;
            case 0: // x == y
                d = Math.Pow(y + f(x), 3) + 0.5;
                break;
        }

        Console.WriteLine($"d = {d:F4}");
    }
}