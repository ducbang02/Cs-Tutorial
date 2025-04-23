// Tính S(n) = √(x^n + √(x^(n-1) + √(... + √x))) với n dấu căn.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        double result = 0;
        for (int i = 1; i <= n; i++)
        {
            result = Math.Sqrt(Math.Pow(x, n - i + 1) + result);
        }
        Console.WriteLine($"S(n) = {result}");
    }
}
