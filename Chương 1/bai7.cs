
// Tính S(n) = 1/2 + 2/3 + 3/4 + … + n/(n+1).

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
            sum += (double)i / (i + 1);
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
