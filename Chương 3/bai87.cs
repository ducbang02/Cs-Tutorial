using System;

// Bài 87: Tìm số nguyên dương n nhỏ nhất sao cho 1 + 2 + ... + n > 10000
class Program
{
    static void Main()
    {
        int n = 1, tong = 0;

        while (tong <= 10000)
        {
            tong += n;
            n++;
        }

        Console.WriteLine("Giá trị n nhỏ nhất là: " + (n - 1));
    }
}
