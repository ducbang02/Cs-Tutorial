// Đếm số lượng chữ số là số chính phương của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0, temp = n;
        int[] squares = {0, 1, 4, 9};
        while (temp > 0)
        {
            if (Array.Exists(squares, s => s == temp % 10)) count++;
            temp /= 10;
        }
        Console.WriteLine($"Số lượng chữ số chính phương là {count}");
    }
}
