using System;

// Bài 99: Nhập 3 số thực, in ra theo thứ tự tăng dần, chỉ dùng tối đa 2 biến phụ
class Program
{
    static void Main()
    {
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhập c: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double t = a; a = b; b = t;
        }

        if (a > c)
        {
            double t = a; a = c; c = t;
        }

        if (b > c)
        {
            double t = b; b = c; c = t;
        }

        Console.WriteLine($"Thứ tự tăng dần: {a}, {b}, {c}");
    }
}
