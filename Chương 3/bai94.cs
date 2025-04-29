using System;

// Bài 94: In ra tất cả các số lẻ nhỏ hơn 100, trừ 5, 7, 93
class Program
{
    static void Main()
    {
        for (int i = 1; i < 100; i += 2)
        {
            if (i == 5 || i == 7 || i == 93) continue;
            Console.Write(i + " ");
        }
    }
}
