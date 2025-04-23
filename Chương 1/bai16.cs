
// Tính S(n) = x/(1+2) + x^2/(1+2+3) + x^3/(1+2+3+4) + … + x^n/(1+2+3+…+n).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 0;
        int partialSum = 0;
        for (int i = 1; i <= n; i++)
        {
            {
                partialSum += i;
                sum += Math.Pow(x, i) / partialSum;
            }
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
