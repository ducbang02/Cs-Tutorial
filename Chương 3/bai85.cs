using System;

// Bài 85: Nhập tháng (1-12). Cho biết tháng thuộc quý mấy trong năm.
class Program
{
    static void Main()
    {
        Console.Write("Nhập tháng (1-12): ");
        int thang = int.Parse(Console.ReadLine());

        if (thang >= 1 && thang <= 12)
        {
            int quy = (thang - 1) / 3 + 1;
            Console.WriteLine("Tháng " + thang + " thuộc quý " + quy);
        }
        else
        {
            Console.WriteLine("Tháng không hợp lệ.");
        }
    }
}
