// Tìm chữ số chính phương lớn nhất của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int maxSquare = -1, temp = n;
        int[] squares = {0, 1, 4, 9};
        while (temp > 0)
        {
            int digit = temp % 10;
            if (Array.Exists(squares, s => s == digit) && digit > maxSquare)
                maxSquare = digit;
            temp /= 10;
        }
        Console.WriteLine(maxSquare != -1 ? $"Chữ số chính phương lớn nhất là {maxSquare}" : "Không có chữ số chính phương");
    }
}
