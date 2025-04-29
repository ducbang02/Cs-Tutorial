using System;

// Bài 101: Nhập tháng, năm. Cho biết tháng đó có bao nhiêu ngày.
class Program
{
    static void Main()
    {
        Console.Write("Nhập tháng: ");
        int thang = int.Parse(Console.ReadLine());

        Console.Write("Nhập năm: ");
        int nam = int.Parse(Console.ReadLine());

        int ngay;

        switch (thang)
        {
            case 4:
            case 6:
            case 9:
            case 11:
                ngay = 30;
                break;
            case 2:
                ngay = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0) ? 29 : 28;
                break;
            default:
                ngay = 31;
                break;
        }

        Console.WriteLine($"Tháng {thang}/{nam} có {ngay} ngày.");
    }
}

