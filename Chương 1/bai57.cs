// Kiểm tra số nguyên dương n có phải là số đối xứng hay không.

using System;

class Program
{
    static void Main(string[] args)
    {
        int reversed = 0, original = n, temp = n;
        while (temp > 0)
        {
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }
        Console.WriteLine(original == reversed ? "Là số đối xứng" : "Không là số đối xứng");
    }
}
