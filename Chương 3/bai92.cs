using System;

// Bài 92: Tìm ước chung lớn nhất của hai số nguyên dương
class Program
{
    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("ƯCLN là: " + UCLN(a, b));
    }
}
