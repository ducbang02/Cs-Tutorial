using System;

// Bài 100: Giải phương trình bậc 2: ax² + bx + c = 0
class Program
{
    static void Main()
    {
        Console.Write("Nhập a, b, c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Không phải phương trình bậc 2.");
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phương trình có 2 nghiệm: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
        }
        else
        {
            Console.WriteLine("Phương trình vô nghiệm thực.");
        }
    }
}

