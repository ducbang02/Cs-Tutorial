using System;

// Bài 91: In tất cả số lẻ nguyên dương nhỏ hơn 100
class Program
{
    static void Main()
    {
        for (int i = 1; i < 100; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}
