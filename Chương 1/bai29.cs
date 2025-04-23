
// Tìm ước số lẻ lớn nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int maxOdd = 1;
        for (int i = 1; i <= n; i += 2)
        {
            if (n % i == 0)
            {
                maxOdd = i;
            }
        }
        Console.WriteLine($"Ước lẻ lớn nhất của {n} là {maxOdd}");
    }
}
