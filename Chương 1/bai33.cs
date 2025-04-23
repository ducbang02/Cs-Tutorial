// Tính S(n) = √2 + √(2 + √(2 + ... √2)) với n dấu căn.

using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        for (int i = 0; i < n; i++)
        {
            result = Math.Sqrt(2 + result);
        }
        Console.WriteLine($"S(n) = {result}");
    }
}
