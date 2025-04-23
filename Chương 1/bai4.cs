
// Tính S(n) = 1/2 + 1/4 + 1/6 + … + 1/2n.

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
            sum += 1.0 / (2 * i);
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
