// Tính S(n) = √(n! + √((n-1)! + √((n-2)! + ... + √(1!)))) với n dấu căn.

using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        for (int i = n; i >= 1; i--)
        {
            long f = 1;
            for (int j = 1; j <= i; j++) f *= j;
            result = Math.Sqrt(f + result);
        }
        Console.WriteLine($"S(n) = {result}");
    }
}
