
// Tính S(n) = 1/(1×2) + 1/(2×3) + … + 1/(n×(n+1)).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / (i * (i + 1));
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
