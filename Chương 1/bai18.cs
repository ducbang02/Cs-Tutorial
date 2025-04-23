
// Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^(2n)/(2n)!.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1, fact = 1;
        for (int i = 1; i <= n; i++)
        {
            {
                fact *= (2 * i - 1) * (2 * i);
                sum += Math.Pow(x, 2 * i) / fact;
            }
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
