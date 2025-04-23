
// Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/n!.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 0, fact = 1;
        for (int i = 1; i <= n; i++)
        {
            {
                fact *= i;
                sum += Math.Pow(x, i) / fact;
            }
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
