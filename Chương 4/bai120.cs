using System;

class Program
{
    // Bài 120: Liệt kê các số chính phương nhỏ hơn n
    static void Main()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Các số chính phương nhỏ hơn n:");
        for (int i = 1; i * i < n; i++)
        {
            Console.Write(i * i + " ");
        }
    }
}
