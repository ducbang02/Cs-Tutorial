
// Tính S(n) = 1^2 + 2^2 + 3^2 + … + n^2.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i * i;
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
