bai97.cs
using System;

// Bài 97: Nhập 3 cạnh tam giác. Cho biết loại tam giác.
class Program
{
    static void Main()
    {
        Console.Write("Nhập cạnh a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập cạnh b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhập cạnh c: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giác đều");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giác cân");
            }
            else if (a * a + b * b == c * c ||
                     a * a + c * c == b * b ||
                     b * b + c * c == a * a)
            {
                Console.WriteLine("Tam giác vuông");
            }
            else
            {
                Console.WriteLine("Tam giác thường");
            }
        }
        else
        {
            Console.WriteLine("Ba cạnh không tạo thành tam giác");
        }
    }
}
