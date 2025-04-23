// Đếm số lượng chữ số nhỏ nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int minDigit = 9, count = 0, temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit < minDigit)
            {
                minDigit = digit;
                count = 1;
            }
            else if (digit == minDigit) count++;
            temp /= 10;
        }
        Console.WriteLine($"Số lượng chữ số nhỏ nhất là {count}");
    }
}
