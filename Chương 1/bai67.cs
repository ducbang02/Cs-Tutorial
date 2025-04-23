// Tìm số Fibonacci thứ n.

using System;

class Program
{
    static void Main(string[] args)
    {
        if (n == 0) Console.WriteLine(0);
        else if (n == 1) Console.WriteLine(1);
        else
        {
            int a = 0, b = 1, res = 1;
            for (int i = 2; i <= n; i++)
            {
                res = a + b;
                a = b;
                b = res;
            }
            Console.WriteLine($"Fibonacci thứ {n} là {res}");
        }
    }
}
