
// Tính S(n) = x^2 + x^4 + x^6 + … + x^(2n).

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
            sum += Math.Pow(x, 2 * i);
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
