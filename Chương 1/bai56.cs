// Kiểm tra số nguyên dương n có toàn chữ số chẵn hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        int temp = n;
        bool allEven = true;
        while (temp > 0)
        {
            if ((temp % 10) % 2 != 0) { allEven = false; break; }
            temp /= 10;
        }
        Console.WriteLine(allEven ? "Toàn chữ số chẵn" : "Không toàn chữ số chẵn");
    }
}
