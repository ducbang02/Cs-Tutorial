// Tìm chữ số nhỏ nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int minDigit = 9, temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit < minDigit) minDigit = digit;
            temp /= 10;
        }
        Console.WriteLine($"Chữ số nhỏ nhất là {minDigit}");
    }
}
