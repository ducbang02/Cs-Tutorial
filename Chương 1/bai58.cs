// Kiểm tra các chữ số của số nguyên dương n có tăng dần từ trái sang phải hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        string s = n.ToString();
        bool isIncreasing = true;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] >= s[i + 1]) { isIncreasing = false; break; }
        }
        Console.WriteLine(isIncreasing ? "Tăng dần" : "Không tăng dần");
    }
}
