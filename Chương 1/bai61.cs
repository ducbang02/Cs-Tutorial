// Tìm bội chung nhỏ nhất (BCNN) của hai số nguyên dương a và b.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());
        int x = a, y = b;
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        int lcm = x * y / a;
        Console.WriteLine($"BCNN là {lcm}");
    }
}
