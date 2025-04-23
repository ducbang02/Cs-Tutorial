// Tính tích các chữ số là số chính phương của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int product = 1, temp = n;
        int[] squares = {0, 1, 4, 9};
        bool found = false;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(squares, s => s == digit))
            {
                product *= digit;
                found = true;
            }
            temp /= 10;
        }
        Console.WriteLine($"Tích các chữ số chính phương là {(found ? product : 0)}");
    }
}
