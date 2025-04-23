
// Tính S(n) = x + x^3 + x^5 + … + x^(2n+1).

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
        for (int i = 0; i <= n; i++)
        {
            sum += Math.Pow(x, 2 * i + 1);
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
