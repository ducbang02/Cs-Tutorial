
using System;

class Program
{
    //128. Viết hàm nhập mảng 1 chiều các số thực
    
    static void NhapMang(double[] array, int n){
        for(int i = 0; i < n; i++){
            array[i] = double.Parse(Console.ReadLine());
        }
    }

    
    static void Main(){
        Console.Write("Nhap so phan tu mang: ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        
        NhapMang(array, n);
        
        foreach(double i in array){
            Console.Write($"{i} ");
        }

    }
}
