
// Tính tổng các ước số nhỏ hơn chính nó của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) sum += i;
        }
        Console.WriteLine($"Tổng các ước nhỏ hơn {n} là {sum}");
    }
}
