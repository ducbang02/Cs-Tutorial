// Tính tổng các chữ số là số chính phương của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0, temp = n;
        int[] squares = {0, 1, 4, 9};
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(squares, s => s == digit)) sum += digit;
            temp /= 10;
        }
        Console.WriteLine($"Tổng các chữ số chính phương là {sum}");
    }
}
