
// Liệt kê tất cả ước số của số nguyên dương n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Các ước số của {0} là: ");
        for (int i = 1; i <= n; i++)
        {
            {
                if (n % i == 0) Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
