
// Tính S(n) = 1/(1) + 1/(1+2) + 1/(1+2+3) + … + 1/(1+2+3+…+n).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        int partialSum = 0;
        for (int i = 1; i <= n; i++)
        {
            {
                partialSum += i;
                sum += 1.0 / partialSum;
            }
        }
        Console.WriteLine($"S(n) = {sum}");
    }
}
