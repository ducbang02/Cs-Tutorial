// Đếm số lượng số Fibonacci không vượt quá n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0, b = 1, count = 0;
        while (b <= n)
        {
            count++;
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine($"Số lượng số Fibonacci không vượt quá {n} là {count}");
    }
}
