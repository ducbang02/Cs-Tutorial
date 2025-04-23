// Kiểm tra số nguyên dương n có phải là số nguyên tố cùng nhau với m hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập m: ");
        int m = int.Parse(Console.ReadLine());
        int a = n, b = m;
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        Console.WriteLine(a == 1 ? "Nguyên tố cùng nhau" : "Không nguyên tố cùng nhau");
    }
}
