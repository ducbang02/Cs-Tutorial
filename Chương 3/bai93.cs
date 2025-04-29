using System;

// Bài 93: Kiểm tra một số nguyên dương có phải là số nguyên tố không
class Program
{
    static bool LaNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Nhập số nguyên dương: ");
        int n = int.Parse(Console.ReadLine());

        if (LaNguyenTo(n))
        {
            Console.WriteLine($"{n} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{n} không là số nguyên tố.");
        }
    }
}
