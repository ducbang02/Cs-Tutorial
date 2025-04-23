// Tính tổng các chữ số của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0, temp = n;
        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        Console.WriteLine($"Tổng các chữ số là {sum}");
    }
}
