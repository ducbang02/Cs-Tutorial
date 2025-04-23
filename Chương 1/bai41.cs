// Tìm giá trị nguyên dương k lớn nhất sao cho S(k) = 1 + 2 + 3 + … + k < n.

using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0, k = 0;
        while (sum + k + 1 < n)
        {
            k++;
            sum += k;
        }
        Console.WriteLine($"Giá trị k lớn nhất là {k}");
    }
}
