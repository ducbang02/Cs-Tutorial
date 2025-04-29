using System;

// Bài 84: Giải phương trình ax + b = 0
class Program
{
    static void Main()
    {
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiệm x = " + x);
        }
    }
}
