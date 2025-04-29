using System;

class Program
{
    static double AverageScore(double math, double literature){
        return (math + literature) / 2;
    }
    
    static void Main()
    {
        Console.Write("Nhập tên học sinh: ");
        string ten = Console.ReadLine();

        Console.Write("Nhập điểm Toán: ");
        double toan = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm Văn: ");
        double van = double.Parse(Console.ReadLine());

        double diemTrungBinh = AverageScore(toan, van);
        Console.WriteLine($"Học sinh {ten} có điểm trung bình là: {diemTrungBinh:F2}");
    }
}
