
// Kiểm tra số nguyên dương n có phải là số hoàn thiện hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) sum += i;
        }
        if (sum == n)
        {
            Console.WriteLine($"{n} là số hoàn thiện");
        }
        else
        {
            Console.WriteLine($"{n} không là số hoàn thiện");
        }
    }
}
