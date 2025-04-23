// Tính tổng các chữ số chẵn của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0, temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit % 2 == 0) sum += digit;
            temp /= 10;
        }
        Console.WriteLine($"Tổng các chữ số chẵn là {sum}");
    }
}
