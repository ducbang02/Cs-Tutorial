using System;

// Bài 90: Tìm số nguyên dương m lớn nhất sao cho 1 + 2 + ... + m < N
class Program
{
    static void Main()
    {
        Console.Write("Nhập N: ");
        int n = int.Parse(Console.ReadLine());

        int m = 1, tong = 0;

        while (tong + m < n)
        {
            tong += m;
            m++;
        }

        Console.WriteLine("Giá trị m lớn nhất là: " + (m - 1));
    }
}

