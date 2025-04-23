
// Đếm số lượng ước số của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) count++;
        }

        Console.WriteLine($"Số lượng ước của {n} là {count}");
    }
}
