// Tính S(n) = 1 / (1 + (1 / (1 + (1 / (1 + ... )))) có n dấu phân số.

using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 1;
        for (int i = 0; i < n; i++)
        {
            result = 1.0 / (1 + result);
        }
        Console.WriteLine($"S(n) = {result}");
    }
}
