// Tìm chữ số nguyên tố lớn nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int maxPrime = -1, temp = n;
        int[] primes = {2, 3, 5, 7};
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(primes, p => p == digit) && digit > maxPrime)
                maxPrime = digit;
            temp /= 10;
        }
        Console.WriteLine(maxPrime != -1 ? $"Chữ số nguyên tố lớn nhất là {maxPrime}" : "Không có chữ số nguyên tố");
    }
}
