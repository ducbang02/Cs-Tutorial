
// Đếm số lượng ước số chẵn của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 2; i <= n; i += 2)
        {
            if (n % i == 0) count++;
        }
        Console.WriteLine($"Số lượng ước chẵn của {n} là {count}");
    }
}
