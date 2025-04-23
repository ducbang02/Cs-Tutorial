// Tính S(n) = √n + √(n-1 + √(n-2 + ... + √1)) với n dấu căn.

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
