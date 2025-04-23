// Kiểm tra số nguyên dương n có phải là số Fibonacci hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool isFibo = false;
        int a = 0, b = 1;
        while (b <= n)
        {
            if (b == n) { isFibo = true; break; }
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine(isFibo ? "Là số Fibonacci" : "Không là số Fibonacci");
    }
}
