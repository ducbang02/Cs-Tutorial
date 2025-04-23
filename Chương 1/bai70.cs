// Tìm số Fibonacci nhỏ nhất lớn hơn n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0, b = 1;
        while (b <= n)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine($"Số Fibonacci nhỏ nhất lớn hơn {n} là {b}");
    }
}
