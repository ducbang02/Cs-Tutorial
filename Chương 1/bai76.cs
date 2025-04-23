// Kiểm tra số nguyên dương n có chữ số nguyên tố hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool hasPrimeDigit = false, temp = n;
        int[] primes = {2, 3, 5, 7};
        while (temp > 0)
        {
            if (Array.Exists(primes, p => p == temp % 10))
            {
                hasPrimeDigit = true;
                break;
            }
            temp /= 10;
        }
        Console.WriteLine(hasPrimeDigit ? "Có chữ số nguyên tố" : "Không có chữ số nguyên tố");
    }
}
