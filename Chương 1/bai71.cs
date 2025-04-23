// Tính tổng các chữ số là số nguyên tố của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0, temp = n;
        int[] primes = {2, 3, 5, 7};
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(primes, p => p == digit)) sum += digit;
            temp /= 10;
        }
        Console.WriteLine($"Tổng các chữ số nguyên tố là {sum}");
    }
}
