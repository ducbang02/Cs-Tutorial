// Tính tích các chữ số của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int product = 1, temp = n;
        while (temp > 0)
        {
            product *= temp % 10;
            temp /= 10;
        }
        Console.WriteLine($"Tích các chữ số là {product}");
    }
}
