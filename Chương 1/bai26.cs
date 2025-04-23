
// Tính tích tất cả các ước số lẻ của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        long product = 1;
        for (int i = 1; i <= n; i += 2)
        {
            if (n % i == 0)
            {
                product *= i;
            }
        }

        Console.WriteLine($"Tích các ước lẻ của {n} là {product}");
    }
}
