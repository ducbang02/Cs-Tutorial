using System;

class Program
{
    //82. Viết chương trình tìm số lớn nhất trong ba số thực a, b, c. 
   
    static void Main(){
        Console.WriteLine("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Nhap c: ");
        double c = double.Parse(Console.ReadLine());
        
        double max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        Console.WriteLine("Số lớn nhất là: " + max);
    }
}
