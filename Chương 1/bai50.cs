// Tìm chữ số lớn nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int maxDigit = 0, temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit > maxDigit) maxDigit = digit;
            temp /= 10;
        }
        Console.WriteLine($"Chữ số lớn nhất là {maxDigit}");
    }
}
