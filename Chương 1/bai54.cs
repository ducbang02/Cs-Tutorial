// Đếm số lượng chữ số đầu tiên của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int temp = n;
        while (temp >= 10)
        {
            temp /= 10;
        }
        int firstDigit = temp, count = 0, check = n;
        while (check > 0)
        {
            if (check % 10 == firstDigit) count++;
            check /= 10;
        }
        Console.WriteLine($"Số lượng chữ số đầu tiên là {count}");
    }
}
