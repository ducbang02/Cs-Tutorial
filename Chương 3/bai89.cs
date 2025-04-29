using System;

// Bài 89: Tính tổng các số lẻ nguyên dương nhỏ hơn N
class Program
{
    static void Main()
    {
        Console.Write("Nhập N: ");
        int n = int.Parse(Console.ReadLine());

        int tong = 0;

        for (int i = 1; i < n; i += 2)
        {
            tong += i;
        }

        Console.WriteLine("Tổng các số lẻ nhỏ hơn N là: " + tong);
    }
}
