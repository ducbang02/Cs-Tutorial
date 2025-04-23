// Tính tổng tất cả các ước chung của hai số nguyên dương a và b.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());
        int sum = 0, min = Math.Min(a, b);
        for (int i = 1; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0) sum += i;
        }
        Console.WriteLine($"Tổng các ước chung là {sum}");
    }
}
