// Đếm số lượng ước chung của hai số nguyên dương a và b.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());
        int count = 0, min = Math.Min(a, b);
        for (int i = 1; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0) count++;
        }
        Console.WriteLine($"Số lượng ước chung là {count}");
    }
}
