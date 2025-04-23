
// Tính S(n) = 1 + 1×2 + 1×2×3 + ⋯ + 1×2×3×…×n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        long sum = 0, term = 1;
        for (int i = 1; i <= n; i++)
        {
            {
                term *= i;
                sum += term;
            }
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
