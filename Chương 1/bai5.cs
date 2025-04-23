
// Tính S(n) = 1 + 1/3 + 1/5 + … + 1/(2n+1).

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
            sum += 1.0 / (2 * i + 1);
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
