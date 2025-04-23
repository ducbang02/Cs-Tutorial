// Tìm số đảo ngược của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int reverse = 0, temp = n;
        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }
        Console.WriteLine($"Số đảo ngược là {reverse}");
    }
}
