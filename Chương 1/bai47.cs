// Tính tích các chữ số lẻ của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int product = 1, temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit % 2 != 0) product *= digit;
            temp /= 10;
        }
        Console.WriteLine($"Tích các chữ số lẻ là {product}");
    }
}
