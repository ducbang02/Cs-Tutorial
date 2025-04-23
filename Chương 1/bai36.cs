// Tính S(n) = √(n! + √((n-1)! + √(... + √(1!)))) với n dấu căn.

using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        long factorial = 1;
        for (int i = 1; i <= n; i++) factorial *= i;
        for (int i = n; i >= 1; i--)
        {
            long f = 1;
            for (int j = 1; j <= i; j++) f *= j;
            result = Math.Sqrt(f + result);
        }
        Console.WriteLine($"S(n) = {result}");
    }
}
