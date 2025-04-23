// Tìm chữ số đầu tiên của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int temp = n;
        while (temp >= 10)
        {
            temp /= 10;
        }
        Console.WriteLine($"Chữ số đầu tiên là {temp}");
    }
}
