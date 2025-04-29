using System;

class Program
{
    // Bài 117: Tính S(n) = x + x^2 + x^3 + ... + x^n
    static double TinhTongLuyThua(double x, int n)
    {
        double tong = 0;
        for (int i = 1; i <= n; i++)
            tong += Math.Pow(x, i);
        return tong;
    }

    static void Main()
    {
        Console.Write("Nhập x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng S(n) = {TinhTongLuyThua(x, n):F2}");
    }
}
