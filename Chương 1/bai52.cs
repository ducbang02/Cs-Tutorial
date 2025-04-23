// Đếm số lượng chữ số lớn nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int maxDigit = 0, count = 0, temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit > maxDigit)
            {
                maxDigit = digit;
                count = 1;
            }
            else if (digit == maxDigit) count++;
            temp /= 10;
        }
        Console.WriteLine($"Số lượng chữ số lớn nhất là {count}");
    }
}
