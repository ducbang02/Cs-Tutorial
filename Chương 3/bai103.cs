using System;

// Bài 103: Nhập ngày, tháng, năm. Tìm ngày trước đó.
class Program
{
    static void Main()
    {
        Console.Write("Nhập ngày: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Nhập tháng: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhập năm: ");
        int y = int.Parse(Console.ReadLine());

        int[] ngayThang = { 31, (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        d--;

        if (d < 1)
        {
            m--;
            if (m < 1)
            {
                m = 12;
                y--;
            }
            d = ngayThang[m - 1];
        }

        Console.WriteLine($"Ngày trước đó là: {d}/{m}/{y}");
    }
}
