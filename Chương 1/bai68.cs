// Tìm số hạng lớn nhất trong dãy Fibonacci không vượt quá n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0, b = 1, res = 0;
        while (b <= n)
        {
            res = b;
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine($"Số Fibonacci lớn nhất không vượt quá {n} là {res}");
    }
}
