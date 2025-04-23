// Kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        string s = n.ToString();
        bool isDecreasing = true;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] <= s[i + 1]) { isDecreasing = false; break; }
        }
        Console.WriteLine(isDecreasing ? "Giảm dần" : "Không giảm dần");
    }
}
