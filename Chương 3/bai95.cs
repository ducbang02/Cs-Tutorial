using System;

// Bài 95: Nhập 3 số thực. Thay số âm bằng giá trị tuyệt đối của nó.
class Program
{
    static void Main()
    {
        double[] arr = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nhập số thứ {i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine());

            if (arr[i] < 0)
            {
                arr[i] = Math.Abs(arr[i]);
            }
        }

        Console.WriteLine("Các số sau khi thay:");
        foreach (var x in arr)
        {
            Console.WriteLine(x);
        }
    }
}
