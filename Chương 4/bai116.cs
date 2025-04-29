using System;

class Program
{
    // Bài 116: Tính tổng S(n) = 1 + 2 + ... + n
    static int TinhTong(int n)
    {
        int tong = 0;
        for (int i = 1; i <= n; i++) {
            tong += i;
        }
        return tong;
    }

    static void Main()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tổng S(n) = {TinhTong(n)}");
    }
}
