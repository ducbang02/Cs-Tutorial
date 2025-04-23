// Đếm số lượng chữ số lẻ của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0, temp = n;
        while (temp > 0)
        {
            if ((temp % 10) % 2 != 0) count++;
            temp /= 10;
        }
        Console.WriteLine($"Số lượng chữ số lẻ là {count}");
    }
}
