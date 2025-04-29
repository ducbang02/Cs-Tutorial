using System;

// Bài 102: Nhập ngày, tháng, năm. Tìm ngày kế tiếp.
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

        d++;

        if (d > ngayThang[m - 1])
        {
            d = 1;
            m++;
            if (m > 12)
            {
                m = 1;
                y++;
            }
        }

        Console.WriteLine($"Ngày kế tiếp là: {d}/{m}/{y}");
    }
}
