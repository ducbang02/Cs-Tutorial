// Đếm số lượng chữ số là số nguyên tố của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0, temp = n;
        int[] primes = {2, 3, 5, 7};
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(primes, p => p == digit)) count++;
            temp /= 10;
        }
        Console.WriteLine($"Số lượng chữ số nguyên tố là {count}");
    }
}
