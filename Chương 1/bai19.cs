
// Tính S(n) = 1 + x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)!.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1 + x;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            {
                fact *= (2 * i) * (2 * i + 1);
                sum += Math.Pow(x, 2 * i + 1) / fact;
            }
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
