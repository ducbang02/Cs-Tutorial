using System;

class Program
{
    //83. Viết chương trình nhập vào 2 số thực. Kiểm tra nó có cùng dấu hay không?
   
    static void Main(){
        Console.WriteLine("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        
        if(a * b > 0){
            Console.WriteLine("Cung Dau");
        }else {
            Console.WriteLine("Khac Dau");
        }
    }
}
