// Kiểm tra số nguyên dương n có phải là số chính phương hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool isPerfectSquare = Math.Sqrt(n) % 1 == 0;
        Console.WriteLine($"{n} {(isPerfectSquare ? "là số chính phương" : "không là số chính phương")}");
    }
}
