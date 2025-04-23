
// Tính S(n) = x + x^2 + x^3 + … + x^n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(x, i);
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
