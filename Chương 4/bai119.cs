using System;

class Program
{
    // Bài 119: Liệt kê tất cả số nguyên tố nhỏ hơn n
    static bool LaNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Main()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Các số nguyên tố nhỏ hơn n:");
        for (int i = 2; i < n; i++)
            if (LaNguyenTo(i)) Console.Write(i + " ");
    }
}
