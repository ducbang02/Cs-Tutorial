
// Tính T(x, n) = x^n.

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        double result = Math.Pow(x, n);
        Console.WriteLine($"T(x, n) = {result}");
    }
}
