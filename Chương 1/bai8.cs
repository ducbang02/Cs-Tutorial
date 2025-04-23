
// Tính S(n) = 1/2 + 3/4 + 5/6 + … + (2n+1)/(2n+2).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += (double)(2 * i + 1) / (2 * i + 2);
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
