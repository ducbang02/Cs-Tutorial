using System;

// Bài 96: Nhập x, tính f(x) = 2x² + 5x + 9 nếu x ≥ 5; ngược lại f(x) = -2x² + 4x - 9
class Program
{
    static void Main()
    {
        Console.Write("Nhập x: ");
        double x = double.Parse(Console.ReadLine());

        double fx = x >= 5 ? 2 * x * x + 5 * x + 9 : -2 * x * x + 4 * x - 9;
        Console.WriteLine($"f(x) = {fx}");
    }
}
