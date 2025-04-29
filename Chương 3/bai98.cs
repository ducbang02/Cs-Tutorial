using System;

// Bài 98: Giải hệ phương trình tuyến tính: ax + by = c và dx + ey = f
class Program
{
    static void Main()
    {
        Console.Write("Nhập a, b, c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.Write("Nhập d, e, f: ");
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        double D = a * e - b * d;
        double Dx = c * e - b * f;
        double Dy = a * f - c * d;

        if (D == 0)
        {
            if (Dx == 0 && Dy == 0)
            {
                Console.WriteLine("Hệ phương trình có vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Hệ phương trình vô nghiệm.");
            }
        }
        else
        {
            double x = Dx / D;
            double y = Dy / D;
            Console.WriteLine($"Nghiệm: x = {x}, y = {y}");
        }
    }
}
