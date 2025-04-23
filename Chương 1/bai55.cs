// Kiểm tra số nguyên dương n có toàn chữ số lẻ hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        int temp = n;
        bool allOdd = true;
        while (temp > 0)
        {
            if ((temp % 10) % 2 == 0) { allOdd = false; break; }
            temp /= 10;
        }
        Console.WriteLine(allOdd ? "Toàn chữ số lẻ" : "Không toàn chữ số lẻ");
    }
}
