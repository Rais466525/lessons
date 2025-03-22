using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        Console.Write("Цифры в строке: ");
        foreach (char ch in input)
        {
            if (char.IsDigit(ch))
            {
                Console.Write(ch);
            }
        }
        Console.WriteLine();
    }
}
