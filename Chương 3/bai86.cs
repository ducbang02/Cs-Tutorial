using System;

// Bài 86: Tính S(n) = 1^3 + 2^3 + 3^3 + ... + n^3
class Program
{
    static void Main()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        long tong = 0;

        for (int i = 1; i <= n; i++)
        {
            tong += i * i * i;
        }

        Console.WriteLine("Tổng S(n) = " + tong);
    }
}
