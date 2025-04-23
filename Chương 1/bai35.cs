// Tính S(n) = √(1 + √(2 + √(3 + ... + √n))) với n dấu căn.

using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        for (int i = n; i >= 1; i--)
        {
            result = Math.Sqrt(i + result);
        }
        Console.WriteLine($"S(n) = {result}");
    }
}
