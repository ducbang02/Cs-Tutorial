// Tính tích các chữ số là số nguyên tố của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int product = 1, temp = n;
        int[] primes = {2, 3, 5, 7};
        bool found = false;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(primes, p => p == digit))
            {
                product *= digit;
                found = true;
            }
            temp /= 10;
        }
        Console.WriteLine($"Tích các chữ số nguyên tố là {(found ? product : 0)}");
    }
}
