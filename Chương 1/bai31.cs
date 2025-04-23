// Kiểm tra số nguyên dương n có phải là số nguyên tố hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool isPrime = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine($"{n} {(isPrime ? "là số nguyên tố" : "không là số nguyên tố")}");
    }
}
