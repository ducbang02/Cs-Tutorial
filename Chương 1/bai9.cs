
// Tính T(n) = 1 × 2 × 3 × … × n (giai thừa).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        long product = 1;
        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }
        Console.WriteLine($"T(n) = {product}");
    }
}
