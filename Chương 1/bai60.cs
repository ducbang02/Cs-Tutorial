// Tìm ước chung lớn nhất (ƯCLN) của hai số nguyên dương a và b.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        Console.WriteLine($"ƯCLN là {a}");
    }
}
