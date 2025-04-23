// Đếm số lượng chữ số của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0, temp = n;
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }
        Console.WriteLine($"Số chữ số là {count}");
    }
}
