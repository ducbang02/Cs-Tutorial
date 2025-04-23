// Tìm chữ số nguyên tố nhỏ nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int minPrime = 10, temp = n;
        int[] primes = {2, 3, 5, 7};
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(primes, p => p == digit) && digit < minPrime)
                minPrime = digit;
            temp /= 10;
        }
        Console.WriteLine(minPrime != 10 ? $"Chữ số nguyên tố nhỏ nhất là {minPrime}" : "Không có chữ số nguyên tố");
    }
}
